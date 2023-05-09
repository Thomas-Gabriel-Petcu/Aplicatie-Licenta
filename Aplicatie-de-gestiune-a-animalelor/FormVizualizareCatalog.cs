using Aplicatie_de_gestiune_a_animalelor.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
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
        string imagePath = "";
        MainMenuForm menu;
        DatabaseManager databaseManager = DatabaseManager.GetInstance();
        public FormVizualizareCatalog(MainMenuForm menu)
        {
            this.menu = menu;
            InitializeComponent();
            foreach (var item in AnimalTypes.Types)
            {
                comboBoxSpecie.Items.Add(item.Key);
            }
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
        private void RefreshDataGridViewAnimale(string s)
        {
            string query = s;
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
        private void FormVizualizareCatalog_ResizeBegin(object sender, EventArgs e)
        {
            //int padding = -70;
            //panel1.Location = new Point((this.ClientSize.Width - panel1.Width - padding) / 2, panel1.Location.Y);
            //labelFiltre.Location = new Point((this.ClientSize.Width - labelFiltre.Width - padding) / 2, labelFiltre.Location.Y);

        }

        private void buttonCautare_Click(object sender, EventArgs e)
        {
            textBoxRasa.Text = textBoxRasa.Text.Replace(" ", "");

            List<string> conditions = new List<string>();
            string query = "";
            if (comboBoxSpecie.SelectedIndex != -1)
            {
                conditions.Add($"Specie = '{comboBoxSpecie.SelectedItem}'");
            }
            if (textBoxRasa.Text != "")
            {
                conditions.Add($"Rasa = '{textBoxRasa.Text}'");
            }
            if (checkBoxVarstaMaiMic.Checked)
            {
                conditions.Add($"Varsta < {textBoxVarsta.Text}");
            }
            if (checkBoxVarstaMaiMare.Checked)
            {
                conditions.Add($"Varsta > {textBoxVarsta.Text}");
            }
            if (checkBoxSexM.Checked)
            {
                conditions.Add($"Sex = 'M'");
            }
            if (checkBoxSexF.Checked)
            {
                conditions.Add($"Sex = 'F'");
            }
            if (checkBoxGreutateMaiMic.Checked)
            {
                conditions.Add($"Greutate < {textBoxGreutate.Text}");
            }
            if (checkBoxGreutateMaiMare.Checked)
            {
                conditions.Add($"Greutate > {textBoxGreutate.Text}");
            }
            if (checkBoxVaccinatDa.Checked)
            {
                conditions.Add($"Vaccinat = 'DA'");
            }
            if (checkBoxVaccinatNu.Checked)
            {
                conditions.Add($"Vaccinat = 'NU'");
            }
            if (checkBoxSterDa.Checked)
            {
                conditions.Add($"Sterilizat = 'DA'");
            }
            if (checkBoxSterNu.Checked)
            {
                conditions.Add($"Sterilizat = 'NU'");
            }

            if (conditions.Count == 0)
            {
                query = "SELECT * FROM Animale";
            }
            else if (conditions.Count == 1)
            {
                query = $"SELECT * FROM Animale WHERE {conditions[0]}";
            }
            else
            {
                string s = "";
                //more than one condition, must use AND
                for (int i = 1; i < conditions.Count; i++)//skip first condition
                {
                    s += $" AND {conditions[i]}";
                }
                query = $"SELECT * FROM Animale WHERE {conditions[0]}" + s;
            }
            RefreshDataGridViewAnimale(query);
        }
        private void checkBoxVarstaMaiMic_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVarstaMaiMic.Checked)
            {
                checkBoxVarstaMaiMare.Checked = false;
            }
        }
        private void checkBoxVarstaMaiMare_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVarstaMaiMare.Checked)
            {
                checkBoxVarstaMaiMic.Checked = false;
            }
        }
        private void checkBoxGreutateMaiMic_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGreutateMaiMic.Checked)
            {
                checkBoxGreutateMaiMare.Checked = false;
            }
        }
        private void checkBoxGreutateMaiMare_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGreutateMaiMare.Checked)
            {
                checkBoxGreutateMaiMic.Checked = false;
            }
        }
        private void checkBoxVaccinatDa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVaccinatDa.Checked)
            {
                checkBoxVaccinatNu.Checked = false;
            }
        }
        private void checkBoxVaccinatNu_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVaccinatNu.Checked)
            {
                checkBoxVaccinatDa.Checked = false;
            }
        }
        private void checkBoxSterDa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSterDa.Checked)
            {
                checkBoxSterNu.Checked = false;
            }
        }
        private void checkBoxSterNu_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSterNu.Checked)
            {
                checkBoxSterDa.Checked = false;
            }
        }
        private void checkBoxSexM_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSexM.Checked)
            {
                checkBoxSexF.Checked = false;
            }
        }
        private void checkBoxSexF_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSexF.Checked)
            {
                checkBoxSexM.Checked = false;
            }
        }
        private void buttonResetareFiltre_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sigur vreti sa resetati filtrele?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;
            comboBoxSpecie.SelectedItem = null;
            textBoxRasa.Text = string.Empty;
            checkBoxVarstaMaiMic.Checked = false;
            checkBoxVarstaMaiMare.Checked = false;
            textBoxVarsta.Text = string.Empty;
            checkBoxSexM.Checked = false;
            checkBoxSexF.Checked = false;
            checkBoxGreutateMaiMic.Checked = false;
            checkBoxGreutateMaiMare.Checked = false;
            textBoxGreutate.Text = string.Empty;
            checkBoxVaccinatDa.Checked = false;
            checkBoxVaccinatNu.Checked = false;
            checkBoxSterDa.Checked = false;
            checkBoxSterNu.Checked = false;
            pictureBox1.Image = null;
        }
        private void dataGridViewAnimale_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewAnimale.SelectedRows.Count > 0 && dataGridViewAnimale.SelectedRows[0].Index != dataGridViewAnimale.Rows.Count - 1)
            {
                DataGridViewRow row = dataGridViewAnimale.SelectedRows[0];
                string imgPath = row.Cells["PathPoza"].Value.ToString();

                if (File.Exists(imgPath))
                {
                    pictureBox1.Image = Image.FromFile(imgPath);
                    imagePath = imgPath;
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }

        }

        private void buttonMeniu_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Hide();
        }
    }
}
