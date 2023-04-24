namespace Aplicatie_de_gestiune_a_animalelor
{
    using Aplicatie_de_gestiune_a_animalelor.Classes;
    public partial class MainMenuForm : Form
    {
        DatabaseManager databaseManager = DatabaseManager.GetInstance();
        FormEditareCatalog formEditareCatalog = new FormEditareCatalog();
        FormVizualizareCatalog formVizualizareCatalog = new FormVizualizareCatalog();
        public MainMenuForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.Sizable;
            TopMost = true;
            //WindowState = FormWindowState.Maximized;
            NewButton(Screen.PrimaryScreen.Bounds);

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

        }

        private void dateStatistice_Click(object sender, EventArgs e)
        {

        }

        
    }
}