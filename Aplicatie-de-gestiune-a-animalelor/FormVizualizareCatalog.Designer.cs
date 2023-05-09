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
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnimale).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
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
            dataGridViewAnimale.Size = new Size(1306, 363);
            dataGridViewAnimale.TabIndex = 1;
            dataGridViewAnimale.SelectionChanged += dataGridViewAnimale_SelectionChanged;
            // 
            // labelFiltre
            // 
            labelFiltre.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelFiltre.AutoSize = true;
            labelFiltre.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelFiltre.Location = new Point(651, 7);
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
            panel1.Location = new Point(470, 468);
            panel1.Name = "panel1";
            panel1.Size = new Size(827, 313);
            panel1.TabIndex = 3;
            // 
            // buttonResetareFiltre
            // 
            buttonResetareFiltre.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonResetareFiltre.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonResetareFiltre.Image = Properties.Resources.button;
            buttonResetareFiltre.Location = new Point(590, 119);
            buttonResetareFiltre.Name = "buttonResetareFiltre";
            buttonResetareFiltre.Size = new Size(222, 75);
            buttonResetareFiltre.TabIndex = 76;
            buttonResetareFiltre.Text = "Resetare filtre";
            buttonResetareFiltre.UseVisualStyleBackColor = true;
            buttonResetareFiltre.Click += buttonResetareFiltre_Click;
            // 
            // checkBoxGreutateMaiMare
            // 
            checkBoxGreutateMaiMare.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxGreutateMaiMare.AutoSize = true;
            checkBoxGreutateMaiMare.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxGreutateMaiMare.Location = new Point(64, 131);
            checkBoxGreutateMaiMare.Name = "checkBoxGreutateMaiMare";
            checkBoxGreutateMaiMare.Size = new Size(44, 29);
            checkBoxGreutateMaiMare.TabIndex = 75;
            checkBoxGreutateMaiMare.Text = ">";
            checkBoxGreutateMaiMare.UseVisualStyleBackColor = true;
            checkBoxGreutateMaiMare.CheckedChanged += checkBoxGreutateMaiMare_CheckedChanged;
            // 
            // checkBoxGreutateMaiMic
            // 
            checkBoxGreutateMaiMic.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxGreutateMaiMic.AutoSize = true;
            checkBoxGreutateMaiMic.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxGreutateMaiMic.Location = new Point(14, 131);
            checkBoxGreutateMaiMic.Name = "checkBoxGreutateMaiMic";
            checkBoxGreutateMaiMic.Size = new Size(44, 29);
            checkBoxGreutateMaiMic.TabIndex = 74;
            checkBoxGreutateMaiMic.Text = "<";
            checkBoxGreutateMaiMic.UseVisualStyleBackColor = true;
            checkBoxGreutateMaiMic.CheckedChanged += checkBoxGreutateMaiMic_CheckedChanged;
            // 
            // checkBoxVarstaMaiMare
            // 
            checkBoxVarstaMaiMare.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxVarstaMaiMare.AutoSize = true;
            checkBoxVarstaMaiMare.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxVarstaMaiMare.Location = new Point(290, 44);
            checkBoxVarstaMaiMare.Name = "checkBoxVarstaMaiMare";
            checkBoxVarstaMaiMare.Size = new Size(44, 29);
            checkBoxVarstaMaiMare.TabIndex = 73;
            checkBoxVarstaMaiMare.Text = ">";
            checkBoxVarstaMaiMare.UseVisualStyleBackColor = true;
            checkBoxVarstaMaiMare.CheckedChanged += checkBoxVarstaMaiMare_CheckedChanged;
            // 
            // checkBoxVarstaMaiMic
            // 
            checkBoxVarstaMaiMic.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxVarstaMaiMic.AutoSize = true;
            checkBoxVarstaMaiMic.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxVarstaMaiMic.Location = new Point(249, 44);
            checkBoxVarstaMaiMic.Name = "checkBoxVarstaMaiMic";
            checkBoxVarstaMaiMic.Size = new Size(44, 29);
            checkBoxVarstaMaiMic.TabIndex = 72;
            checkBoxVarstaMaiMic.Text = "<";
            checkBoxVarstaMaiMic.UseVisualStyleBackColor = true;
            checkBoxVarstaMaiMic.CheckedChanged += checkBoxVarstaMaiMic_CheckedChanged;
            // 
            // buttonCautare
            // 
            buttonCautare.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCautare.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCautare.Image = Properties.Resources.button;
            buttonCautare.Location = new Point(590, 18);
            buttonCautare.Name = "buttonCautare";
            buttonCautare.Size = new Size(222, 76);
            buttonCautare.TabIndex = 71;
            buttonCautare.Text = "Cautare";
            buttonCautare.UseVisualStyleBackColor = true;
            buttonCautare.Click += buttonCautare_Click;
            // 
            // buttonMeniu
            // 
            buttonMeniu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonMeniu.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMeniu.Image = Properties.Resources.button;
            buttonMeniu.Location = new Point(590, 217);
            buttonMeniu.Name = "buttonMeniu";
            buttonMeniu.Size = new Size(222, 75);
            buttonMeniu.TabIndex = 48;
            buttonMeniu.Text = "Meniu";
            buttonMeniu.UseVisualStyleBackColor = true;
            buttonMeniu.Click += buttonMeniu_Click;
            // 
            // labelGreutate
            // 
            labelGreutate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelGreutate.AutoSize = true;
            labelGreutate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelGreutate.Location = new Point(29, 104);
            labelGreutate.Name = "labelGreutate";
            labelGreutate.Size = new Size(85, 25);
            labelGreutate.TabIndex = 54;
            labelGreutate.Text = "Greutate";
            // 
            // comboBoxSpecie
            // 
            comboBoxSpecie.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboBoxSpecie.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSpecie.FormattingEnabled = true;
            comboBoxSpecie.Location = new Point(14, 50);
            comboBoxSpecie.Name = "comboBoxSpecie";
            comboBoxSpecie.Size = new Size(102, 23);
            comboBoxSpecie.TabIndex = 61;
            // 
            // textBoxRasa
            // 
            textBoxRasa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxRasa.Location = new Point(138, 50);
            textBoxRasa.Name = "textBoxRasa";
            textBoxRasa.Size = new Size(98, 23);
            textBoxRasa.TabIndex = 49;
            // 
            // labelSpecie
            // 
            labelSpecie.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelSpecie.AutoSize = true;
            labelSpecie.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelSpecie.Location = new Point(29, 22);
            labelSpecie.Name = "labelSpecie";
            labelSpecie.Size = new Size(67, 25);
            labelSpecie.TabIndex = 62;
            labelSpecie.Text = "Specie";
            // 
            // labelRasa
            // 
            labelRasa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelRasa.AutoSize = true;
            labelRasa.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelRasa.Location = new Point(165, 22);
            labelRasa.Name = "labelRasa";
            labelRasa.Size = new Size(51, 25);
            labelRasa.TabIndex = 50;
            labelRasa.Text = "Rasa";
            // 
            // checkBoxSexM
            // 
            checkBoxSexM.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxSexM.AutoSize = true;
            checkBoxSexM.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxSexM.Location = new Point(443, 22);
            checkBoxSexM.Name = "checkBoxSexM";
            checkBoxSexM.Size = new Size(48, 29);
            checkBoxSexM.TabIndex = 63;
            checkBoxSexM.Text = "M";
            checkBoxSexM.UseVisualStyleBackColor = true;
            checkBoxSexM.CheckedChanged += checkBoxSexM_CheckedChanged;
            // 
            // textBoxVarsta
            // 
            textBoxVarsta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxVarsta.Location = new Point(340, 50);
            textBoxVarsta.Name = "textBoxVarsta";
            textBoxVarsta.Size = new Size(93, 23);
            textBoxVarsta.TabIndex = 51;
            // 
            // checkBoxSexF
            // 
            checkBoxSexF.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxSexF.AutoSize = true;
            checkBoxSexF.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxSexF.Location = new Point(443, 50);
            checkBoxSexF.Name = "checkBoxSexF";
            checkBoxSexF.Size = new Size(40, 29);
            checkBoxSexF.TabIndex = 64;
            checkBoxSexF.Text = "F";
            checkBoxSexF.UseVisualStyleBackColor = true;
            checkBoxSexF.CheckedChanged += checkBoxSexF_CheckedChanged;
            // 
            // labelVarsta
            // 
            labelVarsta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelVarsta.AutoSize = true;
            labelVarsta.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelVarsta.Location = new Point(290, 22);
            labelVarsta.Name = "labelVarsta";
            labelVarsta.Size = new Size(64, 25);
            labelVarsta.TabIndex = 52;
            labelVarsta.Text = "Varsta";
            // 
            // checkBoxVaccinatDa
            // 
            checkBoxVaccinatDa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxVaccinatDa.AutoSize = true;
            checkBoxVaccinatDa.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxVaccinatDa.Location = new Point(219, 131);
            checkBoxVaccinatDa.Name = "checkBoxVaccinatDa";
            checkBoxVaccinatDa.Size = new Size(56, 29);
            checkBoxVaccinatDa.TabIndex = 65;
            checkBoxVaccinatDa.Text = "DA";
            checkBoxVaccinatDa.UseVisualStyleBackColor = true;
            checkBoxVaccinatDa.CheckedChanged += checkBoxVaccinatDa_CheckedChanged;
            // 
            // textBoxGreutate
            // 
            textBoxGreutate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxGreutate.Location = new Point(114, 131);
            textBoxGreutate.Name = "textBoxGreutate";
            textBoxGreutate.Size = new Size(76, 23);
            textBoxGreutate.TabIndex = 53;
            // 
            // labelSterilizat
            // 
            labelSterilizat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelSterilizat.AutoSize = true;
            labelSterilizat.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelSterilizat.Location = new Point(389, 104);
            labelSterilizat.Name = "labelSterilizat";
            labelSterilizat.Size = new Size(84, 25);
            labelSterilizat.TabIndex = 56;
            labelSterilizat.Text = "Sterilizat";
            // 
            // checkBoxSterNu
            // 
            checkBoxSterNu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxSterNu.AutoSize = true;
            checkBoxSterNu.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxSterNu.Location = new Point(433, 131);
            checkBoxSterNu.Name = "checkBoxSterNu";
            checkBoxSterNu.Size = new Size(58, 29);
            checkBoxSterNu.TabIndex = 68;
            checkBoxSterNu.Text = "NU";
            checkBoxSterNu.UseVisualStyleBackColor = true;
            checkBoxSterNu.CheckedChanged += checkBoxSterNu_CheckedChanged;
            // 
            // checkBoxVaccinatNu
            // 
            checkBoxVaccinatNu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxVaccinatNu.AutoSize = true;
            checkBoxVaccinatNu.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxVaccinatNu.Location = new Point(281, 132);
            checkBoxVaccinatNu.Name = "checkBoxVaccinatNu";
            checkBoxVaccinatNu.Size = new Size(58, 29);
            checkBoxVaccinatNu.TabIndex = 66;
            checkBoxVaccinatNu.Text = "NU";
            checkBoxVaccinatNu.UseVisualStyleBackColor = true;
            checkBoxVaccinatNu.CheckedChanged += checkBoxVaccinatNu_CheckedChanged;
            // 
            // labelVaccinat
            // 
            labelVaccinat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelVaccinat.AutoSize = true;
            labelVaccinat.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelVaccinat.Location = new Point(231, 104);
            labelVaccinat.Name = "labelVaccinat";
            labelVaccinat.Size = new Size(83, 25);
            labelVaccinat.TabIndex = 55;
            labelVaccinat.Text = "Vaccinat";
            // 
            // checkBoxSterDa
            // 
            checkBoxSterDa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxSterDa.AutoSize = true;
            checkBoxSterDa.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxSterDa.Location = new Point(377, 132);
            checkBoxSterDa.Name = "checkBoxSterDa";
            checkBoxSterDa.Size = new Size(56, 29);
            checkBoxSterDa.TabIndex = 67;
            checkBoxSterDa.Text = "DA";
            checkBoxSterDa.UseVisualStyleBackColor = true;
            checkBoxSterDa.CheckedChanged += checkBoxSterDa_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.FromArgb(240, 240, 200);
            pictureBox1.Location = new Point(2, 468);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(462, 313);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 77;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(153, 229, 80);
            panel2.Controls.Add(labelFiltre);
            panel2.Location = new Point(-9, 410);
            panel2.Name = "panel2";
            panel2.Size = new Size(1330, 52);
            panel2.TabIndex = 78;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(153, 229, 80);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(-9, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1370, 52);
            panel3.TabIndex = 79;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1821, -41);
            label1.Name = "label1";
            label1.Size = new Size(76, 37);
            label1.TabIndex = 2;
            label1.Text = "Filtre";
            // 
            // FormVizualizareCatalog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 214);
            ClientSize = new Size(1309, 793);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(dataGridViewAnimale);
            MinimumSize = new Size(1325, 832);
            Name = "FormVizualizareCatalog";
            Text = "FormVizualizareCatalog";
            Load += FormVizualizareCatalog_Load;
            ResizeBegin += FormVizualizareCatalog_ResizeBegin;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnimale).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel2;
        private Panel panel3;
        private Label label1;
    }
}