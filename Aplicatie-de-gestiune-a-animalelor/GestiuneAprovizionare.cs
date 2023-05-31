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

        private void buttonAdaugaComanda_Click(object sender, EventArgs e)
        {

        }
    }
}