using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Wpf.Charts.Base;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace group9cmpg
{
    public partial class ReportsDashboard : Form
    {

        string connectionString = "Data Source=dairyexchange.database.windows.net;Initial Catalog=dairyExchange;Persist Security Info=True;User ID=sqlAdmin;Password=r00tmeister101!";

        public ReportsDashboard()
        {
            InitializeComponent();

            fromDate.Value = new DateTime(DateTime.Now.Year, 1, 1);
            toDate.Value = DateTime.Now;

            calculateTotalSalesPerProduct();

            fetchSalesOrdersPerTimeFrame();

            fetchSalesOrderPerClientPerTimeFrame();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pieChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {


        }

        private void ReportsDashboard_Load(object sender, EventArgs e)
        {

        }

        private void calculateTotalSalesPerProduct()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                                    SELECT P.ProductName, COUNT(O.ProductID) as TotalSales FROM Product P LEFT JOIN SalesOrder O ON P.ProductID = O.ProductID GROUP BY P.ProductName;
                                    ";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    int rowCount = 0;
                    while (reader.Read())
                    {
                        rowCount++;
                    }

                    reader.Close();
                    string[] productNames = new string[rowCount];
                    int[] totalSales = new int[rowCount];

                    reader = command.ExecuteReader();
                    int index = 0;
                    while (reader.Read())
                    {
                        productNames[index] = reader["ProductName"].ToString();
                        totalSales[index] = Convert.ToInt32(reader["TotalSales"].ToString());
                        index++;
                    }

                    reader.Close();

                    RenderPieChart(productNames, totalSales);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally { connection.Close(); }
            }
        }

        private void fetchProductsPerTimePeriod()
        {

            // Configure the chart
            productsPerTimeFrame.ChartAreas.Add(new ChartArea("MainChartArea"));
            productsPerTimeFrame.Series.Add(new System.Windows.Forms.DataVisualization.Charting.Series("Sales"));
            productsPerTimeFrame.Series["Sales"].ChartType = SeriesChartType.Column;
            // Get selected dates from DateTimePicker controls
            DateTime fDate = fromDate.Value;
            DateTime tDate = toDate.Value;

            // Clear existing data in the chart
            productsPerTimeFrame.Series["Sales"].Points.Clear();

            // Retrieve and display data
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sqlQuery = @"SELECT Product.ProductName, SUM(SalesOrder.OrderQuantity) AS TotalQuantity
                                    FROM SalesOrder
                                    INNER JOIN Product ON SalesOrder.ProductID = Product.ProductID
                                    WHERE SalesOrder.OrderDate >= @FromDate AND SalesOrder.OrderDate <= @ToDate
                                    GROUP BY Product.ProductName";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@FromDate", fDate);
                    cmd.Parameters.AddWithValue("@ToDate", tDate);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string productName = reader["ProductName"].ToString();
                            int totalQuantity = Convert.ToInt32(reader["TotalQuantity"]);

                            // Add data points to the chart
                            productsPerTimeFrame.Series["Sales"].Points.AddXY(productName, totalQuantity);
                        }
                    }
                }
            }
        }
        private void fetchSalesOrderPerClientPerTimeFrame()
        {

                // Configure the chart
                salesOrderPerClientPerTimeFrame.ChartAreas.Add(new ChartArea("MainChartArea"));
            salesOrderPerClientPerTimeFrame.Series.Add(new System.Windows.Forms.DataVisualization.Charting.Series("Sales"));
            salesOrderPerClientPerTimeFrame.Series["Sales"].ChartType = SeriesChartType.Column;


                DateTime fDate = fromDate.Value;
                DateTime tDate = toDate.Value;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sqlQuery = @"SELECT Client.ClientName, SUM(SalesOrder.OrderQuantity) AS TotalQuantity
                                    FROM SalesOrder
                                    INNER JOIN SalesOrderClient ON SalesOrder.OrderID = SalesOrderClient.OrderID
                                    INNER JOIN Client ON SalesOrderClient.ClientID = Client.ClientID
                                    WHERE SalesOrder.OrderDate >= @FromDate AND SalesOrder.OrderDate <= @ToDate
                                    GROUP BY Client.ClientName";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@FromDate", fDate);
                        cmd.Parameters.AddWithValue("@ToDate", tDate);

                        using (var adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                        // Clear existing data in the chart
                        salesOrderPerClientPerTimeFrame.Series["Sales"].Points.Clear();

                            foreach (DataRow row in dataTable.Rows)
                            {
                                string clientName = row["ClientName"].ToString();
                                int totalQuantity = Convert.ToInt32(row["TotalQuantity"]);

                            // Add data points to the chart
                            salesOrderPerClientPerTimeFrame.Series["Sales"].Points.AddXY(clientName, totalQuantity);
                            }
                        }
                    }
                }
            }
        

        private void RenderPieChart(string[] productNames, int[] totalSales)
        {
            LiveCharts.SeriesCollection series = new LiveCharts.SeriesCollection();

            for (int i = 0; i < productNames.Length; i++)
            {
                PieSeries pieSeries = new PieSeries
                {
                    Title = productNames[i],
                    Values = new ChartValues<int> { totalSales[i] },
                    DataLabels = true
                };

                series.Add(pieSeries);
            }

            pieChart1.Series = series;


        }

        private void RenderBarChart()
        {

        }

        private void fetchSalesOrdersPerTimeFrame()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT 
                                            DATEADD(day, DATEDIFF(day, 0, OrderDate), 0) AS OrderDate,
                                            COUNT(OrderID) AS NumberOfOrders
                                        FROM 
                                            SalesOrder
                                        GROUP BY 
                                            DATEADD(day, DATEDIFF(day, 0, OrderDate), 0)
                                        ORDER BY 
                                            OrderDate;
                                         ";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    int rowCount = 0;
                    while (reader.Read())
                    {
                        rowCount++;
                    }

                    reader.Close();
                    string[] OrderDate = new string[rowCount];
                    int[] NumberOfOrders = new int[rowCount];

                    reader = command.ExecuteReader();
                    int index = 0;
                    while (reader.Read())
                    {
                        OrderDate[index] = reader["OrderDate"].ToString();
                        NumberOfOrders[index] = Convert.ToInt32(reader["NumberOfOrders"].ToString());
                        index++;
                    }

                    reader.Close();

                    RenderLineChart(OrderDate, NumberOfOrders);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally { connection.Close(); }
            }

        }



        private void RenderLineChart(string[] OrderDate, int[] NumberOfOrders)
        {
            // Convert the OrderDate strings to DateTime objects
            DateTime[] dateTimes = OrderDate.Select(dateStr => DateTime.Parse(dateStr)).ToArray();

            // Calculate minDate and maxDate
            DateTime minDate = dateTimes.Min();
            DateTime maxDate = dateTimes.Max();

            // Calculate the minimum and maximum values in NumberOfOrders
            int minYValue = 0;
            int maxYValue = NumberOfOrders.Max() + 1;

            salesOrderChart.Series.Clear();

            LiveCharts.SeriesCollection series = new LiveCharts.SeriesCollection();

            for (int i = 0; i < OrderDate.Length; i++)
            {
                LineSeries pieSeries = new LineSeries
                {
                    Title = OrderDate[i],
                    Values = new ChartValues<int> { NumberOfOrders[i] },
                    DataLabels = true,
                    PointGeometrySize = 10, // Set the size of the dots
                    PointGeometry = DefaultGeometries.Circle, // Use circles as markers
                };

                series.Add(pieSeries);
            }

            salesOrderChart.Series = series;

            salesOrderChart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Date",
                LabelFormatter = value => new DateTime((long)value).ToString("yyyy-MM-dd"), // Format the date as needed
                MinValue = minDate.Ticks, // Set the minimum value to your fromDate
                MaxValue = maxDate.Ticks,   // Set the maximum value to your toDate
                Separator = new Separator { Step = TimeSpan.FromDays(1).Ticks } // Specify tick spacing (e.g., one day)
            });

            salesOrderChart.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Number of Orders",
                MinValue = minYValue, // Set the minimum value for the Y-axis
                MaxValue = maxYValue, // Set the maximum value for the Y-axis
                Separator = new Separator { Step = 1 } // Specify tick spacing for Y-axis
            });
        }

        private void label2_Click(object sender, EventArgs e)
                {

                }

                private void label3_Click(object sender, EventArgs e)
                {

                }

                private void fromDate_ValueChanged(object sender, EventArgs e)
                {
            fetchProductsPerTimePeriod();
                }
            }
        }

