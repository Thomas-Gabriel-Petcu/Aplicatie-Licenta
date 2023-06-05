using Aplicatie_de_gestiune_a_animalelor.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SQLite;
using System.Globalization;
using System.Drawing.Printing;

namespace Aplicatie_de_gestiune_a_animalelor
{
    public partial class FormRaportIndividualFurnizor : Form
    {
        Panel panel1;
        DatabaseManager databaseManager = DatabaseManager.GetInstance();
        int nrSupplierOrders = 0;
        int nrTotalOrders = 0;
        int idSupplier = 0;
        double supplierTotalValue;
        double ordersTotalValue;
        public FormRaportIndividualFurnizor(int idSupplier)
        {
            InitializeComponent();
            this.idSupplier = idSupplier;
            float dpiX, dpiY;
            using (Graphics graphics = this.CreateGraphics())
            {
                dpiX = graphics.DpiX;
                dpiY = graphics.DpiY;
            }
            float widthInCm = 22;
            float heightInCm = 29.7f;
            float widthInPixels = (widthInCm / 2.54f) * dpiX;
            float heightInPixels = (heightInCm / 2.54f) * dpiY;
            this.Size = new Size((int)widthInPixels, (int)heightInPixels);
            this.MaximumSize = this.Size;
            panel1 = new Panel();
            panel1.Location = new Point(10, 0);
            panel1.Size = new Size(this.Size.Width, this.Size.Height);
            //panel1.Dock = DockStyle.Fill;
            panel1.AutoScroll = false;
            this.Controls.Add(panel1);
            labelDate.Text = DateTime.Now.ToString();
            panel1.Controls.Add(labelDate);
            panel1.Controls.Add(labelTitlu);
            panel1.Controls.Add(labelNumeFurnizor);
            panel1.Controls.Add(labelCUI);
            panel1.Controls.Add(labelAdresa);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(labelProcentNumar);
            panel1.Controls.Add(labelNumar);
            panel1.Controls.Add(labelProcentPlatit);
        }

        private void FormRaportIndividualFurnizor_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            string querySupplier = $"SELECT COUNT(*) FROM Comenzi WHERE IDFurnizor = '{idSupplier}'";
            string queryTotalOrders = "SELECT COUNT(*) FROM Comenzi";
            string querySupplierInfo = $"SELECT * FROM Furnizori WHERE IDFurnizor = '{idSupplier}'";
            string queryTotalSupplierValue = $"SELECT SUM(ValoareCuTVA) AS TotalValue FROM Comenzi WHERE IDFurnizor = {idSupplier}";
            string queryTotalOrdersValue = $"SELECT SUM(ValoareCuTVA) AS TotalValoareComenzi FROM Comenzi";
            using SQLiteConnection con = databaseManager.GetConnection();
            using SQLiteCommand command = new SQLiteCommand(querySupplier, con);
            using SQLiteCommand commandTotalOrders = new SQLiteCommand(queryTotalOrders, con);
            using SQLiteCommand commandSupplierInfo = new SQLiteCommand(querySupplierInfo, con);
            using SQLiteCommand commandSupplierTotalValue = new SQLiteCommand(queryTotalSupplierValue, con);
            using SQLiteCommand commandTotalOrdersValue = new SQLiteCommand(queryTotalOrdersValue, con);
            {
                con.Open();
                #region number of orders for given suppliers
                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    nrSupplierOrders = Convert.ToInt32(result);
                    labelNumar.Text = nrSupplierOrders.ToString();
                }
                #endregion
                #region number of total orders
                object result2 = commandTotalOrders.ExecuteScalar();

                if (result2 != null && result2 != DBNull.Value)
                {
                    nrTotalOrders = Convert.ToInt32(result2);
                }
                #endregion
                #region information about given supplier
                SQLiteDataReader reader = commandSupplierInfo.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader.GetString(reader.GetOrdinal("NumeFurnizor"));
                    string cui = reader.GetString(reader.GetOrdinal("CUI"));
                    string address = reader.GetString(reader.GetOrdinal("Adresa"));
                    labelNumeFurnizor.Text += $": {name}";
                    labelCUI.Text += $": {cui}";
                    labelAdresa.Text += $": {address}";
                }
                #endregion
                #region total value for orders to given supplier
                object supplierTotalValueResult = commandSupplierTotalValue.ExecuteScalar();

