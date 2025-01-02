using System;
using System.Drawing;
using System.Windows.Forms;
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
        private PictureBox avatarPictureBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void AvatarPictureBox_Paint(object sender, PaintEventArgs e)
        {
            var avatarPictureBox = sender as PictureBox;
            if (avatarPictureBox != null)
            {
                using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    path.AddEllipse(0, 0, avatarPictureBox.Width - 1, avatarPictureBox.Height - 1);
                    avatarPictureBox.Region = new Region(path);
                }
            }
        }


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.rentalTimeBtn = new FontAwesome.Sharp.IconButton();
            this.rentedCarsBtn = new FontAwesome.Sharp.IconButton();
            this.avatarPictureBox = new System.Windows.Forms.PictureBox();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.sidebarPanel.Controls.Add(this.rentalTimeBtn);
            this.sidebarPanel.Controls.Add(this.rentedCarsBtn);
            this.sidebarPanel.Controls.Add(this.avatarPictureBox);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Margin = new System.Windows.Forms.Padding(2);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(199, 569);
            this.sidebarPanel.TabIndex = 1;
            // 
            // rentalTimeBtn
            // 
            this.rentalTimeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.rentalTimeBtn.FlatAppearance.BorderSize = 0;
            this.rentalTimeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rentalTimeBtn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.rentalTimeBtn.ForeColor = System.Drawing.Color.White;
            this.rentalTimeBtn.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            this.rentalTimeBtn.IconColor = System.Drawing.Color.White;
            this.rentalTimeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rentalTimeBtn.IconSize = 32;
            this.rentalTimeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rentalTimeBtn.Location = new System.Drawing.Point(0, 207);
            this.rentalTimeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.rentalTimeBtn.Name = "rentalTimeBtn";
            this.rentalTimeBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.rentalTimeBtn.Size = new System.Drawing.Size(195, 67);
            this.rentalTimeBtn.TabIndex = 3;
            this.rentalTimeBtn.Text = "TIEMPO DE ALQUILER";
            this.rentalTimeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rentalTimeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rentalTimeBtn.UseVisualStyleBackColor = false;
            this.rentalTimeBtn.Click += new System.EventHandler(this.RentalTimeBtn_Click);
            // 
            // rentedCarsBtn
            // 
            this.rentedCarsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.rentedCarsBtn.FlatAppearance.BorderSize = 0;
            this.rentedCarsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rentedCarsBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentedCarsBtn.ForeColor = System.Drawing.Color.White;
            this.rentedCarsBtn.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.rentedCarsBtn.IconColor = System.Drawing.Color.White;
            this.rentedCarsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rentedCarsBtn.IconSize = 32;
            this.rentedCarsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rentedCarsBtn.Location = new System.Drawing.Point(0, 140);
            this.rentedCarsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.rentedCarsBtn.Name = "rentedCarsBtn";
            this.rentedCarsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.rentedCarsBtn.Size = new System.Drawing.Size(195, 67);
            this.rentedCarsBtn.TabIndex = 2;
            this.rentedCarsBtn.Text = "AUTOS RENTADOS";
            this.rentedCarsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rentedCarsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rentedCarsBtn.UseVisualStyleBackColor = false;
            this.rentedCarsBtn.Click += new System.EventHandler(this.RentedCarsBtn_Click);
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("avatarPictureBox.Image")));
            this.avatarPictureBox.Location = new System.Drawing.Point(35, 20);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.Size = new System.Drawing.Size(100, 100);
            this.avatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatarPictureBox.TabIndex = 4;
            this.avatarPictureBox.TabStop = false;
            this.avatarPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.AvatarPictureBox_Paint);
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.White;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(199, 0);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(701, 569);
            this.contentPanel.TabIndex = 0;
            this.contentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.contentPanel_Paint_1);
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
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
