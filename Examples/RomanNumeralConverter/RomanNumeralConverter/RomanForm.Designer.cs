namespace RomanNumeralConverter
{
    partial class RomanForm
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
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.toDecimalButton = new System.Windows.Forms.Button();
            this.toRomanButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(46, 39);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(100, 22);
            this.inputTextBox.TabIndex = 0;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(185, 39);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(100, 22);
            this.outputTextBox.TabIndex = 1;
            // 
            // toDecimalButton
            // 
            this.toDecimalButton.Location = new System.Drawing.Point(185, 80);
            this.toDecimalButton.Name = "toDecimalButton";
            this.toDecimalButton.Size = new System.Drawing.Size(100, 23);
            this.toDecimalButton.TabIndex = 2;
            this.toDecimalButton.Text = "to Decimal";
            this.toDecimalButton.UseVisualStyleBackColor = true;
            this.toDecimalButton.Click += new System.EventHandler(this.toDecimalButton_Click);
            // 
            // toRomanButton
            // 
            this.toRomanButton.Location = new System.Drawing.Point(50, 80);
            this.toRomanButton.Name = "toRomanButton";
            this.toRomanButton.Size = new System.Drawing.Size(96, 23);
            this.toRomanButton.TabIndex = 3;
            this.toRomanButton.Text = "To Roman";
            this.toRomanButton.UseVisualStyleBackColor = true;
            this.toRomanButton.Click += new System.EventHandler(this.toRomanButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output";
            // 
            // RomanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 127);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toRomanButton);
            this.Controls.Add(this.toDecimalButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Name = "RomanForm";
            this.Text = "Roman Numeral Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button toDecimalButton;
        private System.Windows.Forms.Button toRomanButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

