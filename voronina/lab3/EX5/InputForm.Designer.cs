namespace EX5
{
    partial class InputForm
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
            this.ValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SquareRadioButton = new System.Windows.Forms.RadioButton();
            this.LengthRadioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ValueNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ValueNumericUpDown
            // 
            this.ValueNumericUpDown.Location = new System.Drawing.Point(12, 12);
            this.ValueNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ValueNumericUpDown.Name = "ValueNumericUpDown";
            this.ValueNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.ValueNumericUpDown.TabIndex = 0;
            // 
            // SquareRadioButton
            // 
            this.SquareRadioButton.AutoSize = true;
            this.SquareRadioButton.Checked = true;
            this.SquareRadioButton.Location = new System.Drawing.Point(148, 12);
            this.SquareRadioButton.Name = "SquareRadioButton";
            this.SquareRadioButton.Size = new System.Drawing.Size(72, 17);
            this.SquareRadioButton.TabIndex = 1;
            this.SquareRadioButton.TabStop = true;
            this.SquareRadioButton.Text = "Площадь";
            this.SquareRadioButton.UseVisualStyleBackColor = true;
            // 
            // LengthRadioButton
            // 
            this.LengthRadioButton.AutoSize = true;
            this.LengthRadioButton.Location = new System.Drawing.Point(147, 35);
            this.LengthRadioButton.Name = "LengthRadioButton";
            this.LengthRadioButton.Size = new System.Drawing.Size(58, 17);
            this.LengthRadioButton.TabIndex = 2;
            this.LengthRadioButton.Text = "Длина";
            this.LengthRadioButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 110);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LengthRadioButton);
            this.Controls.Add(this.SquareRadioButton);
            this.Controls.Add(this.ValueNumericUpDown);
            this.Name = "InputForm";
            this.Text = "InputForm";
            ((System.ComponentModel.ISupportInitialize)(this.ValueNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ValueNumericUpDown;
        private System.Windows.Forms.RadioButton SquareRadioButton;
        private System.Windows.Forms.RadioButton LengthRadioButton;
        private System.Windows.Forms.Button button1;
    }
}