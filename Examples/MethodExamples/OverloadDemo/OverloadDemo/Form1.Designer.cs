namespace OverloadDemo
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
            this.calcButton = new System.Windows.Forms.Button();
            this.input1TextBox = new System.Windows.Forms.TextBox();
            this.input2TextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(107, 85);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 0;
            this.calcButton.Text = "Calc";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // input1TextBox
            // 
            this.input1TextBox.Location = new System.Drawing.Point(33, 31);
            this.input1TextBox.Name = "input1TextBox";
            this.input1TextBox.Size = new System.Drawing.Size(100, 20);
            this.input1TextBox.TabIndex = 1;
            // 
            // input2TextBox
            // 
            this.input2TextBox.Location = new System.Drawing.Point(159, 31);
            this.input2TextBox.Name = "input2TextBox";
            this.input2TextBox.Size = new System.Drawing.Size(100, 20);
            this.input2TextBox.TabIndex = 2;
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultLabel.Location = new System.Drawing.Point(96, 168);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(100, 23);
            this.resultLabel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.input2TextBox);
            this.Controls.Add(this.input1TextBox);
            this.Controls.Add(this.calcButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.TextBox input1TextBox;
        private System.Windows.Forms.TextBox input2TextBox;
        private System.Windows.Forms.Label resultLabel;
    }
}

