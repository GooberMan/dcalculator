//----------------------------------------------------------------------------

module dcalculator;

public import binderoo.binding.binding;
import binderoo.util.structofarrays;

import std.conv : to;
//----------------------------------------------------------------------------


@BindExport( 1 )
@CTypeName( "Commands" )
enum Commands : int
{
	Invalid = -1,

	Evaluate,

	ClearCurrent,
	ClearEverything,
	Backspace,

	ToFloating,
	ToIntegral,

	OpenGroup,
	CloseGroup,

	Negate,
	Decimal,

	Plus,
	Minus,
	Multiply,
	Divide,
	Modulus,

	Sin,
	ASin,
	Cos,
	ACos,
	Tan,
	ATan,

	Power,
	Root,

	Zero,
	One,
	Two,
	Three,
	Four,
	Five,
	Six,
	Seven,
	Eight,
	Nine,
	A,
	B,
	C,
	D,
	E,
	F,
}
//----------------------------------------------------------------------------

@BindExport( 1 )
@CTypeName( "FloatingPointPrecision" )
enum FloatingPointPrecision : uint
{
	Half,
	Single,
	Double,
	Quad,
}
//----------------------------------------------------------------------------

@BindExport( 1 )
@CTypeName( "IntegerPrecision" )
enum IntegerPrecision : uint
{
	UInt8,
	UInt16,
	UInt32,
	UInt64,

	SignBit		= 0x80000000,

	Int8		= SignBit | UInt8,
	Int16		= SignBit | UInt16,
	Int32		= SignBit | UInt32,
	Int64		= SignBit | UInt64,
}
//----------------------------------------------------------------------------

@BindExport( 1 )
@CTypeName( "OperatingMode" )
enum OperatingMode : uint
{
	FloatingPoint,
	Integral,
}
//----------------------------------------------------------------------------

@BindNoExportObject
struct CalcState
{
	this( FloatingPointPrecision ePrecision )
	{
		eMode = OperatingMode.FloatingPoint;
		eCurrFP = ePrecision;
	}
	//------------------------------------------------------------------------

	this( IntegerPrecision ePrecision )
	{
		eMode = OperatingMode.Integral;
		eCurrIP = ePrecision;
	}
	//------------------------------------------------------------------------

	@property IsSinglePrecision() const { return eMode == OperatingMode.FloatingPoint && eCurrFP == FloatingPointPrecision.Single; }
	@property IsDoublePrecision() const { return eMode == OperatingMode.FloatingPoint && eCurrFP == FloatingPointPrecision.Double; }
	//------------------------------------------------------------------------

	OperatingMode				eMode		= OperatingMode.FloatingPoint;
	FloatingPointPrecision		eCurrFP		= FloatingPointPrecision.Double;
	IntegerPrecision			eCurrIP		= IntegerPrecision.Int32;
}
//----------------------------------------------------------------------------

@BindNoExportObject
struct CalcValue
{
	this( PrecisionType )( PrecisionType ePrecision ) if( is( PrecisionType == FloatingPointPrecision ) || is( PrecisionType == IntegerPrecision ) )
	{
		currState = CalcState( ePrecision );
	}
	//------------------------------------------------------------------------

	@BindNoExportObject
	struct ThisValue
	{
		ulong					int64;
		double					float64 = 0;
		float					float32 = 0;
	}
	//------------------------------------------------------------------------

	ThisValue					storage;
	CalcState					currState;

	@property IsFloating() const				{ return currState.eMode == OperatingMode.FloatingPoint; }
	@property IsIntegerMode() const				{ return currState.eMode == OperatingMode.Integral; }
	//------------------------------------------------------------------------

	@property FloatValue() const				{ return storage.float32; }
	@property FloatValue( float val )			{ storage.float32 = val; }
	//------------------------------------------------------------------------

	@property DoubleValue() const				{ return storage.float64; }
	@property DoubleValue( double val )			{ storage.float64 = val; }
	//------------------------------------------------------------------------

	@property Value( alias ePrecision )() const
	{
		static if( is( typeof( ePrecision ) == FloatingPointPrecision ) )
		{
			static if( ePrecision == FloatingPointPrecision.Single )
			{
				return currState.IsSinglePrecision ? FloatValue : float.nan;
			}
			else static if( ePrecision == FloatingPointPrecision.Double )
			{
				return currState.IsDoublePrecision ? DoubleValue : double.nan;
			}
		}
		else static if( is( typeof( ePrecision ) == IntegerPrecision ) )
		{
			return cast(int)-1;
		}
	}
	//------------------------------------------------------------------------

