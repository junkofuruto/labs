namespace EX3
{
    partial class ColorForm
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
            this.RedNumbericUpDown = new System.Windows.Forms.NumericUpDown();
            this.GreenRedNumbericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BlueNumbericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FullFormVideoModeRadioButton = new System.Windows.Forms.RadioButton();
            this.TopFormVideoModeRadioButton = new System.Windows.Forms.RadioButton();
            this.BottomFormVideoModeRadioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RedNumbericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenRedNumbericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueNumbericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // RedNumbericUpDown
            // 
            this.RedNumbericUpDown.Location = new System.Drawing.Point(32, 12);
            this.RedNumbericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RedNumbericUpDown.Name = "RedNumbericUpDown";
            this.RedNumbericUpDown.Size = new System.Drawing.Size(120, 20);
            this.RedNumbericUpDown.TabIndex = 0;
            this.RedNumbericUpDown.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // GreenRedNumbericUpDown
            // 
            this.GreenRedNumbericUpDown.Location = new System.Drawing.Point(32, 38);
            this.GreenRedNumbericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.GreenRedNumbericUpDown.Name = "GreenRedNumbericUpDown";
            this.GreenRedNumbericUpDown.Size = new System.Drawing.Size(120, 20);
            this.GreenRedNumbericUpDown.TabIndex = 1;
            this.GreenRedNumbericUpDown.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // BlueNumbericUpDown
            // 
            this.BlueNumbericUpDown.Location = new System.Drawing.Point(32, 64);
            this.BlueNumbericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BlueNumbericUpDown.Name = "BlueNumbericUpDown";
            this.BlueNumbericUpDown.Size = new System.Drawing.Size(120, 20);
            this.BlueNumbericUpDown.TabIndex = 2;
            this.BlueNumbericUpDown.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "R:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "G:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "B:";
            // 
            // FullFormVideoModeRadioButton
            // 
            this.FullFormVideoModeRadioButton.AutoSize = true;
            this.FullFormVideoModeRadioButton.Checked = true;
            this.FullFormVideoModeRadioButton.Location = new System.Drawing.Point(176, 12);
            this.FullFormVideoModeRadioButton.Name = "FullFormVideoModeRadioButton";
            this.FullFormVideoModeRadioButton.Size = new System.Drawing.Size(84, 17);
            this.FullFormVideoModeRadioButton.TabIndex = 6;
            this.FullFormVideoModeRadioButton.TabStop = true;
            this.FullFormVideoModeRadioButton.Text = "Целое окно";
            this.FullFormVideoModeRadioButton.UseVisualStyleBackColor = true;
            // 
            // TopFormVideoModeRadioButton
            // 
            this.TopFormVideoModeRadioButton.AutoSize = true;
            this.TopFormVideoModeRadioButton.Location = new System.Drawing.Point(176, 38);
            this.TopFormVideoModeRadioButton.Name = "TopFormVideoModeRadioButton";
            this.TopFormVideoModeRadioButton.Size = new System.Drawing.Size(118, 17);
            this.TopFormVideoModeRadioButton.TabIndex = 7;
            this.TopFormVideoModeRadioButton.Text = "Верхняя половина";
            this.TopFormVideoModeRadioButton.UseVisualStyleBackColor = true;
            // 
            // BottomFormVideoModeRadioButton
            // 
            this.BottomFormVideoModeRadioButton.AutoSize = true;
            this.BottomFormVideoModeRadioButton.Location = new System.Drawing.Point(176, 64);
            this.BottomFormVideoModeRadioButton.Name = "BottomFormVideoModeRadioButton";
            this.BottomFormVideoModeRadioButton.Size = new System.Drawing.Size(116, 17);
            this.BottomFormVideoModeRadioButton.TabIndex = 8;
            this.BottomFormVideoModeRadioButton.Text = "Нижняя половина";
            this.BottomFormVideoModeRadioButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 142);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BottomFormVideoModeRadioButton);
            this.Controls.Add(this.TopFormVideoModeRadioButton);
            this.Controls.Add(this.FullFormVideoModeRadioButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BlueNumbericUpDown);
            this.Controls.Add(this.GreenRedNumbericUpDown);
            this.Controls.Add(this.RedNumbericUpDown);
            this.Name = "ColorForm";
            this.Text = "ColorForm";
            ((System.ComponentModel.ISupportInitialize)(this.RedNumbericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenRedNumbericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueNumbericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown RedNumbericUpDown;
        private System.Windows.Forms.NumericUpDown GreenRedNumbericUpDown;
        private System.Windows.Forms.NumericUpDown BlueNumbericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton FullFormVideoModeRadioButton;
        private System.Windows.Forms.RadioButton TopFormVideoModeRadioButton;
        private System.Windows.Forms.RadioButton BottomFormVideoModeRadioButton;
        private System.Windows.Forms.Button button1;
    }
}