using Aplicatie_de_gestiune_a_animalelor.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie_de_gestiune_a_animalelor
{
    public partial class FormEditareCatalog : Form
    {
        DatabaseManager databaseManager = DatabaseManager.GetInstance();
        AnimalSettings animalSettings = new AnimalSettings();
        public FormEditareCatalog()
        {
            InitializeComponent();
            foreach (var item in AnimalTypes.Types)
            {
                comboBoxSpecie.Items.Add(item.Key);
            }
            RefreshDataGridView();
        }
        private bool ValidateInputs()
        {
            if (comboBoxSpecie.SelectedIndex == -1)
            {
                MessageBox.Show("Nu ati selectat specia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBoxRasa.Text == "")
            {
                MessageBox.Show("Nu ati specificat rasa!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBoxVarsta.Text == "")
            {
                MessageBox.Show("Nu ati specificat varsta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!checkBoxSexM.Checked && !checkBoxSexF.Checked)
            {
                MessageBox.Show("Nu ati selectat sexul animalului!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBoxGreutate.Text == "")
            {
                MessageBox.Show("Nu ati specificat greutatea!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!checkBoxVaccinatDa.Checked && !checkBoxVaccinatNu.Checked)
            {
                MessageBox.Show("Nu ati specificat starea vaccinarii!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!checkBoxSterDa.Checked && !checkBoxSterNu.Checked)
            {
                MessageBox.Show("Nu ati specificat daca animalul este sterilizat sau nu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBoxNume.Text == "")
            {
                MessageBox.Show("Nu ati specificat numele!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(textBoxVarsta.Text, out int l_age) || l_age <= 0)
            {
                MessageBox.Show($"Varsta nu poate fi \"{textBoxVarsta.Text}\". Doar numere intregi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!double.TryParse(textBoxGreutate.Text, out double l_weight) || l_weight <= 0)
            {
                MessageBox.Show($"Greutatea nu poate fi \"{textBoxGreutate.Text}\". Doar valori numerice!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            textBoxRasa.Text = textBoxRasa.Text.Replace(" ", "");
            textBoxVarsta.Text = textBoxVarsta.Text.Replace(" ", "");
            textBoxGreutate.Text = textBoxGreutate.Text.Replace(" ", "");
            textBoxNume.Text = textBoxNume.Text.Replace(" ", "");
            if (!ValidateInputs())
                return;
            //passed guard clauses
            string species = comboBoxSpecie.SelectedItem.ToString();
            string race = textBoxRasa.Text;
            string name = textBoxNume.Text;
            int age = int.Parse(textBoxVarsta.Text);
            string sex = checkBoxSexM.Checked ? "M" : "F";
            double weight = double.Parse(textBoxGreutate.Text);
            string vaccinated = checkBoxVaccinatDa.Checked ? "DA" : "NU";
            string ster = checkBoxSterDa.Checked ? "DA" : "NU";
            string pathPicture = "default";
            string query = $"INSERT into Animale (Specie,Rasa,Nume,Varsta,Sex,Greutate,Vaccinat,Sterilizat,PathPoza) VALUES ('{species}','{race}','{name}','{age}','{sex}','{weight}','{vaccinated}','{ster}','{pathPicture}');";
            using (SQLiteConnection con = databaseManager.GetConnection())
            using (SQLiteCommand command = new SQLiteCommand(query, con))
            {
                con.Open();
                command.ExecuteNonQuery();
            }
            RefreshDataGridView();

            MessageBox.Show("S-a adaugat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void RefreshDataGridView()
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
        private void dataGridViewAnimale_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewAnimale.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewAnimale.SelectedRows[0];
                string species = row.Cells["Specie"].Value.ToString();
                string race = row.Cells["Rasa"].Value.ToString();
                int age = Convert.ToInt32(row.Cells["Varsta"].Value);
                string sex = row.Cells["Sex"].Value.ToString();
                int weight = Convert.ToInt32(row.Cells["Greutate"].Value);
                string vacc = row.Cells["Vaccinat"].Value.ToString();
                string ster = row.Cells["Sterilizat"].Value.ToString();
                string name = row.Cells["Nume"].Value.ToString();

                comboBoxSpecie.SelectedItem = species;
                textBoxRasa.Text = race;
                textBoxVarsta.Text = age.ToString();
                checkBoxSexM.Checked = sex == "M";
                checkBoxSexF.Checked = sex == "F";
                textBoxGreutate.Text = weight.ToString();
                checkBoxVaccinatDa.Checked = vacc == "DA";
                checkBoxVaccinatNu.Checked = vacc == "NU";
                checkBoxSterDa.Checked = ster == "DA";
                checkBoxSterNu.Checked = ster == "NU";
                textBoxNume.Text = name;
            }
        }
        private void buttonSterge_Click(object sender, EventArgs e)
        {
            if (dataGridViewAnimale.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Nu ati selectat niciun rand pentru stergere!", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Suneti sigur ca vreti sa stergeti?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;
            DataGridViewRow row = dataGridViewAnimale.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["IDAnimal"].Value);
            string query = $"DELETE FROM Animale WHERE IDAnimal = {id}";
            using (SQLiteConnection con = databaseManager.GetConnection())
            using (SQLiteCommand cmd = new SQLiteCommand(query, con))
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            RefreshDataGridView();
        }
        private void buttonModifica_Click(object sender, EventArgs e)
        {
            if (dataGridViewAnimale.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Nu ati selectat niciun rand pentru modificare!", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateInputs())
                return;
            DataGridViewRow row = dataGridViewAnimale.SelectedRows[0];
            int id =Convert.ToInt32(row.Cells["IDAnimal"].Value);
            string sex = checkBoxSexM.Checked ? "M" : "F";
            string vacc = checkBoxVaccinatDa.Checked ? "DA" : "NU";
            string ster = checkBoxSterDa.Checked ? "DA" : "NU";
            double greutate = double.Parse(textBoxGreutate.Text);
            string path = "default";
            string query = $"UPDATE Animale SET Specie = '{comboBoxSpecie.SelectedItem}',Rasa = '{textBoxRasa.Text}', Nume = '{textBoxNume.Text}', Varsta = '{textBoxVarsta.Text}', Sex = '{sex}', Greutate = '{greutate}', Vaccinat = '{vacc}', Sterilizat = '{ster}', PathPoza = '{path}' WHERE IDAnimal = {id}";

            using(SQLiteConnection con = databaseManager.GetConnection())
            using(SQLiteCommand command = new SQLiteCommand(query, con))
            {
                con.Open();
                command.ExecuteNonQuery();
            }
            RefreshDataGridView();
        }
    }
}
