namespace Aplicatie_de_gestiune_a_animalelor
{
    partial class FormRaportIndividualFurnizor
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
            labelNumeFurnizor = new Label();
            labelTitlu = new Label();
            labelDate = new Label();
            labelCUI = new Label();
            labelAdresa = new Label();
            label1 = new Label();
            label2 = new Label();
            labelProcentNumar = new Label();
            label3 = new Label();
            labelNumar = new Label();
            label4 = new Label();
            label5 = new Label();
            labelProcentPlatit = new Label();
            SuspendLayout();
            // 
            // btnPrint
            // 
            btnPrint.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrint.Image = Properties.Resources.button;
            btnPrint.Location = new Point(12, 12);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(202, 42);
            btnPrint.TabIndex = 2;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // labelNumeFurnizor
            // 
            labelNumeFurnizor.AutoSize = true;
            labelNumeFurnizor.BackColor = SystemColors.Control;
            labelNumeFurnizor.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelNumeFurnizor.Location = new Point(63, 157);
            labelNumeFurnizor.Name = "labelNumeFurnizor";
            labelNumeFurnizor.Size = new Size(151, 30);
            labelNumeFurnizor.TabIndex = 4;
            labelNumeFurnizor.Text = "Nume Furnizor";
            // 
            // labelTitlu
            // 
            labelTitlu.AutoSize = true;
            labelTitlu.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitlu.Location = new Point(203, 73);
            labelTitlu.Name = "labelTitlu";
            labelTitlu.Size = new Size(304, 30);
            labelTitlu.TabIndex = 5;
            labelTitlu.Text = "Raport individual al furnizorului";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelDate.Location = new Point(595, 24);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(28, 30);
            labelDate.TabIndex = 6;
            labelDate.Text = "...";
            // 
            // labelCUI
            // 
            labelCUI.AutoSize = true;
            labelCUI.BackColor = SystemColors.Control;
            labelCUI.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelCUI.Location = new Point(63, 199);
            labelCUI.Name = "labelCUI";
            labelCUI.Size = new Size(46, 30);
            labelCUI.TabIndex = 7;
            labelCUI.Text = "CUI";
            // 
            // labelAdresa
            // 
            labelAdresa.AutoSize = true;
            labelAdresa.BackColor = SystemColors.Control;
            labelAdresa.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelAdresa.Location = new Point(63, 239);
            labelAdresa.Name = "labelAdresa";
            labelAdresa.Size = new Size(155, 30);
            labelAdresa.TabIndex = 8;
            labelAdresa.Text = "Adresa furnizor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(368, 309);
            label1.Name = "label1";
            label1.Size = new Size(385, 25);
            label1.TabIndex = 9;
            label1.Text = "Din totalul de comenzi, furnizorului i-au fost";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(368, 334);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 10;
            label2.Text = "adresate: ";
            // 
            // labelProcentNumar
            // 
            labelProcentNumar.AutoSize = true;
            labelProcentNumar.BackColor = SystemColors.Control;
            labelProcentNumar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelProcentNumar.Location = new Point(457, 334);
            labelProcentNumar.Name = "labelProcentNumar";
            labelProcentNumar.Size = new Size(77, 25);
            labelProcentNumar.TabIndex = 11;
            labelProcentNumar.Text = "procent";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(540, 334);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 12;
            label3.Text = "adica: ";
            // 
            // labelNumar
            // 
            labelNumar.AutoSize = true;
            labelNumar.BackColor = SystemColors.Control;
            labelNumar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelNumar.Location = new Point(612, 334);
            labelNumar.Name = "labelNumar";
            labelNumar.Size = new Size(67, 25);
            labelNumar.TabIndex = 13;
            labelNumar.Text = "numar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(368, 402);
            label4.Name = "label4";
            label4.Size = new Size(324, 25);
            label4.TabIndex = 14;
            label4.Text = "Din totalul valorii tuturor comenzilor,";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(368, 427);
            label5.Name = "label5";
            label5.Size = new Size(225, 25);
            label5.TabIndex = 15;
            label5.Text = "furnizorului ii s-au platit: ";
            // 
            // labelProcentPlatit
            // 
            labelProcentPlatit.AutoSize = true;
            labelProcentPlatit.BackColor = SystemColors.Control;
            labelProcentPlatit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelProcentPlatit.Location = new Point(595, 427);
            labelProcentPlatit.Name = "labelProcentPlatit";
            labelProcentPlatit.Size = new Size(141, 25);
            labelProcentPlatit.TabIndex = 16;
            labelProcentPlatit.Text = "procentul platit";
            // 
            // FormRaportIndividualFurnizor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(765, 771);
            Controls.Add(labelProcentPlatit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(labelNumar);
            Controls.Add(label3);
            Controls.Add(labelProcentNumar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelAdresa);
            Controls.Add(labelCUI);
            Controls.Add(labelDate);
            Controls.Add(labelTitlu);
            Controls.Add(labelNumeFurnizor);
            Controls.Add(btnPrint);
            Name = "FormRaportIndividualFurnizor";
            Text = "FormRaportIndividualFurnizor";
            Load += FormRaportIndividualFurnizor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnPrint;
        private Label labelNumeFurnizor;
        private Label labelTitlu;
        private Label labelDate;
        private Label labelCUI;
        private Label labelAdresa;
        private Label label1;
        private Label label2;
        private Label labelProcentNumar;
        private Label label3;
        private Label labelNumar;
        private Label label4;
        private Label label5;
        private Label labelProcentPlatit;
    }
}