using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Aplicatie_de_gestiune_a_animalelor.Classes;

namespace Aplicatie_de_gestiune_a_animalelor
{
    public partial class GestiuneAprovizionare : Form
    {
        MainMenuForm menu;
        FormInstructiuniGestiuneAprovizionare instructiuni = new FormInstructiuniGestiuneAprovizionare();
        DatabaseManager databaseManager = DatabaseManager.GetInstance();
        public GestiuneAprovizionare(MainMenuForm menu)
        {
            InitializeComponent();
            this.menu = menu;

        }

        private void GestiuneHrana_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewFurnizori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GestiuneHrana_ResizeBegin(object sender, EventArgs e)
        {

        }

        private void GestiuneHrana_Resize(object sender, EventArgs e)
        {
            int miniWidth = this.MinimumSize.Width;
            int dif = this.Size.Width - miniWidth;
            int buffer = 17;

            //Furnizori
            dataGridViewFurnizori.Size = new Size(dataGridViewFurnizori.MinimumSize.Width + (dif / 3), dataGridViewFurnizori.Height);


            //Facturi
            dataGridViewFacturi.Size = new Size(
            dataGridViewFacturi.MinimumSize.Width +
            (dif / 3), dataGridViewFacturi.Height);

            dataGridViewFacturi.Location = new Point(this.Width / 2 - dataGridViewFacturi.Width / 2 - 10
            , dataGridViewFacturi.Location.Y);
            //Comenzi
            dataGridViewComenzi.Size = new Size(dataGridViewComenzi.MinimumSize.Width + (dif / 3), dataGridViewComenzi.Height);
            dataGridViewComenzi.Location = new Point(this.Width / 2 + (dataGridViewComenzi.Width / 2) + buffer, dataGridViewComenzi.Location.Y);

            //panels
            panelVertical1.Location = new Point(dataGridViewFacturi.Location.X - panelVertical1.Width, panelVertical1.Location.Y);
            panelVertical2.Location = new Point(dataGridViewComenzi.Location.X - panelVertical2.Width, panelVertical2.Location.Y);
            panelControlsFurnizor.Size = new Size(dataGridViewFurnizori.Size.Width - 20, panelControlsFurnizor.Height);
            panelControlsFacturi.Size = new Size(dataGridViewFacturi.Width - 20, panelControlsFacturi.Height);
            panelControlsFacturi.Location = new Point(dataGridViewFacturi.Location.X, panelControlsFacturi.Location.Y);
            //labels
            labelFurnizori.Location = new Point(dataGridViewFurnizori.Location.X + dataGridViewFurnizori.Width / 2 - labelFurnizori.Width / 2, labelFurnizori.Location.Y);
            labelFacturi.Location = new Point(dataGridViewFacturi.Location.X + dataGridViewFacturi.Width / 2 - labelFacturi.Width / 2, labelFacturi.Location.Y);
            labelComenzi.Location = new Point(dataGridViewComenzi.Location.X + dataGridViewComenzi.Width / 2 - labelComenzi.Width / 2, labelComenzi.Location.Y);

        }

        private void buttonMeniu_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }
        private void buttonInstructiuni_Click(object sender, EventArgs e)
        {
            if (instructiuni.IsDisposed)
            {
                instructiuni = new FormInstructiuniGestiuneAprovizionare();
            }
            instructiuni.Show();
            instructiuni.TopMost = true;
        }
        private bool ValidateSupplierInputs()
        {
            if (textBoxNumeFurnizor.Text == "")
            {
                MessageBox.Show("Nu ati specificat numele furnizorului!", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (textBoxCUIFurnizor.Text == "")
            {
                MessageBox.Show("Nu ati specificat codul unic de identificare al furnizorului!", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (textBoxAdresaFurnizor.Text == "")
            {
                MessageBox.Show("Nu ati specificat adresa furnizorului!", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (textBoxTelefonFurnizor.Text == "")
            {
                MessageBox.Show("Nu ati specificat telefonul furnizorului!", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (textBoxTelefonFurnizor.Text.Length < 10)
            {
                MessageBox.Show("Numarul de telefon trebuie sa fie format din 10 cifre", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!int.TryParse(textBoxTelefonFurnizor.Text, out int phone))
            {
                MessageBox.Show($"Numarul de telefon nu poate fi {textBoxTelefonFurnizor.Text}, doar cifre", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (textBoxEmailFurnizor.Text == "")
            {
                MessageBox.Show("Nu ati specificat eMail-ul furnizorului!", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool ValidateOrderInputs()
        {
            if (textBoxNumarComanda.Text == "")
            {
                MessageBox.Show("Nu ati specificat numarul comenzii!", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (textBoxProduse.Text == "")
            {
                MessageBox.Show("Nu ati specificat produsele!", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (textBoxValCuTVA.Text == "")
            {
                MessageBox.Show("Nu ati specificat valoarea comenzii!", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!double.TryParse(textBoxValCuTVA.Text, out double val))
            {
                if (val <= 0)
                {
                    MessageBox.Show($"Valoarea comenzii nu poate fi {textBoxValCuTVA.Text}. Doar valori numerice pozitive", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        private bool ValidateInvoiceInputs()
        {
            if (textBoxNumarFactura.Text == "")
            {
                MessageBox.Show("Nu ati specificat numarul facturii!", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }


        private void buttonAdaugaComanda_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdaugaFurnizor_Click(object sender, EventArgs e)
        {

        }
    }
}