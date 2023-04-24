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
            dateStatistice = new Button();
            iesire = new Button();
            SuspendLayout();
            // 
            // vizualizareCatalog
            // 
            vizualizareCatalog.Location = new Point(242, 29);
            vizualizareCatalog.Name = "vizualizareCatalog";
            vizualizareCatalog.Size = new Size(255, 44);
            vizualizareCatalog.TabIndex = 0;
            vizualizareCatalog.Text = "Vizualizare Catalog";
            vizualizareCatalog.UseVisualStyleBackColor = true;
            vizualizareCatalog.Click += vizualizareCatalog_Click;
            // 
            // editareCatalog
            // 
            editareCatalog.Location = new Point(242, 103);
            editareCatalog.Name = "editareCatalog";
            editareCatalog.Size = new Size(255, 46);
            editareCatalog.TabIndex = 0;
            editareCatalog.Text = "Editare Catalog";
            editareCatalog.UseVisualStyleBackColor = true;
            editareCatalog.Click += editareCatalog_Click;
            // 
            // dateStatistice
            // 
            dateStatistice.Location = new Point(242, 178);
            dateStatistice.Name = "dateStatistice";
            dateStatistice.Size = new Size(255, 41);
            dateStatistice.TabIndex = 0;
            dateStatistice.Text = "Date Statistice";
            dateStatistice.UseVisualStyleBackColor = true;
            dateStatistice.Click += dateStatistice_Click;
            // 
            // iesire
            // 
            iesire.Location = new Point(242, 356);
            iesire.Name = "iesire";
            iesire.Size = new Size(255, 41);
            iesire.TabIndex = 1;
            iesire.Text = "Iesire";
            iesire.UseVisualStyleBackColor = true;
            iesire.Click += iesire_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(iesire);
            Controls.Add(dateStatistice);
            Controls.Add(editareCatalog);
            Controls.Add(vizualizareCatalog);
            Name = "MainMenuForm";
            Text = "Main Menu";
            TopMost = true;
            Load += MainMenuForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button vizualizareCatalog;
        private Button editareCatalog;
        private Button dateStatistice;
        private Button iesire;
    }
}