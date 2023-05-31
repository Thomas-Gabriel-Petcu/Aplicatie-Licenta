namespace Aplicatie_de_gestiune_a_animalelor
{
    partial class MainMenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            vizualizareCatalog = new Button();
            editareCatalog = new Button();
            iesire = new Button();
            buttonDateStatistice = new Button();
            panel1 = new Panel();
            buttonGestiuneMedicala = new Button();
            buttonGestiuneAprovizionare = new Button();
            SuspendLayout();
            // 
            // vizualizareCatalog
            // 
            vizualizareCatalog.Anchor = AnchorStyles.Top;
            vizualizareCatalog.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            vizualizareCatalog.Image = Properties.Resources.button;
            vizualizareCatalog.Location = new Point(364, 78);
            vizualizareCatalog.Name = "vizualizareCatalog";
            vizualizareCatalog.Size = new Size(545, 78);
            vizualizareCatalog.TabIndex = 0;
            vizualizareCatalog.Text = "Vizualizare Catalog";
            vizualizareCatalog.UseVisualStyleBackColor = true;
            vizualizareCatalog.Click += vizualizareCatalog_Click;
            // 
            // editareCatalog
            // 
            editareCatalog.Anchor = AnchorStyles.Top;
            editareCatalog.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            editareCatalog.Image = Properties.Resources.button;
            editareCatalog.Location = new Point(364, 192);
            editareCatalog.Name = "editareCatalog";
            editareCatalog.Size = new Size(545, 78);
            editareCatalog.TabIndex = 0;
            editareCatalog.Text = "Editare Catalog";
            editareCatalog.UseVisualStyleBackColor = true;
            editareCatalog.Click += editareCatalog_Click;
            // 
            // iesire
            // 
            iesire.Anchor = AnchorStyles.Top;
            iesire.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            iesire.Image = Properties.Resources.button;
            iesire.Location = new Point(364, 697);
            iesire.Name = "iesire";
            iesire.Size = new Size(545, 78);
            iesire.TabIndex = 1;
            iesire.Text = "Iesire";
            iesire.UseVisualStyleBackColor = true;
            iesire.Click += iesire_Click;
            // 
            // buttonDateStatistice
            // 
            buttonDateStatistice.Anchor = AnchorStyles.Top;
            buttonDateStatistice.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDateStatistice.Image = Properties.Resources.button;
            buttonDateStatistice.Location = new Point(364, 551);
            buttonDateStatistice.Name = "buttonDateStatistice";
            buttonDateStatistice.Size = new Size(545, 78);
            buttonDateStatistice.TabIndex = 2;
            buttonDateStatistice.Text = "Date Statistice";
            buttonDateStatistice.UseVisualStyleBackColor = true;
            buttonDateStatistice.Click += buttonDateStatistice_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(153, 229, 80);
            panel1.Location = new Point(-8, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1294, 52);
            panel1.TabIndex = 3;
            // 
            // buttonGestiuneMedicala
            // 
            buttonGestiuneMedicala.Anchor = AnchorStyles.Top;
            buttonGestiuneMedicala.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGestiuneMedicala.Image = Properties.Resources.button;
            buttonGestiuneMedicala.Location = new Point(364, 295);
            buttonGestiuneMedicala.Name = "buttonGestiuneMedicala";
            buttonGestiuneMedicala.Size = new Size(545, 78);
            buttonGestiuneMedicala.TabIndex = 4;
            buttonGestiuneMedicala.Text = "Gestiune Medicala";
            buttonGestiuneMedicala.UseVisualStyleBackColor = true;
            buttonGestiuneMedicala.Click += buttonGestiuneMedicala_Click;
            // 
            // buttonGestiuneAprovizionare
            // 
            buttonGestiuneAprovizionare.Anchor = AnchorStyles.Top;
            buttonGestiuneAprovizionare.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGestiuneAprovizionare.Image = Properties.Resources.button;
            buttonGestiuneAprovizionare.Location = new Point(364, 401);
            buttonGestiuneAprovizionare.Name = "buttonGestiuneAprovizionare";
            buttonGestiuneAprovizionare.Size = new Size(545, 78);
            buttonGestiuneAprovizionare.TabIndex = 5;
            buttonGestiuneAprovizionare.Text = "Gestiune Aprovizionare";
            buttonGestiuneAprovizionare.UseVisualStyleBackColor = true;
            buttonGestiuneAprovizionare.Click += buttonGestiuneHrana_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 214);
            ClientSize = new Size(1279, 787);
            Controls.Add(buttonGestiuneAprovizionare);
            Controls.Add(buttonGestiuneMedicala);
            Controls.Add(panel1);
            Controls.Add(buttonDateStatistice);
            Controls.Add(iesire);
            Controls.Add(editareCatalog);
            Controls.Add(vizualizareCatalog);
            MinimumSize = new Size(1295, 826);
            Name = "MainMenuForm";
            Text = "Main Menu";
            TopMost = true;
            Load += MainMenuForm_Load;
            ResizeBegin += MainMenuForm_ResizeBegin;
            Resize += MainMenuForm_Resize;
            ResumeLayout(false);
        }

        #endregion

        private Button vizualizareCatalog;
        private Button editareCatalog;
        private Button iesire;
        private Button buttonDateStatistice;
        private Panel panel1;
        private Button buttonGestiuneMedicala;
        private Button buttonGestiuneAprovizionare;
    }
}