	@property Value( T )( T val )
	{
		static if( is( T == float ) )
		{
			FloatValue = currState.IsSinglePrecision ? val : float.nan;
		}
		else static if( is( T == double ) )
		{
			DoubleValue = currState.IsDoublePrecision ? val : double.nan;
		}
	}
	//------------------------------------------------------------------------

	string toString()
	{
		final switch( currState.eMode ) with ( OperatingMode )
		{
		case FloatingPoint:
			final switch( currState.eCurrFP ) with ( FloatingPointPrecision )
			{
			case Single:
				return FloatValue.to!string;
			case Double:
				return DoubleValue.to!string;
			case Half:
				break;
			case Quad:
				break;
			}
			break;
		case Integral:
			break;
		}
		return "<ERR>";
	}
	//------------------------------------------------------------------------
}
//----------------------------------------------------------------------------

bool Empty( ref Commands[] eCommands )
{
	return eCommands.length == 0;
}
//----------------------------------------------------------------------------

Commands Peek( ref Commands[] eCommands )
{
	return !eCommands.Empty ? eCommands[ 0 ] : Commands.Invalid;
}
//----------------------------------------------------------------------------

Commands PeekBack( ref Commands[] eCommands )
{
	return !eCommands.Empty ? eCommands[ $ - 1 ] : Commands.Invalid;
}
//----------------------------------------------------------------------------

Commands Pop( ref Commands[] eCommands )
{
	if( !eCommands.Empty )
	{
		Commands eVal = eCommands[ 0 ];
		eCommands = eCommands[ 1 .. $ ];
		return eVal;
	}

	return Commands.Invalid;
}
//----------------------------------------------------------------------------

Commands PopBack( ref Commands[] eCommands )
{
	if( !eCommands.Empty )
	{
		Commands eVal = eCommands[ $ - 1 ];
		eCommands = eCommands[ 0 .. $ - 1 ];
		return eVal;
	}

	return Commands.Invalid;
}
//----------------------------------------------------------------------------

bool IsNumber( Commands eCommand )
{
	return eCommand >= Commands.Zero && eCommand <= Commands.F;
}
//----------------------------------------------------------------------------

bool IsOperator( Commands eCommand )
{
	switch( eCommand ) with( Commands )
	{
	case Plus:
	case Minus:
	case Multiply:
	case Divide:
	case Modulus:
	case Power:
	case Root:
		return true;
	default:
		break;
	}

	return false;
}
//----------------------------------------------------------------------------

