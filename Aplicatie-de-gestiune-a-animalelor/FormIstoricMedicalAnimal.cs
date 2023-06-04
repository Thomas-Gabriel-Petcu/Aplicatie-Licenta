using Aplicatie_de_gestiune_a_animalelor.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie_de_gestiune_a_animalelor
{
    public partial class FormIstoricMedicalAnimal : Form
    {
        Panel panel1;
        int idAnimal = 0;
        DatabaseManager databaseManager = DatabaseManager.GetInstance();
        public FormIstoricMedicalAnimal(int idAnimal)
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
            panel1.Controls.Add(labelTitlu);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dataGridViewAnimale);
            panel1.Controls.Add(dataGridViewConsultatii);
            panel1.Controls.Add(labelData);
            panel1.Location = new Point((this.Width/2) - (panel1.Width/2), panel1.Location.Y);
            labelData.Text = DateTime.Now.ToString();
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
                    DataTable dataTable = new DataTable();

                    dataTable.Columns.Add("Specie");
                    dataTable.Columns.Add("Rasa");
                    dataTable.Columns.Add("Nume");
                    dataTable.Columns.Add("Varsta");
                    dataTable.Columns.Add("Sex");
                    dataTable.Columns.Add("Greutate");
                    dataTable.Columns.Add("Vaccinat");
                    dataTable.Columns.Add("Sterilizat");

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
                        dataTable.Rows.Add(specie, rasa, nume, varsta, sex, greutate, vaccinat, sterilizat);
                    }
                    dataGridViewAnimale.DataSource = dataTable;
                }
            }
        }
        private void PopulateMedicalRecords()
        {
            string query = $"SELECT NumarFisaMedicala, DataConsult, Diagnostic, Tratament FROM FiseMedicale WHERE IDAnimal = {idAnimal}";

            using (SQLiteConnection connection = databaseManager.GetConnection())
            {
                DataTable table = new DataTable();
                table.Columns.Add("Numar Fisa Medicala");
                table.Columns.Add("Data consultului");
                table.Columns.Add("Diagnostic");
                table.Columns.Add("Tratament");
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    connection.Open();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("Nu exista fise medicale pentru acest animal.");
                        }
                        while (reader.Read())
                        {
                            string numarFisa = reader.GetString(reader.GetOrdinal("NumarFisaMedicala"));
                            string dateTimeStr = reader.GetString(reader.GetOrdinal("DataConsult"));
                            DateTime dateTime = DateTime.ParseExact(dateTimeStr, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                            string diagnostic = reader.GetString(reader.GetOrdinal("Diagnostic"));
                            string tratament = reader.GetString(reader.GetOrdinal("Tratament"));
                            table.Rows.Add(numarFisa, dateTime, diagnostic, tratament);
                        }
                        dataGridViewConsultatii.DataSource = table;
                    }
                }
            }

        }
        private void FormIstoricMedicalAnimal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            PopulateAnimalDetails();
            PopulateMedicalRecords();
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

        private void dataGridViewAnimale_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewAnimale.ClearSelection();
        }

        private void FormIstoricMedicalAnimal_Resize(object sender, EventArgs e)
        {
            int padding = 20;
            int dif = this.Height - this.MinimumSize.Height;
            dataGridViewConsultatii.Height = dataGridViewConsultatii.MinimumSize.Height + dif - padding;
        }

        private void dataGridViewConsultatii_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewConsultatii.ClearSelection();
        }
    }
}
