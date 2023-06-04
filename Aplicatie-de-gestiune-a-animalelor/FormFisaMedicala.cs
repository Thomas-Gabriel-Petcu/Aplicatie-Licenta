using Aplicatie_de_gestiune_a_animalelor.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie_de_gestiune_a_animalelor
{
    public partial class FormFisaMedicala : Form
    {
        int idAnimal = 0;
        Panel panel1;
        DatabaseManager databaseManager = DatabaseManager.GetInstance();
        public FormFisaMedicala(int idAnimal)
        {
            InitializeComponent();
            this.idAnimal = idAnimal;
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
            panel1.AutoScroll = false;
            this.Controls.Add(panel1);
            PopulatePanel();
            //panel1.Controls.Add();
            //labelData.Text = DateTime.Now.ToString();
        }

        private void FormFisaMedicala_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            PopulateAnimalDetails();
            PopulateMedicalRecords();
        }
        private void PopulatePanel()
        {
            panel1.Controls.Add(labelTitlu);
            panel1.Controls.Add(labelNume);
            panel1.Controls.Add(labelNumarFisa);
            panel1.Controls.Add(labelDiagnostic);
            panel1.Controls.Add(labelTratament);
            panel1.Controls.Add(labelData);
            panel1.Controls.Add(labelGreutate);
            panel1.Controls.Add(labelVaccinat);
            panel1.Controls.Add(labelSterilizat);
            panel1.Controls.Add(labelSpecie);
            panel1.Controls.Add(labelRasa);
            panel1.Controls.Add(labelVarsta);
            panel1.Controls.Add(labelSex);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(label21);
            panel1.Controls.Add(label23);
            panel1.Controls.Add(label25);
            panel1.Controls.Add(label26);
            panel1.Controls.Add(label27);
            labelTitlu.BringToFront();
            labelNume.BringToFront();
            labelNumarFisa.BringToFront();
            labelDiagnostic.BringToFront();
            labelTratament.BringToFront();
            labelData.BringToFront();
            labelGreutate.BringToFront();
            labelVaccinat.BringToFront();
            labelSterilizat.BringToFront();
            labelSpecie.BringToFront();
            labelRasa.BringToFront();
            labelVarsta.BringToFront();
            labelSex.BringToFront();
        }
        private void PopulateAnimalDetails()
        {
            string query = $"SELECT Specie, Rasa, Nume, Varsta, Sex, Greutate, Vaccinat, Sterilizat FROM Animale WHERE IDAnimal = '{idAnimal}'";
            using (SQLiteConnection con = databaseManager.GetConnection())
            using (SQLiteCommand command = new SQLiteCommand(query, con))
            {
                con.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string specie = reader.GetString(reader.GetOrdinal("Specie"));
                        string rasa = reader.GetString(reader.GetOrdinal("Rasa"));
                        string nume = reader.GetString(reader.GetOrdinal("Nume"));
                        double varsta = reader.GetDouble(reader.GetOrdinal("Varsta"));
                        string sex = reader.GetString(reader.GetOrdinal("Sex"));
                        double greutate = reader.GetDouble(reader.GetOrdinal("Greutate"));
                        string vaccinat = reader.GetString(reader.GetOrdinal("Vaccinat"));
                        string sterilizat = reader.GetString(reader.GetOrdinal("Sterilizat"));
                        labelSpecie.Text = specie;
                        labelRasa.Text = rasa;
                        labelNume.Text = nume;
                        labelVarsta.Text = varsta.ToString();
                        labelSex.Text = sex;
                        labelGreutate.Text = greutate.ToString();
                        labelVaccinat.Text = vaccinat;
                        labelSterilizat.Text = sterilizat;
                    }
                }
            }
        }
        private void PopulateMedicalRecords()
        {
            string query = $"SELECT NumarFisaMedicala, DataConsult, Diagnostic, Tratament FROM FiseMedicale WHERE IDAnimal = {idAnimal}";

            using (SQLiteConnection connection = databaseManager.GetConnection())
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    connection.Open();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string numarFisa = reader.GetString(reader.GetOrdinal("NumarFisaMedicala"));
                            string dateTimeStr = reader.GetString(reader.GetOrdinal("DataConsult"));
                            DateTime dateTime = DateTime.ParseExact(dateTimeStr, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                            string diagnostic = reader.GetString(reader.GetOrdinal("Diagnostic"));
                            string tratament = reader.GetString(reader.GetOrdinal("Tratament"));
                            labelNumarFisa.Text = numarFisa;
                            labelData.Text = dateTime.ToString();
                            labelDiagnostic.Text = diagnostic;
                            labelTratament.Text = tratament;
                        }
                    }
                }
            }

        }

        private void label21_Click(object sender, EventArgs e)
        {

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
