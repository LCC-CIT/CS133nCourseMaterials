namespace GuessMyNumberAI
{
    partial class GuessMyNumberForm
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
            this.compPlayButton = new System.Windows.Forms.Button();
            this.humanGuessTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.humanGuessButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.compAnswerLabel = new System.Windows.Forms.Label();
            this.humanPlayButton = new System.Windows.Forms.Button();
            this.humanGuessCountLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // compPlayButton
            // 
            this.compPlayButton.Location = new System.Drawing.Point(79, 255);
            this.compPlayButton.Name = "compPlayButton";
            this.compPlayButton.Size = new System.Drawing.Size(75, 23);
            this.compPlayButton.TabIndex = 0;
            this.compPlayButton.Text = "Play!";
            this.compPlayButton.UseVisualStyleBackColor = true;
            this.compPlayButton.Click += new System.EventHandler(this.compPlayButton_Click);
            // 
            // humanGuessTextBox
            // 
            this.humanGuessTextBox.Enabled = false;
            this.humanGuessTextBox.Location = new System.Drawing.Point(16, 116);
            this.humanGuessTextBox.Name = "humanGuessTextBox";
            this.humanGuessTextBox.Size = new System.Drawing.Size(79, 20);
            this.humanGuessTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Human does the guessing";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enter a number from 1 to 100:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Computer does the guessing";
            // 
            // humanGuessButton
            // 
            this.humanGuessButton.Location = new System.Drawing.Point(135, 116);
            this.humanGuessButton.Name = "humanGuessButton";
            this.humanGuessButton.Size = new System.Drawing.Size(79, 23);
            this.humanGuessButton.TabIndex = 8;
            this.humanGuessButton.Text = "Enter Guess";
            this.humanGuessButton.UseVisualStyleBackColor = true;
            this.humanGuessButton.Click += new System.EventHandler(this.humanGuessButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(79, 367);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Computer\'s answer:";
            // 
            // compAnswerLabel
            // 
            this.compAnswerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.compAnswerLabel.Location = new System.Drawing.Point(18, 173);
            this.compAnswerLabel.Name = "compAnswerLabel";
            this.compAnswerLabel.Size = new System.Drawing.Size(85, 23);
            this.compAnswerLabel.TabIndex = 13;
            // 
            // humanPlayButton
            // 
            this.humanPlayButton.Location = new System.Drawing.Point(79, 42);
            this.humanPlayButton.Name = "humanPlayButton";
            this.humanPlayButton.Size = new System.Drawing.Size(75, 23);
            this.humanPlayButton.TabIndex = 14;
            this.humanPlayButton.Text = "Play!";
            this.humanPlayButton.UseVisualStyleBackColor = true;
            this.humanPlayButton.Click += new System.EventHandler(this.humanPlayButton_Click);
            // 
            // humanGuessCountLabel
            // 
            this.humanGuessCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.humanGuessCountLabel.Location = new System.Drawing.Point(135, 173);
            this.humanGuessCountLabel.Name = "humanGuessCountLabel";
            this.humanGuessCountLabel.Size = new System.Drawing.Size(85, 23);
            this.humanGuessCountLabel.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Guess count:";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(79, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 23);
            this.label7.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Guess count:";
            // 
            // GuessMyNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 402);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.humanGuessCountLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.humanPlayButton);
            this.Controls.Add(this.compAnswerLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.humanGuessButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.humanGuessTextBox);
            this.Controls.Add(this.compPlayButton);
            this.Name = "GuessMyNumberForm";
            this.Text = "Guess My Number Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button compPlayButton;
        private System.Windows.Forms.TextBox humanGuessTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button humanGuessButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label compAnswerLabel;
        private System.Windows.Forms.Button humanPlayButton;
        private System.Windows.Forms.Label humanGuessCountLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

