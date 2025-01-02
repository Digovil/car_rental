using System;
using System.Data.SqlClient;
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
            UpdateRentalCounts(); // Llamada inicial para mostrar datos
            updateTimer.Interval = 60000; // Configura el intervalo a 1 minuto
            updateTimer.Tick += UpdateTimer_Tick; // Asegura la suscripción al evento Tick
            updateTimer.Start(); // Inicia el temporizador
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            UpdateRentalCounts(); // Actualiza los datos cada minuto
        }

        private void UpdateRentalCounts()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Consulta diaria
                    string dailyQuery = @"
                        SELECT COUNT(*) 
                        FROM ALQUILER 
                        WHERE CAST(FECHA AS DATE) = CAST(GETDATE() AS DATE)";

                    using (SqlCommand dailyCmd = new SqlCommand(dailyQuery, conn))
                    {
                        int dailyCount = (int)dailyCmd.ExecuteScalar();
                        dailyRentalsLabel.Text = dailyCount.ToString();
                    }

                    // Consulta mensual
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
            catch (Exception ex)
            {
                MessageBox.Show($"Error actualizando los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RentalTimeControl_Load(object sender, EventArgs e)
        {

        }
    }
}
