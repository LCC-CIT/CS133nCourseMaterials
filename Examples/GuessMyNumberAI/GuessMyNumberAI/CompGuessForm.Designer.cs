namespace GuessMyNumberAI
{
    partial class CompGuessForm
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
            this.compGuessLabel = new System.Windows.Forms.Label();
            this.tooLowButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.tooHighButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // compGuessLabel
            // 
            this.compGuessLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.compGuessLabel.Location = new System.Drawing.Point(80, 31);
            this.compGuessLabel.Name = "compGuessLabel";
            this.compGuessLabel.Size = new System.Drawing.Size(139, 60);
            this.compGuessLabel.TabIndex = 0;
            // 
            // tooLowButton
            // 
            this.tooLowButton.Location = new System.Drawing.Point(12, 123);
            this.tooLowButton.Name = "tooLowButton";
            this.tooLowButton.Size = new System.Drawing.Size(75, 23);
            this.tooLowButton.TabIndex = 1;
            this.tooLowButton.Text = "Too Low";
            this.tooLowButton.UseVisualStyleBackColor = true;
            this.tooLowButton.Click += new System.EventHandler(this.tooLowButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(105, 123);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(75, 23);
            this.rightButton.TabIndex = 2;
            this.rightButton.Text = "Right On!";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // tooHighButton
            // 
            this.tooHighButton.Location = new System.Drawing.Point(197, 123);
            this.tooHighButton.Name = "tooHighButton";
            this.tooHighButton.Size = new System.Drawing.Size(75, 23);
            this.tooHighButton.TabIndex = 3;
            this.tooHighButton.Text = "Too High";
            this.tooHighButton.UseVisualStyleBackColor = true;
            this.tooHighButton.Click += new System.EventHandler(this.tooHighButton_Click);
            // 
            // CompGuessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 174);
            this.Controls.Add(this.tooHighButton);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.tooLowButton);
            this.Controls.Add(this.compGuessLabel);
            this.Name = "CompGuessForm";
            this.Text = "CompGuessForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label compGuessLabel;
        private System.Windows.Forms.Button tooLowButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button tooHighButton;
    }
}