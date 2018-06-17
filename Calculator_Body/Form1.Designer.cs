namespace Calculator_Body
{
  partial class Form1
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
      System.Windows.Forms.Button Divide;
      this.Digit_1 = new System.Windows.Forms.Button();
      this.Digit_0 = new System.Windows.Forms.Button();
      this.Digit_9 = new System.Windows.Forms.Button();
      this.Digit_8 = new System.Windows.Forms.Button();
      this.Digit_7 = new System.Windows.Forms.Button();
      this.Digit_6 = new System.Windows.Forms.Button();
      this.Digit_5 = new System.Windows.Forms.Button();
      this.Digit_4 = new System.Windows.Forms.Button();
      this.Digit_3 = new System.Windows.Forms.Button();
      this.Digit_2 = new System.Windows.Forms.Button();
      this.Plus_Minus = new System.Windows.Forms.Button();
      this.Times = new System.Windows.Forms.Button();
      this.Minus = new System.Windows.Forms.Button();
      this.Plus = new System.Windows.Forms.Button();
      this.Decimal = new System.Windows.Forms.Button();
      this.Reciprocal = new System.Windows.Forms.Button();
      this.Square_Root = new System.Windows.Forms.Button();
      this.Clear = new System.Windows.Forms.Button();
      this.Calculator_Display = new System.Windows.Forms.TextBox();
      this.History_Tape = new System.Windows.Forms.TextBox();
      this.Equals = new System.Windows.Forms.Button();
      this.LHS_box = new System.Windows.Forms.TextBox();
      this.RHS_box = new System.Windows.Forms.TextBox();
      this.Operator_box = new System.Windows.Forms.TextBox();
      Divide = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // Divide
      // 
      Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      Divide.Location = new System.Drawing.Point(315, 301);
      Divide.Name = "Divide";
      Divide.Size = new System.Drawing.Size(64, 64);
      Divide.TabIndex = 25;
      Divide.Tag = "Division";
      Divide.Text = "÷";
      Divide.UseVisualStyleBackColor = true;
      Divide.Click += new System.EventHandler(this.Binary_operator_Click);
      // 
      // Digit_1
      // 
      this.Digit_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Digit_1.Location = new System.Drawing.Point(27, 397);
      this.Digit_1.Name = "Digit_1";
      this.Digit_1.Size = new System.Drawing.Size(64, 64);
      this.Digit_1.TabIndex = 10;
      this.Digit_1.Tag = "1";
      this.Digit_1.Text = "1";
      this.Digit_1.UseVisualStyleBackColor = true;
      this.Digit_1.Click += new System.EventHandler(this.Digit_Click);
      // 
      // Digit_0
      // 
      this.Digit_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Digit_0.Location = new System.Drawing.Point(27, 493);
      this.Digit_0.Name = "Digit_0";
      this.Digit_0.Size = new System.Drawing.Size(157, 64);
      this.Digit_0.TabIndex = 11;
      this.Digit_0.Tag = "0";
      this.Digit_0.Text = "0";
      this.Digit_0.UseVisualStyleBackColor = true;
      this.Digit_0.Click += new System.EventHandler(this.Digit_Click);
      // 
      // Digit_9
      // 
      this.Digit_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Digit_9.Location = new System.Drawing.Point(213, 209);
      this.Digit_9.Name = "Digit_9";
      this.Digit_9.Size = new System.Drawing.Size(64, 64);
      this.Digit_9.TabIndex = 12;
      this.Digit_9.Tag = "9";
      this.Digit_9.Text = "9";
      this.Digit_9.UseVisualStyleBackColor = true;
      this.Digit_9.Click += new System.EventHandler(this.Digit_Click);
      // 
      // Digit_8
      // 
      this.Digit_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Digit_8.Location = new System.Drawing.Point(120, 209);
      this.Digit_8.Name = "Digit_8";
      this.Digit_8.Size = new System.Drawing.Size(64, 64);
      this.Digit_8.TabIndex = 13;
      this.Digit_8.Tag = "8";
      this.Digit_8.Text = "8";
      this.Digit_8.UseVisualStyleBackColor = true;
      this.Digit_8.Click += new System.EventHandler(this.Digit_Click);
      // 
      // Digit_7
      // 
      this.Digit_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Digit_7.Location = new System.Drawing.Point(27, 209);
      this.Digit_7.Name = "Digit_7";
      this.Digit_7.Size = new System.Drawing.Size(64, 64);
      this.Digit_7.TabIndex = 14;
      this.Digit_7.Tag = "7";
      this.Digit_7.Text = "7";
      this.Digit_7.UseVisualStyleBackColor = true;
      this.Digit_7.Click += new System.EventHandler(this.Digit_Click);
      // 
      // Digit_6
      // 
      this.Digit_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Digit_6.Location = new System.Drawing.Point(213, 301);
      this.Digit_6.Name = "Digit_6";
      this.Digit_6.Size = new System.Drawing.Size(64, 64);
      this.Digit_6.TabIndex = 15;
      this.Digit_6.Tag = "6";
      this.Digit_6.Text = "6";
      this.Digit_6.UseVisualStyleBackColor = true;
      this.Digit_6.Click += new System.EventHandler(this.Digit_Click);
      // 
      // Digit_5
      // 
      this.Digit_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Digit_5.Location = new System.Drawing.Point(120, 301);
      this.Digit_5.Name = "Digit_5";
      this.Digit_5.Size = new System.Drawing.Size(64, 64);
      this.Digit_5.TabIndex = 16;
      this.Digit_5.Tag = "5";
      this.Digit_5.Text = "5";
      this.Digit_5.UseVisualStyleBackColor = true;
      this.Digit_5.Click += new System.EventHandler(this.Digit_Click);
      // 
      // Digit_4
      // 
      this.Digit_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Digit_4.Location = new System.Drawing.Point(27, 301);
      this.Digit_4.Name = "Digit_4";
      this.Digit_4.Size = new System.Drawing.Size(64, 64);
      this.Digit_4.TabIndex = 17;
      this.Digit_4.Tag = "4";
      this.Digit_4.Text = "4";
      this.Digit_4.UseVisualStyleBackColor = true;
      this.Digit_4.Click += new System.EventHandler(this.Digit_Click);
      // 
      // Digit_3
      // 
      this.Digit_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Digit_3.Location = new System.Drawing.Point(213, 397);
      this.Digit_3.Name = "Digit_3";
      this.Digit_3.Size = new System.Drawing.Size(64, 64);
      this.Digit_3.TabIndex = 18;
      this.Digit_3.Tag = "3";
      this.Digit_3.Text = "3";
      this.Digit_3.UseVisualStyleBackColor = true;
      this.Digit_3.Click += new System.EventHandler(this.Digit_Click);
      // 
      // Digit_2
      // 
      this.Digit_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Digit_2.Location = new System.Drawing.Point(120, 397);
      this.Digit_2.Name = "Digit_2";
      this.Digit_2.Size = new System.Drawing.Size(64, 64);
      this.Digit_2.TabIndex = 19;
      this.Digit_2.Tag = "2";
      this.Digit_2.Text = "2";
      this.Digit_2.UseVisualStyleBackColor = true;
      this.Digit_2.Click += new System.EventHandler(this.Digit_Click);
      // 
      // Plus_Minus
      // 
      this.Plus_Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Plus_Minus.Location = new System.Drawing.Point(412, 113);
      this.Plus_Minus.Name = "Plus_Minus";
      this.Plus_Minus.Size = new System.Drawing.Size(64, 64);
      this.Plus_Minus.TabIndex = 20;
      this.Plus_Minus.Tag = "Plus_Minus";
      this.Plus_Minus.Text = "+/-";
      this.Plus_Minus.UseVisualStyleBackColor = true;
      this.Plus_Minus.Click += new System.EventHandler(this.Plus_minus_Click);
      // 
      // Times
      // 
      this.Times.Location = new System.Drawing.Point(315, 209);
      this.Times.Name = "Times";
      this.Times.Size = new System.Drawing.Size(64, 64);
      this.Times.TabIndex = 21;
      this.Times.Tag = "Multiplication";
      this.Times.Text = "X";
      this.Times.UseVisualStyleBackColor = true;
      this.Times.Click += new System.EventHandler(this.Binary_operator_Click);
      // 
      // Minus
      // 
      this.Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Minus.Location = new System.Drawing.Point(315, 397);
      this.Minus.Name = "Minus";
      this.Minus.Size = new System.Drawing.Size(64, 64);
      this.Minus.TabIndex = 22;
      this.Minus.Tag = "Subtraction";
      this.Minus.Text = "–";
      this.Minus.UseVisualStyleBackColor = true;
      this.Minus.Click += new System.EventHandler(this.Binary_operator_Click);
      // 
      // Plus
      // 
      this.Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Plus.Location = new System.Drawing.Point(315, 493);
      this.Plus.Name = "Plus";
      this.Plus.Size = new System.Drawing.Size(64, 64);
      this.Plus.TabIndex = 23;
      this.Plus.Tag = "Addition";
      this.Plus.Text = "+";
      this.Plus.UseVisualStyleBackColor = true;
      this.Plus.Click += new System.EventHandler(this.Binary_operator_Click);
      // 
      // Decimal
      // 
      this.Decimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Decimal.Location = new System.Drawing.Point(213, 493);
      this.Decimal.Name = "Decimal";
      this.Decimal.Size = new System.Drawing.Size(64, 64);
      this.Decimal.TabIndex = 24;
      this.Decimal.Tag = "Decimal";
      this.Decimal.Text = ".";
      this.Decimal.UseVisualStyleBackColor = true;
      this.Decimal.Click += new System.EventHandler(this.Decimal_Click);
      // 
      // Reciprocal
      // 
      this.Reciprocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Reciprocal.Location = new System.Drawing.Point(412, 301);
      this.Reciprocal.Name = "Reciprocal";
      this.Reciprocal.Size = new System.Drawing.Size(64, 64);
      this.Reciprocal.TabIndex = 26;
      this.Reciprocal.Tag = "Reciprocal";
      this.Reciprocal.Text = "1/x";
      this.Reciprocal.UseVisualStyleBackColor = true;
      this.Reciprocal.Click += new System.EventHandler(this.Unary_operator_Click);
      // 
      // Square_Root
      // 
      this.Square_Root.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Square_Root.Location = new System.Drawing.Point(412, 209);
      this.Square_Root.Name = "Square_Root";
      this.Square_Root.Size = new System.Drawing.Size(64, 64);
      this.Square_Root.TabIndex = 27;
      this.Square_Root.Tag = "Square_Root";
      this.Square_Root.Text = "√";
      this.Square_Root.UseVisualStyleBackColor = true;
      this.Square_Root.Click += new System.EventHandler(this.Unary_operator_Click);
      // 
      // Clear
      // 
      this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Clear.Location = new System.Drawing.Point(27, 113);
      this.Clear.Name = "Clear";
      this.Clear.Size = new System.Drawing.Size(352, 64);
      this.Clear.TabIndex = 28;
      this.Clear.Tag = "Clear";
      this.Clear.Text = "C";
      this.Clear.UseVisualStyleBackColor = true;
      this.Clear.Click += new System.EventHandler(this.Clear_Click);
      // 
      // Calculator_Display
      // 
      this.Calculator_Display.BackColor = System.Drawing.SystemColors.InfoText;
      this.Calculator_Display.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Calculator_Display.ForeColor = System.Drawing.Color.Red;
      this.Calculator_Display.Location = new System.Drawing.Point(27, 63);
      this.Calculator_Display.Name = "Calculator_Display";
      this.Calculator_Display.ReadOnly = true;
      this.Calculator_Display.Size = new System.Drawing.Size(449, 40);
      this.Calculator_Display.TabIndex = 29;
      this.Calculator_Display.Tag = "Calculator_Display";
      this.Calculator_Display.Text = "0";
      this.Calculator_Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // History_Tape
      // 
      this.History_Tape.BackColor = System.Drawing.SystemColors.InfoText;
      this.History_Tape.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.History_Tape.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.History_Tape.Location = new System.Drawing.Point(27, 22);
      this.History_Tape.Name = "History_Tape";
      this.History_Tape.ReadOnly = true;
      this.History_Tape.Size = new System.Drawing.Size(449, 31);
      this.History_Tape.TabIndex = 30;
      this.History_Tape.Tag = "History_Tape";
      this.History_Tape.Text = "0";
      this.History_Tape.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // Equals
      // 
      this.Equals.Location = new System.Drawing.Point(412, 397);
      this.Equals.Name = "Equals";
      this.Equals.Size = new System.Drawing.Size(64, 160);
      this.Equals.TabIndex = 31;
      this.Equals.Tag = "Equals";
      this.Equals.Text = "=";
      this.Equals.UseVisualStyleBackColor = true;
      this.Equals.Click += new System.EventHandler(this.Equals_Click);
      // 
      // LHS_box
      // 
      this.LHS_box.Location = new System.Drawing.Point(607, 113);
      this.LHS_box.Name = "LHS_box";
      this.LHS_box.Size = new System.Drawing.Size(199, 26);
      this.LHS_box.TabIndex = 32;
      this.LHS_box.Tag = "LHS_box";
      // 
      // RHS_box
      // 
      this.RHS_box.Location = new System.Drawing.Point(607, 209);
      this.RHS_box.Name = "RHS_box";
      this.RHS_box.Size = new System.Drawing.Size(199, 26);
      this.RHS_box.TabIndex = 33;
      this.RHS_box.Tag = "RHS_box";
      // 
      // Operator_box
      // 
      this.Operator_box.Location = new System.Drawing.Point(607, 161);
      this.Operator_box.Name = "Operator_box";
      this.Operator_box.Size = new System.Drawing.Size(199, 26);
      this.Operator_box.TabIndex = 34;
      this.Operator_box.Tag = "Operator_box";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(511, 614);
      this.Controls.Add(this.Operator_box);
      this.Controls.Add(this.RHS_box);
      this.Controls.Add(this.LHS_box);
      this.Controls.Add(this.Equals);
      this.Controls.Add(this.History_Tape);
      this.Controls.Add(this.Calculator_Display);
      this.Controls.Add(this.Clear);
      this.Controls.Add(this.Square_Root);
      this.Controls.Add(this.Reciprocal);
      this.Controls.Add(Divide);
      this.Controls.Add(this.Decimal);
      this.Controls.Add(this.Plus);
      this.Controls.Add(this.Minus);
      this.Controls.Add(this.Times);
      this.Controls.Add(this.Plus_Minus);
      this.Controls.Add(this.Digit_2);
      this.Controls.Add(this.Digit_3);
      this.Controls.Add(this.Digit_4);
      this.Controls.Add(this.Digit_5);
      this.Controls.Add(this.Digit_6);
      this.Controls.Add(this.Digit_7);
      this.Controls.Add(this.Digit_8);
      this.Controls.Add(this.Digit_9);
      this.Controls.Add(this.Digit_0);
      this.Controls.Add(this.Digit_1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button Digit_1;
    private System.Windows.Forms.Button Digit_0;
    private System.Windows.Forms.Button Digit_9;
    private System.Windows.Forms.Button Digit_8;
    private System.Windows.Forms.Button Digit_7;
    private System.Windows.Forms.Button Digit_6;
    private System.Windows.Forms.Button Digit_5;
    private System.Windows.Forms.Button Digit_4;
    private System.Windows.Forms.Button Digit_3;
    private System.Windows.Forms.Button Digit_2;
    private System.Windows.Forms.Button Plus_Minus;
    private System.Windows.Forms.Button Times;
    private System.Windows.Forms.Button Minus;
    private System.Windows.Forms.Button Plus;
    private System.Windows.Forms.Button Decimal;
    private System.Windows.Forms.Button Reciprocal;
    private System.Windows.Forms.Button Square_Root;
    private System.Windows.Forms.Button Clear;
    private System.Windows.Forms.TextBox Calculator_Display;
    private System.Windows.Forms.TextBox History_Tape;
    private System.Windows.Forms.Button Equals;
    private System.Windows.Forms.TextBox LHS_box;
    private System.Windows.Forms.TextBox RHS_box;
    private System.Windows.Forms.TextBox Operator_box;
  }
}

