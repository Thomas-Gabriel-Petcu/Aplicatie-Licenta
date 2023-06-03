using Aplicatie_de_gestiune_a_animalelor.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie_de_gestiune_a_animalelor
{
    public partial class GestiuneMedicala : Form
    {
        DatabaseManager databaseManager = DatabaseManager.GetInstance();
        MainMenuForm menu;
        public GestiuneMedicala(MainMenuForm menu)
        {
            InitializeComponent();
            this.menu = menu;
        }

        private void GestiuneMedicala_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void GestiuneMedicala_Shown(object sender, EventArgs e)
        {
            RefreshDataGridViewAnimale();
        }
        private void RefreshDataGridViewAnimale()
        {
            string query = "SELECT * FROM Animale";
            using (SQLiteConnection con = databaseManager.GetConnection())
            using (SQLiteCommand command = new SQLiteCommand(query, con))
            {
                con.Open();
                using (var reader = command.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridViewAnimale.DataSource = dataTable;
                }
            }
        }

        private void buttonMeniu_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }

        private void GestiuneMedicala_Resize(object sender, EventArgs e)
        {
            int width = this.Width;
            int padding = 20;
            //gridviews
            dataGridViewAnimale.Width = width / 2 - padding;
            dataGridViewAnimale.Location = new Point(padding, dataGridViewAnimale.Location.Y);

            dataGridViewFiseMedicale.Width = width / 2 - (padding * 2);
            dataGridViewFiseMedicale.Location = new Point(width - dataGridViewFiseMedicale.Width - padding, dataGridViewFiseMedicale.Location.Y);
            //labels
            labelAnimale.Location = new Point(dataGridViewAnimale.Width / 2, labelAnimale.Location.Y);
            labelFise.Location = new Point(dataGridViewFiseMedicale.Location.X + (dataGridViewFiseMedicale.Width / 2), labelFise.Location.Y);
            labelPrelucrari.Location = new Point(width / 2 - (labelPrelucrari.Width / 2), labelPrelucrari.Location.Y);
        }
    }
}
