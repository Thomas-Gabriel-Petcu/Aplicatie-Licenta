using Aplicatie_de_gestiune_a_animalelor.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SQLite;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Aplicatie_de_gestiune_a_animalelor
{
    public partial class FormEditareCatalog : Form
    {
        string imagePath = "";
        int timeStep = 10;
        MainMenuForm menu;
        DatabaseManager databaseManager = DatabaseManager.GetInstance();
        public FormEditareCatalog(MainMenuForm menu)
        {
            this.menu = menu;
            InitializeComponent();
            foreach (var item in AnimalTypes.Types)
            {
                comboBoxSpecie.Items.Add(item.Key);
            }
            RefreshDataGridViewAnimale();
            RefreshDataGridViewProgramari();
        }
        private bool ValidateInputs()
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
            if (imagePath == "")
            {
                MessageBox.Show("Nu ati specificat poza!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            textBoxRasa.Text = textBoxRasa.Text.Replace(" ", "");
            textBoxVarsta.Text = textBoxVarsta.Text.Replace(" ", "");
            textBoxGreutate.Text = textBoxGreutate.Text.Replace(" ", "");
            textBoxNume.Text = textBoxNume.Text.Replace(" ", "");
            if (!ValidateInputs())
                return;

            string species = comboBoxSpecie.SelectedItem.ToString();
            string race = textBoxRasa.Text;
            string name = textBoxNume.Text;
            int age = int.Parse(textBoxVarsta.Text);
            string sex = checkBoxSexM.Checked ? "M" : "F";
            float weight = float.Parse(textBoxGreutate.Text);
            string vaccinated = checkBoxVaccinatDa.Checked ? "DA" : "NU";
            string ster = checkBoxSterDa.Checked ? "DA" : "NU";

            string query = $"INSERT into Animale (Specie,Rasa,Nume,Varsta,Sex,Greutate,Vaccinat,Sterilizat,PathPoza) VALUES" +
            $" ('{species}','{race}','{name}','{age}','{sex}','{weight}','{vaccinated}','{ster}','{imagePath}');";
            using (SQLiteConnection con = databaseManager.GetConnection())
            using (SQLiteCommand command = new SQLiteCommand(query, con))
            {
                con.Open();
                command.ExecuteNonQuery();
            }
            RefreshDataGridViewAnimale();
            MessageBox.Show("S-a adaugat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearBoxes();
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
        private void RefreshDataGridViewProgramari(string s)
        {
            string query = "SELECT strftime('%dd.%MM.%yyyy %HH:%mm:%ss', DataProgramarii) AS FormattedDataProgramarii, * FROM Programari" + s;
            using (SQLiteConnection con = databaseManager.GetConnection())
            using (SQLiteCommand command = new SQLiteCommand(query, con))
            {
                con.Open();
                using (var reader = command.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();

                    dataTable.Columns.Add("IDProgramare");
                    dataTable.Columns.Add("IDAnimal");
                    dataTable.Columns.Add("DataProgramarii");
                    dataTable.Columns.Add("Detalii");
                    while (reader.Read())
                    {
                        int idAnimal = reader.GetInt32(reader.GetOrdinal("IDAnimal"));
                        string dateTimeStr = reader.GetString(reader.GetOrdinal("DataProgramarii"));
                        string details = reader.GetString(reader.GetOrdinal("Detalii"));
                        DateTime dateTime = DateTime.ParseExact(dateTimeStr, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                        dataTable.Rows.Add(reader["IDProgramare"], idAnimal, dateTime, details);
                    }
                    dataGridViewProgramari.DataSource = dataTable;
                }
            }
        }
        private void RefreshDataGridViewProgramari()
        {
            string query = "SELECT strftime('%dd.%MM.%yyyy %HH:%mm:%ss', DataProgramarii) AS FormattedDataProgramarii, *FROM Programari";
            using (SQLiteConnection con = databaseManager.GetConnection())
            using (SQLiteCommand command = new SQLiteCommand(query, con))
            {
                con.Open();
                using (var reader = command.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();

                    dataTable.Columns.Add("IDProgramare");
                    dataTable.Columns.Add("IDAnimal");
                    dataTable.Columns.Add("DataProgramarii");
                    dataTable.Columns.Add("Detalii");
                    while (reader.Read())
                    {
                        int idAnimal = reader.GetInt32(reader.GetOrdinal("IDAnimal"));
                        string dateTimeStr = reader.GetString(reader.GetOrdinal("DataProgramarii"));
                        string details = reader.GetString(reader.GetOrdinal("Detalii"));
                        DateTime dateTime = DateTime.ParseExact(dateTimeStr, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                        dataTable.Rows.Add(reader["IDProgramare"], idAnimal, dateTime, details);
                    }
                    dataGridViewProgramari.DataSource = dataTable;
                    dataGridViewProgramari.CellFormatting += DataGridViewProgramari_CellFormatting;
                }
            }
        }
        private void DataGridViewProgramari_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewProgramari.Columns["DataProgramarii"].Index)
            {
                if (e.Value != null && !string.IsNullOrEmpty(e.Value.ToString()))
                {
                    string dateTimeStr = e.Value.ToString();
                    DateTime appointmentDateTime;
                    if (DateTime.TryParseExact(dateTimeStr, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out appointmentDateTime))
                    {
                        if (appointmentDateTime < DateTime.Now)
                        {
                            e.CellStyle.BackColor = Color.Crimson;
                        }
                    }
                }
            }
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
                string s = $" WHERE IDAnimal = '{id}'";
                RefreshDataGridViewProgramari(s);
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
            MessageBox.Show("S-a sters cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshDataGridViewAnimale();
            ClearBoxes();
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
            int id = Convert.ToInt32(row.Cells["IDAnimal"].Value);
            string sex = checkBoxSexM.Checked ? "M" : "F";
            string vacc = checkBoxVaccinatDa.Checked ? "DA" : "NU";
            string ster = checkBoxSterDa.Checked ? "DA" : "NU";
            float greutate = float.Parse(textBoxGreutate.Text);
            Debug.WriteLine(greutate);
            string path = imagePath;
            string query = $"UPDATE Animale SET Specie = '{comboBoxSpecie.SelectedItem}',Rasa = '{textBoxRasa.Text}', Nume = '{textBoxNume.Text}'," +
            $" Varsta = '{textBoxVarsta.Text}', Sex = '{sex}', Greutate = '{greutate}', Vaccinat = '{vacc}', Sterilizat = '{ster}', PathPoza = '{path}'" +
            $" WHERE IDAnimal = {id}";

            using (SQLiteConnection con = databaseManager.GetConnection())
            using (SQLiteCommand command = new SQLiteCommand(query, con))
            {
                con.Open();
                command.ExecuteNonQuery();
            }
            MessageBox.Show("S-a modificat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshDataGridViewAnimale();
        }
        private void buttonPoza_Click(object sender, EventArgs e)
        {
            OpenFileDialog picturePicker = new OpenFileDialog();
            picturePicker.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif) | *.jpg; *.jpeg; *.png; *.gif";
            if (picturePicker.ShowDialog() == DialogResult.OK)
            {
                imagePath = picturePicker.FileName;
                // Display the selected image in a PictureBox (optional)
                pictureBox1.Image = Image.FromFile(imagePath);
            }
        }
        private void ClearBoxes()
        {
            comboBoxSpecie.SelectedItem = null;
            textBoxRasa.Text = "";
            textBoxVarsta.Text = "";
            checkBoxSexM.Checked = false;
            checkBoxSexF.Checked = false;
            textBoxGreutate.Text = "";
            checkBoxVaccinatDa.Checked = false;
            checkBoxVaccinatNu.Checked = false;
            checkBoxSterDa.Checked = false;
            checkBoxSterNu.Checked = false;
            textBoxNume.Text = "";
            imagePath = "";
            pictureBox1.Image = null;
        }
        private void buttonMeniu_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }
        private void buttonAdaugaProg_Click(object sender, EventArgs e)
        {
            if (dataGridViewAnimale.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Nu ati selectat niciun animal pentru programare!", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxDetaliiProg.Text == "")
            {
                MessageBox.Show("Nu ati specificat detalii pentru programare!", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DateTime selectedDate = dateTimePickerData.Value.Date;
            TimeSpan selectedTime = dateTimePickerOra.Value.TimeOfDay;
            DateTime selectedDateTime = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, selectedTime.Hours, selectedTime.Minutes, 0);
            if (selectedDate < DateTime.Now.Date)
            {
                MessageBox.Show("Data selectata a trecut, nu s-a inregistrat!", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (selectedDate == DateTime.Now.Date && selectedTime < DateTime.Now.TimeOfDay)
            {
                MessageBox.Show("Ora selectata a trecut, nu s-a inregistrat!", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var overlaps = GetOverlappingAppointments(selectedDateTime);
            switch (overlaps.Count)
            {
                case 1:
                    MessageBox.Show($"Aceasta ora se suprapune cu programarea de la ora {overlaps[0]}. Pasul orar este de {timeStep} minute.", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                case 2:
                    MessageBox.Show($"Aceasta ora se suprapune cu programarile de la orele: {overlaps[0]} si {overlaps[1]}. Pasul orar este de {timeStep} minute.", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                case 0:
                    goto skip;
                default:
                    break;
            }
        skip:
            int IDAnimal = Convert.ToInt32(dataGridViewAnimale.SelectedRows[0].Cells["IDAnimal"].Value);
            string query = $"INSERT into Programari (IDAnimal,DataProgramarii,Detalii) VALUES ('{IDAnimal}','{selectedDateTime}','{textBoxDetaliiProg.Text}')";
            using (SQLiteConnection con = databaseManager.GetConnection())
            using (SQLiteCommand com = new SQLiteCommand(query, con))
            {
                con.Open();
                com.ExecuteNonQuery();
            }
            dataGridViewProgramari.ClearSelection();
            MessageBox.Show("S-a adaugat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshDataGridViewProgramari();
        }
        private List<DateTime> GetOverlappingAppointments(DateTime selectedDateTime)
        {
            List<DateTime> overlappingAppointments = new List<DateTime>();
            DateTime startDateTime = selectedDateTime.AddMinutes(-timeStep);
            DateTime endDateTime = selectedDateTime.AddMinutes(timeStep);

            string query = $"SELECT DataProgramarii FROM Programari WHERE DataProgramarii >= '{startDateTime}' AND DataProgramarii <= '{endDateTime}'";

            using (SQLiteConnection con = databaseManager.GetConnection())
            using (SQLiteCommand command = new SQLiteCommand(query, con))
            {
                con.Open();

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string dateTimeStr = reader.GetString(reader.GetOrdinal("DataProgramarii"));
                        DateTime appointmentDateTime = DateTime.ParseExact(dateTimeStr, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                        overlappingAppointments.Add(appointmentDateTime);
                    }
                }
            }

            return overlappingAppointments;
        }
        private void dataGridViewProgramari_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewProgramari.SelectedRows.Count > 0 && dataGridViewProgramari.SelectedRows[0].Index != dataGridViewProgramari.Rows.Count - 1)
            {
                DataGridViewRow row = dataGridViewProgramari.SelectedRows[0];
                string details = row.Cells["Detalii"].Value.ToString();
                DateTime.TryParse(row.Cells["DataProgramarii"].Value.ToString(), out DateTime datetime);

                dateTimePickerData.Text = datetime.Date.ToString();
                dateTimePickerOra.Text = datetime.TimeOfDay.ToString();
                textBoxDetaliiProg.Text = details;
            }
        }
        private void buttonModifProg_Click(object sender, EventArgs e)
        {
            if (dataGridViewProgramari.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Nu ati selectat programarea de modificat!", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DataGridViewRow row = dataGridViewProgramari.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["IDProgramare"].Value);
            DateTime selectedDate = dateTimePickerData.Value.Date;
            TimeSpan selectedTime = dateTimePickerOra.Value.TimeOfDay;
            DateTime dateTime = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, selectedTime.Hours, selectedTime.Minutes, selectedTime.Seconds);
            var overlaps = GetOverlappingAppointments(dateTime);
            switch (overlaps.Count)
            {
                case 1:
                    MessageBox.Show($"Aceasta ora se suprapune cu programarea de la ora {overlaps[0]}." +
                    $" Pasul orar este de {timeStep} minute.", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                case 2:
                    MessageBox.Show($"Aceasta ora se suprapune cu programarile de la orele: {overlaps[0]} si {overlaps[1]}." +
                    $" Pasul orar este de {timeStep} minute.", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                case 0:
                    goto modify;
                default:
                    break;
            }
        modify:
            string query = $"UPDATE Programari SET DataProgramarii = '{dateTime}', Detalii = '{textBoxDetaliiProg.Text}' WHERE IDProgramare = '{id}'";
            using SQLiteConnection con = databaseManager.GetConnection();
            using SQLiteCommand command = new SQLiteCommand(query, con);
            {
                con.Open();
                command.ExecuteNonQuery();
            }
            MessageBox.Show("S-a modificat cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshDataGridViewProgramari();
        }
        private void buttonStergeProg_Click(object sender, EventArgs e)
        {
            if (dataGridViewProgramari.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Nu ati selectat programarea de modificat!", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Suneti sigur ca vreti sa stergeti?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;
            DataGridViewRow row = dataGridViewProgramari.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["IDProgramare"].Value);
            string query = $"DELETE FROM PRogramari WHERE IDProgramare = {id}";
            using SQLiteConnection con = databaseManager.GetConnection();
            using SQLiteCommand command = new SQLiteCommand(query, con);
            {
                con.Open();
                command.ExecuteNonQuery();
            }
            MessageBox.Show("S-a sters cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshDataGridViewProgramari();
        }
        private void buttonAfisareToateProg_Click(object sender, EventArgs e)
        {
            RefreshDataGridViewProgramari();
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

        private void FormEditareCatalog_ResizeBegin(object sender, EventArgs e)
        {
            panel1.Location = new Point((this.ClientSize.Width - panel1.Width) / 2, panel1.Location.Y);
            labelFiltre.Location = new Point((this.ClientSize.Width - labelFiltre.Width) / 2, labelFiltre.Location.Y);
            labelAnimale.Location = new Point((this.ClientSize.Width) / 2, labelAnimale.Location.Y);
        }
        private void FormEditareCatalog_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void FormEditareCatalog_Shown(object sender, EventArgs e)
        {
            dataGridViewAnimale.ClearSelection();
        }
    }
}