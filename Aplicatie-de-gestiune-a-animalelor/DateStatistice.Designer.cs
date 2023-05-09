namespace Aplicatie_de_gestiune_a_animalelor
{
    partial class DateStatistice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPrint = new Button();
            btnMenu = new Button();
            SuspendLayout();
            // 
            // btnPrint
            // 
            btnPrint.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrint.Image = Properties.Resources.button;
            btnPrint.Location = new Point(12, 12);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(202, 42);
            btnPrint.TabIndex = 0;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenu.Image = Properties.Resources.button;
            btnMenu.Location = new Point(236, 12);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(202, 42);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "Meniu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // DateStatistice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 214);
            ClientSize = new Size(765, 771);
            Controls.Add(btnMenu);
            Controls.Add(btnPrint);
            Name = "DateStatistice";
            Text = "DateStatistice";
            Load += DateStatistice_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnPrint;
        private Button btnMenu;
    }
}