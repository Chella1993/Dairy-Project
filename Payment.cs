using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace group9cmpg
{
    public partial class Payment : Form
    {

        static String connString = @"Data Source=dairyexchange.database.windows.net;Initial Catalog=dairyExchange;Persist Security Info=True;User ID=sqlAdmin;Password=***********";
        SqlConnection conn = new SqlConnection(connString);
        public Payment()
        {
            InitializeComponent();
        }


        private void btnPayment_Click(object sender, EventArgs e)
        {
            float paymentAmount = 0;
            String paymentMethod;
            int counter = 0;

            try
            {
                conn.Open();

                String sql = "";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    counter = int.Parse(reader.GetValue(0).ToString()) + 1;
                }

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            paymentMethod = cmbMethod.Text;
            paymentAmount = float.Parse(txtAmount.Text);

            DateTime date = new DateTime();
            date = dtpPaymentDate.Value;

            try
            {
                conn.Open();

                String sql = "INSERT INTO dbo.Payment (PaymentID, OrderID, PaymentAmount, PaymentDate, PaymentMethod) " +
                                "values( )";
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();

                command = new SqlCommand(sql, conn);

                adapter.InsertCommand = new SqlCommand(sql, conn);
                adapter.InsertCommand.ExecuteNonQuery();

                conn.Close();
            }
            catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            //Display the payment summary from the SalesOrder Form
        }
    }
}
