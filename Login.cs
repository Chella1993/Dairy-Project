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
    public partial class Login : Form
    {
        static String connString = @"Data Source=dairyexchange.database.windows.net;Initial Catalog=dairyExchange;Persist Security Info=True;User ID=sqlAdmin;Password=***********";
        SqlConnection conn = new SqlConnection(connString);

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean credentialCheck = false;
            String email, password;

            email = txtUsername.Text;
            password = txtPassword.Text;

            if(email == "" || password == "")
            {
                credentialCheck = false;
            }
            else
            {
                credentialCheck = true;
            }




            if (credentialCheck)
            {
                try
                {
                    conn.Open();

                    String sql = "SELECT * FROM dbo.User WHERE UserType = 'Client' AND " +
                        " Username = '" + email + "'" + " AND " +
                        " Password = '" + password + "'";

                    SqlCommand command = new SqlCommand(sql, conn);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader == null)
                    {
                        MessageBox.Show("Invalid username or password.");
                        txtUsername.Clear();
                        txtPassword.Clear();
                        txtUsername.Focus();
                    }
                    else if (reader.GetValue(3).ToString() == "Client")
                    {
                        
                        //ProductCatalog catalog = new ProductCatalog();
                        //this.Hide();
                        //catalog.Show();
                    }
                    else if (reader.GetValue(3).ToString() == "Administrator")
                    {
                        ReportsDashboard reports = new ReportsDashboard();
                        reports.Show();
                        this.Hide();
                    }

                    conn.Close();

                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }


            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.White;
            btnLogin.ForeColor = Color.RoyalBlue;
        }

        private void btnClear_MouseHover(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.White;
            btnClear.ForeColor = Color.RoyalBlue;
        }
    }
}
