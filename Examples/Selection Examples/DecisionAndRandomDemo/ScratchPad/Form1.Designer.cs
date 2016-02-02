namespace ScratchPad
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.executeButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.creditRadioButton = new System.Windows.Forms.RadioButton();
            this.cashRadioButton = new System.Windows.Forms.RadioButton();
            this.regularRadioButton = new System.Windows.Forms.RadioButton();
            this.plusRadioButton = new System.Windows.Forms.RadioButton();
            this.premiumRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(69, 41);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(100, 20);
            this.inputTextBox.TabIndex = 0;
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(69, 102);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(100, 23);
            this.executeButton.TabIndex = 1;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Location = new System.Drawing.Point(69, 169);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(187, 23);
            this.outputLabel.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cashRadioButton);
            this.groupBox1.Controls.Add(this.creditRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(314, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Method";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.premiumRadioButton);
            this.groupBox2.Controls.Add(this.plusRadioButton);
            this.groupBox2.Controls.Add(this.regularRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(323, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 120);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fuel Grade";
            // 
            // creditRadioButton
            // 
            this.creditRadioButton.AutoSize = true;
            this.creditRadioButton.Location = new System.Drawing.Point(29, 34);
            this.creditRadioButton.Name = "creditRadioButton";
            this.creditRadioButton.Size = new System.Drawing.Size(80, 17);
            this.creditRadioButton.TabIndex = 0;
            this.creditRadioButton.TabStop = true;
            this.creditRadioButton.Text = " Credit Card";
            this.creditRadioButton.UseVisualStyleBackColor = true;
            // 
            // cashRadioButton
            // 
            this.cashRadioButton.AutoSize = true;
            this.cashRadioButton.Location = new System.Drawing.Point(29, 68);
            this.cashRadioButton.Name = "cashRadioButton";
            this.cashRadioButton.Size = new System.Drawing.Size(49, 17);
            this.cashRadioButton.TabIndex = 1;
            this.cashRadioButton.TabStop = true;
            this.cashRadioButton.Text = "Cash";
            this.cashRadioButton.UseVisualStyleBackColor = true;
            // 
            // regularRadioButton
            // 
            this.regularRadioButton.AutoSize = true;
            this.regularRadioButton.Location = new System.Drawing.Point(20, 35);
            this.regularRadioButton.Name = "regularRadioButton";
            this.regularRadioButton.Size = new System.Drawing.Size(62, 17);
            this.regularRadioButton.TabIndex = 0;
            this.regularRadioButton.TabStop = true;
            this.regularRadioButton.Text = "Regular";
            this.regularRadioButton.UseVisualStyleBackColor = true;
            // 
            // plusRadioButton
            // 
            this.plusRadioButton.AutoSize = true;
            this.plusRadioButton.Location = new System.Drawing.Point(20, 59);
            this.plusRadioButton.Name = "plusRadioButton";
            this.plusRadioButton.Size = new System.Drawing.Size(45, 17);
            this.plusRadioButton.TabIndex = 1;
            this.plusRadioButton.TabStop = true;
            this.plusRadioButton.Text = "Plus";
            this.plusRadioButton.UseVisualStyleBackColor = true;
            // 
            // premiumRadioButton
            // 
            this.premiumRadioButton.AutoSize = true;
            this.premiumRadioButton.Location = new System.Drawing.Point(20, 83);
            this.premiumRadioButton.Name = "premiumRadioButton";
            this.premiumRadioButton.Size = new System.Drawing.Size(65, 17);
            this.premiumRadioButton.TabIndex = 2;
            this.premiumRadioButton.TabStop = true;
            this.premiumRadioButton.Text = "Premium";
            this.premiumRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 276);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.inputTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton cashRadioButton;
        private System.Windows.Forms.RadioButton creditRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton premiumRadioButton;
        private System.Windows.Forms.RadioButton plusRadioButton;
        private System.Windows.Forms.RadioButton regularRadioButton;
    }
}

