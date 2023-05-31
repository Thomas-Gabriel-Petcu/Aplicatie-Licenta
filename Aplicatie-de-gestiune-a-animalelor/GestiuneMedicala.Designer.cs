namespace Aplicatie_de_gestiune_a_animalelor
{
    partial class GestiuneMedicala
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
            panel3 = new Panel();
            label1 = new Label();
            dataGridViewAnimale = new DataGridView();
            labelFiltre = new Label();
            panel2 = new Panel();
            labelPrelucrari = new Label();
            pictureBox1 = new PictureBox();
            buttonMeniu = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnimale).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(153, 229, 80);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(-8, -4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1370, 52);
            panel3.TabIndex = 80;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(4339, -34);
            label1.Name = "label1";
            label1.Size = new Size(76, 37);
            label1.TabIndex = 2;
            label1.Text = "Filtre";
            // 
            // dataGridViewAnimale
            // 
            dataGridViewAnimale.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAnimale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAnimale.BackgroundColor = SystemColors.Control;
            dataGridViewAnimale.Location = new Point(2, 51);
            dataGridViewAnimale.MultiSelect = false;
            dataGridViewAnimale.Name = "dataGridViewAnimale";
            dataGridViewAnimale.ReadOnly = true;
            dataGridViewAnimale.RowTemplate.Height = 25;
            dataGridViewAnimale.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAnimale.Size = new Size(1306, 221);
            dataGridViewAnimale.TabIndex = 81;
            // 
            // labelFiltre
            // 
            labelFiltre.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelFiltre.AutoSize = true;
            labelFiltre.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelFiltre.Location = new Point(1757, -41);
            labelFiltre.Name = "labelFiltre";
            labelFiltre.Size = new Size(76, 37);
            labelFiltre.TabIndex = 2;
            labelFiltre.Text = "Filtre";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(153, 229, 80);
            panel2.Controls.Add(labelPrelucrari);
            panel2.Controls.Add(labelFiltre);
            panel2.Location = new Point(2, 278);
            panel2.Name = "panel2";
            panel2.Size = new Size(1306, 52);
            panel2.TabIndex = 82;
            // 
            // labelPrelucrari
            // 
            labelPrelucrari.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelPrelucrari.AutoSize = true;
            labelPrelucrari.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrelucrari.Location = new Point(615, 8);
            labelPrelucrari.Name = "labelPrelucrari";
            labelPrelucrari.Size = new Size(128, 37);
            labelPrelucrari.TabIndex = 3;
            labelPrelucrari.Text = "Prelucrari";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.FromArgb(240, 240, 200);
            pictureBox1.Location = new Point(2, 532);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(367, 259);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 83;
            pictureBox1.TabStop = false;
            // 
            // buttonMeniu
            // 
            buttonMeniu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonMeniu.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMeniu.Image = Properties.Resources.button;
            buttonMeniu.Location = new Point(1096, 723);
            buttonMeniu.Name = "buttonMeniu";
            buttonMeniu.Size = new Size(201, 58);
            buttonMeniu.TabIndex = 84;
            buttonMeniu.Text = "Meniu";
            buttonMeniu.UseVisualStyleBackColor = true;
            buttonMeniu.Click += button1_Click;
            // 
            // GestiuneMedicala
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1309, 793);
            Controls.Add(buttonMeniu);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(dataGridViewAnimale);
            Controls.Add(panel3);
            MinimumSize = new Size(1325, 832);
            Name = "GestiuneMedicala";
            Text = "GestiuneMedicala";
            Load += GestiuneMedicala_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnimale).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label1;
        private DataGridView dataGridViewAnimale;
        private Label labelFiltre;
        private Panel panel2;
        private Label labelPrelucrari;
        private PictureBox pictureBox1;
        private Button buttonMeniu;
    }
}