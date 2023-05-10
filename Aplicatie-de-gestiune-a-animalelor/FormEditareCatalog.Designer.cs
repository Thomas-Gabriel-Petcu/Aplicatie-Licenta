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
            buttonMeniu = new Button();
            buttonAdaugaProg = new Button();
            dateTimePickerData = new DateTimePicker();
            dateTimePickerOra = new DateTimePicker();
            buttonModifProg = new Button();
            buttonStergeProg = new Button();
            panel3 = new Panel();
            buttonAfisareToateProg = new Button();
            textBoxDetaliiProg = new TextBox();
            panel2 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnimale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProgramari).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewAnimale
            // 
            dataGridViewAnimale.AllowUserToDeleteRows = false;
            dataGridViewAnimale.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAnimale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAnimale.BackgroundColor = SystemColors.Control;
            dataGridViewAnimale.Location = new Point(-1, 34);
            dataGridViewAnimale.MultiSelect = false;
            dataGridViewAnimale.Name = "dataGridViewAnimale";
            dataGridViewAnimale.ReadOnly = true;
            dataGridViewAnimale.RowTemplate.Height = 25;
            dataGridViewAnimale.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAnimale.Size = new Size(1310, 259);
            dataGridViewAnimale.TabIndex = 0;
            dataGridViewAnimale.SelectionChanged += dataGridViewAnimale_SelectionChanged;
            // 
            // textBoxRasa
            // 
            textBoxRasa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxRasa.Location = new Point(98, 54);
            textBoxRasa.Name = "textBoxRasa";
            textBoxRasa.Size = new Size(96, 23);
            textBoxRasa.TabIndex = 5;
            // 
            // labelRasa
            // 
            labelRasa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelRasa.AutoSize = true;
            labelRasa.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelRasa.Location = new Point(117, 23);
            labelRasa.Name = "labelRasa";
            labelRasa.Size = new Size(51, 25);
            labelRasa.TabIndex = 6;
            labelRasa.Text = "Rasa";
            // 
            // textBoxVarsta
            // 
            textBoxVarsta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxVarsta.Location = new Point(225, 54);
            textBoxVarsta.Name = "textBoxVarsta";
            textBoxVarsta.Size = new Size(57, 23);
            textBoxVarsta.TabIndex = 10;
            // 
            // labelVarsta
            // 
            labelVarsta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelVarsta.AutoSize = true;
            labelVarsta.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelVarsta.Location = new Point(225, 23);
            labelVarsta.Name = "labelVarsta";
            labelVarsta.Size = new Size(64, 25);
            labelVarsta.TabIndex = 11;
            labelVarsta.Text = "Varsta";
            // 
            // textBoxGreutate
            // 
            textBoxGreutate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxGreutate.Location = new Point(314, 54);
            textBoxGreutate.Name = "textBoxGreutate";
            textBoxGreutate.Size = new Size(57, 23);
            textBoxGreutate.TabIndex = 14;
            // 
            // labelGreutate
            // 
            labelGreutate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelGreutate.AutoSize = true;
            labelGreutate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelGreutate.Location = new Point(304, 23);
            labelGreutate.Name = "labelGreutate";
            labelGreutate.Size = new Size(85, 25);
            labelGreutate.TabIndex = 15;
            labelGreutate.Text = "Greutate";
            // 
            // labelVaccinat
            // 
            labelVaccinat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelVaccinat.AutoSize = true;
            labelVaccinat.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelVaccinat.Location = new Point(411, 23);
            labelVaccinat.Name = "labelVaccinat";
            labelVaccinat.Size = new Size(83, 25);
            labelVaccinat.TabIndex = 18;
            labelVaccinat.Text = "Vaccinat";
            // 
            // labelSterilizat
            // 
            labelSterilizat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelSterilizat.AutoSize = true;
            labelSterilizat.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelSterilizat.Location = new Point(536, 23);
            labelSterilizat.Name = "labelSterilizat";
            labelSterilizat.Size = new Size(84, 25);
            labelSterilizat.TabIndex = 21;
            labelSterilizat.Text = "Sterilizat";
            // 
            // labelFiltre
            // 
            labelFiltre.Anchor = AnchorStyles.Bottom;
            labelFiltre.AutoSize = true;
            labelFiltre.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelFiltre.Location = new Point(522, 10);
            labelFiltre.Name = "labelFiltre";
            labelFiltre.Size = new Size(220, 30);
            labelFiltre.TabIndex = 24;
            labelFiltre.Text = "Optiuni de prelucrare";
            // 
            // labelAnimale
            // 
            labelAnimale.Anchor = AnchorStyles.None;
            labelAnimale.AutoSize = true;
            labelAnimale.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelAnimale.Location = new Point(539, 7);
            labelAnimale.Name = "labelAnimale";
            labelAnimale.Size = new Size(81, 25);
            labelAnimale.TabIndex = 25;
            labelAnimale.Text = "Animale";
            // 
            // buttonAdauga
            // 
            buttonAdauga.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAdauga.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdauga.Image = Properties.Resources.button;
            buttonAdauga.Location = new Point(906, 5);
            buttonAdauga.Name = "buttonAdauga";
            buttonAdauga.Size = new Size(179, 43);
            buttonAdauga.TabIndex = 26;
            buttonAdauga.Text = "Adauga animal";
            buttonAdauga.UseVisualStyleBackColor = true;
            buttonAdauga.Click += buttonAdauga_Click;
            // 
            // buttonSterge
            // 
            buttonSterge.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonSterge.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSterge.Image = Properties.Resources.button;
            buttonSterge.Location = new Point(1091, 4);
            buttonSterge.Name = "buttonSterge";
            buttonSterge.Size = new Size(179, 44);
            buttonSterge.TabIndex = 27;
            buttonSterge.Text = "Sterge animal";
            buttonSterge.UseVisualStyleBackColor = true;
            buttonSterge.Click += buttonSterge_Click;
            // 
            // buttonModifica
            // 
            buttonModifica.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonModifica.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonModifica.Image = Properties.Resources.button;
            buttonModifica.Location = new Point(1091, 54);
            buttonModifica.Name = "buttonModifica";
            buttonModifica.Size = new Size(179, 43);
            buttonModifica.TabIndex = 28;
            buttonModifica.Text = "Modifica animal";
            buttonModifica.UseVisualStyleBackColor = true;
            buttonModifica.Click += buttonModifica_Click;
            // 
            // comboBoxSpecie
            // 
            comboBoxSpecie.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBoxSpecie.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSpecie.FormattingEnabled = true;
            comboBoxSpecie.Location = new Point(19, 54);
            comboBoxSpecie.Name = "comboBoxSpecie";
            comboBoxSpecie.Size = new Size(65, 23);
            comboBoxSpecie.TabIndex = 29;
            // 
            // labelSpecie
            // 
            labelSpecie.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelSpecie.AutoSize = true;
            labelSpecie.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelSpecie.Location = new Point(17, 23);
            labelSpecie.Name = "labelSpecie";
            labelSpecie.Size = new Size(67, 25);
            labelSpecie.TabIndex = 30;
            labelSpecie.Text = "Specie";
            // 
            // checkBoxSexM
            // 
            checkBoxSexM.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            checkBoxSexM.AutoSize = true;
            checkBoxSexM.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxSexM.Location = new Point(771, 22);
            checkBoxSexM.Name = "checkBoxSexM";
            checkBoxSexM.Size = new Size(48, 29);
            checkBoxSexM.TabIndex = 37;
            checkBoxSexM.Text = "M";
            checkBoxSexM.UseVisualStyleBackColor = true;
            checkBoxSexM.CheckedChanged += checkBoxSexM_CheckedChanged;
            // 
            // checkBoxSexF
            // 
            checkBoxSexF.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            checkBoxSexF.AutoSize = true;
            checkBoxSexF.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxSexF.Location = new Point(771, 51);
            checkBoxSexF.Name = "checkBoxSexF";
            checkBoxSexF.Size = new Size(40, 29);
            checkBoxSexF.TabIndex = 38;
            checkBoxSexF.Text = "F";
            checkBoxSexF.UseVisualStyleBackColor = true;
            checkBoxSexF.CheckedChanged += checkBoxSexF_CheckedChanged;
            // 
            // checkBoxVaccinatNu
            // 
            checkBoxVaccinatNu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            checkBoxVaccinatNu.AutoSize = true;
            checkBoxVaccinatNu.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxVaccinatNu.Location = new Point(457, 46);
            checkBoxVaccinatNu.Name = "checkBoxVaccinatNu";
            checkBoxVaccinatNu.Size = new Size(58, 29);
            checkBoxVaccinatNu.TabIndex = 42;
            checkBoxVaccinatNu.Text = "NU";
            checkBoxVaccinatNu.UseVisualStyleBackColor = true;
            checkBoxVaccinatNu.CheckedChanged += checkBoxVaccinatNu_CheckedChanged;
            // 
            // checkBoxVaccinatDa
            // 
            checkBoxVaccinatDa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            checkBoxVaccinatDa.AutoSize = true;
            checkBoxVaccinatDa.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxVaccinatDa.Location = new Point(395, 46);
            checkBoxVaccinatDa.Name = "checkBoxVaccinatDa";
            checkBoxVaccinatDa.Size = new Size(56, 29);
            checkBoxVaccinatDa.TabIndex = 41;
            checkBoxVaccinatDa.Text = "DA";
            checkBoxVaccinatDa.UseVisualStyleBackColor = true;
            checkBoxVaccinatDa.CheckedChanged += checkBoxVaccinatDa_CheckedChanged;
            // 
            // checkBoxSterNu
            // 
            checkBoxSterNu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            checkBoxSterNu.AutoSize = true;
            checkBoxSterNu.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxSterNu.Location = new Point(588, 48);
            checkBoxSterNu.Name = "checkBoxSterNu";
            checkBoxSterNu.Size = new Size(58, 29);
            checkBoxSterNu.TabIndex = 44;
            checkBoxSterNu.Text = "NU";
            checkBoxSterNu.UseVisualStyleBackColor = true;
            checkBoxSterNu.CheckedChanged += checkBoxSterNu_CheckedChanged;
            // 
            // checkBoxSterDa
            // 
            checkBoxSterDa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            checkBoxSterDa.AutoSize = true;
            checkBoxSterDa.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxSterDa.Location = new Point(526, 48);
            checkBoxSterDa.Name = "checkBoxSterDa";
            checkBoxSterDa.Size = new Size(56, 29);
            checkBoxSterDa.TabIndex = 43;
            checkBoxSterDa.Text = "DA";
            checkBoxSterDa.UseVisualStyleBackColor = true;
            checkBoxSterDa.CheckedChanged += checkBoxSterDa_CheckedChanged;
            // 
            // textBoxNume
            // 
            textBoxNume.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxNume.Location = new Point(657, 51);
            textBoxNume.Name = "textBoxNume";
            textBoxNume.Size = new Size(98, 23);
            textBoxNume.TabIndex = 45;
            // 
            // labelNume
            // 
            labelNume.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelNume.AutoSize = true;
            labelNume.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelNume.Location = new Point(670, 23);
            labelNume.Name = "labelNume";
            labelNume.Size = new Size(63, 25);
            labelNume.TabIndex = 46;
            labelNume.Text = "Nume";
            // 
            // buttonPoza
            // 
            buttonPoza.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonPoza.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPoza.Image = Properties.Resources.button;
            buttonPoza.Location = new Point(906, 105);
            buttonPoza.Name = "buttonPoza";
            buttonPoza.Size = new Size(179, 43);
            buttonPoza.TabIndex = 47;
            buttonPoza.Text = "Cauta poza";
            buttonPoza.UseVisualStyleBackColor = true;
            buttonPoza.Click += buttonPoza_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.BackColor = Color.FromArgb(240, 240, 200);
            pictureBox1.Location = new Point(12, 309);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(426, 240);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // dataGridViewProgramari
            // 
            dataGridViewProgramari.AllowUserToAddRows = false;
            dataGridViewProgramari.AllowUserToDeleteRows = false;
            dataGridViewProgramari.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProgramari.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProgramari.BackgroundColor = SystemColors.Control;
            dataGridViewProgramari.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProgramari.Location = new Point(646, 309);
            dataGridViewProgramari.MultiSelect = false;
            dataGridViewProgramari.Name = "dataGridViewProgramari";
            dataGridViewProgramari.ReadOnly = true;
            dataGridViewProgramari.RowTemplate.Height = 25;
            dataGridViewProgramari.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProgramari.Size = new Size(651, 182);
            dataGridViewProgramari.TabIndex = 49;
            dataGridViewProgramari.SelectionChanged += dataGridViewProgramari_SelectionChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom;
            panel1.Controls.Add(buttonMeniu);
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
            panel1.Size = new Size(1285, 160);
            panel1.TabIndex = 50;
            // 
            // buttonMeniu
            // 
            buttonMeniu.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMeniu.Image = Properties.Resources.button;
            buttonMeniu.Location = new Point(1091, 103);
            buttonMeniu.Name = "buttonMeniu";
            buttonMeniu.Size = new Size(179, 45);
            buttonMeniu.TabIndex = 0;
            buttonMeniu.Text = "Meniu";
            buttonMeniu.UseVisualStyleBackColor = true;
            buttonMeniu.Click += buttonMeniu_Click;
            // 
            // buttonAdaugaProg
            // 
            buttonAdaugaProg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdaugaProg.Image = Properties.Resources.button;
            buttonAdaugaProg.Location = new Point(3, 13);
            buttonAdaugaProg.Name = "buttonAdaugaProg";
            buttonAdaugaProg.Size = new Size(183, 41);
            buttonAdaugaProg.TabIndex = 52;
            buttonAdaugaProg.Text = "Adauga programare";
            buttonAdaugaProg.UseVisualStyleBackColor = true;
            buttonAdaugaProg.Click += buttonAdaugaProg_Click;
            // 
            // dateTimePickerData
            // 
            dateTimePickerData.Location = new Point(6, 201);
            dateTimePickerData.Name = "dateTimePickerData";
            dateTimePickerData.Size = new Size(183, 23);
            dateTimePickerData.TabIndex = 53;
            // 
            // dateTimePickerOra
            // 
            dateTimePickerOra.Format = DateTimePickerFormat.Time;
            dateTimePickerOra.Location = new Point(6, 230);
            dateTimePickerOra.Name = "dateTimePickerOra";
            dateTimePickerOra.Size = new Size(183, 23);
            dateTimePickerOra.TabIndex = 54;
            // 
            // buttonModifProg
            // 
            buttonModifProg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonModifProg.Image = Properties.Resources.button;
            buttonModifProg.Location = new Point(3, 60);
            buttonModifProg.Name = "buttonModifProg";
            buttonModifProg.Size = new Size(183, 41);
            buttonModifProg.TabIndex = 55;
            buttonModifProg.Text = "Modifica programare";
            buttonModifProg.UseVisualStyleBackColor = true;
            buttonModifProg.Click += buttonModifProg_Click;
            // 
            // buttonStergeProg
            // 
            buttonStergeProg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonStergeProg.Image = Properties.Resources.button;
            buttonStergeProg.Location = new Point(3, 107);
            buttonStergeProg.Name = "buttonStergeProg";
            buttonStergeProg.Size = new Size(183, 41);
            buttonStergeProg.TabIndex = 56;
            buttonStergeProg.Text = "Sterge programare";
            buttonStergeProg.UseVisualStyleBackColor = true;
            buttonStergeProg.Click += buttonStergeProg_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.Controls.Add(buttonAfisareToateProg);
            panel3.Controls.Add(buttonAdaugaProg);
            panel3.Controls.Add(dateTimePickerData);
            panel3.Controls.Add(buttonStergeProg);
            panel3.Controls.Add(dateTimePickerOra);
            panel3.Controls.Add(buttonModifProg);
            panel3.Location = new Point(446, 309);
            panel3.Name = "panel3";
            panel3.Size = new Size(192, 263);
            panel3.TabIndex = 58;
            // 
            // buttonAfisareToateProg
            // 
            buttonAfisareToateProg.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAfisareToateProg.Image = Properties.Resources.button;
            buttonAfisareToateProg.Location = new Point(3, 154);
            buttonAfisareToateProg.Name = "buttonAfisareToateProg";
            buttonAfisareToateProg.Size = new Size(183, 41);
            buttonAfisareToateProg.TabIndex = 58;
            buttonAfisareToateProg.Text = "Afiseaza toate programarile";
            buttonAfisareToateProg.UseVisualStyleBackColor = true;
            buttonAfisareToateProg.Click += buttonAfisareToateProg_Click;
            // 
            // textBoxDetaliiProg
            // 
            textBoxDetaliiProg.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDetaliiProg.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDetaliiProg.Location = new Point(646, 497);
            textBoxDetaliiProg.Multiline = true;
            textBoxDetaliiProg.Name = "textBoxDetaliiProg";
            textBoxDetaliiProg.PlaceholderText = "Detalii programare";
            textBoxDetaliiProg.ScrollBars = ScrollBars.Vertical;
            textBoxDetaliiProg.Size = new Size(651, 75);
            textBoxDetaliiProg.TabIndex = 59;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(153, 229, 80);
            panel2.Controls.Add(labelFiltre);
            panel2.Location = new Point(-10, 578);
            panel2.Name = "panel2";
            panel2.Size = new Size(1328, 46);
            panel2.TabIndex = 60;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(153, 229, 80);
            panel4.Controls.Add(labelAnimale);
            panel4.Location = new Point(-1, -1);
            panel4.Name = "panel4";
            panel4.Size = new Size(1310, 37);
            panel4.TabIndex = 61;
            // 
            // FormEditareCatalog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 214);
            ClientSize = new Size(1309, 793);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(textBoxDetaliiProg);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(dataGridViewProgramari);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridViewAnimale);
            MinimumSize = new Size(1325, 832);
            Name = "FormEditareCatalog";
            Text = "FormEditareCatalog";
            Load += FormEditareCatalog_Load;
            Shown += FormEditareCatalog_Shown;
            ResizeBegin += FormEditareCatalog_ResizeBegin;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnimale).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProgramari).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private Button buttonMeniu;
        private Button buttonAdaugaProg;
        private DateTimePicker dateTimePickerData;
        private DateTimePicker dateTimePickerOra;
        private Button buttonModifProg;
        private Button buttonStergeProg;
        private Panel panel3;
        private TextBox textBoxDetaliiProg;
        private Button buttonAfisareToateProg;
        private Panel panel2;
        private Panel panel4;
    }
}