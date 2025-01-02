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
            this.labelDaily = new System.Windows.Forms.Label();
            this.dailyRentalsLabel = new System.Windows.Forms.Label();
            this.monthlyRentalsCard = new System.Windows.Forms.Panel();
            this.labelMonthly = new System.Windows.Forms.Label();
            this.monthlyRentalsLabel = new System.Windows.Forms.Label();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dailyRentalsCard.SuspendLayout();
            this.monthlyRentalsCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // dailyRentalsCard
            // 
            this.dailyRentalsCard.BackColor = System.Drawing.Color.White;
            this.dailyRentalsCard.Controls.Add(this.labelDaily);
            this.dailyRentalsCard.Controls.Add(this.dailyRentalsLabel);
            this.dailyRentalsCard.Location = new System.Drawing.Point(9, 105);
            this.dailyRentalsCard.Margin = new System.Windows.Forms.Padding(2);
            this.dailyRentalsCard.Name = "dailyRentalsCard";
            this.dailyRentalsCard.Size = new System.Drawing.Size(187, 141);
            this.dailyRentalsCard.TabIndex = 0;
            // 
            // labelDaily
            // 
            this.labelDaily.AutoSize = true;
            this.labelDaily.Font = new System.Drawing.Font("Segoe UI", 9.7F, System.Drawing.FontStyle.Bold);
            this.labelDaily.Location = new System.Drawing.Point(22, 112);
            this.labelDaily.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDaily.Name = "labelDaily";
            this.labelDaily.Size = new System.Drawing.Size(116, 17);
            this.labelDaily.TabIndex = 3;
            this.labelDaily.Text = "Alquileres diarios";
            // 
            // dailyRentalsLabel
            // 
            this.dailyRentalsLabel.AutoSize = true;
            this.dailyRentalsLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.dailyRentalsLabel.Location = new System.Drawing.Point(18, 47);
            this.dailyRentalsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dailyRentalsLabel.Name = "dailyRentalsLabel";
            this.dailyRentalsLabel.Size = new System.Drawing.Size(35, 37);
            this.dailyRentalsLabel.TabIndex = 0;
            this.dailyRentalsLabel.Text = "0";
            // 
            // monthlyRentalsCard
            // 
            this.monthlyRentalsCard.BackColor = System.Drawing.Color.White;
            this.monthlyRentalsCard.Controls.Add(this.labelMonthly);
            this.monthlyRentalsCard.Controls.Add(this.monthlyRentalsLabel);
            this.monthlyRentalsCard.Location = new System.Drawing.Point(205, 105);
            this.monthlyRentalsCard.Margin = new System.Windows.Forms.Padding(2);
            this.monthlyRentalsCard.Name = "monthlyRentalsCard";
            this.monthlyRentalsCard.Size = new System.Drawing.Size(187, 141);
            this.monthlyRentalsCard.TabIndex = 1;
            // 
            // labelMonthly
            // 
            this.labelMonthly.AutoSize = true;
            this.labelMonthly.Font = new System.Drawing.Font("Segoe UI", 9.7F, System.Drawing.FontStyle.Bold);
            this.labelMonthly.Location = new System.Drawing.Point(22, 112);
            this.labelMonthly.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMonthly.Name = "labelMonthly";
            this.labelMonthly.Size = new System.Drawing.Size(139, 17);
            this.labelMonthly.TabIndex = 2;
            this.labelMonthly.Text = "Alquileres mensuales";
            // 
            // monthlyRentalsLabel
            // 
            this.monthlyRentalsLabel.AutoSize = true;
            this.monthlyRentalsLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.monthlyRentalsLabel.Location = new System.Drawing.Point(18, 47);
            this.monthlyRentalsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.monthlyRentalsLabel.Name = "monthlyRentalsLabel";
            this.monthlyRentalsLabel.Size = new System.Drawing.Size(35, 37);
            this.monthlyRentalsLabel.TabIndex = 0;
            this.monthlyRentalsLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "TIEMPO DE ALQUILER";
            // 
            // RentalTimeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(69)))), ((int)(((byte)(89)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dailyRentalsCard);
            this.Controls.Add(this.monthlyRentalsCard);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(69)))), ((int)(((byte)(89)))));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RentalTimeControl";
            this.Size = new System.Drawing.Size(761, 540);
            this.dailyRentalsCard.ResumeLayout(false);
            this.dailyRentalsCard.PerformLayout();
            this.monthlyRentalsCard.ResumeLayout(false);
            this.monthlyRentalsCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelMonthly;
        private System.Windows.Forms.Label labelDaily;
        private System.Windows.Forms.Label label1;
    }
}