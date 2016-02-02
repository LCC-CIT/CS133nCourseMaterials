namespace BoolDemo
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
            this.input1TextBox = new System.Windows.Forms.TextBox();
            this.input2TextBox = new System.Windows.Forms.TextBox();
            this.doSomethingButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input1TextBox
            // 
            this.input1TextBox.Location = new System.Drawing.Point(13, 35);
            this.input1TextBox.Name = "input1TextBox";
            this.input1TextBox.Size = new System.Drawing.Size(100, 20);
            this.input1TextBox.TabIndex = 0;
            // 
            // input2TextBox
            // 
            this.input2TextBox.Location = new System.Drawing.Point(13, 78);
            this.input2TextBox.Name = "input2TextBox";
            this.input2TextBox.Size = new System.Drawing.Size(100, 20);
            this.input2TextBox.TabIndex = 1;
            // 
            // doSomethingButton
            // 
            this.doSomethingButton.Location = new System.Drawing.Point(13, 130);
            this.doSomethingButton.Name = "doSomethingButton";
            this.doSomethingButton.Size = new System.Drawing.Size(100, 23);
            this.doSomethingButton.TabIndex = 2;
            this.doSomethingButton.Text = "Do Something";
            this.doSomethingButton.UseVisualStyleBackColor = true;
            this.doSomethingButton.Click += new System.EventHandler(this.doSomethingButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Location = new System.Drawing.Point(13, 178);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(167, 23);
            this.outputLabel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 262);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.doSomethingButton);
            this.Controls.Add(this.input2TextBox);
            this.Controls.Add(this.input1TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input1TextBox;
        private System.Windows.Forms.TextBox input2TextBox;
        private System.Windows.Forms.Button doSomethingButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

