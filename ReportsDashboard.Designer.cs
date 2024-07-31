namespace group9cmpg
{
    partial class ReportsDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.label1 = new System.Windows.Forms.Label();
            this.greetingsLabel = new System.Windows.Forms.Label();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.pieChartLabel = new System.Windows.Forms.Label();
            this.salesOrdersPerTime = new System.Windows.Forms.Label();
            this.salesOrderChart = new LiveCharts.WinForms.CartesianChart();
            this.productsPerTimeFrame = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.salesOrderPerClientPerTimeFrame = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.productsPerTimeFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrderPerClientPerTimeFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // greetingsLabel
            // 
            this.greetingsLabel.AutoSize = true;
            this.greetingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetingsLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.greetingsLabel.Location = new System.Drawing.Point(195, 96);
            this.greetingsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.greetingsLabel.Name = "greetingsLabel";
            this.greetingsLabel.Size = new System.Drawing.Size(232, 20);
            this.greetingsLabel.TabIndex = 1;
            this.greetingsLabel.Text = "Welcome to your dashboard";
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(140, 240);
            this.pieChart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(380, 250);
            this.pieChart1.TabIndex = 2;
            this.pieChart1.Text = "pieChart1";
            this.pieChart1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.pieChart1_ChildChanged);
            // 
            // pieChartLabel
            // 
            this.pieChartLabel.AutoSize = true;
            this.pieChartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pieChartLabel.Location = new System.Drawing.Point(196, 194);
            this.pieChartLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pieChartLabel.Name = "pieChartLabel";
            this.pieChartLabel.Size = new System.Drawing.Size(102, 16);
            this.pieChartLabel.TabIndex = 3;
            this.pieChartLabel.Text = "Product sales";
            // 
            // salesOrdersPerTime
            // 
            this.salesOrdersPerTime.AutoSize = true;
            this.salesOrdersPerTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesOrdersPerTime.Location = new System.Drawing.Point(729, 194);
            this.salesOrdersPerTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salesOrdersPerTime.Name = "salesOrdersPerTime";
            this.salesOrdersPerTime.Size = new System.Drawing.Size(207, 16);
            this.salesOrdersPerTime.TabIndex = 4;
            this.salesOrdersPerTime.Text = "Sales Orders per time period";
            this.salesOrdersPerTime.Click += new System.EventHandler(this.label2_Click);
            // 
            // salesOrderChart
            // 
            this.salesOrderChart.Location = new System.Drawing.Point(667, 240);
            this.salesOrderChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.salesOrderChart.Name = "salesOrderChart";
            this.salesOrderChart.Size = new System.Drawing.Size(645, 229);
            this.salesOrderChart.TabIndex = 5;
            this.salesOrderChart.Text = "cartesianChart1";
            // 
            // productsPerTimeFrame
            // 
            this.productsPerTimeFrame.BackColor = System.Drawing.Color.Transparent;
            this.productsPerTimeFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.productsPerTimeFrame.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.productsPerTimeFrame.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.productsPerTimeFrame.BorderlineColor = System.Drawing.Color.Transparent;
            this.productsPerTimeFrame.BorderSkin.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.productsPerTimeFrame.BorderSkin.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.productsPerTimeFrame.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.productsPerTimeFrame.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.Transparent;
            legend3.Name = "Legend1";
            this.productsPerTimeFrame.Legends.Add(legend3);
            this.productsPerTimeFrame.Location = new System.Drawing.Point(124, 557);
            this.productsPerTimeFrame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productsPerTimeFrame.MinimumSize = new System.Drawing.Size(471, 369);
            this.productsPerTimeFrame.Name = "productsPerTimeFrame";
            this.productsPerTimeFrame.Size = new System.Drawing.Size(471, 369);
            this.productsPerTimeFrame.TabIndex = 8;
            this.productsPerTimeFrame.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 537);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Products per time period";
            // 
            // fromDate
            // 
            this.fromDate.Location = new System.Drawing.Point(733, 96);
            this.fromDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(265, 22);
            this.fromDate.TabIndex = 10;
            this.fromDate.ValueChanged += new System.EventHandler(this.fromDate_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(729, 537);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sales orders per client per time period";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // toDate
            // 
            this.toDate.Location = new System.Drawing.Point(733, 140);
            this.toDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(265, 22);
            this.toDate.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(663, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "From:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(676, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "To:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(165, 782);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Sales orders per status per time period";
            // 
            // salesOrderPerClientPerTimeFrame
            // 
            this.salesOrderPerClientPerTimeFrame.BackColor = System.Drawing.Color.Transparent;
            this.salesOrderPerClientPerTimeFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.salesOrderPerClientPerTimeFrame.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.salesOrderPerClientPerTimeFrame.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.salesOrderPerClientPerTimeFrame.ChartAreas.Add(chartArea4);
            legend4.BackColor = System.Drawing.Color.Transparent;
            legend4.Name = "Legend1";
            this.salesOrderPerClientPerTimeFrame.Legends.Add(legend4);
            this.salesOrderPerClientPerTimeFrame.Location = new System.Drawing.Point(680, 560);
            this.salesOrderPerClientPerTimeFrame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.salesOrderPerClientPerTimeFrame.Name = "salesOrderPerClientPerTimeFrame";
            this.salesOrderPerClientPerTimeFrame.Size = new System.Drawing.Size(548, 369);
            this.salesOrderPerClientPerTimeFrame.TabIndex = 16;
            this.salesOrderPerClientPerTimeFrame.Text = "chart1";
            // 
            // ReportsDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 958);
            this.Controls.Add(this.salesOrderPerClientPerTimeFrame);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fromDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salesOrderChart);
            this.Controls.Add(this.salesOrdersPerTime);
            this.Controls.Add(this.pieChartLabel);
            this.Controls.Add(this.pieChart1);
            this.Controls.Add(this.greetingsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productsPerTimeFrame);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReportsDashboard";
            this.Text = "ReportsDashboard";
            this.Load += new System.EventHandler(this.ReportsDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsPerTimeFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrderPerClientPerTimeFrame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label greetingsLabel;
        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.Label pieChartLabel;
        private System.Windows.Forms.Label salesOrdersPerTime;
        private LiveCharts.WinForms.CartesianChart salesOrderChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart productsPerTimeFrame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fromDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker toDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart salesOrderPerClientPerTimeFrame;
    }
}