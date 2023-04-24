using Aplicatie_de_gestiune_a_animalelor.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        enum animals { caine, pisica }
        string race;
        string age;
        enum sex { f, m }
        float weight;
        enum vaccinated { n, y}
        enum sterilized { n, y }
        public FormEditareCatalog()
        {
            InitializeComponent();
            string s = animals.caine.ToString();
            Debug.WriteLine(s);
        }

        private void labelVaccinat_Click(object sender, EventArgs e)
        {

        }
    }
}
