using System;
using System.Windows.Forms;

namespace group9cmpg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();

            ReportsDashboard reportsDashboard = new ReportsDashboard();
            reportsDashboard.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            ProductCatalog productCatalog = new ProductCatalog();
            productCatalog.ShowDialog();
        
    }

    }
}
