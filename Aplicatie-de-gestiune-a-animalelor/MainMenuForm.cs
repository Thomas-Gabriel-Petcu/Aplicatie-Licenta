namespace Aplicatie_de_gestiune_a_animalelor
{
    using Aplicatie_de_gestiune_a_animalelor.Classes;
    using System.Diagnostics;
    using System.Drawing.Text;
    using System.Windows.Forms;

    public partial class MainMenuForm : Form
    {
        DatabaseManager databaseManager = DatabaseManager.GetInstance();
        FormEditareCatalog formEditareCatalog;
        FormVizualizareCatalog formVizualizareCatalog;
        GestiuneMedicala formGestiuneMedicala;
        GestiuneAprovizionare formGestiuneAprovizionare;
        DateStatistice dateStatistice;
        //bool hasReset;
        public MainMenuForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.Sizable;
            TopMost = true;
            formEditareCatalog = new FormEditareCatalog(this);
            formVizualizareCatalog = new FormVizualizareCatalog(this);
            formGestiuneMedicala = new GestiuneMedicala(this);
            formGestiuneAprovizionare = new GestiuneAprovizionare(this);

        }
        public void NewButton(Rectangle bounds)
        {
            Button button = new Button();
            button.Text = "Vizualizare catalog";
            button.Size = new Size(200, 50);
            button.Anchor = AnchorStyles.None;
            button.Dock = DockStyle.Fill;
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
        private void iesire_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Suneti sigur ca vreti sa iesiti", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;
            Application.Exit();
        }
        private void buttonDateStatistice_Click(object sender, EventArgs e)
        {
            this.Hide();
            dateStatistice = new DateStatistice(this);
            dateStatistice.Show();
        }


        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void MainMenuForm_ResizeBegin(object sender, EventArgs e)
        {
            //vizualizareCatalog.Location = new Point((this.ClientSize.Width - this.ClientSize.Width / 2) / 2, vizualizareCatalog.Location.Y);
        }

        private void MainMenuForm_Resize(object sender, EventArgs e)
        {
            vizualizareCatalog.Location = new Point((this.ClientSize.Width - vizualizareCatalog.Width) / 2, vizualizareCatalog.Location.Y);
            editareCatalog.Location = new Point((this.ClientSize.Width - editareCatalog.Width) / 2, editareCatalog.Location.Y);

        }

        private void buttonGestiuneMedicala_Click(object sender, EventArgs e)
        {
            this.Hide();
            formGestiuneMedicala.Show();
        }

        private void buttonGestiuneHrana_Click(object sender, EventArgs e)
        {
            this.Hide();
            formGestiuneAprovizionare.Show();
        }
    }
}