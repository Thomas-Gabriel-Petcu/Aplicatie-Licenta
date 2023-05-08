﻿using System;
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

namespace Aplicatie_de_gestiune_a_animalelor
{
    using Aplicatie_de_gestiune_a_animalelor.Classes;
    using System.Data.SQLite;
    using System.Diagnostics.Metrics;
    using System.Drawing.Printing;
    using System.Globalization;
    using System.Timers;
    public partial class DateStatistice : Form
    {
        DatabaseManager databaseManager = DatabaseManager.GetInstance();
        MainMenuForm menu;
        Dictionary<string, int> counters = new Dictionary<string, int>();
        int fontSize = 16;
        Panel panel1;
        public DateStatistice(MainMenuForm menu)
        {
            InitializeComponent();
            this.menu = menu;
            float dpiX, dpiY;
            using (Graphics graphics = this.CreateGraphics())
            {
                dpiX = graphics.DpiX;
                dpiY = graphics.DpiY;
            }
            float widthInCm = 21;
            float heightInCm = 29.7f;
            float widthInPixels = (widthInCm / 2.54f) * dpiX;
            float heightInPixels = (heightInCm / 2.54f) * dpiY;
            this.Size = new Size((int)widthInPixels, (int)heightInPixels);
            this.MaximumSize = this.Size;
            panel1 = new Panel();
            panel1.Location = new Point(0, 0);
            panel1.Size = new Size(this.Size.Width, this.Size.Height);
            panel1.Dock = DockStyle.Fill;
            panel1.AutoScroll = false;
            this.Controls.Add(panel1);
            foreach (var item in AnimalTypes.Types)
            {
                counters.Add(item.Key,0);
            }
        }

