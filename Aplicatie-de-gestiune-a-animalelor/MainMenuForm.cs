namespace Aplicatie_de_gestiune_a_animalelor
{
    using Aplicatie_de_gestiune_a_animalelor.Classes;
    using System.Diagnostics;
    using System.Drawing.Text;

    public partial class MainMenuForm : Form
    {
        DatabaseManager databaseManager = DatabaseManager.GetInstance();
        FormEditareCatalog formEditareCatalog;
        FormVizualizareCatalog formVizualizareCatalog;
        DateStatistice dateStatistice;
        //bool hasReset;
        public MainMenuForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.Sizable;
            TopMost = true;
            //WindowState = FormWindowState.Maximized;
            NewButton(Screen.PrimaryScreen.Bounds);
            formEditareCatalog = new FormEditareCatalog(this);
            formVizualizareCatalog = new FormVizualizareCatalog(this);
            dateStatistice = new DateStatistice(this);
            Statistics.GetRegisteredAnimals();
            //if (System.DateTime.Now.Day == 2)//second day of month
            //{
            //    hasReset = false;
            //}
            //if (System.DateTime.Now.Day == 1 && hasReset == false)//first day of month
            //{
            //    Statistics.WipeData();
            //    hasReset = true;
            //}

        }
        public void NewButton(Rectangle bounds)
        {
            Button button = new Button();
            button.Text = "Vizualizare catalog";
            button.Size = new Size(200, 50);
            button.Anchor = AnchorStyles.None;
            button.Dock = DockStyle.Fill;
            //button.Location = new Point(bounds.Height/2,bounds.Width/2);
            Controls.Add(button);
        }

        private void vizualizareCatalog_Click(object sender, EventArgs e)
        {
            formVizualizareCatalog.Show();
            this.Hide();
        }
        private void editareCatalog_Click(object sender, EventArgs e)
        {
            formEditareCatalog.Show();
            this.Hide();//hide main menu
        }
        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void iesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonDateStatistice_Click(object sender, EventArgs e)
        {
            this.Hide();
            dateStatistice.Show();
        }
    }
}