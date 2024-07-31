using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace group9cmpg
{
    public partial class Return : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=dairyexchange.database.windows.net;Initial Catalog=dairyExchange;Persist Security Info=True;User ID=sqlAdmin;Password=r00tmeister101!");
        SqlDataAdapter adapter;
        DataSet dataset;

        public Return()
        {
            InitializeComponent();
        }

        private void btnLogReturn_Click(object sender, EventArgs e)
        {
            string orderID = txtBoxOrderID.Text;
            string returnStatus = "Return Logged";
            string returnReason = cBReturnReason.SelectedIndex.ToString();
            DateTime returnDate = calenderReturnDate.SelectionStart;

            lblReturnStatus.Text = "Return Logged";
            lblDisclaimer.Text = "All returns must be postmarked within 5 days of the purchase date. " + "\n" +
                                 "All returned items must be in an unused condition, with original packaging." + "\n" +
                                 "No returns accepted for customer ordering errors";

            try
            {
                conn.Open();
                string insertQuery = @"INSERT INTO [Return] (returnDate, returnReason, returnStatus)
                                     VALUES (@ReturnDate, @ReturnReason, @ReturnStatus)";

                using (SqlCommand sqlCommand = new SqlCommand(insertQuery, conn))
                {
                    // Provide values for the parameters
                   // sqlCommand.Parameters.AddWithValue("@OrderID", orderID); // Assuming orderID is a variable with the OrderID value
                    sqlCommand.Parameters.AddWithValue("@ReturnDate", returnDate); // Assuming returnDate is a variable with the return date
                    sqlCommand.Parameters.AddWithValue("@ReturnReason", returnReason); // Assuming returnReason is a variable with the return reason
                    sqlCommand.Parameters.AddWithValue("@ReturnStatus", returnStatus); // Assuming returnStatus is a variable with the return status

                    // Execute the SQL INSERT operation
                    int rowsAffected = sqlCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Query logged successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No rows were inserted.");
                    }
                }
}
catch (SqlException error)
{
    MessageBox.Show("Error: " + error.Message);
}

}

        private void btnRetry_Click(object sender, EventArgs e)
        {
            txtBoxOrderID.Text = "";
            cBReturnReason.Items.Clear();
            DateTime currentDate = DateTime.Today;
            lblReturnStatus.Text = "";
            lblDisclaimer.Text = "";
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void calenderReturnDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime currentDate = DateTime.Today;
        }

        private void txtBoxOrderID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Return_Load(object sender, EventArgs e)
        {

        }
    }
}
