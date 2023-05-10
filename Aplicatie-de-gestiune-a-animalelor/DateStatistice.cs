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
using System.Drawing;
using Aplicatie_de_gestiune_a_animalelor.Classes;
using System.Data.SQLite;
using System.Diagnostics.Metrics;
using System.Drawing.Printing;
using System.Globalization;
using System.Timers;
using System.Windows.Forms.DataVisualization.Charting;

namespace Aplicatie_de_gestiune_a_animalelor
{
    public partial class DateStatistice : Form
    {
        DatabaseManager databaseManager = DatabaseManager.GetInstance();
        MainMenuForm menu;
        Dictionary<string, int> counters = new Dictionary<string, int>();
        int fontSize = 16;
        int yStep = 0;
        int xPos = 0;
        Panel panel1;
        public DateStatistice(MainMenuForm menu)
        {
            InitializeComponent();
            this.menu = menu;
            float dpiX, dpiY;
            yStep = fontSize * 2 + 10;
            xPos = (int)(0.1f * this.Size.Width);
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
            foreach (var item in AnimalTypes.Types)
            {
                counters.Add(item.Key, 0);
            }
        }

        private void DateStatistice_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            string query = "SELECT * from Animale";
            int totalAnimals = 0;
            float ageSum = 0;
            float weightSum = 0;
            int vacNumber = 0;
            int sterNumber = 0;
            using (SQLiteConnection con = databaseManager.GetConnection())
            using (SQLiteCommand command = new SQLiteCommand(query, con))
            {
                con.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        totalAnimals++;
                        string animalType = reader.GetString(reader.GetOrdinal("Specie"));
                        int age = reader.GetInt32(reader.GetOrdinal("Varsta"));
                        float weight = reader.GetFloat(reader.GetOrdinal("Greutate"));
                        if (reader.GetString(reader.GetOrdinal("Vaccinat")) == "DA")
                        {
                            vacNumber += 1;
                        }
                        if (reader.GetString(reader.GetOrdinal("Sterilizat")) == "DA")
                        {
                            sterNumber += 1;
                        }
                        ageSum += age;
                        weightSum += weight;
                        if (counters.ContainsKey(animalType))
                        {
                            counters[animalType]++;
                        }
                    }


                }
            }
            int startY = 100;
            
            Label title = new Label();
            title.AutoSize = true;
            title.Text = $"Raport privind animalele gestionate";
            title.Location = new Point(this.Size.Width/2 - 300, startY);
            title.Font = new Font(title.Font.FontFamily, fontSize * 1.5f);
            panel1.Controls.Add(title);

            Label labelDate = new Label();
            labelDate.AutoSize = true;
            labelDate.Text = $"{DateTime.Now}";
            labelDate.Location = new Point(this.Size.Width - 250, 50);
            labelDate.Font = new Font(labelDate.Font.FontFamily, fontSize);
            panel1.Controls.Add(labelDate);

            startY += 100;
            Label generalData = new Label();
            generalData.AutoSize = true;
            generalData.Text = $"STATISTICI GENERALE";
            generalData.Location = new Point(this.Size.Width / 2 - 150, startY);
            generalData.Font = new Font(generalData.Font.FontFamily, fontSize);
            panel1.Controls.Add(generalData);

            #region AnimalDistributionPieChart
            startY += 50;
            Chart distChart = new Chart();
            distChart.Location = new Point(xPos, startY);
            ChartArea distArea = new ChartArea();
            distChart.ChartAreas.Add(distArea);
            distChart.Titles.Add("Distributia animalelor");
            Series distSeries = distChart.Series.Add("Animale");
            distSeries.ChartType = SeriesChartType.Pie;

            foreach (var item in counters)
            {
                distSeries.Points.AddXY(AnimalTypes.PluralTypes[item.Key], item.Value);
            }
            distChart.Series[0].IsValueShownAsLabel = true;
            distChart.Series[0].Palette = ChartColorPalette.BrightPastel;

            Legend distLegend = new Legend();
            distLegend.Enabled = true;
            distLegend.Docking = Docking.Bottom;
            distChart.Legends.Add(distLegend);
            TextAnnotation totalAnimalsAnnotation = new TextAnnotation();
            totalAnimalsAnnotation.Text = $"Total animale: {totalAnimals}";
            totalAnimalsAnnotation.Font = new Font("Arial", 12);
            totalAnimalsAnnotation.ForeColor = Color.Black;
            totalAnimalsAnnotation.X = 50;
            Debug.WriteLine(distChart.Height - 210);
            totalAnimalsAnnotation.Y = distChart.Height - 210;
            distChart.Annotations.Add(totalAnimalsAnnotation);
            panel1.Controls.Add(distChart);

            #endregion

            #region Vacc/SterDistribution
            Chart chart1 = new Chart();
            chart1.ChartAreas.Add(new ChartArea());
            chart1.Location = new Point(xPos * 5, startY);
            chart1.Size = new Size(chart1.Width, chart1.Height);

            chart1.Series.Clear();
            chart1.Series.Add("Total animale");
            chart1.Series.Add("Vaccinate");
            chart1.Series.Add("Sterilizate");

            chart1.Series["Total animale"].ChartType = SeriesChartType.Column;
            chart1.Series["Vaccinate"].ChartType = SeriesChartType.Column;
            chart1.Series["Sterilizate"].ChartType = SeriesChartType.Column;

            chart1.Series["Total animale"].Points.AddXY("", totalAnimals);
            chart1.Series["Total animale"].Points[0].Label = "Total animale";
            chart1.Series["Vaccinate"].Points.AddXY("", vacNumber);
            chart1.Series["Vaccinate"].Points[0].Label = "Vacc";
            chart1.Series["Sterilizate"].Points.AddXY("", sterNumber);
            chart1.Series["Sterilizate"].Points[0].Label = "Ster";
            foreach (var item in chart1.Series)
            {
                item.Font = new Font("Arial", 12);
            }

            chart1.Titles.Add("Grafic vaccinare/sterilizare");
            chart1.ChartAreas[0].AxisX.MajorTickMark.Enabled = true;
            chart1.ChartAreas[0].AxisX.LabelStyle.Enabled = true;
            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 0.5;
            chart1.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Arial", 10);
            chart1.Series["Total animale"].Color = Color.Green;
            chart1.Series["Vaccinate"].Color = Color.Blue;
            chart1.Series["Sterilizate"].Color = Color.Red;
            panel1.Controls.Add(chart1);
            #endregion
            startY += 320;
            foreach (var item in counters)
            {
                Label label3 = new Label();
                label3.AutoSize = true;
                float percentage = (float)counters[item.Key] / totalAnimals * 100;
                label3.Text = $"Procentul de {AnimalTypes.PluralTypes[item.Key]} este {percentage.ToString("N2")}%";
                label3.Location = new Point(xPos, startY);
                label3.Font = new Font(label3.Font.FontFamily, fontSize);
                panel1.Controls.Add(label3);
                startY += yStep;
            }

            Label label4 = new Label();
            label4.AutoSize = true;
            float avgAge = ageSum / (float)totalAnimals;
            label4.Text = $"Varsta medie a animalelor este de {avgAge.ToString("N2")} ani";
            label4.Location = new Point(xPos, startY);
            label4.Font = new Font(label4.Font.FontFamily, fontSize);
            panel1.Controls.Add(label4);

            startY += yStep;
            Label label5 = new Label();
            label5.AutoSize = true;
            float avgWeight = weightSum / (float)totalAnimals;
            label5.Text = $"Greutatea medie a animalelor este de {avgWeight.ToString("N2")} Kg";
            label5.Location = new Point(xPos, startY);
            label5.Font = new Font(label5.Font.FontFamily, fontSize);
            panel1.Controls.Add(label5);

            startY += yStep;
            Label label6 = new Label();
            label6.AutoSize = true;
            label6.Text = $"Numarul animalelor vaccinate este de {vacNumber}";
            label6.Location = new Point(xPos, startY);
            label6.Font = new Font(label6.Font.FontFamily, fontSize);
            panel1.Controls.Add(label6);

            startY += yStep;
            Label label7 = new Label();
            label7.AutoSize = true;
            float vacPercentage = (float)vacNumber / (float)totalAnimals * 100;
            label7.Text = $"Procentul animalelor vaccinate este de {vacPercentage.ToString("N2")}%";
            label7.Location = new Point(xPos, startY);
            label7.Font = new Font(label7.Font.FontFamily, fontSize);
            panel1.Controls.Add(label7);

            startY += yStep;
            Label label8 = new Label();
            label8.AutoSize = true;
            label8.Text = $"Numarul animalelor sterilizate este de {sterNumber}";
            label8.Location = new Point(xPos, startY);
            label8.Font = new Font(label8.Font.FontFamily, fontSize);
            panel1.Controls.Add(label8);

            startY += yStep;
            Label label9 = new Label();
            label9.AutoSize = true;
            float sterPercentage = (float)sterNumber / (float)totalAnimals * 100;
            label9.Text = $"Procentul animalelor sterilizate este de {sterPercentage.ToString("N2")}%";
            label9.Location = new Point(xPos, startY);
            label9.Font = new Font(label9.Font.FontFamily, fontSize);
            panel1.Controls.Add(label9);
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
        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }
    }
}