        private void DateStatistice_Load(object sender, EventArgs e)
        {
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
            
            Label generalData = new Label();
            generalData.AutoSize = true;
            generalData.Text = $"STATISTICI GENERALE";
            generalData.Location = new Point(40, 50);
            generalData.Font = new Font(generalData.Font.FontFamily, fontSize);
            panel1.Controls.Add(generalData);

            int startY = 100; 
            Label label1 = new Label();
            label1.AutoSize = true;
            label1.Text = $"Numarul total al animalelor este de {totalAnimals}";
            label1.Location = new Point(this.Width / 2 - label1.Width * 2, startY);
            label1.Font = new Font(label1.Font.FontFamily, fontSize);
            panel1.Controls.Add(label1);
            foreach (var item in counters)
            {
                startY += fontSize + fontSize/2;
                Label label2 = new Label();
                label2.AutoSize = true;
                label2.Text = $"Numarul de \"{AnimalTypes.PluralTypes[item.Key]}\" este de {item.Value}";
                label2.Location = new Point(this.Width / 2 - label2.Width * 2, startY);
                label2.Font = new Font(label2.Font.FontFamily, fontSize);
                panel1.Controls.Add(label2);
            }
            foreach (var item in counters)
            {
                startY += fontSize + fontSize / 2;
                Label label3 = new Label();
                label3.AutoSize = true;
                float percentage = (float)counters[item.Key] / totalAnimals * 100;
                label3.Text = $"Procentul de {AnimalTypes.PluralTypes[item.Key]} este {percentage.ToString("N2")}%";
                label3.Location = new Point(this.Width / 2 - label3.Width * 2, startY);
                label3.Font = new Font(label3.Font.FontFamily, fontSize);
                panel1.Controls.Add(label3);
            }
            startY += fontSize + fontSize / 2;
            Label label4 = new Label();
            label4.AutoSize = true;
            float avgAge = ageSum / (float)totalAnimals;
            label4.Text = $"Varsta medie a animalelor este de {avgAge.ToString("N2")} ani";
            label4.Location = new Point(this.Width / 2 - label4.Width * 2, startY);
            label4.Font = new Font(label4.Font.FontFamily, fontSize);
            panel1.Controls.Add(label4);

            startY += fontSize + fontSize / 2;
            Label label5 = new Label();
            label5.AutoSize = true;
            float avgWeight = weightSum / (float)totalAnimals;
            label5.Text = $"Greutatea medie a animalelor este de {avgWeight.ToString("N2")} Kg";
            label5.Location = new Point(this.Width / 2 - label5.Width * 2, startY);
            label5.Font = new Font(label5.Font.FontFamily, fontSize);
            panel1.Controls.Add(label5);

            startY += fontSize + fontSize / 2;
            Label label6 = new Label();
            label6.AutoSize = true;
            label6.Text = $"Numarul animalelor vaccinate este de {vacNumber}";
            label6.Location = new Point(this.Width / 2 - label6.Width * 2, startY);
            label6.Font = new Font(label6.Font.FontFamily, fontSize);
            panel1.Controls.Add(label6);

            startY += fontSize + fontSize / 2;
            Label label7 = new Label();
            label7.AutoSize = true;
            float vacPercentage = vacNumber / totalAnimals * 100;
            label7.Text = $"Procentul animalelor vaccinate este de {vacPercentage.ToString("N2")}";
            label7.Location = new Point(this.Width / 2 -label7.Width * 2, startY);
            label7.Font = new Font(label7.Font.FontFamily, fontSize);
            panel1.Controls.Add(label7);

            startY += fontSize + fontSize / 2;
            Label label8 = new Label();
            label8.AutoSize = true;
            label8.Text = $"Numarul animalelor sterilizate este de {sterNumber}";
            label8.Location = new Point(this.Width / 2 - label8.Width * 2, startY);
            label8.Font = new Font(label8.Font.FontFamily, fontSize);
            panel1.Controls.Add(label8);

            startY += fontSize + fontSize / 2;
            Label label9 = new Label();
            label9.AutoSize = true;
            float sterPercentage = sterNumber / totalAnimals * 100;
            label9.Text = $"Procentul animalelor sterilizate este de {sterPercentage.ToString("N2")}";
            label9.Location = new Point(this.Width / 2 - label9.Width * 2, startY);
            label9.Font = new Font(label9.Font.FontFamily, fontSize);
            panel1.Controls.Add(label9);

            startY += 50;
            Label monthlyData = new Label();
            monthlyData.AutoSize = true;
            monthlyData.Text = $"DATE INCEPAND CU PRIMA ZI A LUNII";
            monthlyData.Location = new Point(40, startY);
            monthlyData.Font = new Font(monthlyData.Font.FontFamily, fontSize);
            panel1.Controls.Add(monthlyData);

            startY += 50;
            Label label10 = new Label();
            label10.AutoSize = true;
            label10.Text = $"Numarul de animale inregistrate luna aceasta este {Statistics.GetRegisteredAnimals()}";
            label10.Location = new Point(this.Width / 2 - label10.Width * 2, startY);
            label10.Font = new Font(label10.Font.FontFamily, fontSize);
            panel1.Controls.Add(label10);

            startY += fontSize + fontSize / 2;
            Label label11 = new Label();
            label11.AutoSize = true;
            label11.Text = $"Numarul de animale iesite din sistem luna aceasta este {Statistics.GetUnregisteredAnimals()}";
            label11.Location = new Point(this.Width / 2 - label11.Width * 2, startY);
            label11.Font = new Font(label11.Font.FontFamily, fontSize);
            panel1.Controls.Add(label11);

            startY += fontSize + fontSize / 2;
            Label label12 = new Label();
            label12.AutoSize = true;
            label12.Text = $"Numarul de programari inregistrate luna aceasta este {Statistics.GetRegisteredAppointments()}";
            label12.Location = new Point(this.Width / 2 - label12.Width * 2, startY);
            label12.Font = new Font(label12.Font.FontFamily, fontSize);
            panel1.Controls.Add(label12);
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
