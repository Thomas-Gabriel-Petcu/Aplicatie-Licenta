namespace Aplicatie_de_gestiune_a_animalelor
{
    partial class FormEditareCatalog
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
            dataGridViewAnimale = new DataGridView();
            textBoxRasa = new TextBox();
            labelRasa = new Label();
            textBoxVarsta = new TextBox();
            labelVarsta = new Label();
            textBoxGreutate = new TextBox();
            labelGreutate = new Label();
            labelVaccinat = new Label();
            labelSterilizat = new Label();
            labelFiltre = new Label();
            labelAnimale = new Label();
            buttonAdauga = new Button();
            buttonSterge = new Button();
            buttonModifica = new Button();
            comboBoxSpecie = new ComboBox();
            labelSpecie = new Label();
            checkBoxSexM = new CheckBox();
            checkBoxSexF = new CheckBox();
            checkBoxVaccinatNu = new CheckBox();
            checkBoxVaccinatDa = new CheckBox();
            checkBoxSterNu = new CheckBox();
            checkBoxSterDa = new CheckBox();
            textBoxNume = new TextBox();
            labelNume = new Label();
            buttonPoza = new Button();
            pictureBox1 = new PictureBox();
            dataGridViewProgramari = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            buttonMeniu = new Button();
            buttonAdaugaProg = new Button();
            dateTimePickerData = new DateTimePicker();
            dateTimePickerOra = new DateTimePicker();
            buttonModifProg = new Button();
            buttonStergeProg = new Button();
            buttonVerificareOre = new Button();
            panel3 = new Panel();
            buttonAfisareToateProg = new Button();
            textBoxDetaliiProg = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnimale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProgramari).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewAnimale
            // 
            dataGridViewAnimale.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAnimale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAnimale.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewAnimale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAnimale.Location = new Point(12, 34);
            dataGridViewAnimale.Name = "dataGridViewAnimale";
            dataGridViewAnimale.RowTemplate.Height = 25;
            dataGridViewAnimale.Size = new Size(1285, 249);
            dataGridViewAnimale.TabIndex = 0;
            dataGridViewAnimale.SelectionChanged += dataGridViewAnimale_SelectionChanged;
            // 
            // textBoxRasa
            // 
            textBoxRasa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxRasa.Location = new Point(89, 101);
            textBoxRasa.Name = "textBoxRasa";
            textBoxRasa.Size = new Size(70, 23);
            textBoxRasa.TabIndex = 5;
            // 
            // labelRasa
            // 
            labelRasa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelRasa.AutoSize = true;
            labelRasa.Location = new Point(107, 74);
            labelRasa.Name = "labelRasa";
            labelRasa.Size = new Size(31, 15);
            labelRasa.TabIndex = 6;
            labelRasa.Text = "Rasa";
            // 
            // textBoxVarsta
            // 
            textBoxVarsta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxVarsta.Location = new Point(165, 101);
            textBoxVarsta.Name = "textBoxVarsta";
            textBoxVarsta.Size = new Size(57, 23);
            textBoxVarsta.TabIndex = 10;
            // 
            // labelVarsta
            // 
            labelVarsta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelVarsta.AutoSize = true;
            labelVarsta.Location = new Point(174, 74);
            labelVarsta.Name = "labelVarsta";
            labelVarsta.Size = new Size(38, 15);
            labelVarsta.TabIndex = 11;
            labelVarsta.Text = "Varsta";
            // 
            // textBoxGreutate
            // 
            textBoxGreutate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxGreutate.Location = new Point(266, 101);
            textBoxGreutate.Name = "textBoxGreutate";
            textBoxGreutate.Size = new Size(57, 23);
            textBoxGreutate.TabIndex = 14;
            // 
            // labelGreutate
            // 
            labelGreutate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelGreutate.AutoSize = true;
            labelGreutate.Location = new Point(266, 76);
            labelGreutate.Name = "labelGreutate";
            labelGreutate.Size = new Size(52, 15);
            labelGreutate.TabIndex = 15;
            labelGreutate.Text = "Greutate";
            // 
            // labelVaccinat
            // 
            labelVaccinat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelVaccinat.AutoSize = true;
            labelVaccinat.Location = new Point(337, 72);
            labelVaccinat.Name = "labelVaccinat";
            labelVaccinat.Size = new Size(51, 15);
            labelVaccinat.TabIndex = 18;
            labelVaccinat.Text = "Vaccinat";
            // 
            // labelSterilizat
            // 
            labelSterilizat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelSterilizat.AutoSize = true;
            labelSterilizat.Location = new Point(394, 72);
            labelSterilizat.Name = "labelSterilizat";
            labelSterilizat.Size = new Size(51, 15);
            labelSterilizat.TabIndex = 21;
            labelSterilizat.Text = "Sterilizat";
            // 
            // labelFiltre
            // 
            labelFiltre.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelFiltre.AutoSize = true;
            labelFiltre.Location = new Point(314, 33);
            labelFiltre.Name = "labelFiltre";
            labelFiltre.Size = new Size(119, 15);
            labelFiltre.TabIndex = 24;
            labelFiltre.Text = "Optiuni de prelucrare";
            // 
            // labelAnimale
            // 
            labelAnimale.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelAnimale.AutoSize = true;
            labelAnimale.Location = new Point(587, 9);
            labelAnimale.Name = "labelAnimale";
            labelAnimale.Size = new Size(51, 15);
            labelAnimale.TabIndex = 25;
            labelAnimale.Text = "Animale";
            // 
            // buttonAdauga
            // 
            buttonAdauga.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAdauga.Location = new Point(634, 101);
            buttonAdauga.Name = "buttonAdauga";
            buttonAdauga.Size = new Size(75, 23);
            buttonAdauga.TabIndex = 26;
            buttonAdauga.Text = "Adauga";
            buttonAdauga.UseVisualStyleBackColor = true;
            buttonAdauga.Click += buttonAdauga_Click;
            // 
            // buttonSterge
            // 
            buttonSterge.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonSterge.Location = new Point(796, 100);
            buttonSterge.Name = "buttonSterge";
            buttonSterge.Size = new Size(75, 23);
            buttonSterge.TabIndex = 27;
            buttonSterge.Text = "Sterge";
            buttonSterge.UseVisualStyleBackColor = true;
            buttonSterge.Click += buttonSterge_Click;
            // 
            // buttonModifica
            // 
            buttonModifica.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonModifica.Location = new Point(715, 100);
            buttonModifica.Name = "buttonModifica";
            buttonModifica.Size = new Size(75, 23);
            buttonModifica.TabIndex = 28;
            buttonModifica.Text = "Modifica";
            buttonModifica.UseVisualStyleBackColor = true;
            buttonModifica.Click += buttonModifica_Click;
            // 
            // comboBoxSpecie
            // 
            comboBoxSpecie.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBoxSpecie.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSpecie.FormattingEnabled = true;
            comboBoxSpecie.Location = new Point(8, 101);
            comboBoxSpecie.Name = "comboBoxSpecie";
            comboBoxSpecie.Size = new Size(65, 23);
            comboBoxSpecie.TabIndex = 29;
            // 
            // labelSpecie
            // 
            labelSpecie.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelSpecie.AutoSize = true;
            labelSpecie.Location = new Point(17, 72);
            labelSpecie.Name = "labelSpecie";
            labelSpecie.Size = new Size(41, 15);
            labelSpecie.TabIndex = 30;
            labelSpecie.Text = "Specie";
            // 
            // checkBoxSexM
            // 
            checkBoxSexM.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            checkBoxSexM.AutoSize = true;
            checkBoxSexM.Location = new Point(227, 90);
            checkBoxSexM.Name = "checkBoxSexM";
            checkBoxSexM.Size = new Size(37, 19);
            checkBoxSexM.TabIndex = 37;
            checkBoxSexM.Text = "M";
            checkBoxSexM.UseVisualStyleBackColor = true;
            checkBoxSexM.CheckedChanged += checkBoxSexM_CheckedChanged;
            // 
            // checkBoxSexF
            // 
            checkBoxSexF.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            checkBoxSexF.AutoSize = true;
            checkBoxSexF.Location = new Point(228, 106);
            checkBoxSexF.Name = "checkBoxSexF";
            checkBoxSexF.Size = new Size(32, 19);
            checkBoxSexF.TabIndex = 38;
            checkBoxSexF.Text = "F";
            checkBoxSexF.UseVisualStyleBackColor = true;
            checkBoxSexF.CheckedChanged += checkBoxSexF_CheckedChanged;
            // 
            // checkBoxVaccinatNu
            // 
            checkBoxVaccinatNu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            checkBoxVaccinatNu.AutoSize = true;
            checkBoxVaccinatNu.Location = new Point(337, 106);
            checkBoxVaccinatNu.Name = "checkBoxVaccinatNu";
            checkBoxVaccinatNu.Size = new Size(43, 19);
            checkBoxVaccinatNu.TabIndex = 42;
            checkBoxVaccinatNu.Text = "NU";
            checkBoxVaccinatNu.UseVisualStyleBackColor = true;
            checkBoxVaccinatNu.CheckedChanged += checkBoxVaccinatNu_CheckedChanged;
            // 
            // checkBoxVaccinatDa
            // 
            checkBoxVaccinatDa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            checkBoxVaccinatDa.AutoSize = true;
            checkBoxVaccinatDa.Location = new Point(337, 90);
            checkBoxVaccinatDa.Name = "checkBoxVaccinatDa";
            checkBoxVaccinatDa.Size = new Size(42, 19);
            checkBoxVaccinatDa.TabIndex = 41;
            checkBoxVaccinatDa.Text = "DA";
            checkBoxVaccinatDa.UseVisualStyleBackColor = true;
            checkBoxVaccinatDa.CheckedChanged += checkBoxVaccinatDa_CheckedChanged;
            // 
            // checkBoxSterNu
            // 
            checkBoxSterNu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            checkBoxSterNu.AutoSize = true;
            checkBoxSterNu.Location = new Point(402, 106);
            checkBoxSterNu.Name = "checkBoxSterNu";
            checkBoxSterNu.Size = new Size(43, 19);
            checkBoxSterNu.TabIndex = 44;
            checkBoxSterNu.Text = "NU";
            checkBoxSterNu.UseVisualStyleBackColor = true;
            checkBoxSterNu.CheckedChanged += checkBoxSterNu_CheckedChanged;
            // 
            // checkBoxSterDa
            // 
            checkBoxSterDa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            checkBoxSterDa.AutoSize = true;
            checkBoxSterDa.Location = new Point(401, 89);
            checkBoxSterDa.Name = "checkBoxSterDa";
            checkBoxSterDa.Size = new Size(42, 19);
            checkBoxSterDa.TabIndex = 43;
            checkBoxSterDa.Text = "DA";
            checkBoxSterDa.UseVisualStyleBackColor = true;
            checkBoxSterDa.CheckedChanged += checkBoxSterDa_CheckedChanged;
            // 
            // textBoxNume
            // 
            textBoxNume.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxNume.Location = new Point(451, 101);
            textBoxNume.Name = "textBoxNume";
            textBoxNume.Size = new Size(57, 23);
            textBoxNume.TabIndex = 45;
            // 
            // labelNume
            // 
            labelNume.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelNume.AutoSize = true;
            labelNume.Location = new Point(451, 72);
            labelNume.Name = "labelNume";
            labelNume.Size = new Size(40, 15);
            labelNume.TabIndex = 46;
            labelNume.Text = "Nume";
            // 
            // buttonPoza
            // 
            buttonPoza.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonPoza.Location = new Point(526, 101);
            buttonPoza.Name = "buttonPoza";
            buttonPoza.Size = new Size(100, 22);
            buttonPoza.TabIndex = 47;
            buttonPoza.Text = "Cauta poza";
            buttonPoza.UseVisualStyleBackColor = true;
            buttonPoza.Click += buttonPoza_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.Location = new Point(12, 309);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(426, 240);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // dataGridViewProgramari
            // 
            dataGridViewProgramari.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridViewProgramari.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProgramari.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProgramari.Location = new Point(700, 309);
            dataGridViewProgramari.Name = "dataGridViewProgramari";
            dataGridViewProgramari.RowTemplate.Height = 25;
            dataGridViewProgramari.Size = new Size(597, 182);
            dataGridViewProgramari.TabIndex = 49;
            dataGridViewProgramari.SelectionChanged += dataGridViewProgramari_SelectionChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.Controls.Add(labelFiltre);
            panel1.Controls.Add(textBoxRasa);
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
            panel1.Controls.Add(buttonAdauga);
            panel1.Controls.Add(checkBoxSexF);
            panel1.Controls.Add(buttonSterge);
            panel1.Controls.Add(checkBoxSexM);
            panel1.Controls.Add(buttonModifica);
            panel1.Controls.Add(labelSpecie);
            panel1.Controls.Add(comboBoxSpecie);
            panel1.Location = new Point(12, 621);
            panel1.MinimumSize = new Size(768, 160);
            panel1.Name = "panel1";
            panel1.Size = new Size(895, 160);
            panel1.TabIndex = 50;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.Controls.Add(buttonMeniu);
            panel2.Location = new Point(940, 621);
            panel2.Name = "panel2";
            panel2.Size = new Size(357, 160);
            panel2.TabIndex = 51;
            // 
            // buttonMeniu
            // 
            buttonMeniu.Location = new Point(265, 58);
            buttonMeniu.Name = "buttonMeniu";
            buttonMeniu.Size = new Size(75, 67);
            buttonMeniu.TabIndex = 0;
            buttonMeniu.Text = "Meniu";
            buttonMeniu.UseVisualStyleBackColor = true;
            buttonMeniu.Click += buttonMeniu_Click;
            // 
            // buttonAdaugaProg
            // 
            buttonAdaugaProg.Location = new Point(20, 20);
            buttonAdaugaProg.Name = "buttonAdaugaProg";
            buttonAdaugaProg.Size = new Size(145, 36);
            buttonAdaugaProg.TabIndex = 52;
            buttonAdaugaProg.Text = "Adauga programare";
            buttonAdaugaProg.UseVisualStyleBackColor = true;
            buttonAdaugaProg.Click += buttonAdaugaProg_Click;
            // 
            // dateTimePickerData
            // 
            dateTimePickerData.Location = new Point(20, 240);
            dateTimePickerData.Name = "dateTimePickerData";
            dateTimePickerData.Size = new Size(183, 23);
            dateTimePickerData.TabIndex = 53;
            // 
            // dateTimePickerOra
            // 
            dateTimePickerOra.Format = DateTimePickerFormat.Time;
            dateTimePickerOra.Location = new Point(20, 269);
            dateTimePickerOra.Name = "dateTimePickerOra";
            dateTimePickerOra.Size = new Size(183, 23);
            dateTimePickerOra.TabIndex = 54;
            // 
            // buttonModifProg
            // 
            buttonModifProg.Location = new Point(20, 62);
            buttonModifProg.Name = "buttonModifProg";
            buttonModifProg.Size = new Size(145, 36);
            buttonModifProg.TabIndex = 55;
            buttonModifProg.Text = "Modifica programare";
            buttonModifProg.UseVisualStyleBackColor = true;
            buttonModifProg.Click += buttonModifProg_Click;
            // 
            // buttonStergeProg
            // 
            buttonStergeProg.Location = new Point(20, 104);
            buttonStergeProg.Name = "buttonStergeProg";
            buttonStergeProg.Size = new Size(145, 36);
            buttonStergeProg.TabIndex = 56;
            buttonStergeProg.Text = "Sterge programare";
            buttonStergeProg.UseVisualStyleBackColor = true;
            buttonStergeProg.Click += buttonStergeProg_Click;
            // 
            // buttonVerificareOre
            // 
            buttonVerificareOre.Location = new Point(20, 146);
            buttonVerificareOre.Name = "buttonVerificareOre";
            buttonVerificareOre.Size = new Size(145, 36);
            buttonVerificareOre.TabIndex = 57;
            buttonVerificareOre.Text = "Verifica ore disponibile";
            buttonVerificareOre.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(buttonAfisareToateProg);
            panel3.Controls.Add(buttonAdaugaProg);
            panel3.Controls.Add(buttonVerificareOre);
            panel3.Controls.Add(dateTimePickerData);
            panel3.Controls.Add(buttonStergeProg);
            panel3.Controls.Add(dateTimePickerOra);
            panel3.Controls.Add(buttonModifProg);
            panel3.Location = new Point(463, 309);
            panel3.Name = "panel3";
            panel3.Size = new Size(218, 306);
            panel3.TabIndex = 58;
            // 
            // buttonAfisareToateProg
            // 
            buttonAfisareToateProg.Location = new Point(20, 188);
            buttonAfisareToateProg.Name = "buttonAfisareToateProg";
            buttonAfisareToateProg.Size = new Size(145, 46);
            buttonAfisareToateProg.TabIndex = 58;
            buttonAfisareToateProg.Text = "Afiseaza toate programarile";
            buttonAfisareToateProg.UseVisualStyleBackColor = true;
            buttonAfisareToateProg.Click += buttonAfisareToateProg_Click;
            // 
            // textBoxDetaliiProg
            // 
            textBoxDetaliiProg.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDetaliiProg.Location = new Point(700, 497);
            textBoxDetaliiProg.Multiline = true;
            textBoxDetaliiProg.Name = "textBoxDetaliiProg";
            textBoxDetaliiProg.PlaceholderText = "Detalii programare";
            textBoxDetaliiProg.ScrollBars = ScrollBars.Vertical;
            textBoxDetaliiProg.Size = new Size(597, 75);
            textBoxDetaliiProg.TabIndex = 59;
            // 
            // FormEditareCatalog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1309, 793);
            Controls.Add(textBoxDetaliiProg);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridViewProgramari);
            Controls.Add(pictureBox1);
            Controls.Add(labelAnimale);
            Controls.Add(dataGridViewAnimale);
            MinimumSize = new Size(1325, 832);
            Name = "FormEditareCatalog";
            Text = "FormEditareCatalog";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnimale).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProgramari).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewAnimale;
        private TextBox textBoxRasa;
        private Label labelRasa;
        private TextBox textBoxVarsta;
        private Label labelVarsta;
        private TextBox textBoxGreutate;
        private Label labelGreutate;
        private Label labelVaccinat;
        private Label labelSterilizat;
        private Label labelFiltre;
        private Label labelAnimale;
        private Button buttonAdauga;
        private Button buttonSterge;
        private Button buttonModifica;
        private ComboBox comboBoxSpecie;
        private Label labelSpecie;
        private CheckBox checkBoxSexM;
        private CheckBox checkBoxSexF;
        private CheckBox checkBoxVaccinatNu;
        private CheckBox checkBoxVaccinatDa;
        private CheckBox checkBoxSterNu;
        private CheckBox checkBoxSterDa;
        private TextBox textBoxNume;
        private Label labelNume;
        private Button buttonPoza;
        private PictureBox pictureBox1;
        private DataGridView dataGridViewProgramari;
        private Panel panel1;
        private Panel panel2;
        private Button buttonMeniu;
        private Button buttonAdaugaProg;
        private DateTimePicker dateTimePickerData;
        private DateTimePicker dateTimePickerOra;
        private Button buttonModifProg;
        private Button buttonStergeProg;
        private Button buttonVerificareOre;
        private Panel panel3;
        private TextBox textBoxDetaliiProg;
        private Button buttonAfisareToateProg;
    }
}