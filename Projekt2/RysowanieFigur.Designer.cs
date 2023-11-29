namespace Projekt2
{
    partial class RysowanieFigur
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnResetujRysowanieFigur = new System.Windows.Forms.Button();
            this.btnWylaczanieSlajdera = new System.Windows.Forms.Button();
            this.btnWlaczanieSlajdera = new System.Windows.Forms.Button();
            this.btnLosujAtrybuty = new System.Windows.Forms.Button();
            this.btnPrzesunLosowo = new System.Windows.Forms.Button();
            this.btnPowrot = new System.Windows.Forms.Button();
            this.chlbFiguryGeometryczne = new System.Windows.Forms.CheckedListBox();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.pbRysownica = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbManualny = new System.Windows.Forms.RadioButton();
            this.rdbAutomatyczny = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIndeksTablicyTFG = new System.Windows.Forms.TextBox();
            this.btnNastepna = new System.Windows.Forms.Button();
            this.btnPoprzednia = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.Location = new System.Drawing.Point(36, 118);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(161, 57);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START\r\n(wykreśl figury)";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnResetujRysowanieFigur
            // 
            this.btnResetujRysowanieFigur.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnResetujRysowanieFigur.Location = new System.Drawing.Point(1129, 392);
            this.btnResetujRysowanieFigur.Name = "btnResetujRysowanieFigur";
            this.btnResetujRysowanieFigur.Size = new System.Drawing.Size(201, 57);
            this.btnResetujRysowanieFigur.TabIndex = 1;
            this.btnResetujRysowanieFigur.Text = "Resetuj";
            this.btnResetujRysowanieFigur.UseVisualStyleBackColor = true;
            this.btnResetujRysowanieFigur.Click += new System.EventHandler(this.btnResetujRysowanieFigur_Click);
            // 
            // btnWylaczanieSlajdera
            // 
            this.btnWylaczanieSlajdera.Enabled = false;
            this.btnWylaczanieSlajdera.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWylaczanieSlajdera.Location = new System.Drawing.Point(36, 496);
            this.btnWylaczanieSlajdera.Name = "btnWylaczanieSlajdera";
            this.btnWylaczanieSlajdera.Size = new System.Drawing.Size(161, 57);
            this.btnWylaczanieSlajdera.TabIndex = 2;
            this.btnWylaczanieSlajdera.Text = "Wyłącz slajder";
            this.btnWylaczanieSlajdera.UseVisualStyleBackColor = true;
            this.btnWylaczanieSlajdera.Click += new System.EventHandler(this.btnWylaczanieSlajdera_Click);
            // 
            // btnWlaczanieSlajdera
            // 
            this.btnWlaczanieSlajdera.Enabled = false;
            this.btnWlaczanieSlajdera.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWlaczanieSlajdera.Location = new System.Drawing.Point(36, 423);
            this.btnWlaczanieSlajdera.Name = "btnWlaczanieSlajdera";
            this.btnWlaczanieSlajdera.Size = new System.Drawing.Size(161, 57);
            this.btnWlaczanieSlajdera.TabIndex = 3;
            this.btnWlaczanieSlajdera.Text = "Włącz slajder";
            this.btnWlaczanieSlajdera.UseVisualStyleBackColor = true;
            this.btnWlaczanieSlajdera.Click += new System.EventHandler(this.btnWlaczanieSlajdera_Click);
            // 
            // btnLosujAtrybuty
            // 
            this.btnLosujAtrybuty.Enabled = false;
            this.btnLosujAtrybuty.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLosujAtrybuty.Location = new System.Drawing.Point(36, 272);
            this.btnLosujAtrybuty.Name = "btnLosujAtrybuty";
            this.btnLosujAtrybuty.Size = new System.Drawing.Size(161, 88);
            this.btnLosujAtrybuty.TabIndex = 4;
            this.btnLosujAtrybuty.Text = "Wylosuj nowe atrybuty graficzne i przesuń do losowej lokalizacji";
            this.btnLosujAtrybuty.UseVisualStyleBackColor = true;
            this.btnLosujAtrybuty.Click += new System.EventHandler(this.btnLosujAtrybuty_Click);
            // 
            // btnPrzesunLosowo
            // 
            this.btnPrzesunLosowo.Enabled = false;
            this.btnPrzesunLosowo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrzesunLosowo.Location = new System.Drawing.Point(36, 196);
            this.btnPrzesunLosowo.Name = "btnPrzesunLosowo";
            this.btnPrzesunLosowo.Size = new System.Drawing.Size(161, 57);
            this.btnPrzesunLosowo.TabIndex = 5;
            this.btnPrzesunLosowo.Text = "Przesuń do losowej lokalizacji";
            this.btnPrzesunLosowo.UseVisualStyleBackColor = true;
            this.btnPrzesunLosowo.Click += new System.EventHandler(this.btnPrzesunLosowo_Click);
            // 
            // btnPowrot
            // 
            this.btnPowrot.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPowrot.Location = new System.Drawing.Point(1129, 468);
            this.btnPowrot.Name = "btnPowrot";
            this.btnPowrot.Size = new System.Drawing.Size(201, 57);
            this.btnPowrot.TabIndex = 6;
            this.btnPowrot.Text = "Powrót do formularza głównego";
            this.btnPowrot.UseVisualStyleBackColor = true;
            this.btnPowrot.Click += new System.EventHandler(this.btnPowrot_Click);
            // 
            // chlbFiguryGeometryczne
            // 
            this.chlbFiguryGeometryczne.FormattingEnabled = true;
            this.chlbFiguryGeometryczne.Items.AddRange(new object[] {
            "Punkt",
            "Linia",
            "Elipsa",
            "Okrąg",
            "Prostokąt",
            "Kwadrat"});
            this.chlbFiguryGeometryczne.Location = new System.Drawing.Point(1129, 113);
            this.chlbFiguryGeometryczne.Name = "chlbFiguryGeometryczne";
            this.chlbFiguryGeometryczne.Size = new System.Drawing.Size(201, 259);
            this.chlbFiguryGeometryczne.TabIndex = 7;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMenu.Location = new System.Drawing.Point(1125, 36);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(205, 57);
            this.lblMenu.TabIndex = 8;
            this.lblMenu.Text = "Zaznacz figury geometryczne,\r\nktóre mają być wylosowanei \r\nwyświetlane na planszy" +
    "graficznej";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblN.Location = new System.Drawing.Point(65, 21);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(113, 38);
            this.lblN.TabIndex = 9;
            this.lblN.Text = "Podaj liczbę figur\r\n geometrycznych";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(69, 73);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 10;
            // 
            // pbRysownica
            // 
            this.pbRysownica.BackColor = System.Drawing.SystemColors.Info;
            this.pbRysownica.Location = new System.Drawing.Point(227, 21);
            this.pbRysownica.Name = "pbRysownica";
            this.pbRysownica.Size = new System.Drawing.Size(865, 532);
            this.pbRysownica.TabIndex = 11;
            this.pbRysownica.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbManualny);
            this.groupBox1.Controls.Add(this.rdbAutomatyczny);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIndeksTablicyTFG);
            this.groupBox1.Controls.Add(this.btnNastepna);
            this.groupBox1.Controls.Add(this.btnPoprzednia);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(328, 597);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 144);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tryb pokazu figur geomatrycznych";
            // 
            // rdbManualny
            // 
            this.rdbManualny.AutoSize = true;
            this.rdbManualny.Location = new System.Drawing.Point(34, 81);
            this.rdbManualny.Name = "rdbManualny";
            this.rdbManualny.Size = new System.Drawing.Size(150, 23);
            this.rdbManualny.TabIndex = 18;
            this.rdbManualny.TabStop = true;
            this.rdbManualny.Text = "Manualny (przycisk)";
            this.rdbManualny.UseVisualStyleBackColor = true;
            this.rdbManualny.CheckedChanged += new System.EventHandler(this.rdbManualny_CheckedChanged);
            // 
            // rdbAutomatyczny
            // 
            this.rdbAutomatyczny.AutoSize = true;
            this.rdbAutomatyczny.Checked = true;
            this.rdbAutomatyczny.Location = new System.Drawing.Point(34, 52);
            this.rdbAutomatyczny.Name = "rdbAutomatyczny";
            this.rdbAutomatyczny.Size = new System.Drawing.Size(159, 23);
            this.rdbAutomatyczny.TabIndex = 17;
            this.rdbAutomatyczny.TabStop = true;
            this.rdbAutomatyczny.Text = "Automatyczny (zegar)";
            this.rdbAutomatyczny.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 38);
            this.label1.TabIndex = 16;
            this.label1.Text = "Indeks figury \r\nw tablicy FTG";
            // 
            // txtIndeksTablicyTFG
            // 
            this.txtIndeksTablicyTFG.Enabled = false;
            this.txtIndeksTablicyTFG.Location = new System.Drawing.Point(228, 83);
            this.txtIndeksTablicyTFG.Name = "txtIndeksTablicyTFG";
            this.txtIndeksTablicyTFG.Size = new System.Drawing.Size(100, 26);
            this.txtIndeksTablicyTFG.TabIndex = 15;
            this.txtIndeksTablicyTFG.TextChanged += new System.EventHandler(this.txtIndeksTablicyTFG_TextChanged);
            // 
            // btnNastepna
            // 
            this.btnNastepna.Enabled = false;
            this.btnNastepna.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNastepna.Location = new System.Drawing.Point(408, 23);
            this.btnNastepna.Name = "btnNastepna";
            this.btnNastepna.Size = new System.Drawing.Size(111, 45);
            this.btnNastepna.TabIndex = 14;
            this.btnNastepna.Text = "Następna";
            this.btnNastepna.UseVisualStyleBackColor = true;
            this.btnNastepna.Click += new System.EventHandler(this.btnNastepna_Click);
            // 
            // btnPoprzednia
            // 
            this.btnPoprzednia.Enabled = false;
            this.btnPoprzednia.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPoprzednia.Location = new System.Drawing.Point(408, 83);
            this.btnPoprzednia.Name = "btnPoprzednia";
            this.btnPoprzednia.Size = new System.Drawing.Size(111, 45);
            this.btnPoprzednia.TabIndex = 13;
            this.btnPoprzednia.Text = "Poprzednia";
            this.btnPoprzednia.UseVisualStyleBackColor = true;
            this.btnPoprzednia.Click += new System.EventHandler(this.btnPoprzednia_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RysowanieFigur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1385, 796);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbRysownica);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.chlbFiguryGeometryczne);
            this.Controls.Add(this.btnPowrot);
            this.Controls.Add(this.btnPrzesunLosowo);
            this.Controls.Add(this.btnLosujAtrybuty);
            this.Controls.Add(this.btnWlaczanieSlajdera);
            this.Controls.Add(this.btnWylaczanieSlajdera);
            this.Controls.Add(this.btnResetujRysowanieFigur);
            this.Controls.Add(this.btnStart);
            this.Name = "RysowanieFigur";
            this.Text = "RysowanieFigur";
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnResetujRysowanieFigur;
        private System.Windows.Forms.Button btnWylaczanieSlajdera;
        private System.Windows.Forms.Button btnWlaczanieSlajdera;
        private System.Windows.Forms.Button btnLosujAtrybuty;
        private System.Windows.Forms.Button btnPrzesunLosowo;
        private System.Windows.Forms.Button btnPowrot;
        private System.Windows.Forms.CheckedListBox chlbFiguryGeometryczne;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.PictureBox pbRysownica;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton rdbManualny;
        private System.Windows.Forms.RadioButton rdbAutomatyczny;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIndeksTablicyTFG;
        private System.Windows.Forms.Button btnNastepna;
        private System.Windows.Forms.Button btnPoprzednia;
    }
}