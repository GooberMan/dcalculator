using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCalculator
{
	public partial class CalculatorForm : Form
	{
		public CalculatorForm()
		{
			InitializeComponent();
			InitializeCalculator();
			RefreshDisplay();
		}

		private void CalculatorForm_Load(object sender, EventArgs e)
		{

		}

		private void ButtonOne_Click(object sender, EventArgs e)
		{
			HandleOperation( dcalculator.Commands.One );
		}

		private void ButtonTwo_Click(object sender, EventArgs e)
		{
			HandleOperation( dcalculator.Commands.Two );
		}

		private void ButtonThree_Click(object sender, EventArgs e)
		{
			HandleOperation( dcalculator.Commands.Three );
		}

		private void ButtonFour_Click(object sender, EventArgs e)
		{
			HandleOperation( dcalculator.Commands.Four );
		}

		private void ButtonFive_Click(object sender, EventArgs e)
		{
			HandleOperation( dcalculator.Commands.Five );
		}

		private void ButtonSix_Click(object sender, EventArgs e)
		{
			HandleOperation( dcalculator.Commands.Six );
		}

		private void ButtonSeven_Click(object sender, EventArgs e)
		{
			HandleOperation( dcalculator.Commands.Seven );
		}

		private void ButtonEight_Click(object sender, EventArgs e)
		{
			HandleOperation( dcalculator.Commands.Eight );
		}

		private void ButtonNine_Click(object sender, EventArgs e)
		{
			HandleOperation( dcalculator.Commands.Nine );
		}

		private void ButtonZero_Click(object sender, EventArgs e)
		{
			HandleOperation( dcalculator.Commands.Zero );
		}

		private void ButtonNegate_Click(object sender, EventArgs e)
		{
			HandleOperation( dcalculator.Commands.Negate );
		}

		private void ButtonDecimal_Click(object sender, EventArgs e)
		{
			HandleOperation( dcalculator.Commands.Decimal );
		}

		private void ButtonMultiply_Click(object sender, EventArgs e)
		{
			HandleOperation( dcalculator.Commands.Multiply );
		}

		private void ButtonDivide_Click(object sender, EventArgs e)
		{
			HandleOperation( dcalculator.Commands.Divide );
		}

		private void ButtonPlus_Click(object sender, EventArgs e)
		{
			HandleOperation( dcalculator.Commands.Plus );
		}

		private void ButtonMinus_Click(object sender, EventArgs e)
		{
			HandleOperation( dcalculator.Commands.Minus );
		}

		private void ButtonModulus_Click(object sender, EventArgs e)
		{
			HandleOperation( dcalculator.Commands.Modulus );
		}

		private void ButtonEvaluate_Click(object sender, EventArgs e)
		{
			HandleOperation( dcalculator.Commands.Evaluate );
		}

/*		private void CalculatorForm_KeyDown(object sender, KeyEventArgs e)
		{
			switch( e.KeyCode )
			{
				case Keys.D1:
				case Keys.NumPad1:
					HandleOperation( dcalculator.Commands.One );
					break;
				case Keys.D2:
				case Keys.NumPad2:
					HandleOperation( dcalculator.Commands.Two );
					break;
				case Keys.D3:
				case Keys.NumPad3:
					HandleOperation( dcalculator.Commands.Three );
					break;
				case Keys.D4:
				case Keys.NumPad4:
					HandleOperation( dcalculator.Commands.Four );
					break;
				case Keys.D5:
				case Keys.NumPad5:
					HandleOperation( dcalculator.Commands.Five );
					break;
				case Keys.D6:
				case Keys.NumPad6:
					HandleOperation( dcalculator.Commands.Six );
					break;
				case Keys.D7:
				case Keys.NumPad7:
					HandleOperation( dcalculator.Commands.Seven );
					break;
				case Keys.D8:
				case Keys.NumPad8:
					HandleOperation( dcalculator.Commands.Eight );
					break;
				case Keys.D9:
				case Keys.NumPad9:
					HandleOperation( dcalculator.Commands.Nine );
					break;
				case Keys.D0:
				case Keys.NumPad0:
					HandleOperation( dcalculator.Commands.Zero );
					break;
				case Keys.Enter:
					HandleOperation( dcalculator.Commands.Evaluate );
					break;
			}
		}*/

		private void CalculatorForm_KeyPress(object sender, KeyPressEventArgs e)
		{
			switch( e.KeyChar )
			{
				case (char)Keys.D1:
				case (char)Keys.NumPad1:
					HandleOperation( dcalculator.Commands.One );
					break;
				case (char)Keys.D2:
				case (char)Keys.NumPad2:
					HandleOperation( dcalculator.Commands.Two );
					break;
				case (char)Keys.D3:
				case (char)Keys.NumPad3:
					HandleOperation( dcalculator.Commands.Three );
					break;
				case (char)Keys.D4:
				case (char)Keys.NumPad4:
					HandleOperation( dcalculator.Commands.Four );
					break;
				case (char)Keys.D5:
				case (char)Keys.NumPad5:
					HandleOperation( dcalculator.Commands.Five );
					break;
				case (char)Keys.D6:
				case (char)Keys.NumPad6:
					HandleOperation( dcalculator.Commands.Six );
					break;
				case (char)Keys.D7:
				case (char)Keys.NumPad7:
					HandleOperation( dcalculator.Commands.Seven );
					break;
				case (char)Keys.D8:
				case (char)Keys.NumPad8:
					HandleOperation( dcalculator.Commands.Eight );
					break;
				case (char)Keys.D9:
				case (char)Keys.NumPad9:
					HandleOperation( dcalculator.Commands.Nine );
					break;
				case (char)Keys.D0:
				case (char)Keys.NumPad0:
					HandleOperation( dcalculator.Commands.Zero );
					break;
				case (char)Keys.Enter:
					HandleOperation( dcalculator.Commands.Evaluate );
					break;
				case (char)Keys.Add:
					HandleOperation( dcalculator.Commands.Plus );
					break;
				case (char)Keys.Subtract:
					HandleOperation( dcalculator.Commands.Minus );
					break;
				case (char)Keys.Multiply:
					HandleOperation( dcalculator.Commands.Multiply );
					break;
				case (char)Keys.Divide:
					HandleOperation( dcalculator.Commands.Divide );
					break;
			}
		}

		private void ButtonSin_Click(object sender, EventArgs e)
		{
			HandleOperation( dcalculator.Commands.Sin );
		}

		private void ButtonASin_Click(object sender, EventArgs e)
		{
			HandleOperation( dcalculator.Commands.ASin );
		}

		private void ButtonCos_Click(object sender, EventArgs e)
		{
			HandleOperation( dcalculator.Commands.Cos );
		}

		private void ButtonACos_Click(object sender, EventArgs e)
		{
			HandleOperation( dcalculator.Commands.ACos );
		}

		private void ButtonTan_Click(object sender, EventArgs e)
		{
			HandleOperation( dcalculator.Commands.Tan );
		}

		private void ButtonATan_Click(object sender, EventArgs e)
		{
			HandleOperation( dcalculator.Commands.ATan );
		}

		private void ButtonSquarePower_Click(object sender, EventArgs e)
		{
			HandleOperation( dcalculator.Commands.Power );
			HandleOperation( dcalculator.Commands.Two );
		}

		private void ButtonNthPower_Click(object sender, EventArgs e)
		{
			HandleOperation( dcalculator.Commands.Power );
		}

		private void ButtonSquareRoot_Click(object sender, EventArgs e)
		{
			HandleOperation( dcalculator.Commands.Root );
			HandleOperation( dcalculator.Commands.Two );
		}

		private void ButtonNthRoot_Click(object sender, EventArgs e)
		{
			HandleOperation( dcalculator.Commands.Root );
		}

		private void ButtonClearInput_Click(object sender, EventArgs e)
		{
			HandleOperation( dcalculator.Commands.ClearCurrent );
		}

		private void ButtonClearAll_Click(object sender, EventArgs e)
		{
			HandleOperation( dcalculator.Commands.ClearEverything );
		}

		private void ButtonBackspace_Click(object sender, EventArgs e)
		{
			HandleOperation( dcalculator.Commands.Backspace );
		}

		private void ButtonMemAdd_Click(object sender, EventArgs e)
		{
			HandleMemMode( MemoryMode.Add );
		}

		private void ButtonMemMinus_Click(object sender, EventArgs e)
		{
			HandleMemMode( MemoryMode.Subtract );
		}

		private void ButtonMemRecall_Click(object sender, EventArgs e)
		{
			HandleMemMode( MemoryMode.Recall );
		}

		private void ButtonMemClear_Click(object sender, EventArgs e)
		{
			HandleMemMode( MemoryMode.Clear );
		}
	}
}
