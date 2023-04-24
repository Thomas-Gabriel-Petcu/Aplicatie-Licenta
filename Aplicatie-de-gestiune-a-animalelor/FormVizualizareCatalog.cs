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
    public partial class FormVizualizareCatalog : Form
    {
        public FormVizualizareCatalog()
        {
            InitializeComponent();
        }

        private void FormVizualizareCatalog_Load(object sender, EventArgs e)
        {
            DatabaseManager dbManager = DatabaseManager.GetInstance();
            string query = "SELECT * FROM Animale";
            SQLiteConnection con = dbManager.GetConnection();
            using (SQLiteCommand command = new SQLiteCommand(query, con))
            {
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    DataSet set = new DataSet();
                    adapter.Fill(set, "animals");
                    dataGridView1.DataSource = set.Tables["Animale"];
                }
            }
        }
    }
}