CalcValue Evaluate( alias PrecisionType )( Commands[] eCommands )
{
	import std.math;

	CalcValue workingValLHS = CalcValue( PrecisionType );
	CalcValue workingValRHS = CalcValue( PrecisionType );
	
	Commands workingOpLHSAndRHS = Commands.Invalid;
	Commands workingOpRHS = Commands.Invalid;

	CalcValue eval()
	{
		CalcValue output = CalcValue( PrecisionType );

		CalcValue newRHS = CalcValue( PrecisionType );
		switch( workingOpRHS ) with( Commands )
		{
		case Sin:
			newRHS.Value = sin( workingValRHS.Value!PrecisionType() );
			break;
		case ASin:
			newRHS.Value = asin( workingValRHS.Value!PrecisionType() );
			break;
		case Cos:
			newRHS.Value = cos( workingValRHS.Value!PrecisionType() );
			break;
		case ACos:
			newRHS.Value = acos( workingValRHS.Value!PrecisionType() );
			break;
		case Tan:
			newRHS.Value = tan( workingValRHS.Value!PrecisionType() );
			break;
		case ATan:
			newRHS.Value = atan( workingValRHS.Value!PrecisionType() );
			break;
		default:
			newRHS = workingValRHS;
			break;
		}

		switch( workingOpLHSAndRHS ) with( Commands )
		{
		case Plus:
			output.Value = workingValLHS.Value!PrecisionType() + newRHS.Value!PrecisionType();
			break;
		case Minus:
			output.Value = workingValLHS.Value!PrecisionType() - newRHS.Value!PrecisionType();
			break;
		case Multiply:
			output.Value = workingValLHS.Value!PrecisionType() * newRHS.Value!PrecisionType();
			break;
		case Divide:
			output.Value = workingValLHS.Value!PrecisionType() / newRHS.Value!PrecisionType();
			break;
		case Modulus:
			static if( is( typeof( PrecisionType ) == FloatingPointPrecision ) )
			{
				output.Value = cast(double)fmod( workingValLHS.Value!PrecisionType(), newRHS.Value!PrecisionType() );
			}
			else static if( is( typeof( PrecisionType ) == IntegerPrecision ) )
			{
				output.Value = workingValLHS.Value!PrecisionType() % newRHS.Value!PrecisionType();
			}
			break;
		case Power:
			output.Value = pow( workingValLHS.Value!PrecisionType(), newRHS.Value!PrecisionType() );
			break;
		case Root:
			output.Value = pow( workingValLHS.Value!PrecisionType(), 1.0 / newRHS.Value!PrecisionType() );
			break;
		default:
			output.Value = newRHS.Value!PrecisionType();
			break;
		}

		return output;
	}

	if( !eCommands.Empty )
	{
		while( !eCommands.Empty )
		{
			switch( eCommands.Peek ) with( Commands )
			{
			case Zero:
			case One:
			case Two:
			case Three:
			case Four:
			case Five:
			case Six:
			case Seven:
			case Eight:
			case Nine:
			case A:
			case B:
			case C:
			case D:
			case E:
			case F:
				int iVal = cast( int )eCommands.Peek - cast( int )Commands.Zero;

				workingValRHS.Value = ( workingValRHS.Value!PrecisionType() * 10 + iVal );
				break;

			case Negate:
				workingValRHS.Value = ( workingValRHS.Value!PrecisionType() * -1 );
				break;

			case Plus:
			case Minus:
			case Multiply:
			case Divide:
			case Modulus:
			case Power:
			case Root:
				CalcValue newVal = eval();

				workingOpLHSAndRHS = eCommands.Peek();
				workingOpRHS = Commands.Invalid;

				workingValLHS = newVal;
				workingValRHS.Value = 0.0;
				break;

			case Sin:
			case ASin:
			case Cos:
			case ACos:
			case Tan:
			case ATan:
				int iVal = cast( int )eCommands.Peek - cast( int )Commands.Sin;
				workingOpRHS = cast(Commands)iVal;
				break;

			case Evaluate:
				workingValRHS = eval();
				workingValLHS.Value = 0.0;

				workingOpLHSAndRHS = workingOpRHS = Commands.Invalid;

				break;

			default:
				break;
			}

			eCommands.Pop;
		}
	}

	return workingValRHS;
}
//----------------------------------------------------------------------------

string Stringify( Commands[] eCommands )
{
	string[] finalVal;

	string workingVal;
	bool bCloseBrackets;

	void pushIt()
	{
		if( workingVal.length > 0 )
		{
			if( bCloseBrackets )
			{
				workingVal ~= ")";
			}
			finalVal ~= workingVal;
			workingVal.length = 0;
			bCloseBrackets = false;
		}
	}

	void process( Commands[] theseCommands )
	{
		foreach( ref command; theseCommands )
		{
			final switch( command ) with( Commands )
			{
			case Evaluate:
				pushIt();
				workingVal = "=";
				pushIt();
				break;
			case Negate:
				if( workingVal.length > 0 && workingVal[ 0 ] == '-' )
				{
					workingVal = workingVal[ 1 .. $ ];
				}
				else
				{
					workingVal = "-" ~ workingVal;
				}
				break;
			case Plus:
				pushIt();
				workingVal = "+";
				pushIt();
				break;
			case Minus:
				pushIt();
				workingVal = "-";
				pushIt();
				break;
			case Multiply:
				pushIt();
				workingVal = "*";
				pushIt();
				break;
			case Divide:
				pushIt();
				workingVal = "/";
				pushIt();
				break;
			case Modulus:
				pushIt();
				workingVal = "%";
				pushIt();
				break;
			case Power:
				pushIt();
				workingVal = "^";
				pushIt();
				break;
			case Root:
				pushIt();
				workingVal = "v";
				pushIt();
				break;
			case Zero:
				if( workingVal.length > 0 )
				{
					workingVal ~= "0";
				}
				break;
			case One:
				workingVal ~= "1";
				break;
			case Two:
				workingVal ~= "2";
				break;
			case Three:
				workingVal ~= "3";
				break;
			case Four:
				workingVal ~= "4";
				break;
			case Five:
				workingVal ~= "5";
				break;
			case Six:
				workingVal ~= "6";
				break;
			case Seven:
				workingVal ~= "7";
				break;
			case Eight:
				workingVal ~= "8";
				break;
			case Nine:
				workingVal ~= "9";
				break;

			case Sin:
			case ASin:
			case Cos:
			case ACos:
			case Tan:
			case ATan:

			case A:
			case B:
			case C:
			case D:
			case E:
			case F:

			case OpenGroup:
			case CloseGroup:
			case Decimal:

			case ClearCurrent:
			case ClearEverything:
			case Backspace:
			case ToFloating:
			case ToIntegral:

			case Invalid:
				break;
			}
		}

		pushIt();
	}

	Commands[] cleanUp( Commands[] currCommands )
	{
		Commands[] newCommands;

		while( currCommands.length > 0 )
		{
			if( currCommands.Peek.IsOperator || currCommands.Peek == Commands.Evaluate )
			{
				if( newCommands.PeekBack.IsOperator || newCommands.PeekBack == Commands.Evaluate )
				{
					newCommands.PopBack;
				}
				newCommands ~= currCommands.Pop;
			}
			else
			{
				if( newCommands.PeekBack == Commands.Evaluate )
				{
					newCommands.PopBack;
				}
				newCommands ~= currCommands.Pop;
			}
		}

		return newCommands;
	}

	process( cleanUp( eCommands ) );

	return finalVal.joinWith( " " );
}
//----------------------------------------------------------------------------

