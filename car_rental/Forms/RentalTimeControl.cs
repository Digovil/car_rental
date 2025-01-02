using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace car_rental.Forms
{
    public partial class RentalTimeControl : UserControl
    {
        private string connectionString = "Server=DESKTOP-CBA25NH;Database=CovisionDB;Trusted_Connection=True;";

        public RentalTimeControl()
        {
            InitializeComponent();
            StartTimer();
        }

        private void StartTimer()
        {
            UpdateRentalCounts();
            updateTimer.Start();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            UpdateRentalCounts();
        }

        private void UpdateRentalCounts()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string dailyQuery = @"
                    SELECT COUNT(*) 
                    FROM ALQUILER 
                    WHERE CAST(FECHA AS DATE) = CAST(GETDATE() AS DATE)";

                using (SqlCommand dailyCmd = new SqlCommand(dailyQuery, conn))
                {
                    int dailyCount = (int)dailyCmd.ExecuteScalar();
                    dailyRentalsLabel.Text = dailyCount.ToString();
                }

                string monthlyQuery = @"
                    SELECT COUNT(*) 
                    FROM ALQUILER 
                    WHERE MONTH(FECHA) = MONTH(GETDATE()) 
                    AND YEAR(FECHA) = YEAR(GETDATE())";

                using (SqlCommand monthlyCmd = new SqlCommand(monthlyQuery, conn))
                {
                    int monthlyCount = (int)monthlyCmd.ExecuteScalar();
                    monthlyRentalsLabel.Text = monthlyCount.ToString();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void monthlyRentalsCard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dailyRentalsCard_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
