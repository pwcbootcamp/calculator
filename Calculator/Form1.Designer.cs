namespace Calculator
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnNum00 = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnClearEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtResult.Location = new System.Drawing.Point(49, 36);
            this.txtResult.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(400, 65);
            this.txtResult.TabIndex = 0;
            this.txtResult.Text = "0";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnNum7
            // 
            this.btnNum7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNum7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNum7.Location = new System.Drawing.Point(49, 129);
            this.btnNum7.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(80, 63);
            this.btnNum7.TabIndex = 1;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = false;
            this.btnNum7.Click += new System.EventHandler(this.NumbersCal);
            // 
            // btnNum8
            // 
            this.btnNum8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNum8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNum8.Location = new System.Drawing.Point(154, 127);
            this.btnNum8.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(80, 63);
            this.btnNum8.TabIndex = 2;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = false;
            this.btnNum8.Click += new System.EventHandler(this.NumbersCal);
            // 
            // btnNum9
            // 
            this.btnNum9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNum9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNum9.Location = new System.Drawing.Point(259, 129);
            this.btnNum9.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(80, 63);
            this.btnNum9.TabIndex = 3;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = false;
            this.btnNum9.Click += new System.EventHandler(this.NumbersCal);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.BurlyWood;
            this.btnClear.Location = new System.Drawing.Point(369, 134);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 63);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.Location = new System.Drawing.Point(49, 204);
            this.btnNum4.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(80, 63);
            this.btnNum4.TabIndex = 5;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = true;
            this.btnNum4.Click += new System.EventHandler(this.NumbersCal);
            // 
            // btnNum5
            // 
            this.btnNum5.Location = new System.Drawing.Point(154, 204);
            this.btnNum5.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(80, 63);
            this.btnNum5.TabIndex = 6;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = true;
            this.btnNum5.Click += new System.EventHandler(this.NumbersCal);
            // 
            // btnNum6
            // 
            this.btnNum6.Location = new System.Drawing.Point(259, 206);
            this.btnNum6.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(80, 63);
            this.btnNum6.TabIndex = 7;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = true;
            this.btnNum6.Click += new System.EventHandler(this.NumbersCal);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(369, 211);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(80, 63);
            this.btnDivide.TabIndex = 8;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnNum1
            // 
            this.btnNum1.Location = new System.Drawing.Point(49, 281);
            this.btnNum1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(80, 63);
            this.btnNum1.TabIndex = 9;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = true;
            this.btnNum1.Click += new System.EventHandler(this.NumbersCal);
            // 
            // btnNum2
            // 
            this.btnNum2.Location = new System.Drawing.Point(154, 281);
            this.btnNum2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(80, 63);
            this.btnNum2.TabIndex = 10;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = true;
            this.btnNum2.Click += new System.EventHandler(this.NumbersCal);
            // 
            // btnNum3
            // 
            this.btnNum3.Location = new System.Drawing.Point(259, 284);
            this.btnNum3.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(80, 63);
            this.btnNum3.TabIndex = 11;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = true;
            this.btnNum3.Click += new System.EventHandler(this.NumbersCal);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(369, 288);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(80, 63);
            this.btnMultiply.TabIndex = 12;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnNum0
            // 
            this.btnNum0.Location = new System.Drawing.Point(49, 358);
            this.btnNum0.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(80, 63);
            this.btnNum0.TabIndex = 13;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = true;
            this.btnNum0.Click += new System.EventHandler(this.NumbersCal);
            // 
            // btnNum00
            // 
            this.btnNum00.Location = new System.Drawing.Point(154, 358);
            this.btnNum00.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnNum00.Name = "btnNum00";
            this.btnNum00.Size = new System.Drawing.Size(80, 63);
            this.btnNum00.TabIndex = 14;
            this.btnNum00.Text = "00";
            this.btnNum00.UseVisualStyleBackColor = true;
            this.btnNum00.Click += new System.EventHandler(this.NumbersCal);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(259, 361);
            this.btnDecimal.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(80, 63);
            this.btnDecimal.TabIndex = 15;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.NumbersCal);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(369, 365);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 63);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEquals.Location = new System.Drawing.Point(49, 442);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(185, 63);
            this.btnEquals.TabIndex = 17;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(369, 442);
            this.btnSubtract.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(80, 63);
            this.btnSubtract.TabIndex = 18;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnClearEnter
            // 
            this.btnClearEnter.Font = new System.Drawing.Font("Segoe UI Symbol", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearEnter.Location = new System.Drawing.Point(259, 442);
            this.btnClearEnter.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnClearEnter.Name = "btnClearEnter";
            this.btnClearEnter.Size = new System.Drawing.Size(80, 63);
            this.btnClearEnter.TabIndex = 19;
            this.btnClearEnter.Text = "⇦";
            this.btnClearEnter.UseVisualStyleBackColor = true;
            this.btnClearEnter.Click += new System.EventHandler(this.btnClearEnter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(500, 539);
            this.Controls.Add(this.btnClearEnter);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnNum00);
            this.Controls.Add(this.btnNum0);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnNum3);
            this.Controls.Add(this.btnNum2);
            this.Controls.Add(this.btnNum1);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnNum6);
            this.Controls.Add(this.btnNum5);
            this.Controls.Add(this.btnNum4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnNum9);
            this.Controls.Add(this.btnNum8);
            this.Controls.Add(this.btnNum7);
            this.Controls.Add(this.txtResult);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button btnNum00;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnClearEnter;
    }
}

