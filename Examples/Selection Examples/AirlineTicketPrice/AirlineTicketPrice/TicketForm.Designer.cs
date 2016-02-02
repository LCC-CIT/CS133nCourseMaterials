namespace AirlineTicketPrice
{
    partial class TicketPriceForm
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
            this.departureUpDown = new System.Windows.Forms.NumericUpDown();
            this.returnUpDown = new System.Windows.Forms.NumericUpDown();
            this.ageUpDown = new System.Windows.Forms.NumericUpDown();
            this.priceLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.departureUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // departureUpDown
            // 
            this.departureUpDown.Location = new System.Drawing.Point(131, 59);
            this.departureUpDown.Name = "departureUpDown";
            this.departureUpDown.Size = new System.Drawing.Size(120, 20);
            this.departureUpDown.TabIndex = 0;
            this.departureUpDown.ValueChanged += new System.EventHandler(this.departureUpDown_ValueChanged);
            // 
            // returnUpDown
            // 
            this.returnUpDown.Location = new System.Drawing.Point(131, 110);
            this.returnUpDown.Name = "returnUpDown";
            this.returnUpDown.Size = new System.Drawing.Size(120, 20);
            this.returnUpDown.TabIndex = 1;
            this.returnUpDown.ValueChanged += new System.EventHandler(this.returnUpDown_ValueChanged);
            // 
            // ageUpDown
            // 
            this.ageUpDown.Location = new System.Drawing.Point(131, 154);
            this.ageUpDown.Name = "ageUpDown";
            this.ageUpDown.Size = new System.Drawing.Size(120, 20);
            this.ageUpDown.TabIndex = 2;
            this.ageUpDown.ValueChanged += new System.EventHandler(this.ageUpDown_ValueChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(121, 201);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(34, 13);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "$0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Days until departure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Days until return";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Age";
            // 
            // TicketPriceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.ageUpDown);
            this.Controls.Add(this.returnUpDown);
            this.Controls.Add(this.departureUpDown);
            this.Name = "TicketPriceForm";
            this.Text = "Lane Air Ticket Price Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.departureUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown departureUpDown;
        private System.Windows.Forms.NumericUpDown returnUpDown;
        private System.Windows.Forms.NumericUpDown ageUpDown;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

