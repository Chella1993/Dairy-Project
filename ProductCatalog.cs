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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace group9cmpg
{
    public partial class ProductCatalog : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=dairyexchange.database.windows.net;Initial Catalog=dairyExchange;Persist Security Info=True;User ID=sqlAdmin;Password=r00tmeister101!");
        SqlDataAdapter adapter;
        DataSet dataset;

        public ProductCatalog()
        {
            InitializeComponent();
        }

        private void ProductCatalog_Load(object sender, EventArgs e)
        {
            //Display entire table upon opening
            try
            {
                conn.Open();//Open connection
                SqlCommand sqlcommand = new SqlCommand(@"SELECT * FROM Product", conn);//select all from table
                adapter = new SqlDataAdapter();
                dataset = new DataSet();
                adapter.SelectCommand = sqlcommand;
                adapter.Fill(dataset, "Product"); // Adapter fill the dataset with specified table
                dataGridView1.DataSource = dataset;//display
                dataGridView1.DataMember = "Product";
                conn.Close();//close connecion
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);//error message
            }
            //Fill combo box ProductPrice
            try
            {
                conn.Open();
                SqlCommand sqlcommand = new SqlCommand(@"SELECT DISTINCT ProductPrice FROM Product", conn);
                adapter = new SqlDataAdapter();
                dataset = new DataSet();
                adapter.SelectCommand = sqlcommand;
                adapter.Fill(dataset, "Product");
                cBPrice.DisplayMember = "ProductPrice"; //add things to combo box 
                cBPrice.ValueMember = "ProductPrice"; //Value to be returned
                cBPrice.DataSource = dataset.Tables["Product"]; //Table in the dataset to use
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            //Fill combo box ProductStock
            try
            {
                conn.Open();
                SqlCommand sqlcommand = new SqlCommand(@"SELECT DISTINCT ProductStock FROM Product", conn);
                adapter = new SqlDataAdapter();
                dataset = new DataSet();
                adapter.SelectCommand = sqlcommand;
                adapter.Fill(dataset, "Product");
                cBStock.DisplayMember = "ProductStock"; //add things to combo box 
                cBStock.ValueMember = "ProductStock";
                cBStock.DataSource = dataset.Tables["Product"]; //Table in the dataset to use
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            //Fill combo box All Product Names
            try
            {
                conn.Open();
                SqlCommand sqlcommand = new SqlCommand(@"SELECT ProductName FROM Product", conn);
                adapter = new SqlDataAdapter();
                dataset = new DataSet();
                adapter.SelectCommand = sqlcommand;
                adapter.Fill(dataset, "Product");
                cBSearch.DisplayMember = "ProductName"; //add things to combo box 
                cBSearch.ValueMember = "ProductName";
                cBSearch.DataSource = dataset.Tables["Product"]; //Table in the dataset
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }            
        }

    

    private void btnReset_Click(object sender, EventArgs e)
        {
          
        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {
            string Name = txtBoxName.Text;
            try
            {
                conn.Open();
                SqlCommand sqlcommand = new SqlCommand(@"SELECT * FROM Product WHERE ProductName LIKE '%' + @Name", conn);
                sqlcommand.Parameters.AddWithValue("@Name", Name);
                adapter = new SqlDataAdapter();
                dataset = new DataSet();
                adapter.SelectCommand = sqlcommand;
                adapter.Fill(dataset, "Product");
                dataGridView1.DataSource = dataset;
                dataGridView1.DataMember = "Product";
                conn.Close(); // Closing connection
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message); // Error message
            }



        }

        private void cBPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void cBSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item from the ComboBox
            string selectedProduct = cBSearch.SelectedValue.ToString();

           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Search according to price, stock and textbox
            string Name = txtBoxName.Text;
            try
            {
                conn.Open();
                SqlCommand sqlcommand = new SqlCommand(@"SELECT * FROM Product WHERE ProductName LIKE '%' + @Name + '%' OR  ProductPrice = @Price OR  ProductStock = @Stock", conn); 
                sqlcommand.Parameters.AddWithValue("@Stock", cBStock.SelectedValue);
                sqlcommand.Parameters.AddWithValue("@Name", Name);
                sqlcommand.Parameters.AddWithValue("@Price", cBPrice.SelectedValue);
                adapter = new SqlDataAdapter();
                dataset = new DataSet();
                adapter.SelectCommand = sqlcommand;
                adapter.Fill(dataset, "Product");
                dataGridView1.DataSource = dataset;
                dataGridView1.DataMember = "Product";
                conn.Close(); // Closing connection
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message); // Error message
            }
           
               
        }

        private void cBStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand sqlcommand = new SqlCommand(@"SELECT ProductDescription, ProductPrice, ProductStock FROM Product WHERE ProductName ='"+ cBSearch.SelectedValue + "'", conn);
                adapter = new SqlDataAdapter();
                dataset = new DataSet();
                adapter.SelectCommand = sqlcommand;
                adapter.Fill(dataset, "Product");
                lbDisplay.Visible = true;
       
                lbDisplay.Items.Add("Description\tProduct Price\tProduct Stock");
                foreach (DataRow row in dataset.Tables["Product"].Rows)
                {
                    string productDescription = row["ProductDescription"].ToString();
                    string productPrice = row["ProductPrice"].ToString();
                    string productStock = row["ProductStock"].ToString();

                    // Construct a string representing each row of data
                    string rowData = $"{productDescription,-30}\t{productPrice,-15}\t{productStock,-15}";

                    // Add the constructed string to the ListBox
                    lbDisplay.Items.Add(rowData);
                }

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            lbDisplay.Visible = false;
            txtBoxName.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Return Return = new Return();
            Return.ShowDialog();
        }
    }
}