                if (supplierTotalValueResult != null && supplierTotalValueResult != DBNull.Value)
                {
                    double totalValue = Convert.ToDouble(supplierTotalValueResult);
                    supplierTotalValue = totalValue;
                }
                #endregion

                #region total value of all orders
                object totalOrdersValue = commandTotalOrdersValue.ExecuteScalar();
                if (totalOrdersValue != DBNull.Value)
                {
                    double totalValue = Convert.ToDouble(totalOrdersValue);
                    ordersTotalValue = totalValue;
                }
                #endregion

                double percentOfOrders = ((double)nrSupplierOrders / (double)nrTotalOrders) * 100;
                labelProcentNumar.Text = $"{percentOfOrders}%";
                double percentOfPayment = ((double)supplierTotalValue / (double)ordersTotalValue) * 100;
                labelProcentPlatit.Text = $"{percentOfPayment}%";
            }

            #region Char_order_distribution_by_number
            Chart distChart = new Chart();
            distChart.Location = new Point(63, 290);
            ChartArea distArea = new ChartArea();
            distChart.ChartAreas.Add(distArea);
            distChart.Titles.Add("Distributia comenzilor");
            distChart.Titles[0].Font = new Font("Arial", 14);
            Series distSeries = distChart.Series.Add("Comenzi");
            distSeries.ChartType = SeriesChartType.Pie;

            distSeries.Points.AddXY("Comenzi furnizor", nrSupplierOrders);
            distSeries.Points.AddXY("Rest", nrTotalOrders - nrSupplierOrders);

            distChart.Series[0].IsValueShownAsLabel = true;
            distChart.Series[0].Palette = ChartColorPalette.BrightPastel;

            Legend distLegend = new Legend();
            distLegend.Enabled = true;
            distLegend.Docking = Docking.Bottom;
            distChart.Legends.Add(distLegend);
            distChart.Series[0].Font = new Font("Arial", 14);
            distChart.Legends[0].Font = new Font("Arial", 12);
            foreach (DataPoint point in distChart.Series[0].Points)
            {
                point.Font = new Font("Arial", 14);
            }
            TextAnnotation totalOrderNumbers = new TextAnnotation();
            totalOrderNumbers.Text = $"Total comenzi: {nrTotalOrders}";
            totalOrderNumbers.Font = new Font("Arial", 12);
            totalOrderNumbers.ForeColor = Color.Black;
            totalOrderNumbers.X = 50;
            totalOrderNumbers.Y = distChart.Height - 210;
            distChart.Annotations.Add(totalOrderNumbers);
            panel1.Controls.Add(distChart);
            #endregion

            #region Char_order_distribution_by_value
            Chart chart = new Chart();
            chart.Location = new Point(63, 600);
            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);
            chart.Titles.Add("Distributia valorilor comenzilor");
            chart.Titles[0].Font = new Font("Arial", 14);
            Series charSeries = chart.Series.Add("Comenzi");
            charSeries.ChartType = SeriesChartType.Pie;

            charSeries.Points.AddXY("valoare comenzi furnizor", supplierTotalValue);
            charSeries.Points.AddXY("valoare rest", ordersTotalValue - supplierTotalValue);

            chart.Series[0].IsValueShownAsLabel = true;
            chart.Series[0].Palette = ChartColorPalette.Fire;

            Legend chartLegend = new Legend();
            chartLegend.Enabled = true;
            chartLegend.Docking = Docking.Bottom;
            chart.Legends.Add(chartLegend);
            chart.Series[0].Font = new Font("Arial", 14);
            chart.Legends[0].Font = new Font("Arial", 12);
            foreach (DataPoint point in chart.Series[0].Points)
            {
                point.Font = new Font("Arial", 14);
            }
            TextAnnotation totalOrderValue = new TextAnnotation();
            totalOrderValue.Text = $"Total: {ordersTotalValue}";
            totalOrderValue.Font = new Font("Arial", 12);
            totalOrderValue.ForeColor = Color.Black;
            totalOrderValue.X = 50;
            totalOrderValue.Y = chart.Height - 210;
            chart.Annotations.Add(totalOrderValue);
            panel1.Controls.Add(chart);
            #endregion

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintPage);
            pd.Print();
        }
        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            e.Graphics.DrawImage(bmp, new Point(0, 0));
        }
    }
}