@BindExport( 1 )
@CTypeName( "DCalculator" )
class DCalculator
{
	final string GetCurrentDisplayValue()
	{
		return currDisplay.to!string;
	}
	//------------------------------------------------------------------------

	final string GetCurrentEvaluatedValue()
	{
		return currEvaluated.to!string;
	}
	//------------------------------------------------------------------------

	final void Execute( Commands eCommand )
	{
		if( eCommand == Commands.ClearEverything )
		{
			PerformClearEverything();
		}
		else if( eCommand == Commands.ClearCurrent )
		{
			PerformClearCurrent();
		}
		else if( eCommand == Commands.Backspace )
		{
			PerformBackspace();
		}
		else
		{
			if( commandBuffer.PeekBack == Commands.Evaluate && eCommand.IsNumber )
			{
				PerformClearEverything();
			}

			commandBuffer ~= eCommand;
		}

		auto workingBuffer = commandBuffer;

		currDisplay = workingBuffer.Evaluate!( FloatingPointPrecision.Double );

		if( workingBuffer.PeekBack != Commands.Evaluate )
		{
			workingBuffer ~= Commands.Evaluate;
		}
		currEvaluated = workingBuffer.Evaluate!( FloatingPointPrecision.Double );

	}
	//------------------------------------------------------------------------

	string GetOperations()
	{
		return commandBuffer.Stringify;
	}
	//------------------------------------------------------------------------

	final bool HasStoredResult( int iSlot )
	{
		return storedResults[ iSlot ].Value!( FloatingPointPrecision.Double ) != 0.0;
	}
	//------------------------------------------------------------------------

	final string GetStoredResult( int iSlot )
	{
		return storedResults[ iSlot ].to!string;
	}
	//------------------------------------------------------------------------

	final void AddStoredResult( int iSlot )
	{
		storedResults[ iSlot ].Value = storedResults[ iSlot ].Value!( FloatingPointPrecision.Double ) + currDisplay.Value!( FloatingPointPrecision.Double );
	}
	//------------------------------------------------------------------------

	final void SubtractStoredResult( int iSlot )
	{
		storedResults[ iSlot ].Value = storedResults[ iSlot ].Value!( FloatingPointPrecision.Double ) - currDisplay.Value!( FloatingPointPrecision.Double );
	}
	//------------------------------------------------------------------------

	final void RecallStoredResult( int iSlot )
	{
	}
	//------------------------------------------------------------------------

	final void ClearStoredResult( int iSlot )
	{
		storedResults[ iSlot ].Value = 0.0;
	}
	//------------------------------------------------------------------------

	final void PerformClearEverything()
	{
		commandBuffer.length = 0;
	}
	//------------------------------------------------------------------------

	final void PerformClearCurrent()
	{
		while( commandBuffer.length > 0 && commandBuffer.PeekBack.IsNumber )
		{
			commandBuffer.PopBack;
		}
	}
	//------------------------------------------------------------------------

	final void PerformBackspace()
	{
		if( commandBuffer.length > 0 && commandBuffer.PeekBack.IsNumber )
		{
			commandBuffer.PopBack;
		}
	}
	//------------------------------------------------------------------------

	private Commands[]			commandBuffer;
	private CalcState			currState;
	private CalcValue			currDisplay;
	private CalcValue			currEvaluated;

	private CalcValue[ 10 ]		storedResults;
}
//----------------------------------------------------------------------------

mixin BindModule!1;
