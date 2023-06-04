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
            buttonInstructiuni = new Button();
            textBoxNumarFisa = new TextBox();
            labelNumarFisa = new Label();
            dateTimePickerOra = new DateTimePicker();
            labelOra = new Label();
            dateTimePickerData = new DateTimePicker();
            labelData = new Label();
            labelTratament = new Label();
            textBoxTratament = new TextBox();
            labelDiagnostic = new Label();
            textBoxRasa = new TextBox();
            textBoxDiagnostic = new TextBox();
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
            labelFise.Size = new Size(176, 37);
            labelFise.TabIndex = 5;
            labelFise.Text = "Fise medicale";
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
            dataGridViewAnimale.AllowUserToDeleteRows = false;
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
            dataGridViewAnimale.TabIndex = 0;
            dataGridViewAnimale.CellMouseDoubleClick += dataGridViewAnimale_CellMouseDoubleClick;
            dataGridViewAnimale.SelectionChanged += dataGridViewAnimale_SelectionChanged;
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
            labelPrelucrari.Size = new Size(289, 37);
            labelPrelucrari.TabIndex = 3;
            labelPrelucrari.Text = "Prelucrari fisa medicala";
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
            dataGridViewFiseMedicale.AllowUserToDeleteRows = false;
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
            dataGridViewFiseMedicale.TabIndex = 0;
            dataGridViewFiseMedicale.SelectionChanged += dataGridViewFiseMedicale_SelectionChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.Controls.Add(buttonInstructiuni);
            panel1.Controls.Add(textBoxNumarFisa);
            panel1.Controls.Add(labelNumarFisa);
            panel1.Controls.Add(dateTimePickerOra);
            panel1.Controls.Add(labelOra);
            panel1.Controls.Add(dateTimePickerData);
            panel1.Controls.Add(labelData);
            panel1.Controls.Add(labelTratament);
            panel1.Controls.Add(textBoxTratament);
            panel1.Controls.Add(labelDiagnostic);
            panel1.Controls.Add(textBoxRasa);
            panel1.Controls.Add(textBoxDiagnostic);
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
            panel1.Size = new Size(908, 325);
            panel1.TabIndex = 86;
            // 
            // buttonInstructiuni
            // 
            buttonInstructiuni.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonInstructiuni.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonInstructiuni.Image = Properties.Resources.button;
            buttonInstructiuni.Location = new Point(704, 264);
            buttonInstructiuni.Name = "buttonInstructiuni";
            buttonInstructiuni.Size = new Size(201, 58);
            buttonInstructiuni.TabIndex = 96;
            buttonInstructiuni.Text = "Instructiuni";
            buttonInstructiuni.UseVisualStyleBackColor = true;
            buttonInstructiuni.Click += buttonInstructiuni_Click;
            // 
            // textBoxNumarFisa
            // 
            textBoxNumarFisa.Location = new Point(210, 251);
            textBoxNumarFisa.Name = "textBoxNumarFisa";
            textBoxNumarFisa.Size = new Size(96, 23);
            textBoxNumarFisa.TabIndex = 95;
            // 
            // labelNumarFisa
            // 
            labelNumarFisa.AutoSize = true;
            labelNumarFisa.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelNumarFisa.Location = new Point(93, 249);
            labelNumarFisa.Name = "labelNumarFisa";
            labelNumarFisa.Size = new Size(107, 25);
            labelNumarFisa.TabIndex = 94;
            labelNumarFisa.Text = "Numar Fisa";
            // 
            // dateTimePickerOra
            // 
            dateTimePickerOra.Format = DateTimePickerFormat.Time;
            dateTimePickerOra.Location = new Point(263, 214);
            dateTimePickerOra.Name = "dateTimePickerOra";
            dateTimePickerOra.Size = new Size(200, 23);
            dateTimePickerOra.TabIndex = 93;
            // 
            // labelOra
            // 
            labelOra.AutoSize = true;
            labelOra.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelOra.Location = new Point(93, 212);
            labelOra.Name = "labelOra";
            labelOra.Size = new Size(144, 25);
            labelOra.TabIndex = 92;
            labelOra.Text = "Ora Consultului";
            // 
            // dateTimePickerData
            // 
            dateTimePickerData.Location = new Point(263, 179);
            dateTimePickerData.Name = "dateTimePickerData";
            dateTimePickerData.Size = new Size(200, 23);
            dateTimePickerData.TabIndex = 91;
            // 
            // labelData
            // 
            labelData.AutoSize = true;
            labelData.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelData.Location = new Point(93, 177);
            labelData.Name = "labelData";
            labelData.Size = new Size(152, 25);
            labelData.TabIndex = 90;
            labelData.Text = "Data Consultului";
            // 
            // labelTratament
            // 
            labelTratament.AutoSize = true;
            labelTratament.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelTratament.Location = new Point(93, 136);
            labelTratament.Name = "labelTratament";
            labelTratament.Size = new Size(96, 25);
            labelTratament.TabIndex = 89;
            labelTratament.Text = "Tratament";
            // 
            // textBoxTratament
            // 
            textBoxTratament.Location = new Point(210, 136);
            textBoxTratament.Name = "textBoxTratament";
            textBoxTratament.Size = new Size(683, 23);
            textBoxTratament.TabIndex = 88;
            // 
            // labelDiagnostic
            // 
            labelDiagnostic.AutoSize = true;
            labelDiagnostic.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelDiagnostic.Location = new Point(91, 100);
            labelDiagnostic.Name = "labelDiagnostic";
            labelDiagnostic.Size = new Size(101, 25);
            labelDiagnostic.TabIndex = 48;
            labelDiagnostic.Text = "Diagnostic";
            // 
            // textBoxRasa
            // 
            textBoxRasa.Location = new Point(172, 39);
            textBoxRasa.Name = "textBoxRasa";
            textBoxRasa.Size = new Size(96, 23);
            textBoxRasa.TabIndex = 5;
            // 
            // textBoxDiagnostic
            // 
            textBoxDiagnostic.Location = new Point(210, 100);
            textBoxDiagnostic.Name = "textBoxDiagnostic";
            textBoxDiagnostic.Size = new Size(683, 23);
            textBoxDiagnostic.TabIndex = 87;
            // 
            // labelRasa
            // 
            labelRasa.AutoSize = true;
            labelRasa.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelRasa.Location = new Point(191, 8);
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
            buttonPoza.Location = new Point(906, 330);
            buttonPoza.Name = "buttonPoza";
            buttonPoza.Size = new Size(179, 43);
            buttonPoza.TabIndex = 47;
            buttonPoza.Text = "Cauta poza";
            buttonPoza.UseVisualStyleBackColor = true;
            // 
            // textBoxVarsta
            // 
            textBoxVarsta.Location = new Point(299, 39);
            textBoxVarsta.Name = "textBoxVarsta";
            textBoxVarsta.Size = new Size(57, 23);
            textBoxVarsta.TabIndex = 10;
            // 
            // labelNume
            // 
            labelNume.AutoSize = true;
            labelNume.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelNume.Location = new Point(744, 8);
            labelNume.Name = "labelNume";
            labelNume.Size = new Size(63, 25);
            labelNume.TabIndex = 46;
            labelNume.Text = "Nume";
            // 
            // labelVarsta
            // 
            labelVarsta.AutoSize = true;
            labelVarsta.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelVarsta.Location = new Point(299, 8);
            labelVarsta.Name = "labelVarsta";
            labelVarsta.Size = new Size(64, 25);
            labelVarsta.TabIndex = 11;
            labelVarsta.Text = "Varsta";
            // 
            // textBoxNume
            // 
            textBoxNume.Location = new Point(731, 36);
            textBoxNume.Name = "textBoxNume";
            textBoxNume.Size = new Size(98, 23);
            textBoxNume.TabIndex = 45;
            // 
            // textBoxGreutate
            // 
            textBoxGreutate.Location = new Point(388, 39);
            textBoxGreutate.Name = "textBoxGreutate";
            textBoxGreutate.Size = new Size(57, 23);
            textBoxGreutate.TabIndex = 14;
            // 
            // checkBoxSterNu
            // 
            checkBoxSterNu.AutoSize = true;
            checkBoxSterNu.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxSterNu.Location = new Point(662, 33);
            checkBoxSterNu.Name = "checkBoxSterNu";
            checkBoxSterNu.Size = new Size(58, 29);
            checkBoxSterNu.TabIndex = 44;
            checkBoxSterNu.Text = "NU";
            checkBoxSterNu.UseVisualStyleBackColor = true;
            checkBoxSterNu.CheckedChanged += checkBoxSterNu_CheckedChanged;
            // 
            // labelGreutate
            // 
            labelGreutate.AutoSize = true;
            labelGreutate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelGreutate.Location = new Point(378, 8);
            labelGreutate.Name = "labelGreutate";
            labelGreutate.Size = new Size(85, 25);
            labelGreutate.TabIndex = 15;
            labelGreutate.Text = "Greutate";
            // 
            // checkBoxSterDa
            // 
            checkBoxSterDa.AutoSize = true;
            checkBoxSterDa.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxSterDa.Location = new Point(600, 33);
            checkBoxSterDa.Name = "checkBoxSterDa";
            checkBoxSterDa.Size = new Size(56, 29);
            checkBoxSterDa.TabIndex = 43;
            checkBoxSterDa.Text = "DA";
            checkBoxSterDa.UseVisualStyleBackColor = true;
            checkBoxSterDa.CheckedChanged += checkBoxSterDa_CheckedChanged;
            // 
            // labelVaccinat
            // 
            labelVaccinat.AutoSize = true;
            labelVaccinat.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelVaccinat.Location = new Point(485, 8);
            labelVaccinat.Name = "labelVaccinat";
            labelVaccinat.Size = new Size(83, 25);
            labelVaccinat.TabIndex = 18;
            labelVaccinat.Text = "Vaccinat";
            // 
            // checkBoxVaccinatNu
            // 
            checkBoxVaccinatNu.AutoSize = true;
            checkBoxVaccinatNu.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxVaccinatNu.Location = new Point(531, 31);
            checkBoxVaccinatNu.Name = "checkBoxVaccinatNu";
            checkBoxVaccinatNu.Size = new Size(58, 29);
            checkBoxVaccinatNu.TabIndex = 42;
            checkBoxVaccinatNu.Text = "NU";
            checkBoxVaccinatNu.UseVisualStyleBackColor = true;
            checkBoxVaccinatNu.CheckedChanged += checkBoxVaccinatNu_CheckedChanged;
            // 
            // labelSterilizat
            // 
            labelSterilizat.AutoSize = true;
            labelSterilizat.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelSterilizat.Location = new Point(610, 8);
            labelSterilizat.Name = "labelSterilizat";
            labelSterilizat.Size = new Size(84, 25);
            labelSterilizat.TabIndex = 21;
            labelSterilizat.Text = "Sterilizat";
            // 
            // checkBoxVaccinatDa
            // 
            checkBoxVaccinatDa.AutoSize = true;
            checkBoxVaccinatDa.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxVaccinatDa.Location = new Point(469, 31);
            checkBoxVaccinatDa.Name = "checkBoxVaccinatDa";
            checkBoxVaccinatDa.Size = new Size(56, 29);
            checkBoxVaccinatDa.TabIndex = 41;
            checkBoxVaccinatDa.Text = "DA";
            checkBoxVaccinatDa.UseVisualStyleBackColor = true;
            checkBoxVaccinatDa.CheckedChanged += checkBoxVaccinatDa_CheckedChanged;
            // 
            // checkBoxSexF
            // 
            checkBoxSexF.AutoSize = true;
            checkBoxSexF.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxSexF.Location = new Point(845, 36);
            checkBoxSexF.Name = "checkBoxSexF";
            checkBoxSexF.Size = new Size(40, 29);
            checkBoxSexF.TabIndex = 38;
            checkBoxSexF.Text = "F";
            checkBoxSexF.UseVisualStyleBackColor = true;
            checkBoxSexF.CheckedChanged += checkBoxSexF_CheckedChanged;
            // 
            // checkBoxSexM
            // 
            checkBoxSexM.AutoSize = true;
            checkBoxSexM.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxSexM.Location = new Point(845, 7);
            checkBoxSexM.Name = "checkBoxSexM";
            checkBoxSexM.Size = new Size(48, 29);
            checkBoxSexM.TabIndex = 37;
            checkBoxSexM.Text = "M";
            checkBoxSexM.UseVisualStyleBackColor = true;
            checkBoxSexM.CheckedChanged += checkBoxSexM_CheckedChanged;
            // 
            // labelSpecie
            // 
            labelSpecie.AutoSize = true;
            labelSpecie.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelSpecie.Location = new Point(91, 8);
            labelSpecie.Name = "labelSpecie";
            labelSpecie.Size = new Size(67, 25);
            labelSpecie.TabIndex = 30;
            labelSpecie.Text = "Specie";
            // 
            // comboBoxSpecie
            // 
            comboBoxSpecie.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSpecie.FormattingEnabled = true;
            comboBoxSpecie.Location = new Point(93, 39);
            comboBoxSpecie.Name = "comboBoxSpecie";
            comboBoxSpecie.Size = new Size(65, 23);
            comboBoxSpecie.TabIndex = 29;
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
            buttonSterge.Click += buttonSterge_Click;
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
            buttonModifica.Click += buttonModifica_Click;
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
            buttonAdauga.Click += buttonAdauga_Click;
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
        private TextBox textBoxDiagnostic;
        private Label labelTratament;
        private TextBox textBoxTratament;
        private Button buttonSterge;
        private Button buttonModifica;
        private Button buttonAdauga;
        private DateTimePicker dateTimePickerData;
        private Label labelData;
        private Label labelOra;
        private DateTimePicker dateTimePickerOra;
        private TextBox textBoxNumarFisa;
        private Label labelNumarFisa;
        private Button buttonInstructiuni;
    }
}