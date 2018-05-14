using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace DCalculator
{
	enum MemoryMode
	{
		None,
		Add,
		Subtract,
		Recall,
		Clear,
	}

	public partial class CalculatorForm
	{
		private void HandleOperation( dcalculator.Commands eCommand )
		{
			if( memMode != MemoryMode.None )
			{
				if( (int)eCommand >= (int)dcalculator.Commands.Zero && (int)eCommand <= (int)dcalculator.Commands.Nine )
				{
					int iSlot = (int)eCommand - (int)dcalculator.Commands.Zero;

					switch( memMode )
					{
						case MemoryMode.Add:
							calculator.AddStoredResult( iSlot );
							break;
						case MemoryMode.Subtract:
							calculator.SubtractStoredResult( iSlot );
							break;
						case MemoryMode.Recall:
							calculator.RecallStoredResult( iSlot );
							break;
						case MemoryMode.Clear:
							calculator.ClearStoredResult( iSlot );
							break;
					}
				}
				memMode = MemoryMode.None;
			}
			else
			{
				calculator.Execute( eCommand );
			}
			RefreshDisplay();
		}

		private void HandleMemMode( MemoryMode eMode )
		{
			memMode = eMode;
			RefreshDisplay();
		}

		private void InitializeCalculator()
		{
			memStatus = new System.Windows.Forms.Label[] { Mem0Value, Mem1Value, Mem2Value, Mem3Value, Mem4Value, Mem5Value, Mem6Value, Mem7Value, Mem8Value, Mem9Value };
			string[] paths = new string[] { "." };
			host = new binderoo.Host( paths, false );
			calculator = new dcalculator.DCalculator();

		}

		private void RefreshDisplay()
		{
			//double evaluated = calculator.GetCurrentEvaluatedValue();
			//double display = calculator.GetCurrentDisplayValue();

			this.SuspendLayout();

			this.CalculatorOutput.Clear();

/*			this.CalculatorOutput.SelectionFont = topLinesInfoFont;
			this.CalculatorOutput.SelectionAlignment = HorizontalAlignment.Right;
			this.CalculatorOutput.SelectedText = "Progress:" + "\n";

			this.CalculatorOutput.SelectionFont = topLinesValueFont;
			this.CalculatorOutput.SelectionAlignment = HorizontalAlignment.Right;

			this.CalculatorOutput.SelectedText = evaluated.ToString( "G" ) + "\n";

			this.CalculatorOutput.SelectionFont = topLinesInfoFont;
			this.CalculatorOutput.SelectionAlignment = HorizontalAlignment.Right;
			this.CalculatorOutput.SelectedText = "Inputs (coming soon...) "\n";

			this.CalculatorOutput.SelectionFont = topLinesValueFont;
			this.CalculatorOutput.SelectionAlignment = HorizontalAlignment.Right;
			this.CalculatorOutput.SelectedText = calculator.GetOperations() + "\n";
			
			this.CalculatorOutput.SelectedText = "\n";

			this.CalculatorOutput.SelectionFont = inputLineFont;
			this.CalculatorOutput.SelectionAlignment = HorizontalAlignment.Right;

			this.CalculatorOutput.SelectedText = display.ToString( "G" ) + "\n";*/

//			this.ProgressText.Text = evaluated.ToString( "G" );
			this.ProgressText.Text = calculator.GetCurrentEvaluatedValue();

//			this.DisplayText.Text = display.ToString( "G" );
			this.DisplayText.Text = calculator.GetCurrentDisplayValue();

			this.InputStreamText.Text = calculator.GetOperations();

			if( memMode != MemoryMode.None )
			{
/*				this.CalculatorOutput.SelectionFont = topLinesInfoFont;
				this.CalculatorOutput.SelectionAlignment = HorizontalAlignment.Right;
				this.CalculatorOutput.SelectedText = "Memory " + memMode.ToString() + " slot?\n";*/

				this.MemorySlotText.Text = "Memory " + memMode.ToString() + " slot?";
			}
			else
			{
				this.MemorySlotText.Text = "";
			}

			for( int iMemSlot = 0; iMemSlot < memStatus.Length; ++iMemSlot )
			{
				bool bHasResult = calculator.HasStoredResult( iMemSlot );
				memStatus[ iMemSlot ].BackColor = bHasResult ? HasMemColor : NoMemColor;
				memStatus[ iMemSlot ].Text = "M" + iMemSlot.ToString() + ": " + ( bHasResult ? calculator.GetStoredResult( iMemSlot ) : "empty" );
			}

			this.ResumeLayout(false);
			this.PerformLayout();
		}
	
		private System.Drawing.Color NoMemColor = System.Drawing.Color.Maroon;
		private System.Drawing.Color HasMemColor = System.Drawing.Color.YellowGreen;

		private Font topLinesInfoFont = new Font( "Lucida Console", 10, FontStyle.Italic );
		private Font topLinesValueFont = new Font( "Lucida Console", 10, FontStyle.Bold );
		private Font inputLineFont = new Font( "Lucida Console", 24, FontStyle.Bold );

		private binderoo.Host host;
		private dcalculator.DCalculator calculator;

		private System.Windows.Forms.Label[] memStatus;
		private MemoryMode memMode = MemoryMode.None;
	}
}