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
            labelFise = new Label();
            labelAnimale = new Label();
            label1 = new Label();
            dataGridViewAnimale = new DataGridView();
            labelFiltre = new Label();
            panel2 = new Panel();
            labelPrelucrari = new Label();
            pictureBox1 = new PictureBox();
            buttonMeniu = new Button();
            dataGridViewFiseMedicale = new DataGridView();
            panel1 = new Panel();
            textBoxRasa = new TextBox();
            labelRasa = new Label();
            buttonPoza = new Button();
            textBoxVarsta = new TextBox();
            labelNume = new Label();
            labelVarsta = new Label();
            textBoxNume = new TextBox();
            textBoxGreutate = new TextBox();
            checkBoxSterNu = new CheckBox();
            labelGreutate = new Label();
            checkBoxSterDa = new CheckBox();
            labelVaccinat = new Label();
            checkBoxVaccinatNu = new CheckBox();
            labelSterilizat = new Label();
            checkBoxVaccinatDa = new CheckBox();
            checkBoxSexF = new CheckBox();
            checkBoxSexM = new CheckBox();
            labelSpecie = new Label();
            comboBoxSpecie = new ComboBox();
            textBox1 = new TextBox();
            labelDiagnostic = new Label();
            textBox2 = new TextBox();
            labelTratament = new Label();
            buttonSterge = new Button();
            buttonModifica = new Button();
            buttonAdauga = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnimale).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFiseMedicale).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(153, 229, 80);
            panel3.Controls.Add(labelFise);
            panel3.Controls.Add(labelAnimale);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(-8, -4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1370, 52);
            panel3.TabIndex = 80;
            // 
            // labelFise
            // 
            labelFise.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelFise.AutoSize = true;
            labelFise.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelFise.Location = new Point(969, 10);
            labelFise.Name = "labelFise";
            labelFise.Size = new Size(190, 37);
            labelFise.TabIndex = 5;
            labelFise.Text = "Fise de control";
            // 
            // labelAnimale
            // 
            labelAnimale.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelAnimale.AutoSize = true;
            labelAnimale.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelAnimale.Location = new Point(170, 10);
            labelAnimale.Name = "labelAnimale";
            labelAnimale.Size = new Size(114, 37);
            labelAnimale.TabIndex = 4;
            labelAnimale.Text = "Animale";
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
            dataGridViewAnimale.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewAnimale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAnimale.BackgroundColor = SystemColors.Control;
            dataGridViewAnimale.Location = new Point(2, 51);
            dataGridViewAnimale.MultiSelect = false;
            dataGridViewAnimale.Name = "dataGridViewAnimale";
            dataGridViewAnimale.ReadOnly = true;
            dataGridViewAnimale.RowTemplate.Height = 25;
            dataGridViewAnimale.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAnimale.Size = new Size(667, 221);
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
            labelPrelucrari.Location = new Point(539, 4);
            labelPrelucrari.Name = "labelPrelucrari";
            labelPrelucrari.Size = new Size(303, 37);
            labelPrelucrari.TabIndex = 3;
            labelPrelucrari.Text = "Prelucrari fisa de control";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.FromArgb(240, 240, 200);
            pictureBox1.Location = new Point(2, 365);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(367, 426);
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
            buttonMeniu.Click += buttonMeniu_Click;
            // 
            // dataGridViewFiseMedicale
            // 
            dataGridViewFiseMedicale.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridViewFiseMedicale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFiseMedicale.BackgroundColor = SystemColors.Control;
            dataGridViewFiseMedicale.Location = new Point(675, 51);
            dataGridViewFiseMedicale.MultiSelect = false;
            dataGridViewFiseMedicale.Name = "dataGridViewFiseMedicale";
            dataGridViewFiseMedicale.ReadOnly = true;
            dataGridViewFiseMedicale.RowTemplate.Height = 25;
            dataGridViewFiseMedicale.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFiseMedicale.Size = new Size(633, 221);
            dataGridViewFiseMedicale.TabIndex = 85;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.Controls.Add(labelTratament);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(labelDiagnostic);
            panel1.Controls.Add(textBoxRasa);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(labelRasa);
            panel1.Controls.Add(buttonPoza);
            panel1.Controls.Add(textBoxVarsta);
            panel1.Controls.Add(labelNume);
            panel1.Controls.Add(labelVarsta);
            panel1.Controls.Add(textBoxNume);
            panel1.Controls.Add(textBoxGreutate);
            panel1.Controls.Add(checkBoxSterNu);
            panel1.Controls.Add(labelGreutate);
            panel1.Controls.Add(checkBoxSterDa);
            panel1.Controls.Add(labelVaccinat);
            panel1.Controls.Add(checkBoxVaccinatNu);
            panel1.Controls.Add(labelSterilizat);
            panel1.Controls.Add(checkBoxVaccinatDa);
            panel1.Controls.Add(checkBoxSexF);
            panel1.Controls.Add(checkBoxSexM);
            panel1.Controls.Add(labelSpecie);
            panel1.Controls.Add(comboBoxSpecie);
            panel1.Location = new Point(389, 365);
            panel1.Name = "panel1";
            panel1.Size = new Size(908, 200);
            panel1.TabIndex = 86;
            // 
            // textBoxRasa
            // 
            textBoxRasa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxRasa.Location = new Point(169, 48);
            textBoxRasa.Name = "textBoxRasa";
            textBoxRasa.Size = new Size(96, 23);
            textBoxRasa.TabIndex = 5;
            // 
            // labelRasa
            // 
            labelRasa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelRasa.AutoSize = true;
            labelRasa.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelRasa.Location = new Point(188, 17);
            labelRasa.Name = "labelRasa";
            labelRasa.Size = new Size(51, 25);
            labelRasa.TabIndex = 6;
            labelRasa.Text = "Rasa";
            // 
            // buttonPoza
            // 
            buttonPoza.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonPoza.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPoza.Image = Properties.Resources.button;
            buttonPoza.Location = new Point(906, 205);
            buttonPoza.Name = "buttonPoza";
            buttonPoza.Size = new Size(179, 43);
            buttonPoza.TabIndex = 47;
            buttonPoza.Text = "Cauta poza";
            buttonPoza.UseVisualStyleBackColor = true;
            // 
            // textBoxVarsta
            // 
            textBoxVarsta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxVarsta.Location = new Point(296, 48);
            textBoxVarsta.Name = "textBoxVarsta";
            textBoxVarsta.Size = new Size(57, 23);
            textBoxVarsta.TabIndex = 10;
            // 
            // labelNume
            // 
            labelNume.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelNume.AutoSize = true;
            labelNume.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelNume.Location = new Point(741, 17);
            labelNume.Name = "labelNume";
            labelNume.Size = new Size(63, 25);
            labelNume.TabIndex = 46;
            labelNume.Text = "Nume";
            // 
            // labelVarsta
            // 
            labelVarsta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelVarsta.AutoSize = true;
            labelVarsta.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelVarsta.Location = new Point(296, 17);
            labelVarsta.Name = "labelVarsta";
            labelVarsta.Size = new Size(64, 25);
            labelVarsta.TabIndex = 11;
            labelVarsta.Text = "Varsta";
            // 
            // textBoxNume
            // 
            textBoxNume.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxNume.Location = new Point(728, 45);
            textBoxNume.Name = "textBoxNume";
            textBoxNume.Size = new Size(98, 23);
            textBoxNume.TabIndex = 45;
            // 
            // textBoxGreutate
            // 
            textBoxGreutate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxGreutate.Location = new Point(385, 48);
            textBoxGreutate.Name = "textBoxGreutate";
            textBoxGreutate.Size = new Size(57, 23);
            textBoxGreutate.TabIndex = 14;
            // 
            // checkBoxSterNu
            // 
            checkBoxSterNu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            checkBoxSterNu.AutoSize = true;
            checkBoxSterNu.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxSterNu.Location = new Point(659, 42);
            checkBoxSterNu.Name = "checkBoxSterNu";
            checkBoxSterNu.Size = new Size(58, 29);
            checkBoxSterNu.TabIndex = 44;
            checkBoxSterNu.Text = "NU";
            checkBoxSterNu.UseVisualStyleBackColor = true;
            // 
            // labelGreutate
            // 
            labelGreutate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelGreutate.AutoSize = true;
            labelGreutate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelGreutate.Location = new Point(375, 17);
            labelGreutate.Name = "labelGreutate";
            labelGreutate.Size = new Size(85, 25);
            labelGreutate.TabIndex = 15;
            labelGreutate.Text = "Greutate";
            // 
            // checkBoxSterDa
            // 
            checkBoxSterDa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            checkBoxSterDa.AutoSize = true;
            checkBoxSterDa.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxSterDa.Location = new Point(597, 42);
            checkBoxSterDa.Name = "checkBoxSterDa";
            checkBoxSterDa.Size = new Size(56, 29);
            checkBoxSterDa.TabIndex = 43;
            checkBoxSterDa.Text = "DA";
            checkBoxSterDa.UseVisualStyleBackColor = true;
            // 
            // labelVaccinat
            // 
            labelVaccinat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelVaccinat.AutoSize = true;
            labelVaccinat.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelVaccinat.Location = new Point(482, 17);
            labelVaccinat.Name = "labelVaccinat";
            labelVaccinat.Size = new Size(83, 25);
            labelVaccinat.TabIndex = 18;
            labelVaccinat.Text = "Vaccinat";
            // 
            // checkBoxVaccinatNu
            // 
            checkBoxVaccinatNu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            checkBoxVaccinatNu.AutoSize = true;
            checkBoxVaccinatNu.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxVaccinatNu.Location = new Point(528, 40);
            checkBoxVaccinatNu.Name = "checkBoxVaccinatNu";
            checkBoxVaccinatNu.Size = new Size(58, 29);
            checkBoxVaccinatNu.TabIndex = 42;
            checkBoxVaccinatNu.Text = "NU";
            checkBoxVaccinatNu.UseVisualStyleBackColor = true;
            // 
            // labelSterilizat
            // 
            labelSterilizat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelSterilizat.AutoSize = true;
            labelSterilizat.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelSterilizat.Location = new Point(607, 17);
            labelSterilizat.Name = "labelSterilizat";
            labelSterilizat.Size = new Size(84, 25);
            labelSterilizat.TabIndex = 21;
            labelSterilizat.Text = "Sterilizat";
            // 
            // checkBoxVaccinatDa
            // 
            checkBoxVaccinatDa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            checkBoxVaccinatDa.AutoSize = true;
            checkBoxVaccinatDa.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxVaccinatDa.Location = new Point(466, 40);
            checkBoxVaccinatDa.Name = "checkBoxVaccinatDa";
            checkBoxVaccinatDa.Size = new Size(56, 29);
            checkBoxVaccinatDa.TabIndex = 41;
            checkBoxVaccinatDa.Text = "DA";
            checkBoxVaccinatDa.UseVisualStyleBackColor = true;
            // 
            // checkBoxSexF
            // 
            checkBoxSexF.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            checkBoxSexF.AutoSize = true;
            checkBoxSexF.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxSexF.Location = new Point(842, 45);
            checkBoxSexF.Name = "checkBoxSexF";
            checkBoxSexF.Size = new Size(40, 29);
            checkBoxSexF.TabIndex = 38;
            checkBoxSexF.Text = "F";
            checkBoxSexF.UseVisualStyleBackColor = true;
            // 
            // checkBoxSexM
            // 
            checkBoxSexM.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            checkBoxSexM.AutoSize = true;
            checkBoxSexM.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxSexM.Location = new Point(842, 16);
            checkBoxSexM.Name = "checkBoxSexM";
            checkBoxSexM.Size = new Size(48, 29);
            checkBoxSexM.TabIndex = 37;
            checkBoxSexM.Text = "M";
            checkBoxSexM.UseVisualStyleBackColor = true;
            // 
            // labelSpecie
            // 
            labelSpecie.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelSpecie.AutoSize = true;
            labelSpecie.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelSpecie.Location = new Point(88, 17);
            labelSpecie.Name = "labelSpecie";
            labelSpecie.Size = new Size(67, 25);
            labelSpecie.TabIndex = 30;
            labelSpecie.Text = "Specie";
            // 
            // comboBoxSpecie
            // 
            comboBoxSpecie.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBoxSpecie.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSpecie.FormattingEnabled = true;
            comboBoxSpecie.Location = new Point(90, 48);
            comboBoxSpecie.Name = "comboBoxSpecie";
            comboBoxSpecie.Size = new Size(65, 23);
            comboBoxSpecie.TabIndex = 29;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(207, 81);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(683, 46);
            textBox1.TabIndex = 87;
            // 
            // labelDiagnostic
            // 
            labelDiagnostic.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelDiagnostic.AutoSize = true;
            labelDiagnostic.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelDiagnostic.Location = new Point(88, 90);
            labelDiagnostic.Name = "labelDiagnostic";
            labelDiagnostic.Size = new Size(101, 25);
            labelDiagnostic.TabIndex = 48;
            labelDiagnostic.Text = "Diagnostic";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(207, 133);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(683, 46);
            textBox2.TabIndex = 88;
            // 
            // labelTratament
            // 
            labelTratament.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelTratament.AutoSize = true;
            labelTratament.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelTratament.Location = new Point(88, 144);
            labelTratament.Name = "labelTratament";
            labelTratament.Size = new Size(96, 25);
            labelTratament.TabIndex = 89;
            labelTratament.Text = "Tratament";
            // 
            // buttonSterge
            // 
            buttonSterge.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSterge.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSterge.Image = Properties.Resources.button;
            buttonSterge.Location = new Point(889, 723);
            buttonSterge.Name = "buttonSterge";
            buttonSterge.Size = new Size(201, 58);
            buttonSterge.TabIndex = 87;
            buttonSterge.Text = "Sterge Fisa";
            buttonSterge.UseVisualStyleBackColor = true;
            // 
            // buttonModifica
            // 
            buttonModifica.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonModifica.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonModifica.Image = Properties.Resources.button;
            buttonModifica.Location = new Point(682, 723);
            buttonModifica.Name = "buttonModifica";
            buttonModifica.Size = new Size(201, 58);
            buttonModifica.TabIndex = 88;
            buttonModifica.Text = "Modifica Fisa";
            buttonModifica.UseVisualStyleBackColor = true;
            // 
            // buttonAdauga
            // 
            buttonAdauga.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAdauga.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdauga.Image = Properties.Resources.button;
            buttonAdauga.Location = new Point(475, 723);
            buttonAdauga.Name = "buttonAdauga";
            buttonAdauga.Size = new Size(201, 58);
            buttonAdauga.TabIndex = 89;
            buttonAdauga.Text = "Adauga Fisa";
            buttonAdauga.UseVisualStyleBackColor = true;
            // 
            // GestiuneMedicala
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1309, 793);
            Controls.Add(buttonAdauga);
            Controls.Add(buttonModifica);
            Controls.Add(buttonSterge);
            Controls.Add(panel1);
            Controls.Add(dataGridViewFiseMedicale);
            Controls.Add(buttonMeniu);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(dataGridViewAnimale);
            Controls.Add(panel3);
            MinimumSize = new Size(1325, 832);
            Name = "GestiuneMedicala";
            Text = "GestiuneMedicala";
            Load += GestiuneMedicala_Load;
            Shown += GestiuneMedicala_Shown;
            Resize += GestiuneMedicala_Resize;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnimale).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFiseMedicale).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private DataGridView dataGridViewFiseMedicale;
        private Label labelFise;
        private Label labelAnimale;
        private Panel panel1;
        private TextBox textBoxRasa;
        private Label labelRasa;
        private Button buttonPoza;
        private TextBox textBoxVarsta;
        private Label labelNume;
        private Label labelVarsta;
        private TextBox textBoxNume;
        private TextBox textBoxGreutate;
        private CheckBox checkBoxSterNu;
        private Label labelGreutate;
        private CheckBox checkBoxSterDa;
        private Label labelVaccinat;
        private CheckBox checkBoxVaccinatNu;
        private Label labelSterilizat;
        private CheckBox checkBoxVaccinatDa;
        private CheckBox checkBoxSexF;
        private CheckBox checkBoxSexM;
        private Label labelSpecie;
        private ComboBox comboBoxSpecie;
        private Label labelDiagnostic;
        private TextBox textBox1;
        private Label labelTratament;
        private TextBox textBox2;
        private Button buttonSterge;
        private Button buttonModifica;
        private Button buttonAdauga;
    }
}