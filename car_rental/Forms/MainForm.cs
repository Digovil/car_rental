﻿using System;
using System.Windows.Forms;

namespace car_rental.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadRentedCarsView();
        }

        private void LoadRentedCarsView()
        {
            contentPanel.Controls.Clear();
            var rentedCarsControl = new RentedCarsControl
            {
                Dock = DockStyle.Fill
            };
            contentPanel.Controls.Add(rentedCarsControl);
        }

        private void LoadRentalTimeView()
        {
            contentPanel.Controls.Clear();
            var rentalTimeControl = new RentalTimeControl
            {
                Dock = DockStyle.Fill
            };
            contentPanel.Controls.Add(rentalTimeControl);
        }

        private void RentedCarsBtn_Click(object sender, EventArgs e)
        {
            LoadRentedCarsView();
        }

        private void RentalTimeBtn_Click(object sender, EventArgs e)
        {
            LoadRentalTimeView();
        }


    }
}
