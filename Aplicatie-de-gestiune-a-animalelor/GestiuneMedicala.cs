using Aplicatie_de_gestiune_a_animalelor.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie_de_gestiune_a_animalelor
{
    public partial class GestiuneMedicala : Form
    {
        string imagePath = "";
        FormInstructiuniGestiuneMedicala instructiuni = new FormInstructiuniGestiuneMedicala();
        DatabaseManager databaseManager = DatabaseManager.GetInstance();
        MainMenuForm menu;
        public GestiuneMedicala(MainMenuForm menu)
        {
            InitializeComponent();
            this.menu = menu;
            foreach (var item in AnimalTypes.Types)
            {
                comboBoxSpecie.Items.Add(item.Key);
            }
        }

        private void GestiuneMedicala_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void GestiuneMedicala_Shown(object sender, EventArgs e)
        {
            RefreshDataGridViewAnimale();
            RefreshFiseMedicale();
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
        private void RefreshFiseMedicale()
        {
            string query = "SELECT strftime('%dd.%MM.%yyyy %HH:%mm:%ss', DataConsult) AS FormattedDataFactura, *FROM FiseMedicale";
            using (SQLiteConnection con = databaseManager.GetConnection())
            using (SQLiteCommand command = new SQLiteCommand(query, con))
            {
                con.Open();
                using (var reader = command.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();

                    dataTable.Columns.Add("IDFisaMedicala");
                    dataTable.Columns.Add("IDAnimal");
                    dataTable.Columns.Add("NumarFisaMedicala");
                    dataTable.Columns.Add("DataConsult");
                    dataTable.Columns.Add("Diagnostic");
                    dataTable.Columns.Add("Tratament");
                    while (reader.Read())
                    {
                        int idFisaMedicala = reader.GetInt32(reader.GetOrdinal("IDFisaMedicala"));
                        int idAnimal = reader.GetInt32(reader.GetOrdinal("IDAnimal"));
                        string numarFisaMedicala = reader.GetString(reader.GetOrdinal("NumarFisaMedicala"));
                        string dateTimeStr = reader.GetString(reader.GetOrdinal("DataConsult"));
                        string diagnostic = reader.GetString(reader.GetOrdinal("Diagnostic"));
                        string tratament = reader.GetString(reader.GetOrdinal("Tratament"));

                        DateTime dateTime = DateTime.ParseExact(dateTimeStr, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                        dataTable.Rows.Add(reader["IDFisaMedicala"], idAnimal, numarFisaMedicala, dateTime, diagnostic, tratament);
                    }
                    dataGridViewFiseMedicale.DataSource = dataTable;
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
        private bool ValidateAnimalInputs()
        {
            if (comboBoxSpecie.SelectedIndex == -1)
            {
                MessageBox.Show("Nu ati selectat specia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBoxRasa.Text == "" || textBoxRasa.Text == " ")
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
            if (!float.TryParse(textBoxGreutate.Text, out float l_weight) || l_weight <= 0)
            {
                MessageBox.Show($"Greutatea nu poate fi \"{textBoxGreutate.Text}\". Doar valori numerice pozitive!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool ValidateMedicalRecordInputs()
        {
            if (textBoxDiagnostic.Text == "")
            {
                MessageBox.Show("Nu ati specificat diagnosticul!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBoxTratament.Text == "")
            {
                MessageBox.Show("Nu ati specificat tratamentul!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBoxNumarFisa.Text == "")
            {
                MessageBox.Show("Nu ati specificat numarul fisei de control medical!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void dataGridViewAnimale_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewAnimale.SelectedRows.Count > 0 && dataGridViewAnimale.SelectedRows[0].Index != dataGridViewAnimale.Rows.Count - 1)
            {

                DataGridViewRow row = dataGridViewAnimale.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells["IDAnimal"].Value);
                string species = row.Cells["Specie"].Value.ToString();
                string race = row.Cells["Rasa"].Value.ToString();
                int age = Convert.ToInt32(row.Cells["Varsta"].Value);
                string sex = row.Cells["Sex"].Value.ToString();
                float.TryParse(row.Cells["Greutate"].Value.ToString(), out float weight);
                string vacc = row.Cells["Vaccinat"].Value.ToString();
                string ster = row.Cells["Sterilizat"].Value.ToString();
                string name = row.Cells["Nume"].Value.ToString();
                string imgPath = row.Cells["PathPoza"].Value.ToString();

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
                if (!File.Exists(imgPath))
                {
                    pictureBox1.Image = null;
                }
                else
                {
                    pictureBox1.Image = Image.FromFile(imgPath);
                    imagePath = imgPath;
                }
            }
        }
        private void dataGridViewFiseMedicale_SelectionChanged(object sender, EventArgs e)
        {
            int targetID = 0;
            if (dataGridViewFiseMedicale.SelectedRows.Count > 0 && dataGridViewFiseMedicale.SelectedRows[0].Index != dataGridViewFiseMedicale.Rows.Count - 1)
            {

                DataGridViewRow row = dataGridViewFiseMedicale.SelectedRows[0];
                string medicalRecordNr = row.Cells["NumarFisaMedicala"].Value.ToString();
                string diagnostic = row.Cells["Diagnostic"].Value.ToString();
                string treatment = row.Cells["Tratament"].Value.ToString();
                DateTime.TryParse(row.Cells["DataConsult"].Value.ToString(), out DateTime datetime);
                dateTimePickerData.Text = datetime.Date.ToString();
                dateTimePickerOra.Text = datetime.TimeOfDay.ToString();
                textBoxNumarFisa.Text = medicalRecordNr;
                textBoxDiagnostic.Text = diagnostic;
                textBoxTratament.Text = treatment;
                targetID = Convert.ToInt32(row.Cells["IDAnimal"].Value);
            }
            foreach (DataGridViewRow row in dataGridViewAnimale.Rows)
            {
                int currentID = Convert.ToInt32(row.Cells["IDAnimal"].Value);
                if (currentID == targetID)
                {
                    row.Selected = true;
                    dataGridViewAnimale.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
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

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            textBoxRasa.Text = textBoxRasa.Text.Replace(" ", "");
            textBoxVarsta.Text = textBoxVarsta.Text.Replace(" ", "");
            textBoxGreutate.Text = textBoxGreutate.Text.Replace(" ", "");
            textBoxNume.Text = textBoxNume.Text.Replace(" ", "");
            if (!ValidateAnimalInputs())
                return;
            if (!ValidateMedicalRecordInputs())
                return;

            if (dataGridViewAnimale.SelectedRows.Count == 0 || dataGridViewAnimale.SelectedRows[0].Index == dataGridViewAnimale.Rows.Count - 1)
            {
                MessageBox.Show("Nu ati selectat animalul prevazut de fisa!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Sigur vreti sa adaugati?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;
            DataGridViewRow row = dataGridViewAnimale.SelectedRows[0];
            int idAnimal = Convert.ToInt32(row.Cells["IDAnimal"].Value);
            string path = row.Cells["PathPoza"].Value.ToString();
            string species = comboBoxSpecie.SelectedItem.ToString();
            string race = textBoxRasa.Text;
            string name = textBoxNume.Text;
            int age = int.Parse(textBoxVarsta.Text);
            string sex = checkBoxSexM.Checked ? "M" : "F";
            float weight = float.Parse(textBoxGreutate.Text);
            string vaccinated = checkBoxVaccinatDa.Checked ? "DA" : "NU";
            string ster = checkBoxSterDa.Checked ? "DA" : "NU";
            DateTime selectedDate = dateTimePickerData.Value.Date;
            TimeSpan selectedTime = dateTimePickerOra.Value.TimeOfDay;
            DateTime selectedDateTime = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, selectedTime.Hours, selectedTime.Minutes, 0);

            string queryAnimal = $"UPDATE Animale SET Specie = '{species}',Rasa = '{race}', Nume = '{name}'," +
           $" Varsta = '{age}', Sex = '{sex}', Greutate = '{weight}', Vaccinat = '{vaccinated}', Sterilizat = '{ster}', PathPoza = '{path}'" +
           $" WHERE IDAnimal = {idAnimal}";

            string diagnostic = textBoxDiagnostic.Text;
            string treatment = textBoxTratament.Text;
            string queryMedicalRecord = $"INSERT INTO FiseMedicale (IDAnimal,NumarFisaMedicala,DataConsult,Diagnostic,Tratament) VALUES('{idAnimal}','{textBoxNumarFisa.Text}','{selectedDateTime}','{diagnostic}','{treatment}')";
            using (SQLiteConnection con = databaseManager.GetConnection())
            using (SQLiteCommand command = new SQLiteCommand(queryAnimal, con))
            using (SQLiteCommand commandMedicalRecord = new SQLiteCommand(queryMedicalRecord, con))
            {
                con.Open();
                command.ExecuteNonQuery();
                commandMedicalRecord.ExecuteNonQuery();
            }
            RefreshDataGridViewAnimale();
            RefreshFiseMedicale();
            MessageBox.Show("S-a adaugat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonModifica_Click(object sender, EventArgs e)
        {
            if (!(dataGridViewFiseMedicale.SelectedRows.Count > 0) || dataGridViewFiseMedicale.SelectedRows[0].Index == dataGridViewFiseMedicale.Rows.Count - 1)
            {
                MessageBox.Show("Nu ati selectat niciun rand pentru modificare!", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateAnimalInputs())
                return;
            if (!ValidateMedicalRecordInputs())
                return;
            DialogResult result = MessageBox.Show("Sigur vreti sa modificati?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;
            DataGridViewRow row = dataGridViewFiseMedicale.SelectedRows[0];
            int idAnimal = Convert.ToInt32(row.Cells["IDAnimal"].Value);
            int idMedicalRecord = Convert.ToInt32(row.Cells["IDFisaMedicala"].Value);
            string sex = checkBoxSexM.Checked ? "M" : "F";
            string vacc = checkBoxVaccinatDa.Checked ? "DA" : "NU";
            string ster = checkBoxSterDa.Checked ? "DA" : "NU";
            float greutate = float.Parse(textBoxGreutate.Text);
            string path = imagePath;
            DateTime selectedDate = dateTimePickerData.Value.Date;
            TimeSpan selectedTime = dateTimePickerOra.Value.TimeOfDay;
            DateTime dateTime = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, selectedTime.Hours, selectedTime.Minutes, selectedTime.Seconds);

            string queryAnimal = $"UPDATE Animale SET Specie = '{comboBoxSpecie.SelectedItem}',Rasa = '{textBoxRasa.Text}', Nume = '{textBoxNume.Text}'," +
            $" Varsta = '{textBoxVarsta.Text}', Sex = '{sex}', Greutate = '{greutate}', Vaccinat = '{vacc}', Sterilizat = '{ster}', PathPoza = '{path}'" +
            $" WHERE IDAnimal = {idAnimal}";
            string queryMedicalRecord = $"UPDATE FiseMedicale SET IDAnimal = '{idAnimal}', NumarFisaMedicala = '{textBoxNumarFisa.Text}', DataConsult = '{dateTime}', Diagnostic = '{textBoxDiagnostic.Text}', Tratament = '{textBoxTratament.Text}' WHERE IDFisaMedicala = '{idMedicalRecord}'";
            using (SQLiteConnection con = databaseManager.GetConnection())
            using (SQLiteCommand command = new SQLiteCommand(queryAnimal, con))
            using (SQLiteCommand commandMedicalRecord = new SQLiteCommand(queryMedicalRecord, con))
            {
                con.Open();
                command.ExecuteNonQuery();
                commandMedicalRecord.ExecuteNonQuery();
            }
            MessageBox.Show("S-a modificat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshDataGridViewAnimale();
            RefreshFiseMedicale();
        }
        private void buttonSterge_Click(object sender, EventArgs e)
        {
            if (!(dataGridViewFiseMedicale.SelectedRows.Count > 0) || dataGridViewFiseMedicale.SelectedRows[0].Index == dataGridViewFiseMedicale.Rows.Count - 1)
            {
                MessageBox.Show("Nu ati selectat fisa pentru stergere!", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Sigur vreti sa stergeti fisa de control?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;
            DataGridViewRow row = dataGridViewFiseMedicale.SelectedRows[0];
            int idRecord = Convert.ToInt32(row.Cells["IDFisaMedicala"].Value);
            string query = $"DELETE FROM FiseMedicale WHERE IDFisaMedicala = '{idRecord}'";
            using (SQLiteConnection con = databaseManager.GetConnection())
            using (SQLiteCommand command = new SQLiteCommand(query, con))
            {
                con.Open();
                command.ExecuteNonQuery();
            }
            RefreshFiseMedicale();
        }


        private void buttonInstructiuni_Click(object sender, EventArgs e)
        {
            if (instructiuni.IsDisposed)
            {
                instructiuni = new FormInstructiuniGestiuneMedicala();
            }
            instructiuni.Show();
            instructiuni.TopMost = true;
        }

        private void dataGridViewAnimale_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewAnimale.SelectedRows[0].Index == dataGridViewAnimale.Rows.Count - 1)
            {
                MessageBox.Show("Nu se poate genera raport pentru un rand gol!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow row = dataGridViewAnimale.SelectedRows[0];
            int idAnimal = Convert.ToInt32(row.Cells["IDAnimal"].Value);
            FormIstoricMedicalAnimal istoricMedical = new FormIstoricMedicalAnimal(idAnimal);
            istoricMedical.Show();
        }

        private void dataGridViewFiseMedicale_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewFiseMedicale.SelectedRows[0].Index == dataGridViewFiseMedicale.Rows.Count - 1)
            {
                MessageBox.Show("Nu se poate genera raport pentru un rand gol!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow row = dataGridViewFiseMedicale.SelectedRows[0];
            int idAnimal = Convert.ToInt32(row.Cells["IDAnimal"].Value);
            int idRecord = Convert.ToInt32(row.Cells["IDFisaMedicala"].Value);
            FormFisaMedicala fisaMedicala = new FormFisaMedicala(idAnimal, idRecord);
            fisaMedicala.Show();
        }
    }
}