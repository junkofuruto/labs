namespace EX1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RubelsTextBox = new System.Windows.Forms.TextBox();
            this.EuroTextBox = new System.Windows.Forms.TextBox();
            this.DollarsTextBox = new System.Windows.Forms.TextBox();
            this.DefaultCurrentRadioButton = new System.Windows.Forms.RadioButton();
            this.LoweredCurrentRadioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Рубли";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Доллары";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Евро";
            // 
            // RubelsTextBox
            // 
            this.RubelsTextBox.Location = new System.Drawing.Point(35, 12);
            this.RubelsTextBox.Name = "RubelsTextBox";
            this.RubelsTextBox.Size = new System.Drawing.Size(140, 20);
            this.RubelsTextBox.TabIndex = 3;
            // 
            // EuroTextBox
            // 
            this.EuroTextBox.Location = new System.Drawing.Point(35, 38);
            this.EuroTextBox.Name = "EuroTextBox";
            this.EuroTextBox.ReadOnly = true;
            this.EuroTextBox.Size = new System.Drawing.Size(140, 20);
            this.EuroTextBox.TabIndex = 4;
            // 
            // DollarsTextBox
            // 
            this.DollarsTextBox.Location = new System.Drawing.Point(35, 64);
            this.DollarsTextBox.Name = "DollarsTextBox";
            this.DollarsTextBox.ReadOnly = true;
            this.DollarsTextBox.Size = new System.Drawing.Size(140, 20);
            this.DollarsTextBox.TabIndex = 5;
            // 
            // DefaultCurrentRadioButton
            // 
            this.DefaultCurrentRadioButton.AutoSize = true;
            this.DefaultCurrentRadioButton.Checked = true;
            this.DefaultCurrentRadioButton.Location = new System.Drawing.Point(35, 90);
            this.DefaultCurrentRadioButton.Name = "DefaultCurrentRadioButton";
            this.DefaultCurrentRadioButton.Size = new System.Drawing.Size(72, 17);
            this.DefaultCurrentRadioButton.TabIndex = 7;
            this.DefaultCurrentRadioButton.TabStop = true;
            this.DefaultCurrentRadioButton.Text = "Обычный";
            this.DefaultCurrentRadioButton.UseVisualStyleBackColor = true;
            // 
            // LoweredCurrentRadioButton
            // 
            this.LoweredCurrentRadioButton.AutoSize = true;
            this.LoweredCurrentRadioButton.Location = new System.Drawing.Point(35, 113);
            this.LoweredCurrentRadioButton.Name = "LoweredCurrentRadioButton";
            this.LoweredCurrentRadioButton.Size = new System.Drawing.Size(75, 17);
            this.LoweredCurrentRadioButton.TabIndex = 8;
            this.LoweredCurrentRadioButton.Text = "Льготный";
            this.LoweredCurrentRadioButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LoweredCurrentRadioButton);
            this.Controls.Add(this.DefaultCurrentRadioButton);
            this.Controls.Add(this.DollarsTextBox);
            this.Controls.Add(this.EuroTextBox);
            this.Controls.Add(this.RubelsTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RubelsTextBox;
        private System.Windows.Forms.TextBox EuroTextBox;
        private System.Windows.Forms.TextBox DollarsTextBox;
        private System.Windows.Forms.RadioButton DefaultCurrentRadioButton;
        private System.Windows.Forms.RadioButton LoweredCurrentRadioButton;
        private System.Windows.Forms.Button button1;
    }
}