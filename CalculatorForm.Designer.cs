namespace DCalculator
{
	partial class CalculatorForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ModeSelector = new System.Windows.Forms.TabControl();
			this.FloatingPointPanel = new System.Windows.Forms.TabPage();
			this.ButtonNthRoot = new System.Windows.Forms.Button();
			this.ButtonSquareRoot = new System.Windows.Forms.Button();
			this.ButtonNthPower = new System.Windows.Forms.Button();
			this.ButtonSquarePower = new System.Windows.Forms.Button();
			this.ButtonASin = new System.Windows.Forms.Button();
			this.ButtonACos = new System.Windows.Forms.Button();
			this.ButtonSin = new System.Windows.Forms.Button();
			this.ButtonATan = new System.Windows.Forms.Button();
			this.ButtonCos = new System.Windows.Forms.Button();
			this.ButtonTan = new System.Windows.Forms.Button();
			this.IntegralPanel = new System.Windows.Forms.TabPage();
			this.ButtonShiftRight1 = new System.Windows.Forms.Button();
			this.ButtonShiftLeft1 = new System.Windows.Forms.Button();
			this.ButtonShiftRight = new System.Windows.Forms.Button();
			this.ButtonShiftLeft = new System.Windows.Forms.Button();
			this.ButtonOnesCompliment = new System.Windows.Forms.Button();
			this.ButtonBinaryAnd = new System.Windows.Forms.Button();
			this.ButtonBinaryOr = new System.Windows.Forms.Button();
			this.ButtonBinaryXor = new System.Windows.Forms.Button();
			this.Mem1Value = new System.Windows.Forms.Label();
			this.Mem2Value = new System.Windows.Forms.Label();
			this.Mem3Value = new System.Windows.Forms.Label();
			this.Mem4Value = new System.Windows.Forms.Label();
			this.Mem5Value = new System.Windows.Forms.Label();
			this.Mem6Value = new System.Windows.Forms.Label();
			this.Mem7Value = new System.Windows.Forms.Label();
			this.Mem8Value = new System.Windows.Forms.Label();
			this.Mem9Value = new System.Windows.Forms.Label();
			this.Mem0Value = new System.Windows.Forms.Label();
			this.ButtonDecimal = new System.Windows.Forms.Button();
			this.ButtonNegate = new System.Windows.Forms.Button();
			this.ButtonZero = new System.Windows.Forms.Button();
			this.ButtonEvaluate = new System.Windows.Forms.Button();
			this.ButtonExponent = new System.Windows.Forms.Button();
			this.ButtonModulus = new System.Windows.Forms.Button();
			this.ButtonDivide = new System.Windows.Forms.Button();
			this.ButtonMinus = new System.Windows.Forms.Button();
			this.ButtonMemMinus = new System.Windows.Forms.Button();
			this.ButtonClearInput = new System.Windows.Forms.Button();
			this.ButtonMultiply = new System.Windows.Forms.Button();
			this.ButtonMemClear = new System.Windows.Forms.Button();
			this.ButtonMemRecall = new System.Windows.Forms.Button();
			this.ButtonClearAll = new System.Windows.Forms.Button();
			this.ButtonMemAdd = new System.Windows.Forms.Button();
			this.ButtonPlus = new System.Windows.Forms.Button();
			this.ButtonBackspace = new System.Windows.Forms.Button();
			this.ButtonThree = new System.Windows.Forms.Button();
			this.ButtonTwo = new System.Windows.Forms.Button();
			this.ButtonOne = new System.Windows.Forms.Button();
			this.CalculatorOutput = new System.Windows.Forms.RichTextBox();
			this.ButtonA = new System.Windows.Forms.Button();
			this.ButtonB = new System.Windows.Forms.Button();
			this.ButtonC = new System.Windows.Forms.Button();
			this.ButtonSix = new System.Windows.Forms.Button();
			this.ButtonFive = new System.Windows.Forms.Button();
			this.ButtonFour = new System.Windows.Forms.Button();
			this.ButtonNine = new System.Windows.Forms.Button();
			this.ButtonEight = new System.Windows.Forms.Button();
			this.ButtonSeven = new System.Windows.Forms.Button();
			this.ButtonF = new System.Windows.Forms.Button();
			this.ButtonE = new System.Windows.Forms.Button();
			this.ButtonD = new System.Windows.Forms.Button();
			this.ProgressLabel = new System.Windows.Forms.Label();
			this.ProgressText = new System.Windows.Forms.TextBox();
			this.DisplayText = new System.Windows.Forms.TextBox();
			this.MemorySlotText = new System.Windows.Forms.TextBox();
			this.InputLabel = new System.Windows.Forms.Label();
			this.InputStreamText = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			this.ModeSelector.SuspendLayout();
			this.FloatingPointPanel.SuspendLayout();
			this.IntegralPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(714, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			// 
			// ModeSelector
			// 
			this.ModeSelector.Controls.Add(this.FloatingPointPanel);
			this.ModeSelector.Controls.Add(this.IntegralPanel);
			this.ModeSelector.HotTrack = true;
			this.ModeSelector.Location = new System.Drawing.Point(10, 259);
			this.ModeSelector.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ModeSelector.Name = "ModeSelector";
			this.ModeSelector.Padding = new System.Drawing.Point(10, 3);
			this.ModeSelector.SelectedIndex = 0;
			this.ModeSelector.Size = new System.Drawing.Size(347, 214);
			this.ModeSelector.TabIndex = 16;
			this.ModeSelector.TabStop = false;
			// 
			// FloatingPointPanel
			// 
			this.FloatingPointPanel.BackColor = System.Drawing.Color.Silver;
			this.FloatingPointPanel.Controls.Add(this.ButtonNthRoot);
			this.FloatingPointPanel.Controls.Add(this.ButtonSquareRoot);
			this.FloatingPointPanel.Controls.Add(this.ButtonNthPower);
			this.FloatingPointPanel.Controls.Add(this.ButtonSquarePower);
			this.FloatingPointPanel.Controls.Add(this.ButtonASin);
			this.FloatingPointPanel.Controls.Add(this.ButtonACos);
			this.FloatingPointPanel.Controls.Add(this.ButtonSin);
			this.FloatingPointPanel.Controls.Add(this.ButtonATan);
			this.FloatingPointPanel.Controls.Add(this.ButtonCos);
			this.FloatingPointPanel.Controls.Add(this.ButtonTan);
			this.FloatingPointPanel.Location = new System.Drawing.Point(4, 22);
			this.FloatingPointPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.FloatingPointPanel.Name = "FloatingPointPanel";
			this.FloatingPointPanel.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.FloatingPointPanel.Size = new System.Drawing.Size(339, 188);
			this.FloatingPointPanel.TabIndex = 0;
			this.FloatingPointPanel.Text = "Floating";
			// 
			// ButtonNthRoot
			// 
			this.ButtonNthRoot.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonNthRoot.Location = new System.Drawing.Point(274, 14);
			this.ButtonNthRoot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonNthRoot.Name = "ButtonNthRoot";
			this.ButtonNthRoot.Size = new System.Drawing.Size(64, 40);
			this.ButtonNthRoot.TabIndex = 16;
			this.ButtonNthRoot.TabStop = false;
			this.ButtonNthRoot.Text = "ⁿ√";
			this.ButtonNthRoot.UseVisualStyleBackColor = true;
			this.ButtonNthRoot.Click += new System.EventHandler(this.ButtonNthRoot_Click);
			// 
			// ButtonSquareRoot
			// 
			this.ButtonSquareRoot.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonSquareRoot.Location = new System.Drawing.Point(274, 59);
			this.ButtonSquareRoot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonSquareRoot.Name = "ButtonSquareRoot";
			this.ButtonSquareRoot.Size = new System.Drawing.Size(64, 40);
			this.ButtonSquareRoot.TabIndex = 16;
			this.ButtonSquareRoot.TabStop = false;
			this.ButtonSquareRoot.Text = "√";
			this.ButtonSquareRoot.UseVisualStyleBackColor = true;
			this.ButtonSquareRoot.Click += new System.EventHandler(this.ButtonSquareRoot_Click);
			// 
			// ButtonNthPower
			// 
			this.ButtonNthPower.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonNthPower.Location = new System.Drawing.Point(206, 14);
			this.ButtonNthPower.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonNthPower.Name = "ButtonNthPower";
			this.ButtonNthPower.Size = new System.Drawing.Size(64, 40);
			this.ButtonNthPower.TabIndex = 17;
			this.ButtonNthPower.TabStop = false;
			this.ButtonNthPower.Text = "xⁿ";
			this.ButtonNthPower.UseVisualStyleBackColor = true;
			this.ButtonNthPower.Click += new System.EventHandler(this.ButtonNthPower_Click);
			// 
			// ButtonSquarePower
			// 
			this.ButtonSquarePower.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonSquarePower.Location = new System.Drawing.Point(206, 59);
			this.ButtonSquarePower.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonSquarePower.Name = "ButtonSquarePower";
			this.ButtonSquarePower.Size = new System.Drawing.Size(64, 40);
			this.ButtonSquarePower.TabIndex = 17;
			this.ButtonSquarePower.TabStop = false;
			this.ButtonSquarePower.Text = "x²";
			this.ButtonSquarePower.UseVisualStyleBackColor = true;
			this.ButtonSquarePower.Click += new System.EventHandler(this.ButtonSquarePower_Click);
			// 
			// ButtonASin
			// 
			this.ButtonASin.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonASin.Location = new System.Drawing.Point(2, 14);
			this.ButtonASin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonASin.Name = "ButtonASin";
			this.ButtonASin.Size = new System.Drawing.Size(64, 40);
			this.ButtonASin.TabIndex = 18;
			this.ButtonASin.TabStop = false;
			this.ButtonASin.Text = "asin";
			this.ButtonASin.UseVisualStyleBackColor = true;
			this.ButtonASin.Click += new System.EventHandler(this.ButtonASin_Click);
			// 
			// ButtonACos
			// 
			this.ButtonACos.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonACos.Location = new System.Drawing.Point(70, 14);
			this.ButtonACos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonACos.Name = "ButtonACos";
			this.ButtonACos.Size = new System.Drawing.Size(64, 40);
			this.ButtonACos.TabIndex = 19;
			this.ButtonACos.TabStop = false;
			this.ButtonACos.Text = "acos";
			this.ButtonACos.UseVisualStyleBackColor = true;
			this.ButtonACos.Click += new System.EventHandler(this.ButtonACos_Click);
			// 
			// ButtonSin
			// 
			this.ButtonSin.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonSin.Location = new System.Drawing.Point(2, 59);
			this.ButtonSin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonSin.Name = "ButtonSin";
			this.ButtonSin.Size = new System.Drawing.Size(64, 40);
			this.ButtonSin.TabIndex = 18;
			this.ButtonSin.TabStop = false;
			this.ButtonSin.Text = "sin";
			this.ButtonSin.UseVisualStyleBackColor = true;
			this.ButtonSin.Click += new System.EventHandler(this.ButtonSin_Click);
			// 
			// ButtonATan
			// 
			this.ButtonATan.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonATan.Location = new System.Drawing.Point(138, 14);
			this.ButtonATan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonATan.Name = "ButtonATan";
			this.ButtonATan.Size = new System.Drawing.Size(64, 40);
			this.ButtonATan.TabIndex = 20;
			this.ButtonATan.TabStop = false;
			this.ButtonATan.Text = "atan";
			this.ButtonATan.UseVisualStyleBackColor = true;
			this.ButtonATan.Click += new System.EventHandler(this.ButtonATan_Click);
			// 
			// ButtonCos
			// 
			this.ButtonCos.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonCos.Location = new System.Drawing.Point(70, 59);
			this.ButtonCos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonCos.Name = "ButtonCos";
			this.ButtonCos.Size = new System.Drawing.Size(64, 40);
			this.ButtonCos.TabIndex = 19;
			this.ButtonCos.TabStop = false;
			this.ButtonCos.Text = "cos";
			this.ButtonCos.UseVisualStyleBackColor = true;
			this.ButtonCos.Click += new System.EventHandler(this.ButtonCos_Click);
			// 
			// ButtonTan
			// 
			this.ButtonTan.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonTan.Location = new System.Drawing.Point(138, 59);
			this.ButtonTan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonTan.Name = "ButtonTan";
			this.ButtonTan.Size = new System.Drawing.Size(64, 40);
			this.ButtonTan.TabIndex = 20;
			this.ButtonTan.TabStop = false;
			this.ButtonTan.Text = "tan";
			this.ButtonTan.UseVisualStyleBackColor = true;
			this.ButtonTan.Click += new System.EventHandler(this.ButtonTan_Click);
			// 
			// IntegralPanel
			// 
			this.IntegralPanel.BackColor = System.Drawing.Color.Silver;
			this.IntegralPanel.Controls.Add(this.ButtonShiftRight1);
			this.IntegralPanel.Controls.Add(this.ButtonShiftLeft1);
			this.IntegralPanel.Controls.Add(this.ButtonShiftRight);
			this.IntegralPanel.Controls.Add(this.ButtonShiftLeft);
			this.IntegralPanel.Controls.Add(this.ButtonOnesCompliment);
			this.IntegralPanel.Controls.Add(this.ButtonBinaryAnd);
			this.IntegralPanel.Controls.Add(this.ButtonBinaryOr);
			this.IntegralPanel.Controls.Add(this.ButtonBinaryXor);
			this.IntegralPanel.Location = new System.Drawing.Point(4, 22);
			this.IntegralPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.IntegralPanel.Name = "IntegralPanel";
			this.IntegralPanel.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.IntegralPanel.Size = new System.Drawing.Size(339, 188);
			this.IntegralPanel.TabIndex = 1;
			this.IntegralPanel.Text = "Integral";
			// 
			// ButtonShiftRight1
			// 
			this.ButtonShiftRight1.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonShiftRight1.Location = new System.Drawing.Point(274, 106);
			this.ButtonShiftRight1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonShiftRight1.Name = "ButtonShiftRight1";
			this.ButtonShiftRight1.Size = new System.Drawing.Size(64, 40);
			this.ButtonShiftRight1.TabIndex = 15;
			this.ButtonShiftRight1.TabStop = false;
			this.ButtonShiftRight1.Text = ">> 1";
			this.ButtonShiftRight1.UseVisualStyleBackColor = true;
			// 
			// ButtonShiftLeft1
			// 
			this.ButtonShiftLeft1.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonShiftLeft1.Location = new System.Drawing.Point(206, 106);
			this.ButtonShiftLeft1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonShiftLeft1.Name = "ButtonShiftLeft1";
			this.ButtonShiftLeft1.Size = new System.Drawing.Size(64, 40);
			this.ButtonShiftLeft1.TabIndex = 15;
			this.ButtonShiftLeft1.TabStop = false;
			this.ButtonShiftLeft1.Text = "<< 1";
			this.ButtonShiftLeft1.UseVisualStyleBackColor = true;
			// 
			// ButtonShiftRight
			// 
			this.ButtonShiftRight.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonShiftRight.Location = new System.Drawing.Point(274, 59);
			this.ButtonShiftRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonShiftRight.Name = "ButtonShiftRight";
			this.ButtonShiftRight.Size = new System.Drawing.Size(64, 40);
			this.ButtonShiftRight.TabIndex = 15;
			this.ButtonShiftRight.TabStop = false;
			this.ButtonShiftRight.Text = ">> x";
			this.ButtonShiftRight.UseVisualStyleBackColor = true;
			// 
			// ButtonShiftLeft
			// 
			this.ButtonShiftLeft.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonShiftLeft.Location = new System.Drawing.Point(206, 59);
			this.ButtonShiftLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonShiftLeft.Name = "ButtonShiftLeft";
			this.ButtonShiftLeft.Size = new System.Drawing.Size(64, 40);
			this.ButtonShiftLeft.TabIndex = 15;
			this.ButtonShiftLeft.TabStop = false;
			this.ButtonShiftLeft.Text = "<< x";
			this.ButtonShiftLeft.UseVisualStyleBackColor = true;
			// 
			// ButtonOnesCompliment
			// 
			this.ButtonOnesCompliment.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonOnesCompliment.Location = new System.Drawing.Point(2, 104);
			this.ButtonOnesCompliment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonOnesCompliment.Name = "ButtonOnesCompliment";
			this.ButtonOnesCompliment.Size = new System.Drawing.Size(64, 40);
			this.ButtonOnesCompliment.TabIndex = 15;
			this.ButtonOnesCompliment.TabStop = false;
			this.ButtonOnesCompliment.Text = "~";
			this.ButtonOnesCompliment.UseVisualStyleBackColor = true;
			// 
			// ButtonBinaryAnd
			// 
			this.ButtonBinaryAnd.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonBinaryAnd.Location = new System.Drawing.Point(2, 59);
			this.ButtonBinaryAnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonBinaryAnd.Name = "ButtonBinaryAnd";
			this.ButtonBinaryAnd.Size = new System.Drawing.Size(64, 40);
			this.ButtonBinaryAnd.TabIndex = 15;
			this.ButtonBinaryAnd.TabStop = false;
			this.ButtonBinaryAnd.Text = "&&";
			this.ButtonBinaryAnd.UseVisualStyleBackColor = true;
			// 
			// ButtonBinaryOr
			// 
			this.ButtonBinaryOr.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonBinaryOr.Location = new System.Drawing.Point(70, 59);
			this.ButtonBinaryOr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonBinaryOr.Name = "ButtonBinaryOr";
			this.ButtonBinaryOr.Size = new System.Drawing.Size(64, 40);
			this.ButtonBinaryOr.TabIndex = 15;
			this.ButtonBinaryOr.TabStop = false;
			this.ButtonBinaryOr.Text = "|";
			this.ButtonBinaryOr.UseVisualStyleBackColor = true;
			// 
			// ButtonBinaryXor
			// 
			this.ButtonBinaryXor.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonBinaryXor.Location = new System.Drawing.Point(138, 59);
			this.ButtonBinaryXor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonBinaryXor.Name = "ButtonBinaryXor";
			this.ButtonBinaryXor.Size = new System.Drawing.Size(64, 40);
			this.ButtonBinaryXor.TabIndex = 15;
			this.ButtonBinaryXor.TabStop = false;
			this.ButtonBinaryXor.Text = "^";
			this.ButtonBinaryXor.UseVisualStyleBackColor = true;
			// 
			// Mem1Value
			// 
			this.Mem1Value.BackColor = System.Drawing.Color.Maroon;
			this.Mem1Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Mem1Value.ForeColor = System.Drawing.Color.White;
			this.Mem1Value.Location = new System.Drawing.Point(13, 182);
			this.Mem1Value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Mem1Value.Name = "Mem1Value";
			this.Mem1Value.Size = new System.Drawing.Size(64, 16);
			this.Mem1Value.TabIndex = 15;
			this.Mem1Value.Text = "M1 empty";
			this.Mem1Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Mem2Value
			// 
			this.Mem2Value.BackColor = System.Drawing.Color.Maroon;
			this.Mem2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Mem2Value.ForeColor = System.Drawing.Color.White;
			this.Mem2Value.Location = new System.Drawing.Point(82, 182);
			this.Mem2Value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Mem2Value.Name = "Mem2Value";
			this.Mem2Value.Size = new System.Drawing.Size(64, 16);
			this.Mem2Value.TabIndex = 15;
			this.Mem2Value.Text = "M2 empty";
			this.Mem2Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Mem3Value
			// 
			this.Mem3Value.BackColor = System.Drawing.Color.Maroon;
			this.Mem3Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Mem3Value.ForeColor = System.Drawing.Color.White;
			this.Mem3Value.Location = new System.Drawing.Point(150, 182);
			this.Mem3Value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Mem3Value.Name = "Mem3Value";
			this.Mem3Value.Size = new System.Drawing.Size(64, 16);
			this.Mem3Value.TabIndex = 15;
			this.Mem3Value.Text = "M3 empty";
			this.Mem3Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Mem4Value
			// 
			this.Mem4Value.BackColor = System.Drawing.Color.Maroon;
			this.Mem4Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Mem4Value.ForeColor = System.Drawing.Color.White;
			this.Mem4Value.Location = new System.Drawing.Point(219, 182);
			this.Mem4Value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Mem4Value.Name = "Mem4Value";
			this.Mem4Value.Size = new System.Drawing.Size(64, 16);
			this.Mem4Value.TabIndex = 15;
			this.Mem4Value.Text = "M4 empty";
			this.Mem4Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Mem5Value
			// 
			this.Mem5Value.BackColor = System.Drawing.Color.Maroon;
			this.Mem5Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Mem5Value.ForeColor = System.Drawing.Color.White;
			this.Mem5Value.Location = new System.Drawing.Point(288, 182);
			this.Mem5Value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Mem5Value.Name = "Mem5Value";
			this.Mem5Value.Size = new System.Drawing.Size(64, 16);
			this.Mem5Value.TabIndex = 15;
			this.Mem5Value.Text = "M5 empty";
			this.Mem5Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Mem6Value
			// 
			this.Mem6Value.BackColor = System.Drawing.Color.Maroon;
			this.Mem6Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Mem6Value.ForeColor = System.Drawing.Color.White;
			this.Mem6Value.Location = new System.Drawing.Point(357, 182);
			this.Mem6Value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Mem6Value.Name = "Mem6Value";
			this.Mem6Value.Size = new System.Drawing.Size(64, 16);
			this.Mem6Value.TabIndex = 15;
			this.Mem6Value.Text = "M6 empty";
			this.Mem6Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Mem7Value
			// 
			this.Mem7Value.BackColor = System.Drawing.Color.Maroon;
			this.Mem7Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Mem7Value.ForeColor = System.Drawing.Color.White;
			this.Mem7Value.Location = new System.Drawing.Point(426, 182);
			this.Mem7Value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Mem7Value.Name = "Mem7Value";
			this.Mem7Value.Size = new System.Drawing.Size(64, 16);
			this.Mem7Value.TabIndex = 15;
			this.Mem7Value.Text = "M7 empty";
			this.Mem7Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Mem8Value
			// 
			this.Mem8Value.BackColor = System.Drawing.Color.Maroon;
			this.Mem8Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Mem8Value.ForeColor = System.Drawing.Color.White;
			this.Mem8Value.Location = new System.Drawing.Point(496, 182);
			this.Mem8Value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Mem8Value.Name = "Mem8Value";
			this.Mem8Value.Size = new System.Drawing.Size(64, 16);
			this.Mem8Value.TabIndex = 15;
			this.Mem8Value.Text = "M8 empty";
			this.Mem8Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Mem9Value
			// 
			this.Mem9Value.BackColor = System.Drawing.Color.Maroon;
			this.Mem9Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Mem9Value.ForeColor = System.Drawing.Color.White;
			this.Mem9Value.Location = new System.Drawing.Point(566, 182);
			this.Mem9Value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Mem9Value.Name = "Mem9Value";
			this.Mem9Value.Size = new System.Drawing.Size(64, 16);
			this.Mem9Value.TabIndex = 15;
			this.Mem9Value.Text = "M9 empty";
			this.Mem9Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Mem0Value
			// 
			this.Mem0Value.BackColor = System.Drawing.Color.Maroon;
			this.Mem0Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Mem0Value.ForeColor = System.Drawing.Color.White;
			this.Mem0Value.Location = new System.Drawing.Point(635, 182);
			this.Mem0Value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Mem0Value.Name = "Mem0Value";
			this.Mem0Value.Size = new System.Drawing.Size(64, 16);
			this.Mem0Value.TabIndex = 15;
			this.Mem0Value.Text = "M0 empty";
			this.Mem0Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ButtonDecimal
			// 
			this.ButtonDecimal.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonDecimal.Location = new System.Drawing.Point(496, 428);
			this.ButtonDecimal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonDecimal.Name = "ButtonDecimal";
			this.ButtonDecimal.Size = new System.Drawing.Size(64, 40);
			this.ButtonDecimal.TabIndex = 4;
			this.ButtonDecimal.TabStop = false;
			this.ButtonDecimal.Text = ".";
			this.ButtonDecimal.UseVisualStyleBackColor = true;
			this.ButtonDecimal.Click += new System.EventHandler(this.ButtonDecimal_Click);
			// 
			// ButtonNegate
			// 
			this.ButtonNegate.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonNegate.Location = new System.Drawing.Point(357, 428);
			this.ButtonNegate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonNegate.Name = "ButtonNegate";
			this.ButtonNegate.Size = new System.Drawing.Size(64, 40);
			this.ButtonNegate.TabIndex = 5;
			this.ButtonNegate.TabStop = false;
			this.ButtonNegate.Text = "±";
			this.ButtonNegate.UseVisualStyleBackColor = true;
			this.ButtonNegate.Click += new System.EventHandler(this.ButtonNegate_Click);
			// 
			// ButtonZero
			// 
			this.ButtonZero.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonZero.Location = new System.Drawing.Point(426, 428);
			this.ButtonZero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonZero.Name = "ButtonZero";
			this.ButtonZero.Size = new System.Drawing.Size(64, 40);
			this.ButtonZero.TabIndex = 5;
			this.ButtonZero.TabStop = false;
			this.ButtonZero.Text = "0";
			this.ButtonZero.UseVisualStyleBackColor = true;
			this.ButtonZero.Click += new System.EventHandler(this.ButtonZero_Click);
			// 
			// ButtonEvaluate
			// 
			this.ButtonEvaluate.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonEvaluate.Location = new System.Drawing.Point(635, 382);
			this.ButtonEvaluate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonEvaluate.Name = "ButtonEvaluate";
			this.ButtonEvaluate.Size = new System.Drawing.Size(64, 86);
			this.ButtonEvaluate.TabIndex = 6;
			this.ButtonEvaluate.TabStop = false;
			this.ButtonEvaluate.Text = "=";
			this.ButtonEvaluate.UseVisualStyleBackColor = true;
			this.ButtonEvaluate.Click += new System.EventHandler(this.ButtonEvaluate_Click);
			// 
			// ButtonExponent
			// 
			this.ButtonExponent.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonExponent.Location = new System.Drawing.Point(566, 428);
			this.ButtonExponent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonExponent.Name = "ButtonExponent";
			this.ButtonExponent.Size = new System.Drawing.Size(64, 40);
			this.ButtonExponent.TabIndex = 8;
			this.ButtonExponent.TabStop = false;
			this.ButtonExponent.Text = "exp";
			this.ButtonExponent.UseVisualStyleBackColor = true;
			// 
			// ButtonModulus
			// 
			this.ButtonModulus.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonModulus.Location = new System.Drawing.Point(566, 382);
			this.ButtonModulus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonModulus.Name = "ButtonModulus";
			this.ButtonModulus.Size = new System.Drawing.Size(64, 40);
			this.ButtonModulus.TabIndex = 8;
			this.ButtonModulus.TabStop = false;
			this.ButtonModulus.Text = "%";
			this.ButtonModulus.UseVisualStyleBackColor = true;
			this.ButtonModulus.Click += new System.EventHandler(this.ButtonModulus_Click);
			// 
			// ButtonDivide
			// 
			this.ButtonDivide.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonDivide.Location = new System.Drawing.Point(566, 337);
			this.ButtonDivide.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonDivide.Name = "ButtonDivide";
			this.ButtonDivide.Size = new System.Drawing.Size(64, 40);
			this.ButtonDivide.TabIndex = 8;
			this.ButtonDivide.TabStop = false;
			this.ButtonDivide.Text = "÷";
			this.ButtonDivide.UseVisualStyleBackColor = true;
			this.ButtonDivide.Click += new System.EventHandler(this.ButtonDivide_Click);
			// 
			// ButtonMinus
			// 
			this.ButtonMinus.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonMinus.Location = new System.Drawing.Point(635, 337);
			this.ButtonMinus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonMinus.Name = "ButtonMinus";
			this.ButtonMinus.Size = new System.Drawing.Size(65, 41);
			this.ButtonMinus.TabIndex = 8;
			this.ButtonMinus.TabStop = false;
			this.ButtonMinus.Text = "-";
			this.ButtonMinus.UseVisualStyleBackColor = true;
			this.ButtonMinus.Click += new System.EventHandler(this.ButtonMinus_Click);
			// 
			// ButtonMemMinus
			// 
			this.ButtonMemMinus.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonMemMinus.Location = new System.Drawing.Point(82, 200);
			this.ButtonMemMinus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonMemMinus.Name = "ButtonMemMinus";
			this.ButtonMemMinus.Size = new System.Drawing.Size(64, 40);
			this.ButtonMemMinus.TabIndex = 11;
			this.ButtonMemMinus.TabStop = false;
			this.ButtonMemMinus.Text = "M-x";
			this.ButtonMemMinus.UseVisualStyleBackColor = true;
			this.ButtonMemMinus.Click += new System.EventHandler(this.ButtonMemMinus_Click);
			// 
			// ButtonClearInput
			// 
			this.ButtonClearInput.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonClearInput.Location = new System.Drawing.Point(566, 200);
			this.ButtonClearInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonClearInput.Name = "ButtonClearInput";
			this.ButtonClearInput.Size = new System.Drawing.Size(64, 40);
			this.ButtonClearInput.TabIndex = 11;
			this.ButtonClearInput.TabStop = false;
			this.ButtonClearInput.Text = "clr";
			this.ButtonClearInput.UseVisualStyleBackColor = true;
			this.ButtonClearInput.Click += new System.EventHandler(this.ButtonClearInput_Click);
			// 
			// ButtonMultiply
			// 
			this.ButtonMultiply.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonMultiply.Location = new System.Drawing.Point(566, 291);
			this.ButtonMultiply.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonMultiply.Name = "ButtonMultiply";
			this.ButtonMultiply.Size = new System.Drawing.Size(64, 40);
			this.ButtonMultiply.TabIndex = 11;
			this.ButtonMultiply.TabStop = false;
			this.ButtonMultiply.Text = "X";
			this.ButtonMultiply.UseVisualStyleBackColor = true;
			this.ButtonMultiply.Click += new System.EventHandler(this.ButtonMultiply_Click);
			// 
			// ButtonMemClear
			// 
			this.ButtonMemClear.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonMemClear.Location = new System.Drawing.Point(222, 200);
			this.ButtonMemClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonMemClear.Name = "ButtonMemClear";
			this.ButtonMemClear.Size = new System.Drawing.Size(64, 40);
			this.ButtonMemClear.TabIndex = 11;
			this.ButtonMemClear.TabStop = false;
			this.ButtonMemClear.Text = "MCx";
			this.ButtonMemClear.UseVisualStyleBackColor = true;
			this.ButtonMemClear.Click += new System.EventHandler(this.ButtonMemClear_Click);
			// 
			// ButtonMemRecall
			// 
			this.ButtonMemRecall.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonMemRecall.Location = new System.Drawing.Point(152, 200);
			this.ButtonMemRecall.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonMemRecall.Name = "ButtonMemRecall";
			this.ButtonMemRecall.Size = new System.Drawing.Size(64, 40);
			this.ButtonMemRecall.TabIndex = 11;
			this.ButtonMemRecall.TabStop = false;
			this.ButtonMemRecall.Text = "MRx";
			this.ButtonMemRecall.UseVisualStyleBackColor = true;
			this.ButtonMemRecall.Click += new System.EventHandler(this.ButtonMemRecall_Click);
			// 
			// ButtonClearAll
			// 
			this.ButtonClearAll.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonClearAll.Location = new System.Drawing.Point(635, 200);
			this.ButtonClearAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonClearAll.Name = "ButtonClearAll";
			this.ButtonClearAll.Size = new System.Drawing.Size(64, 40);
			this.ButtonClearAll.TabIndex = 11;
			this.ButtonClearAll.TabStop = false;
			this.ButtonClearAll.Text = "ce";
			this.ButtonClearAll.UseVisualStyleBackColor = true;
			this.ButtonClearAll.Click += new System.EventHandler(this.ButtonClearAll_Click);
			// 
			// ButtonMemAdd
			// 
			this.ButtonMemAdd.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonMemAdd.Location = new System.Drawing.Point(13, 200);
			this.ButtonMemAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonMemAdd.Name = "ButtonMemAdd";
			this.ButtonMemAdd.Size = new System.Drawing.Size(64, 40);
			this.ButtonMemAdd.TabIndex = 11;
			this.ButtonMemAdd.TabStop = false;
			this.ButtonMemAdd.Text = "M+x";
			this.ButtonMemAdd.UseVisualStyleBackColor = true;
			this.ButtonMemAdd.Click += new System.EventHandler(this.ButtonMemAdd_Click);
			// 
			// ButtonPlus
			// 
			this.ButtonPlus.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonPlus.Location = new System.Drawing.Point(635, 291);
			this.ButtonPlus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonPlus.Name = "ButtonPlus";
			this.ButtonPlus.Size = new System.Drawing.Size(65, 41);
			this.ButtonPlus.TabIndex = 11;
			this.ButtonPlus.TabStop = false;
			this.ButtonPlus.Text = "+";
			this.ButtonPlus.UseVisualStyleBackColor = true;
			this.ButtonPlus.Click += new System.EventHandler(this.ButtonPlus_Click);
			// 
			// ButtonBackspace
			// 
			this.ButtonBackspace.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonBackspace.Location = new System.Drawing.Point(566, 246);
			this.ButtonBackspace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonBackspace.Name = "ButtonBackspace";
			this.ButtonBackspace.Size = new System.Drawing.Size(134, 40);
			this.ButtonBackspace.TabIndex = 11;
			this.ButtonBackspace.TabStop = false;
			this.ButtonBackspace.Text = "⌫";
			this.ButtonBackspace.UseVisualStyleBackColor = true;
			this.ButtonBackspace.Click += new System.EventHandler(this.ButtonBackspace_Click);
			// 
			// ButtonThree
			// 
			this.ButtonThree.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonThree.Location = new System.Drawing.Point(496, 382);
			this.ButtonThree.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonThree.Name = "ButtonThree";
			this.ButtonThree.Size = new System.Drawing.Size(64, 40);
			this.ButtonThree.TabIndex = 11;
			this.ButtonThree.TabStop = false;
			this.ButtonThree.Text = "3";
			this.ButtonThree.UseVisualStyleBackColor = true;
			this.ButtonThree.Click += new System.EventHandler(this.ButtonThree_Click);
			// 
			// ButtonTwo
			// 
			this.ButtonTwo.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonTwo.Location = new System.Drawing.Point(426, 382);
			this.ButtonTwo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonTwo.Name = "ButtonTwo";
			this.ButtonTwo.Size = new System.Drawing.Size(64, 40);
			this.ButtonTwo.TabIndex = 13;
			this.ButtonTwo.TabStop = false;
			this.ButtonTwo.Text = "2";
			this.ButtonTwo.UseVisualStyleBackColor = true;
			this.ButtonTwo.Click += new System.EventHandler(this.ButtonTwo_Click);
			// 
			// ButtonOne
			// 
			this.ButtonOne.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonOne.Location = new System.Drawing.Point(357, 382);
			this.ButtonOne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonOne.Name = "ButtonOne";
			this.ButtonOne.Size = new System.Drawing.Size(64, 40);
			this.ButtonOne.TabIndex = 14;
			this.ButtonOne.TabStop = false;
			this.ButtonOne.Text = "1";
			this.ButtonOne.UseVisualStyleBackColor = true;
			this.ButtonOne.Click += new System.EventHandler(this.ButtonOne_Click);
			// 
			// CalculatorOutput
			// 
			this.CalculatorOutput.BackColor = System.Drawing.Color.DarkSlateGray;
			this.CalculatorOutput.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CalculatorOutput.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.CalculatorOutput.Location = new System.Drawing.Point(10, 34);
			this.CalculatorOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.CalculatorOutput.Name = "CalculatorOutput";
			this.CalculatorOutput.ReadOnly = true;
			this.CalculatorOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.CalculatorOutput.Size = new System.Drawing.Size(690, 146);
			this.CalculatorOutput.TabIndex = 3;
			this.CalculatorOutput.TabStop = false;
			this.CalculatorOutput.Text = "";
			// 
			// ButtonA
			// 
			this.ButtonA.Enabled = false;
			this.ButtonA.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonA.Location = new System.Drawing.Point(358, 246);
			this.ButtonA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonA.Name = "ButtonA";
			this.ButtonA.Size = new System.Drawing.Size(64, 40);
			this.ButtonA.TabIndex = 14;
			this.ButtonA.TabStop = false;
			this.ButtonA.Text = "A";
			this.ButtonA.UseVisualStyleBackColor = true;
			// 
			// ButtonB
			// 
			this.ButtonB.Enabled = false;
			this.ButtonB.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonB.Location = new System.Drawing.Point(427, 246);
			this.ButtonB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonB.Name = "ButtonB";
			this.ButtonB.Size = new System.Drawing.Size(64, 40);
			this.ButtonB.TabIndex = 13;
			this.ButtonB.TabStop = false;
			this.ButtonB.Text = "B";
			this.ButtonB.UseVisualStyleBackColor = true;
			// 
			// ButtonC
			// 
			this.ButtonC.Enabled = false;
			this.ButtonC.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonC.Location = new System.Drawing.Point(497, 246);
			this.ButtonC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonC.Name = "ButtonC";
			this.ButtonC.Size = new System.Drawing.Size(64, 40);
			this.ButtonC.TabIndex = 11;
			this.ButtonC.TabStop = false;
			this.ButtonC.Text = "C";
			this.ButtonC.UseVisualStyleBackColor = true;
			// 
			// ButtonSix
			// 
			this.ButtonSix.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonSix.Location = new System.Drawing.Point(497, 337);
			this.ButtonSix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonSix.Name = "ButtonSix";
			this.ButtonSix.Size = new System.Drawing.Size(64, 40);
			this.ButtonSix.TabIndex = 19;
			this.ButtonSix.TabStop = false;
			this.ButtonSix.Text = "6";
			this.ButtonSix.UseVisualStyleBackColor = true;
			this.ButtonSix.Click += new System.EventHandler(this.ButtonSix_Click);
			// 
			// ButtonFive
			// 
			this.ButtonFive.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonFive.Location = new System.Drawing.Point(427, 337);
			this.ButtonFive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonFive.Name = "ButtonFive";
			this.ButtonFive.Size = new System.Drawing.Size(64, 40);
			this.ButtonFive.TabIndex = 20;
			this.ButtonFive.TabStop = false;
			this.ButtonFive.Text = "5";
			this.ButtonFive.UseVisualStyleBackColor = true;
			this.ButtonFive.Click += new System.EventHandler(this.ButtonFive_Click);
			// 
			// ButtonFour
			// 
			this.ButtonFour.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonFour.Location = new System.Drawing.Point(358, 337);
			this.ButtonFour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonFour.Name = "ButtonFour";
			this.ButtonFour.Size = new System.Drawing.Size(64, 40);
			this.ButtonFour.TabIndex = 22;
			this.ButtonFour.TabStop = false;
			this.ButtonFour.Text = "4";
			this.ButtonFour.UseVisualStyleBackColor = true;
			this.ButtonFour.Click += new System.EventHandler(this.ButtonFour_Click);
			// 
			// ButtonNine
			// 
			this.ButtonNine.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonNine.Location = new System.Drawing.Point(496, 292);
			this.ButtonNine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonNine.Name = "ButtonNine";
			this.ButtonNine.Size = new System.Drawing.Size(64, 40);
			this.ButtonNine.TabIndex = 23;
			this.ButtonNine.TabStop = false;
			this.ButtonNine.Text = "9";
			this.ButtonNine.UseVisualStyleBackColor = true;
			this.ButtonNine.Click += new System.EventHandler(this.ButtonNine_Click);
			// 
			// ButtonEight
			// 
			this.ButtonEight.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonEight.Location = new System.Drawing.Point(426, 292);
			this.ButtonEight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonEight.Name = "ButtonEight";
			this.ButtonEight.Size = new System.Drawing.Size(64, 40);
			this.ButtonEight.TabIndex = 24;
			this.ButtonEight.TabStop = false;
			this.ButtonEight.Text = "8";
			this.ButtonEight.UseVisualStyleBackColor = true;
			this.ButtonEight.Click += new System.EventHandler(this.ButtonEight_Click);
			// 
			// ButtonSeven
			// 
			this.ButtonSeven.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonSeven.Location = new System.Drawing.Point(357, 292);
			this.ButtonSeven.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonSeven.Name = "ButtonSeven";
			this.ButtonSeven.Size = new System.Drawing.Size(64, 40);
			this.ButtonSeven.TabIndex = 25;
			this.ButtonSeven.TabStop = false;
			this.ButtonSeven.Text = "7";
			this.ButtonSeven.UseVisualStyleBackColor = true;
			this.ButtonSeven.Click += new System.EventHandler(this.ButtonSeven_Click);
			// 
			// ButtonF
			// 
			this.ButtonF.Enabled = false;
			this.ButtonF.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonF.Location = new System.Drawing.Point(496, 200);
			this.ButtonF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonF.Name = "ButtonF";
			this.ButtonF.Size = new System.Drawing.Size(64, 40);
			this.ButtonF.TabIndex = 26;
			this.ButtonF.TabStop = false;
			this.ButtonF.Text = "F";
			this.ButtonF.UseVisualStyleBackColor = true;
			// 
			// ButtonE
			// 
			this.ButtonE.Enabled = false;
			this.ButtonE.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonE.Location = new System.Drawing.Point(426, 200);
			this.ButtonE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonE.Name = "ButtonE";
			this.ButtonE.Size = new System.Drawing.Size(64, 40);
			this.ButtonE.TabIndex = 27;
			this.ButtonE.TabStop = false;
			this.ButtonE.Text = "E";
			this.ButtonE.UseVisualStyleBackColor = true;
			// 
			// ButtonD
			// 
			this.ButtonD.Enabled = false;
			this.ButtonD.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonD.Location = new System.Drawing.Point(357, 200);
			this.ButtonD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonD.Name = "ButtonD";
			this.ButtonD.Size = new System.Drawing.Size(64, 40);
			this.ButtonD.TabIndex = 28;
			this.ButtonD.TabStop = false;
			this.ButtonD.Text = "D";
			this.ButtonD.UseVisualStyleBackColor = true;
			// 
			// ProgressLabel
			// 
			this.ProgressLabel.AutoSize = true;
			this.ProgressLabel.BackColor = System.Drawing.Color.DarkSlateGray;
			this.ProgressLabel.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProgressLabel.ForeColor = System.Drawing.Color.White;
			this.ProgressLabel.Location = new System.Drawing.Point(610, 39);
			this.ProgressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.ProgressLabel.Name = "ProgressLabel";
			this.ProgressLabel.Size = new System.Drawing.Size(79, 14);
			this.ProgressLabel.TabIndex = 29;
			this.ProgressLabel.Text = "Progress:";
			// 
			// ProgressText
			// 
			this.ProgressText.BackColor = System.Drawing.Color.DarkSlateGray;
			this.ProgressText.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ProgressText.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProgressText.ForeColor = System.Drawing.Color.White;
			this.ProgressText.Location = new System.Drawing.Point(373, 55);
			this.ProgressText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ProgressText.Name = "ProgressText";
			this.ProgressText.ReadOnly = true;
			this.ProgressText.Size = new System.Drawing.Size(315, 14);
			this.ProgressText.TabIndex = 30;
			this.ProgressText.Text = "01234567890123456789";
			this.ProgressText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// DisplayText
			// 
			this.DisplayText.BackColor = System.Drawing.Color.DarkSlateGray;
			this.DisplayText.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DisplayText.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DisplayText.ForeColor = System.Drawing.Color.White;
			this.DisplayText.Location = new System.Drawing.Point(15, 117);
			this.DisplayText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.DisplayText.Name = "DisplayText";
			this.DisplayText.ReadOnly = true;
			this.DisplayText.Size = new System.Drawing.Size(673, 32);
			this.DisplayText.TabIndex = 31;
			this.DisplayText.Text = "01234567890123456789";
			this.DisplayText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// MemorySlotText
			// 
			this.MemorySlotText.BackColor = System.Drawing.Color.DarkSlateGray;
			this.MemorySlotText.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.MemorySlotText.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MemorySlotText.ForeColor = System.Drawing.Color.White;
			this.MemorySlotText.Location = new System.Drawing.Point(373, 153);
			this.MemorySlotText.Margin = new System.Windows.Forms.Padding(2, 2, 5, 2);
			this.MemorySlotText.Name = "MemorySlotText";
			this.MemorySlotText.ReadOnly = true;
			this.MemorySlotText.Size = new System.Drawing.Size(315, 14);
			this.MemorySlotText.TabIndex = 32;
			this.MemorySlotText.Text = "Memory Add to slot?";
			this.MemorySlotText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// InputLabel
			// 
			this.InputLabel.AutoSize = true;
			this.InputLabel.BackColor = System.Drawing.Color.DarkSlateGray;
			this.InputLabel.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.InputLabel.ForeColor = System.Drawing.Color.White;
			this.InputLabel.Location = new System.Drawing.Point(577, 71);
			this.InputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.InputLabel.Name = "InputLabel";
			this.InputLabel.Size = new System.Drawing.Size(111, 14);
			this.InputLabel.TabIndex = 33;
			this.InputLabel.Text = "Input stream:";
			// 
			// InputStreamText
			// 
			this.InputStreamText.BackColor = System.Drawing.Color.DarkSlateGray;
			this.InputStreamText.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.InputStreamText.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.InputStreamText.ForeColor = System.Drawing.Color.White;
			this.InputStreamText.Location = new System.Drawing.Point(16, 87);
			this.InputStreamText.Margin = new System.Windows.Forms.Padding(2);
			this.InputStreamText.Name = "InputStreamText";
			this.InputStreamText.ReadOnly = true;
			this.InputStreamText.Size = new System.Drawing.Size(672, 15);
			this.InputStreamText.TabIndex = 34;
			this.InputStreamText.Text = "01234567890123456789";
			this.InputStreamText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// CalculatorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.Silver;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(714, 486);
			this.Controls.Add(this.InputStreamText);
			this.Controls.Add(this.InputLabel);
			this.Controls.Add(this.MemorySlotText);
			this.Controls.Add(this.DisplayText);
			this.Controls.Add(this.ProgressText);
			this.Controls.Add(this.ProgressLabel);
			this.Controls.Add(this.ButtonF);
			this.Controls.Add(this.ButtonE);
			this.Controls.Add(this.ButtonD);
			this.Controls.Add(this.ButtonNine);
			this.Controls.Add(this.ButtonEight);
			this.Controls.Add(this.ButtonSeven);
			this.Controls.Add(this.ButtonSix);
			this.Controls.Add(this.ButtonFive);
			this.Controls.Add(this.ButtonFour);
			this.Controls.Add(this.ModeSelector);
			this.Controls.Add(this.Mem1Value);
			this.Controls.Add(this.Mem2Value);
			this.Controls.Add(this.Mem3Value);
			this.Controls.Add(this.Mem4Value);
			this.Controls.Add(this.Mem5Value);
			this.Controls.Add(this.Mem6Value);
			this.Controls.Add(this.Mem7Value);
			this.Controls.Add(this.Mem8Value);
			this.Controls.Add(this.Mem9Value);
			this.Controls.Add(this.Mem0Value);
			this.Controls.Add(this.ButtonDecimal);
			this.Controls.Add(this.ButtonNegate);
			this.Controls.Add(this.ButtonZero);
			this.Controls.Add(this.ButtonEvaluate);
			this.Controls.Add(this.ButtonExponent);
			this.Controls.Add(this.ButtonModulus);
			this.Controls.Add(this.ButtonDivide);
			this.Controls.Add(this.ButtonMinus);
			this.Controls.Add(this.ButtonMemMinus);
			this.Controls.Add(this.ButtonClearInput);
			this.Controls.Add(this.ButtonMultiply);
			this.Controls.Add(this.ButtonMemClear);
			this.Controls.Add(this.ButtonMemRecall);
			this.Controls.Add(this.ButtonClearAll);
			this.Controls.Add(this.ButtonMemAdd);
			this.Controls.Add(this.ButtonPlus);
			this.Controls.Add(this.ButtonBackspace);
			this.Controls.Add(this.ButtonC);
			this.Controls.Add(this.ButtonThree);
			this.Controls.Add(this.ButtonB);
			this.Controls.Add(this.ButtonA);
			this.Controls.Add(this.ButtonTwo);
			this.Controls.Add(this.ButtonOne);
			this.Controls.Add(this.CalculatorOutput);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CalculatorForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "D Calculator!";
			this.Load += new System.EventHandler(this.CalculatorForm_Load);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalculatorForm_KeyPress);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ModeSelector.ResumeLayout(false);
			this.FloatingPointPanel.ResumeLayout(false);
			this.IntegralPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		//private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TabControl ModeSelector;
		private System.Windows.Forms.TabPage FloatingPointPanel;
		private System.Windows.Forms.TabPage IntegralPanel;
		private System.Windows.Forms.Button ButtonShiftRight;
		private System.Windows.Forms.Button ButtonShiftLeft;
		private System.Windows.Forms.Button ButtonBinaryOr;
		private System.Windows.Forms.Button ButtonBinaryXor;
		private System.Windows.Forms.Label Mem1Value;
		private System.Windows.Forms.Label Mem2Value;
		private System.Windows.Forms.Label Mem3Value;
		private System.Windows.Forms.Label Mem4Value;
		private System.Windows.Forms.Label Mem5Value;
		private System.Windows.Forms.Label Mem6Value;
		private System.Windows.Forms.Label Mem7Value;
		private System.Windows.Forms.Label Mem8Value;
		private System.Windows.Forms.Label Mem9Value;
		private System.Windows.Forms.Label Mem0Value;
		private System.Windows.Forms.Button ButtonDecimal;
		private System.Windows.Forms.Button ButtonNegate;
		private System.Windows.Forms.Button ButtonZero;
		private System.Windows.Forms.Button ButtonEvaluate;
		private System.Windows.Forms.Button ButtonExponent;
		private System.Windows.Forms.Button ButtonModulus;
		private System.Windows.Forms.Button ButtonDivide;
		private System.Windows.Forms.Button ButtonMinus;
		private System.Windows.Forms.Button ButtonMemMinus;
		private System.Windows.Forms.Button ButtonClearInput;
		private System.Windows.Forms.Button ButtonMultiply;
		private System.Windows.Forms.Button ButtonMemClear;
		private System.Windows.Forms.Button ButtonMemRecall;
		private System.Windows.Forms.Button ButtonClearAll;
		private System.Windows.Forms.Button ButtonMemAdd;
		private System.Windows.Forms.Button ButtonPlus;
		private System.Windows.Forms.Button ButtonBackspace;
		private System.Windows.Forms.Button ButtonThree;
		private System.Windows.Forms.Button ButtonTwo;
		private System.Windows.Forms.Button ButtonOne;
		private System.Windows.Forms.RichTextBox CalculatorOutput;
		private System.Windows.Forms.Button ButtonBinaryAnd;
		private System.Windows.Forms.Button ButtonShiftRight1;
		private System.Windows.Forms.Button ButtonShiftLeft1;
		private System.Windows.Forms.Button ButtonNthRoot;
		private System.Windows.Forms.Button ButtonSquareRoot;
		private System.Windows.Forms.Button ButtonNthPower;
		private System.Windows.Forms.Button ButtonSquarePower;
		private System.Windows.Forms.Button ButtonASin;
		private System.Windows.Forms.Button ButtonACos;
		private System.Windows.Forms.Button ButtonSin;
		private System.Windows.Forms.Button ButtonATan;
		private System.Windows.Forms.Button ButtonCos;
		private System.Windows.Forms.Button ButtonTan;
		private System.Windows.Forms.Button ButtonOnesCompliment;
		private System.Windows.Forms.Button ButtonA;
		private System.Windows.Forms.Button ButtonB;
		private System.Windows.Forms.Button ButtonC;
		private System.Windows.Forms.Button ButtonSix;
		private System.Windows.Forms.Button ButtonFive;
		private System.Windows.Forms.Button ButtonFour;
		private System.Windows.Forms.Button ButtonNine;
		private System.Windows.Forms.Button ButtonEight;
		private System.Windows.Forms.Button ButtonSeven;
		private System.Windows.Forms.Button ButtonF;
		private System.Windows.Forms.Button ButtonE;
		private System.Windows.Forms.Button ButtonD;
		private System.Windows.Forms.Label ProgressLabel;
		private System.Windows.Forms.TextBox ProgressText;
		private System.Windows.Forms.TextBox DisplayText;
		private System.Windows.Forms.TextBox MemorySlotText;
		private System.Windows.Forms.Label InputLabel;
		private System.Windows.Forms.TextBox InputStreamText;
	}
}

