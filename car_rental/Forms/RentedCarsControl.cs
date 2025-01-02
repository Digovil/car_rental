using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace car_rental.Forms
{
    public partial class RentedCarsControl : UserControl
    {
        private string connectionString = "Server=DESKTOP-CBA25NH;Database=CovisionDB;Trusted_Connection=True;";

        public RentedCarsControl()
        {
            InitializeComponent();
        }

        private void RentedCarsControl_Load(object sender, EventArgs e)
        {
            SearchButton_Click(sender, e);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                                SELECT 
                                    C.CEDULA, 
                                    C.NOMBRE, 
                                    A.FECHA AS 'FECHA ALQUILER', 
                                    CAST(A.TIEMPO AS VARCHAR) + ' ' + CASE WHEN A.TIEMPO = 1 THEN 'día' ELSE 'días' END AS 'TIEMPO ALQUILADO', 
                                    A.SALDO, 
                                    CA.PLACA, 
                                    CA.MARCA
                                FROM ALQUILER A
                                JOIN CLIENTE C ON A.ID_CLIENTE = C.ID_CLIENTE
                                JOIN CARRO CA ON A.ID_CARRO = CA.ID_CARRO
                                WHERE A.FECHA BETWEEN @StartDate AND @EndDate";


                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StartDate", startDatePicker.Value.Date);
                cmd.Parameters.AddWithValue("@EndDate", endDatePicker.Value.Date);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView.DataSource = dt;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
