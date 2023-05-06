namespace Aplicatie_de_gestiune_a_animalelor
{
    partial class FormVizualizareCatalog
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
            labelFiltre = new Label();
            panel1 = new Panel();
            buttonResetareFiltre = new Button();
            checkBoxGreutateMaiMare = new CheckBox();
            checkBoxGreutateMaiMic = new CheckBox();
            checkBoxVarstaMaiMare = new CheckBox();
            checkBoxVarstaMaiMic = new CheckBox();
            buttonCautare = new Button();
            buttonMeniu = new Button();
            labelGreutate = new Label();
            comboBoxSpecie = new ComboBox();
            textBoxRasa = new TextBox();
            labelSpecie = new Label();
            labelRasa = new Label();
            checkBoxSexM = new CheckBox();
            textBoxVarsta = new TextBox();
            checkBoxSexF = new CheckBox();
            labelVarsta = new Label();
            checkBoxVaccinatDa = new CheckBox();
            textBoxGreutate = new TextBox();
            labelSterilizat = new Label();
            checkBoxSterNu = new CheckBox();
            checkBoxVaccinatNu = new CheckBox();
            labelVaccinat = new Label();
            checkBoxSterDa = new CheckBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnimale).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAnimale
            // 
            dataGridViewAnimale.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAnimale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAnimale.Location = new Point(12, 12);
            dataGridViewAnimale.Name = "dataGridViewAnimale";
            dataGridViewAnimale.RowTemplate.Height = 25;
            dataGridViewAnimale.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAnimale.Size = new Size(1285, 455);
            dataGridViewAnimale.TabIndex = 1;
            dataGridViewAnimale.SelectionChanged += dataGridViewAnimale_SelectionChanged;
            // 
            // labelFiltre
            // 
            labelFiltre.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelFiltre.AutoSize = true;
            labelFiltre.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelFiltre.Location = new Point(634, 481);
            labelFiltre.Name = "labelFiltre";
            labelFiltre.Size = new Size(76, 37);
            labelFiltre.TabIndex = 2;
            labelFiltre.Text = "Filtre";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.Controls.Add(buttonResetareFiltre);
            panel1.Controls.Add(checkBoxGreutateMaiMare);
            panel1.Controls.Add(checkBoxGreutateMaiMic);
            panel1.Controls.Add(checkBoxVarstaMaiMare);
            panel1.Controls.Add(checkBoxVarstaMaiMic);
            panel1.Controls.Add(buttonCautare);
            panel1.Controls.Add(buttonMeniu);
            panel1.Controls.Add(labelGreutate);
            panel1.Controls.Add(comboBoxSpecie);
            panel1.Controls.Add(textBoxRasa);
            panel1.Controls.Add(labelSpecie);
            panel1.Controls.Add(labelRasa);
            panel1.Controls.Add(checkBoxSexM);
            panel1.Controls.Add(textBoxVarsta);
            panel1.Controls.Add(checkBoxSexF);
            panel1.Controls.Add(labelVarsta);
            panel1.Controls.Add(checkBoxVaccinatDa);
            panel1.Controls.Add(textBoxGreutate);
            panel1.Controls.Add(labelSterilizat);
            panel1.Controls.Add(checkBoxSterNu);
            panel1.Controls.Add(checkBoxVaccinatNu);
            panel1.Controls.Add(labelVaccinat);
            panel1.Controls.Add(checkBoxSterDa);
            panel1.Location = new Point(470, 535);
            panel1.Name = "panel1";
            panel1.Size = new Size(827, 246);
            panel1.TabIndex = 3;
            // 
            // buttonResetareFiltre
            // 
            buttonResetareFiltre.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonResetareFiltre.Location = new Point(573, 154);
            buttonResetareFiltre.Name = "buttonResetareFiltre";
            buttonResetareFiltre.Size = new Size(75, 45);
            buttonResetareFiltre.TabIndex = 76;
            buttonResetareFiltre.Text = "Resetare filtre";
            buttonResetareFiltre.UseVisualStyleBackColor = true;
            buttonResetareFiltre.Click += buttonResetareFiltre_Click;
            // 
            // checkBoxGreutateMaiMare
            // 
            checkBoxGreutateMaiMare.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxGreutateMaiMare.AutoSize = true;
            checkBoxGreutateMaiMare.Location = new Point(329, 178);
            checkBoxGreutateMaiMare.Name = "checkBoxGreutateMaiMare";
            checkBoxGreutateMaiMare.Size = new Size(34, 19);
            checkBoxGreutateMaiMare.TabIndex = 75;
            checkBoxGreutateMaiMare.Text = ">";
            checkBoxGreutateMaiMare.UseVisualStyleBackColor = true;
            checkBoxGreutateMaiMare.CheckedChanged += checkBoxGreutateMaiMare_CheckedChanged;
            // 
            // checkBoxGreutateMaiMic
            // 
            checkBoxGreutateMaiMic.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxGreutateMaiMic.AutoSize = true;
            checkBoxGreutateMaiMic.Location = new Point(329, 162);
            checkBoxGreutateMaiMic.Name = "checkBoxGreutateMaiMic";
            checkBoxGreutateMaiMic.Size = new Size(34, 19);
            checkBoxGreutateMaiMic.TabIndex = 74;
            checkBoxGreutateMaiMic.Text = "<";
            checkBoxGreutateMaiMic.UseVisualStyleBackColor = true;
            checkBoxGreutateMaiMic.CheckedChanged += checkBoxGreutateMaiMic_CheckedChanged;
            // 
            // checkBoxVarstaMaiMare
            // 
            checkBoxVarstaMaiMare.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxVarstaMaiMare.AutoSize = true;
            checkBoxVarstaMaiMare.Location = new Point(182, 180);
            checkBoxVarstaMaiMare.Name = "checkBoxVarstaMaiMare";
            checkBoxVarstaMaiMare.Size = new Size(34, 19);
            checkBoxVarstaMaiMare.TabIndex = 73;
            checkBoxVarstaMaiMare.Text = ">";
            checkBoxVarstaMaiMare.UseVisualStyleBackColor = true;
            checkBoxVarstaMaiMare.CheckedChanged += checkBoxVarstaMaiMare_CheckedChanged;
            // 
            // checkBoxVarstaMaiMic
            // 
            checkBoxVarstaMaiMic.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxVarstaMaiMic.AutoSize = true;
            checkBoxVarstaMaiMic.Location = new Point(182, 164);
            checkBoxVarstaMaiMic.Name = "checkBoxVarstaMaiMic";
            checkBoxVarstaMaiMic.Size = new Size(34, 19);
            checkBoxVarstaMaiMic.TabIndex = 72;
            checkBoxVarstaMaiMic.Text = "<";
            checkBoxVarstaMaiMic.UseVisualStyleBackColor = true;
            checkBoxVarstaMaiMic.CheckedChanged += checkBoxVarstaMaiMic_CheckedChanged;
            // 
            // buttonCautare
            // 
            buttonCautare.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCautare.Location = new Point(654, 154);
            buttonCautare.Name = "buttonCautare";
            buttonCautare.Size = new Size(75, 45);
            buttonCautare.TabIndex = 71;
            buttonCautare.Text = "Cautare";
            buttonCautare.UseVisualStyleBackColor = true;
            buttonCautare.Click += buttonCautare_Click;
            // 
            // buttonMeniu
            // 
            buttonMeniu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonMeniu.Location = new Point(735, 154);
            buttonMeniu.Name = "buttonMeniu";
            buttonMeniu.Size = new Size(73, 45);
            buttonMeniu.TabIndex = 48;
            buttonMeniu.Text = "Meniu";
            buttonMeniu.UseVisualStyleBackColor = true;
            buttonMeniu.Click += buttonMeniu_Click;
            // 
            // labelGreutate
            // 
            labelGreutate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelGreutate.AutoSize = true;
            labelGreutate.Location = new Point(369, 150);
            labelGreutate.Name = "labelGreutate";
            labelGreutate.Size = new Size(52, 15);
            labelGreutate.TabIndex = 54;
            labelGreutate.Text = "Greutate";
            // 
            // comboBoxSpecie
            // 
            comboBoxSpecie.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboBoxSpecie.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSpecie.FormattingEnabled = true;
            comboBoxSpecie.Location = new Point(15, 175);
            comboBoxSpecie.Name = "comboBoxSpecie";
            comboBoxSpecie.Size = new Size(65, 23);
            comboBoxSpecie.TabIndex = 61;
            // 
            // textBoxRasa
            // 
            textBoxRasa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxRasa.Location = new Point(96, 175);
            textBoxRasa.Name = "textBoxRasa";
            textBoxRasa.Size = new Size(70, 23);
            textBoxRasa.TabIndex = 49;
            // 
            // labelSpecie
            // 
            labelSpecie.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelSpecie.AutoSize = true;
            labelSpecie.Location = new Point(24, 146);
            labelSpecie.Name = "labelSpecie";
            labelSpecie.Size = new Size(41, 15);
            labelSpecie.TabIndex = 62;
            labelSpecie.Text = "Specie";
            // 
            // labelRasa
            // 
            labelRasa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelRasa.AutoSize = true;
            labelRasa.Location = new Point(114, 148);
            labelRasa.Name = "labelRasa";
            labelRasa.Size = new Size(31, 15);
            labelRasa.TabIndex = 50;
            labelRasa.Text = "Rasa";
            // 
            // checkBoxSexM
            // 
            checkBoxSexM.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxSexM.AutoSize = true;
            checkBoxSexM.Location = new Point(280, 162);
            checkBoxSexM.Name = "checkBoxSexM";
            checkBoxSexM.Size = new Size(37, 19);
            checkBoxSexM.TabIndex = 63;
            checkBoxSexM.Text = "M";
            checkBoxSexM.UseVisualStyleBackColor = true;
            checkBoxSexM.CheckedChanged += checkBoxSexM_CheckedChanged;
            // 
            // textBoxVarsta
            // 
            textBoxVarsta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxVarsta.Location = new Point(218, 175);
            textBoxVarsta.Name = "textBoxVarsta";
            textBoxVarsta.Size = new Size(57, 23);
            textBoxVarsta.TabIndex = 51;
            // 
            // checkBoxSexF
            // 
            checkBoxSexF.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxSexF.AutoSize = true;
            checkBoxSexF.Location = new Point(281, 180);
            checkBoxSexF.Name = "checkBoxSexF";
            checkBoxSexF.Size = new Size(32, 19);
            checkBoxSexF.TabIndex = 64;
            checkBoxSexF.Text = "F";
            checkBoxSexF.UseVisualStyleBackColor = true;
            checkBoxSexF.CheckedChanged += checkBoxSexF_CheckedChanged;
            // 
            // labelVarsta
            // 
            labelVarsta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelVarsta.AutoSize = true;
            labelVarsta.Location = new Point(227, 148);
            labelVarsta.Name = "labelVarsta";
            labelVarsta.Size = new Size(38, 15);
            labelVarsta.TabIndex = 52;
            labelVarsta.Text = "Varsta";
            // 
            // checkBoxVaccinatDa
            // 
            checkBoxVaccinatDa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxVaccinatDa.AutoSize = true;
            checkBoxVaccinatDa.Location = new Point(440, 164);
            checkBoxVaccinatDa.Name = "checkBoxVaccinatDa";
            checkBoxVaccinatDa.Size = new Size(42, 19);
            checkBoxVaccinatDa.TabIndex = 65;
            checkBoxVaccinatDa.Text = "DA";
            checkBoxVaccinatDa.UseVisualStyleBackColor = true;
            checkBoxVaccinatDa.CheckedChanged += checkBoxVaccinatDa_CheckedChanged;
            // 
            // textBoxGreutate
            // 
            textBoxGreutate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxGreutate.Location = new Point(369, 175);
            textBoxGreutate.Name = "textBoxGreutate";
            textBoxGreutate.Size = new Size(57, 23);
            textBoxGreutate.TabIndex = 53;
            // 
            // labelSterilizat
            // 
            labelSterilizat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelSterilizat.AutoSize = true;
            labelSterilizat.Location = new Point(497, 146);
            labelSterilizat.Name = "labelSterilizat";
            labelSterilizat.Size = new Size(51, 15);
            labelSterilizat.TabIndex = 56;
            labelSterilizat.Text = "Sterilizat";
            // 
            // checkBoxSterNu
            // 
            checkBoxSterNu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxSterNu.AutoSize = true;
            checkBoxSterNu.Location = new Point(505, 180);
            checkBoxSterNu.Name = "checkBoxSterNu";
            checkBoxSterNu.Size = new Size(43, 19);
            checkBoxSterNu.TabIndex = 68;
            checkBoxSterNu.Text = "NU";
            checkBoxSterNu.UseVisualStyleBackColor = true;
            checkBoxSterNu.CheckedChanged += checkBoxSterNu_CheckedChanged;
            // 
            // checkBoxVaccinatNu
            // 
            checkBoxVaccinatNu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxVaccinatNu.AutoSize = true;
            checkBoxVaccinatNu.Location = new Point(440, 180);
            checkBoxVaccinatNu.Name = "checkBoxVaccinatNu";
            checkBoxVaccinatNu.Size = new Size(43, 19);
            checkBoxVaccinatNu.TabIndex = 66;
            checkBoxVaccinatNu.Text = "NU";
            checkBoxVaccinatNu.UseVisualStyleBackColor = true;
            checkBoxVaccinatNu.CheckedChanged += checkBoxVaccinatNu_CheckedChanged;
            // 
            // labelVaccinat
            // 
            labelVaccinat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelVaccinat.AutoSize = true;
            labelVaccinat.Location = new Point(440, 146);
            labelVaccinat.Name = "labelVaccinat";
            labelVaccinat.Size = new Size(51, 15);
            labelVaccinat.TabIndex = 55;
            labelVaccinat.Text = "Vaccinat";
            // 
            // checkBoxSterDa
            // 
            checkBoxSterDa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxSterDa.AutoSize = true;
            checkBoxSterDa.Location = new Point(504, 163);
            checkBoxSterDa.Name = "checkBoxSterDa";
            checkBoxSterDa.Size = new Size(42, 19);
            checkBoxSterDa.TabIndex = 67;
            checkBoxSterDa.Text = "DA";
            checkBoxSterDa.UseVisualStyleBackColor = true;
            checkBoxSterDa.CheckedChanged += checkBoxSterDa_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Location = new Point(12, 484);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(452, 297);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 77;
            pictureBox1.TabStop = false;
            // 
            // FormVizualizareCatalog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1309, 793);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(labelFiltre);
            Controls.Add(dataGridViewAnimale);
            MinimumSize = new Size(1325, 832);
            Name = "FormVizualizareCatalog";
            Text = "FormVizualizareCatalog";
            ResizeBegin += FormVizualizareCatalog_ResizeBegin;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnimale).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewAnimale;
        private Label labelFiltre;
        private Panel panel1;
        private Button buttonMeniu;
        private Label labelGreutate;
        private ComboBox comboBoxSpecie;
        private TextBox textBoxRasa;
        private Label labelSpecie;
        private Label labelRasa;
        private CheckBox checkBoxSexM;
        private TextBox textBoxVarsta;
        private CheckBox checkBoxSexF;
        private Label labelVarsta;
        private CheckBox checkBoxVaccinatDa;
        private TextBox textBoxGreutate;
        private Label labelSterilizat;
        private CheckBox checkBoxSterNu;
        private CheckBox checkBoxVaccinatNu;
        private Label labelVaccinat;
        private CheckBox checkBoxSterDa;
        private Button buttonCautare;
        private CheckBox checkBoxGreutateMaiMare;
        private CheckBox checkBoxGreutateMaiMic;
        private CheckBox checkBoxVarstaMaiMare;
        private CheckBox checkBoxVarstaMaiMic;
        private Button buttonResetareFiltre;
        private PictureBox pictureBox1;
    }
}