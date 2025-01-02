using FontAwesome.Sharp;

namespace car_rental.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Panel contentPanel;
        private FontAwesome.Sharp.IconButton rentalTimeBtn;
        private FontAwesome.Sharp.IconButton rentedCarsBtn;

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
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.rentalTimeBtn = new FontAwesome.Sharp.IconButton();
            this.rentedCarsBtn = new FontAwesome.Sharp.IconButton();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.sidebarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.sidebarPanel.Controls.Add(this.rentalTimeBtn);
            this.sidebarPanel.Controls.Add(this.rentedCarsBtn);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Margin = new System.Windows.Forms.Padding(2);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(180, 569);
            this.sidebarPanel.TabIndex = 1;
            this.sidebarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Load);
            // 
            // rentalTimeBtn
            // 
            this.rentalTimeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.rentalTimeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.rentalTimeBtn.FlatAppearance.BorderSize = 0;
            this.rentalTimeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rentalTimeBtn.Font = new System.Drawing.Font("Segoe UI", 9.7F, System.Drawing.FontStyle.Bold);
            this.rentalTimeBtn.ForeColor = System.Drawing.Color.White;
            this.rentalTimeBtn.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            this.rentalTimeBtn.IconColor = System.Drawing.Color.White;
            this.rentalTimeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rentalTimeBtn.IconSize = 32;
            this.rentalTimeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rentalTimeBtn.Location = new System.Drawing.Point(0, 67);
            this.rentalTimeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.rentalTimeBtn.Name = "rentalTimeBtn";
            this.rentalTimeBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.rentalTimeBtn.Size = new System.Drawing.Size(180, 67);
            this.rentalTimeBtn.TabIndex = 3;
            this.rentalTimeBtn.Text = "T. de Alquiler";
            this.rentalTimeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rentalTimeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rentalTimeBtn.UseVisualStyleBackColor = false;
            this.rentalTimeBtn.Click += new System.EventHandler(this.RentalTimeBtn_Click);
            // 
            // rentedCarsBtn
            // 
            this.rentedCarsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.rentedCarsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.rentedCarsBtn.FlatAppearance.BorderSize = 0;
            this.rentedCarsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rentedCarsBtn.Font = new System.Drawing.Font("Segoe UI", 9.7F, System.Drawing.FontStyle.Bold);
            this.rentedCarsBtn.ForeColor = System.Drawing.Color.White;
            this.rentedCarsBtn.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.rentedCarsBtn.IconColor = System.Drawing.Color.White;
            this.rentedCarsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rentedCarsBtn.IconSize = 32;
            this.rentedCarsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rentedCarsBtn.Location = new System.Drawing.Point(0, 0);
            this.rentedCarsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.rentedCarsBtn.Name = "rentedCarsBtn";
            this.rentedCarsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.rentedCarsBtn.Size = new System.Drawing.Size(180, 67);
            this.rentedCarsBtn.TabIndex = 2;
            this.rentedCarsBtn.Text = "Autos Rentados";
            this.rentedCarsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rentedCarsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rentedCarsBtn.UseVisualStyleBackColor = false;
            this.rentedCarsBtn.Click += new System.EventHandler(this.RentedCarsBtn_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.White;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(180, 0);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(720, 569);
            this.contentPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 569);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.sidebarPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA DE RENTA DE AUTOS";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.sidebarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}