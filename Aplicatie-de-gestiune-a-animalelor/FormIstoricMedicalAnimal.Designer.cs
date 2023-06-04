namespace Aplicatie_de_gestiune_a_animalelor
{
    partial class FormIstoricMedicalAnimal
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
            labelTitlu = new Label();
            dataGridViewAnimale = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            dataGridViewConsultatii = new DataGridView();
            labelData = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnimale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsultatii).BeginInit();
            SuspendLayout();
            // 
            // btnPrint
            // 
            btnPrint.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrint.Image = Properties.Resources.button;
            btnPrint.Location = new Point(12, 12);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(202, 42);
            btnPrint.TabIndex = 3;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // labelTitlu
            // 
            labelTitlu.AutoSize = true;
            labelTitlu.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitlu.Location = new Point(236, 42);
            labelTitlu.Name = "labelTitlu";
            labelTitlu.Size = new Size(288, 30);
            labelTitlu.TabIndex = 6;
            labelTitlu.Text = "Istoricul medical al animalului";
            // 
            // dataGridViewAnimale
            // 
            dataGridViewAnimale.AllowUserToAddRows = false;
            dataGridViewAnimale.AllowUserToDeleteRows = false;
            dataGridViewAnimale.AllowUserToResizeColumns = false;
            dataGridViewAnimale.AllowUserToResizeRows = false;
            dataGridViewAnimale.BackgroundColor = SystemColors.Control;
            dataGridViewAnimale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAnimale.GridColor = SystemColors.Control;
            dataGridViewAnimale.Location = new Point(12, 147);
            dataGridViewAnimale.Name = "dataGridViewAnimale";
            dataGridViewAnimale.ReadOnly = true;
            dataGridViewAnimale.RowTemplate.Height = 25;
            dataGridViewAnimale.ScrollBars = ScrollBars.None;
            dataGridViewAnimale.Size = new Size(741, 48);
            dataGridViewAnimale.TabIndex = 7;
            dataGridViewAnimale.SelectionChanged += dataGridViewAnimale_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(276, 119);
            label1.Name = "label1";
            label1.Size = new Size(190, 25);
            label1.TabIndex = 8;
            label1.Text = "Detalii despre animal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(276, 221);
            label2.Name = "label2";
            label2.Size = new Size(183, 25);
            label2.TabIndex = 9;
            label2.Text = "Consultatii medicale";
            // 
            // dataGridViewConsultatii
            // 
            dataGridViewConsultatii.AllowUserToAddRows = false;
            dataGridViewConsultatii.AllowUserToDeleteRows = false;
            dataGridViewConsultatii.AllowUserToResizeColumns = false;
            dataGridViewConsultatii.AllowUserToResizeRows = false;
            dataGridViewConsultatii.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewConsultatii.BackgroundColor = Color.White;
            dataGridViewConsultatii.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewConsultatii.GridColor = SystemColors.Control;
            dataGridViewConsultatii.Location = new Point(12, 259);
            dataGridViewConsultatii.MinimumSize = new Size(741, 486);
            dataGridViewConsultatii.MultiSelect = false;
            dataGridViewConsultatii.Name = "dataGridViewConsultatii";
            dataGridViewConsultatii.ReadOnly = true;
            dataGridViewConsultatii.RowTemplate.Height = 25;
            dataGridViewConsultatii.Size = new Size(741, 486);
            dataGridViewConsultatii.TabIndex = 10;
            dataGridViewConsultatii.SelectionChanged += dataGridViewConsultatii_SelectionChanged;
            // 
            // labelData
            // 
            labelData.AutoSize = true;
            labelData.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelData.Location = new Point(554, 42);
            labelData.Name = "labelData";
            labelData.Size = new Size(89, 25);
            labelData.TabIndex = 11;
            labelData.Text = "data..........";
            // 
            // FormIstoricMedicalAnimal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(765, 771);
            Controls.Add(labelData);
            Controls.Add(dataGridViewConsultatii);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewAnimale);
            Controls.Add(labelTitlu);
            Controls.Add(btnPrint);
            MinimumSize = new Size(781, 810);
            Name = "FormIstoricMedicalAnimal";
            Text = "FormIstoricMedicalAnimal";
            Load += FormIstoricMedicalAnimal_Load;
            Resize += FormIstoricMedicalAnimal_Resize;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnimale).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsultatii).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPrint;
        private Label labelTitlu;
        private DataGridView dataGridViewAnimale;
        private Label label1;
        private Label label2;
        private DataGridView dataGridViewConsultatii;
        private Label labelData;
    }
}