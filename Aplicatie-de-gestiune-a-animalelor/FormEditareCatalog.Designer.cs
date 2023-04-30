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
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnimale).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAnimale
            // 
            dataGridViewAnimale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAnimale.Location = new Point(12, 34);
            dataGridViewAnimale.Name = "dataGridViewAnimale";
            dataGridViewAnimale.RowTemplate.Height = 25;
            dataGridViewAnimale.Size = new Size(776, 249);
            dataGridViewAnimale.TabIndex = 0;
            dataGridViewAnimale.SelectionChanged += dataGridViewAnimale_SelectionChanged;
            // 
            // textBoxRasa
            // 
            textBoxRasa.Location = new Point(111, 392);
            textBoxRasa.Name = "textBoxRasa";
            textBoxRasa.Size = new Size(70, 23);
            textBoxRasa.TabIndex = 5;
            // 
            // labelRasa
            // 
            labelRasa.AutoSize = true;
            labelRasa.Location = new Point(129, 365);
            labelRasa.Name = "labelRasa";
            labelRasa.Size = new Size(31, 15);
            labelRasa.TabIndex = 6;
            labelRasa.Text = "Rasa";
            // 
            // textBoxVarsta
            // 
            textBoxVarsta.Location = new Point(187, 392);
            textBoxVarsta.Name = "textBoxVarsta";
            textBoxVarsta.Size = new Size(57, 23);
            textBoxVarsta.TabIndex = 10;
            // 
            // labelVarsta
            // 
            labelVarsta.AutoSize = true;
            labelVarsta.Location = new Point(196, 365);
            labelVarsta.Name = "labelVarsta";
            labelVarsta.Size = new Size(38, 15);
            labelVarsta.TabIndex = 11;
            labelVarsta.Text = "Varsta";
            // 
            // textBoxGreutate
            // 
            textBoxGreutate.Location = new Point(288, 392);
            textBoxGreutate.Name = "textBoxGreutate";
            textBoxGreutate.Size = new Size(57, 23);
            textBoxGreutate.TabIndex = 14;
            // 
            // labelGreutate
            // 
            labelGreutate.AutoSize = true;
            labelGreutate.Location = new Point(288, 367);
            labelGreutate.Name = "labelGreutate";
            labelGreutate.Size = new Size(52, 15);
            labelGreutate.TabIndex = 15;
            labelGreutate.Text = "Greutate";
            // 
            // labelVaccinat
            // 
            labelVaccinat.AutoSize = true;
            labelVaccinat.Location = new Point(359, 363);
            labelVaccinat.Name = "labelVaccinat";
            labelVaccinat.Size = new Size(51, 15);
            labelVaccinat.TabIndex = 18;
            labelVaccinat.Text = "Vaccinat";
            // 
            // labelSterilizat
            // 
            labelSterilizat.AutoSize = true;
            labelSterilizat.Location = new Point(416, 363);
            labelSterilizat.Name = "labelSterilizat";
            labelSterilizat.Size = new Size(51, 15);
            labelSterilizat.TabIndex = 21;
            labelSterilizat.Text = "Sterilizat";
            // 
            // labelFiltre
            // 
            labelFiltre.AutoSize = true;
            labelFiltre.Location = new Point(336, 324);
            labelFiltre.Name = "labelFiltre";
            labelFiltre.Size = new Size(119, 15);
            labelFiltre.TabIndex = 24;
            labelFiltre.Text = "Optiuni de prelucrare";
            // 
            // labelAnimale
            // 
            labelAnimale.AutoSize = true;
            labelAnimale.Location = new Point(359, 9);
            labelAnimale.Name = "labelAnimale";
            labelAnimale.Size = new Size(51, 15);
            labelAnimale.TabIndex = 25;
            labelAnimale.Text = "Animale";
            // 
            // buttonAdauga
            // 
            buttonAdauga.Location = new Point(713, 355);
            buttonAdauga.Name = "buttonAdauga";
            buttonAdauga.Size = new Size(75, 23);
            buttonAdauga.TabIndex = 26;
            buttonAdauga.Text = "Adauga";
            buttonAdauga.UseVisualStyleBackColor = true;
            buttonAdauga.Click += buttonAdauga_Click;
            // 
            // buttonSterge
            // 
            buttonSterge.Location = new Point(713, 384);
            buttonSterge.Name = "buttonSterge";
            buttonSterge.Size = new Size(75, 23);
            buttonSterge.TabIndex = 27;
            buttonSterge.Text = "Sterge";
            buttonSterge.UseVisualStyleBackColor = true;
            buttonSterge.Click += buttonSterge_Click;
            // 
            // buttonModifica
            // 
            buttonModifica.Location = new Point(713, 413);
            buttonModifica.Name = "buttonModifica";
            buttonModifica.Size = new Size(75, 23);
            buttonModifica.TabIndex = 28;
            buttonModifica.Text = "Modifica";
            buttonModifica.UseVisualStyleBackColor = true;
            buttonModifica.Click += buttonModifica_Click;
            // 
            // comboBoxSpecie
            // 
            comboBoxSpecie.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSpecie.FormattingEnabled = true;
            comboBoxSpecie.Location = new Point(30, 392);
            comboBoxSpecie.Name = "comboBoxSpecie";
            comboBoxSpecie.Size = new Size(65, 23);
            comboBoxSpecie.TabIndex = 29;
            // 
            // labelSpecie
            // 
            labelSpecie.AutoSize = true;
            labelSpecie.Location = new Point(39, 363);
            labelSpecie.Name = "labelSpecie";
            labelSpecie.Size = new Size(41, 15);
            labelSpecie.TabIndex = 30;
            labelSpecie.Text = "Specie";
            // 
            // checkBoxSexM
            // 
            checkBoxSexM.AutoSize = true;
            checkBoxSexM.Location = new Point(249, 381);
            checkBoxSexM.Name = "checkBoxSexM";
            checkBoxSexM.Size = new Size(37, 19);
            checkBoxSexM.TabIndex = 37;
            checkBoxSexM.Text = "M";
            checkBoxSexM.UseVisualStyleBackColor = true;
            // 
            // checkBoxSexF
            // 
            checkBoxSexF.AutoSize = true;
            checkBoxSexF.Location = new Point(250, 397);
            checkBoxSexF.Name = "checkBoxSexF";
            checkBoxSexF.Size = new Size(32, 19);
            checkBoxSexF.TabIndex = 38;
            checkBoxSexF.Text = "F";
            checkBoxSexF.UseVisualStyleBackColor = true;
            // 
            // checkBoxVaccinatNu
            // 
            checkBoxVaccinatNu.AutoSize = true;
            checkBoxVaccinatNu.Location = new Point(359, 397);
            checkBoxVaccinatNu.Name = "checkBoxVaccinatNu";
            checkBoxVaccinatNu.Size = new Size(43, 19);
            checkBoxVaccinatNu.TabIndex = 42;
            checkBoxVaccinatNu.Text = "NU";
            checkBoxVaccinatNu.UseVisualStyleBackColor = true;
            // 
            // checkBoxVaccinatDa
            // 
            checkBoxVaccinatDa.AutoSize = true;
            checkBoxVaccinatDa.Location = new Point(359, 381);
            checkBoxVaccinatDa.Name = "checkBoxVaccinatDa";
            checkBoxVaccinatDa.Size = new Size(42, 19);
            checkBoxVaccinatDa.TabIndex = 41;
            checkBoxVaccinatDa.Text = "DA";
            checkBoxVaccinatDa.UseVisualStyleBackColor = true;
            // 
            // checkBoxSterNu
            // 
            checkBoxSterNu.AutoSize = true;
            checkBoxSterNu.Location = new Point(424, 397);
            checkBoxSterNu.Name = "checkBoxSterNu";
            checkBoxSterNu.Size = new Size(43, 19);
            checkBoxSterNu.TabIndex = 44;
            checkBoxSterNu.Text = "NU";
            checkBoxSterNu.UseVisualStyleBackColor = true;
            // 
            // checkBoxSterDa
            // 
            checkBoxSterDa.AutoSize = true;
            checkBoxSterDa.Location = new Point(423, 380);
            checkBoxSterDa.Name = "checkBoxSterDa";
            checkBoxSterDa.Size = new Size(42, 19);
            checkBoxSterDa.TabIndex = 43;
            checkBoxSterDa.Text = "DA";
            checkBoxSterDa.UseVisualStyleBackColor = true;
            // 
            // textBoxNume
            // 
            textBoxNume.Location = new Point(473, 392);
            textBoxNume.Name = "textBoxNume";
            textBoxNume.Size = new Size(57, 23);
            textBoxNume.TabIndex = 45;
            // 
            // labelNume
            // 
            labelNume.AutoSize = true;
            labelNume.Location = new Point(473, 363);
            labelNume.Name = "labelNume";
            labelNume.Size = new Size(40, 15);
            labelNume.TabIndex = 46;
            labelNume.Text = "Nume";
            // 
            // FormEditareCatalog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelNume);
            Controls.Add(textBoxNume);
            Controls.Add(checkBoxSterNu);
            Controls.Add(checkBoxSterDa);
            Controls.Add(checkBoxVaccinatNu);
            Controls.Add(checkBoxVaccinatDa);
            Controls.Add(checkBoxSexF);
            Controls.Add(checkBoxSexM);
            Controls.Add(labelSpecie);
            Controls.Add(comboBoxSpecie);
            Controls.Add(buttonModifica);
            Controls.Add(buttonSterge);
            Controls.Add(buttonAdauga);
            Controls.Add(labelAnimale);
            Controls.Add(labelFiltre);
            Controls.Add(labelSterilizat);
            Controls.Add(labelVaccinat);
            Controls.Add(labelGreutate);
            Controls.Add(textBoxGreutate);
            Controls.Add(labelVarsta);
            Controls.Add(textBoxVarsta);
            Controls.Add(labelRasa);
            Controls.Add(textBoxRasa);
            Controls.Add(dataGridViewAnimale);
            Name = "FormEditareCatalog";
            Text = "FormEditareCatalog";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnimale).EndInit();
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
    }
}