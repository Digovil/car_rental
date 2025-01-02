namespace car_rental.Forms
{
    partial class RentalTimeControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel dailyRentalsCard;
        private System.Windows.Forms.Panel monthlyRentalsCard;
        private System.Windows.Forms.Label dailyRentalsLabel;
        private System.Windows.Forms.Label monthlyRentalsLabel;
        private System.Windows.Forms.Timer updateTimer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dailyRentalsCard = new System.Windows.Forms.Panel();
            this.dailyRentalsLabel = new System.Windows.Forms.Label();
            this.monthlyRentalsCard = new System.Windows.Forms.Panel();
            this.monthlyRentalsLabel = new System.Windows.Forms.Label();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.labelMonthly = new System.Windows.Forms.Label();
            this.labelDaily = new System.Windows.Forms.Label();
            this.dailyRentalsCard.SuspendLayout();
            this.monthlyRentalsCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // dailyRentalsCard
            // 
            this.dailyRentalsCard.BackColor = System.Drawing.Color.White;
            this.dailyRentalsCard.Controls.Add(this.dailyRentalsLabel);
            this.dailyRentalsCard.Location = new System.Drawing.Point(8, 8);
            this.dailyRentalsCard.Margin = new System.Windows.Forms.Padding(2);
            this.dailyRentalsCard.Name = "dailyRentalsCard";
            this.dailyRentalsCard.Size = new System.Drawing.Size(150, 122);
            this.dailyRentalsCard.TabIndex = 0;
            this.dailyRentalsCard.Paint += new System.Windows.Forms.PaintEventHandler(this.dailyRentalsCard_Paint);
            // 
            // dailyRentalsLabel
            // 
            this.dailyRentalsLabel.AutoSize = true;
            this.dailyRentalsLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.dailyRentalsLabel.Location = new System.Drawing.Point(15, 41);
            this.dailyRentalsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dailyRentalsLabel.Name = "dailyRentalsLabel";
            this.dailyRentalsLabel.Size = new System.Drawing.Size(35, 37);
            this.dailyRentalsLabel.TabIndex = 0;
            this.dailyRentalsLabel.Text = "0";
            // 
            // monthlyRentalsCard
            // 
            this.monthlyRentalsCard.BackColor = System.Drawing.Color.White;
            this.monthlyRentalsCard.Controls.Add(this.monthlyRentalsLabel);
            this.monthlyRentalsCard.Location = new System.Drawing.Point(172, 8);
            this.monthlyRentalsCard.Margin = new System.Windows.Forms.Padding(2);
            this.monthlyRentalsCard.Name = "monthlyRentalsCard";
            this.monthlyRentalsCard.Size = new System.Drawing.Size(150, 122);
            this.monthlyRentalsCard.TabIndex = 1;
            this.monthlyRentalsCard.Paint += new System.Windows.Forms.PaintEventHandler(this.monthlyRentalsCard_Paint);
            // 
            // monthlyRentalsLabel
            // 
            this.monthlyRentalsLabel.AutoSize = true;
            this.monthlyRentalsLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.monthlyRentalsLabel.Location = new System.Drawing.Point(15, 41);
            this.monthlyRentalsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.monthlyRentalsLabel.Name = "monthlyRentalsLabel";
            this.monthlyRentalsLabel.Size = new System.Drawing.Size(35, 37);
            this.monthlyRentalsLabel.TabIndex = 0;
            this.monthlyRentalsLabel.Text = "0";
            // 
            // updateTimer
            // 
            this.updateTimer.Interval = 5000;
            this.updateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // labelMonthly
            // 
            this.labelMonthly.AutoSize = true;
            this.labelMonthly.Location = new System.Drawing.Point(191, 132);
            this.labelMonthly.Name = "labelMonthly";
            this.labelMonthly.Size = new System.Drawing.Size(105, 13);
            this.labelMonthly.TabIndex = 2;
            this.labelMonthly.Text = "Alquileres mensuales";
            this.labelMonthly.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelDaily
            // 
            this.labelDaily.AutoSize = true;
            this.labelDaily.Location = new System.Drawing.Point(38, 132);
            this.labelDaily.Name = "labelDaily";
            this.labelDaily.Size = new System.Drawing.Size(85, 13);
            this.labelDaily.TabIndex = 3;
            this.labelDaily.Text = "Alquileres diarios";
            // 
            // RentalTimeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelDaily);
            this.Controls.Add(this.labelMonthly);
            this.Controls.Add(this.dailyRentalsCard);
            this.Controls.Add(this.monthlyRentalsCard);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RentalTimeControl";
            this.Size = new System.Drawing.Size(338, 162);
            this.dailyRentalsCard.ResumeLayout(false);
            this.dailyRentalsCard.PerformLayout();
            this.monthlyRentalsCard.ResumeLayout(false);
            this.monthlyRentalsCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelMonthly;
        private System.Windows.Forms.Label labelDaily;
    }
}
