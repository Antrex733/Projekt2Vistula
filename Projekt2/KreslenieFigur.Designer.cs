namespace Projekt2
{
    partial class KreslenieFigur
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
            this.pbRysownica = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPowrot = new System.Windows.Forms.Button();
            this.btnPrzesunFigury = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbly0 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblx0 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbFigury_Line = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rbFillPolygon = new System.Windows.Forms.RadioButton();
            this.rbOsmiokat = new System.Windows.Forms.RadioButton();
            this.rbElipsa = new System.Windows.Forms.RadioButton();
            this.rbKolo = new System.Windows.Forms.RadioButton();
            this.rbKwadrat = new System.Windows.Forms.RadioButton();
            this.rbPelnyKwadrat = new System.Windows.Forms.RadioButton();
            this.rbLiniaProsta = new System.Windows.Forms.RadioButton();
            this.rbOkrag = new System.Windows.Forms.RadioButton();
            this.rbLiniaCiagla = new System.Windows.Forms.RadioButton();
            this.rbProstokat = new System.Windows.Forms.RadioButton();
            this.rbKrzywaBeziera = new System.Windows.Forms.RadioButton();
            this.rbDrawClosedCurve = new System.Windows.Forms.RadioButton();
            this.rbPunkt = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbAtrybutyGraficzne = new System.Windows.Forms.GroupBox();
            this.btnKolorLinii = new System.Windows.Forms.Button();
            this.btnKolorWypelnienia = new System.Windows.Forms.Button();
            this.btnCofnij = new System.Windows.Forms.Button();
            this.txtKolorLinii = new System.Windows.Forms.TextBox();
            this.txtKolorWypelnienia = new System.Windows.Forms.TextBox();
            this.cmbStylLinii = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trSuwakGrubosciLinii = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbFigury_Line.SuspendLayout();
            this.gbAtrybutyGraficzne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trSuwakGrubosciLinii)).BeginInit();
            this.SuspendLayout();
            // 
            // pbRysownica
            // 
            this.pbRysownica.BackColor = System.Drawing.SystemColors.Info;
            this.pbRysownica.Location = new System.Drawing.Point(61, 110);
            this.pbRysownica.Name = "pbRysownica";
            this.pbRysownica.Size = new System.Drawing.Size(837, 473);
            this.pbRysownica.TabIndex = 0;
            this.pbRysownica.TabStop = false;
            this.pbRysownica.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbRysownica_MouseDown);
            this.pbRysownica.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbRysownica_MouseMove);
            this.pbRysownica.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbRysownica_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPowrot);
            this.groupBox1.Controls.Add(this.btnPrzesunFigury);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(77, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 92);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnPowrot
            // 
            this.btnPowrot.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPowrot.Location = new System.Drawing.Point(217, 19);
            this.btnPowrot.Name = "btnPowrot";
            this.btnPowrot.Size = new System.Drawing.Size(178, 62);
            this.btnPowrot.TabIndex = 2;
            this.btnPowrot.Text = "Powrót do \r\nformularza głównego";
            this.btnPowrot.UseVisualStyleBackColor = true;
            this.btnPowrot.Click += new System.EventHandler(this.btnPowrot_Click);
            // 
            // btnPrzesunFigury
            // 
            this.btnPrzesunFigury.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrzesunFigury.Location = new System.Drawing.Point(457, 19);
            this.btnPrzesunFigury.Name = "btnPrzesunFigury";
            this.btnPrzesunFigury.Size = new System.Drawing.Size(328, 62);
            this.btnPrzesunFigury.TabIndex = 1;
            this.btnPrzesunFigury.Text = "Przesuń figury do \r\nnowej lokalizacji";
            this.btnPrzesunFigury.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbly0);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblx0);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 62);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lokalizacja kursora";
            // 
            // lbly0
            // 
            this.lbly0.AutoSize = true;
            this.lbly0.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbly0.Location = new System.Drawing.Point(105, 33);
            this.lbly0.Name = "lbly0";
            this.lbly0.Size = new System.Drawing.Size(16, 17);
            this.lbly0.TabIndex = 4;
            this.lbly0.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(88, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Y:";
            // 
            // lblx0
            // 
            this.lblx0.AutoSize = true;
            this.lblx0.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblx0.Location = new System.Drawing.Point(39, 33);
            this.lblx0.Name = "lblx0";
            this.lblx0.Size = new System.Drawing.Size(16, 17);
            this.lblx0.TabIndex = 2;
            this.lblx0.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "X:";
            // 
            // gbFigury_Line
            // 
            this.gbFigury_Line.Controls.Add(this.button1);
            this.gbFigury_Line.Controls.Add(this.rbFillPolygon);
            this.gbFigury_Line.Controls.Add(this.rbOsmiokat);
            this.gbFigury_Line.Controls.Add(this.rbElipsa);
            this.gbFigury_Line.Controls.Add(this.rbKolo);
            this.gbFigury_Line.Controls.Add(this.rbKwadrat);
            this.gbFigury_Line.Controls.Add(this.rbPelnyKwadrat);
            this.gbFigury_Line.Controls.Add(this.rbLiniaProsta);
            this.gbFigury_Line.Controls.Add(this.rbOkrag);
            this.gbFigury_Line.Controls.Add(this.rbLiniaCiagla);
            this.gbFigury_Line.Controls.Add(this.rbProstokat);
            this.gbFigury_Line.Controls.Add(this.rbKrzywaBeziera);
            this.gbFigury_Line.Controls.Add(this.rbDrawClosedCurve);
            this.gbFigury_Line.Controls.Add(this.rbPunkt);
            this.gbFigury_Line.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbFigury_Line.Location = new System.Drawing.Point(924, 64);
            this.gbFigury_Line.Name = "gbFigury_Line";
            this.gbFigury_Line.Size = new System.Drawing.Size(367, 372);
            this.gbFigury_Line.TabIndex = 2;
            this.gbFigury_Line.TabStop = false;
            this.gbFigury_Line.Text = "Wybierz figurę lub linię";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(82, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cofnij ostatnią figurę";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // rbFillPolygon
            // 
            this.rbFillPolygon.AutoSize = true;
            this.rbFillPolygon.Location = new System.Drawing.Point(27, 191);
            this.rbFillPolygon.Name = "rbFillPolygon";
            this.rbFillPolygon.Size = new System.Drawing.Size(84, 19);
            this.rbFillPolygon.TabIndex = 12;
            this.rbFillPolygon.TabStop = true;
            this.rbFillPolygon.Text = "Fill Polygon";
            this.rbFillPolygon.UseVisualStyleBackColor = true;
            // 
            // rbOsmiokat
            // 
            this.rbOsmiokat.AutoSize = true;
            this.rbOsmiokat.Location = new System.Drawing.Point(186, 166);
            this.rbOsmiokat.Name = "rbOsmiokat";
            this.rbOsmiokat.Size = new System.Drawing.Size(72, 19);
            this.rbOsmiokat.TabIndex = 11;
            this.rbOsmiokat.TabStop = true;
            this.rbOsmiokat.Text = "Ośmiokąt";
            this.rbOsmiokat.UseVisualStyleBackColor = true;
            // 
            // rbElipsa
            // 
            this.rbElipsa.AutoSize = true;
            this.rbElipsa.Location = new System.Drawing.Point(27, 66);
            this.rbElipsa.Name = "rbElipsa";
            this.rbElipsa.Size = new System.Drawing.Size(55, 19);
            this.rbElipsa.TabIndex = 10;
            this.rbElipsa.TabStop = true;
            this.rbElipsa.Text = "Elipsa";
            this.rbElipsa.UseVisualStyleBackColor = true;
            // 
            // rbKolo
            // 
            this.rbKolo.AutoSize = true;
            this.rbKolo.Location = new System.Drawing.Point(27, 91);
            this.rbKolo.Name = "rbKolo";
            this.rbKolo.Size = new System.Drawing.Size(49, 19);
            this.rbKolo.TabIndex = 9;
            this.rbKolo.TabStop = true;
            this.rbKolo.Text = "Koło";
            this.rbKolo.UseVisualStyleBackColor = true;
            // 
            // rbKwadrat
            // 
            this.rbKwadrat.AutoSize = true;
            this.rbKwadrat.Location = new System.Drawing.Point(27, 116);
            this.rbKwadrat.Name = "rbKwadrat";
            this.rbKwadrat.Size = new System.Drawing.Size(67, 19);
            this.rbKwadrat.TabIndex = 8;
            this.rbKwadrat.TabStop = true;
            this.rbKwadrat.Text = "Kwadrat";
            this.rbKwadrat.UseVisualStyleBackColor = true;
            // 
            // rbPelnyKwadrat
            // 
            this.rbPelnyKwadrat.AutoSize = true;
            this.rbPelnyKwadrat.Location = new System.Drawing.Point(27, 141);
            this.rbPelnyKwadrat.Name = "rbPelnyKwadrat";
            this.rbPelnyKwadrat.Size = new System.Drawing.Size(98, 19);
            this.rbPelnyKwadrat.TabIndex = 7;
            this.rbPelnyKwadrat.TabStop = true;
            this.rbPelnyKwadrat.Text = "Pełny Kwadrat";
            this.rbPelnyKwadrat.UseVisualStyleBackColor = true;
            // 
            // rbLiniaProsta
            // 
            this.rbLiniaProsta.AutoSize = true;
            this.rbLiniaProsta.Location = new System.Drawing.Point(186, 41);
            this.rbLiniaProsta.Name = "rbLiniaProsta";
            this.rbLiniaProsta.Size = new System.Drawing.Size(83, 19);
            this.rbLiniaProsta.TabIndex = 6;
            this.rbLiniaProsta.TabStop = true;
            this.rbLiniaProsta.Text = "Linia Prosta";
            this.rbLiniaProsta.UseVisualStyleBackColor = true;
            // 
            // rbOkrag
            // 
            this.rbOkrag.AutoSize = true;
            this.rbOkrag.Location = new System.Drawing.Point(186, 66);
            this.rbOkrag.Name = "rbOkrag";
            this.rbOkrag.Size = new System.Drawing.Size(54, 19);
            this.rbOkrag.TabIndex = 5;
            this.rbOkrag.TabStop = true;
            this.rbOkrag.Text = "Okrąg";
            this.rbOkrag.UseVisualStyleBackColor = true;
            // 
            // rbLiniaCiagla
            // 
            this.rbLiniaCiagla.AutoSize = true;
            this.rbLiniaCiagla.Location = new System.Drawing.Point(186, 91);
            this.rbLiniaCiagla.Name = "rbLiniaCiagla";
            this.rbLiniaCiagla.Size = new System.Drawing.Size(81, 19);
            this.rbLiniaCiagla.TabIndex = 4;
            this.rbLiniaCiagla.TabStop = true;
            this.rbLiniaCiagla.Text = "Linia Ciągła";
            this.rbLiniaCiagla.UseVisualStyleBackColor = true;
            // 
            // rbProstokat
            // 
            this.rbProstokat.AutoSize = true;
            this.rbProstokat.Location = new System.Drawing.Point(186, 116);
            this.rbProstokat.Name = "rbProstokat";
            this.rbProstokat.Size = new System.Drawing.Size(72, 19);
            this.rbProstokat.TabIndex = 3;
            this.rbProstokat.TabStop = true;
            this.rbProstokat.Text = "Prostokąt";
            this.rbProstokat.UseVisualStyleBackColor = true;
            // 
            // rbKrzywaBeziera
            // 
            this.rbKrzywaBeziera.AutoSize = true;
            this.rbKrzywaBeziera.Location = new System.Drawing.Point(186, 141);
            this.rbKrzywaBeziera.Name = "rbKrzywaBeziera";
            this.rbKrzywaBeziera.Size = new System.Drawing.Size(104, 19);
            this.rbKrzywaBeziera.TabIndex = 2;
            this.rbKrzywaBeziera.TabStop = true;
            this.rbKrzywaBeziera.Text = "Krzywa Beziera";
            this.rbKrzywaBeziera.UseVisualStyleBackColor = true;
            // 
            // rbDrawClosedCurve
            // 
            this.rbDrawClosedCurve.AutoSize = true;
            this.rbDrawClosedCurve.Location = new System.Drawing.Point(27, 166);
            this.rbDrawClosedCurve.Name = "rbDrawClosedCurve";
            this.rbDrawClosedCurve.Size = new System.Drawing.Size(120, 19);
            this.rbDrawClosedCurve.TabIndex = 1;
            this.rbDrawClosedCurve.TabStop = true;
            this.rbDrawClosedCurve.Text = "Draw Closed Curve";
            this.rbDrawClosedCurve.UseVisualStyleBackColor = true;
            // 
            // rbPunkt
            // 
            this.rbPunkt.AutoSize = true;
            this.rbPunkt.Location = new System.Drawing.Point(27, 41);
            this.rbPunkt.Name = "rbPunkt";
            this.rbPunkt.Size = new System.Drawing.Size(54, 19);
            this.rbPunkt.TabIndex = 0;
            this.rbPunkt.TabStop = true;
            this.rbPunkt.Text = "Punkt";
            this.rbPunkt.UseVisualStyleBackColor = true;
            // 
            // gbAtrybutyGraficzne
            // 
            this.gbAtrybutyGraficzne.Controls.Add(this.trSuwakGrubosciLinii);
            this.gbAtrybutyGraficzne.Controls.Add(this.label2);
            this.gbAtrybutyGraficzne.Controls.Add(this.cmbStylLinii);
            this.gbAtrybutyGraficzne.Controls.Add(this.txtKolorWypelnienia);
            this.gbAtrybutyGraficzne.Controls.Add(this.txtKolorLinii);
            this.gbAtrybutyGraficzne.Controls.Add(this.btnCofnij);
            this.gbAtrybutyGraficzne.Controls.Add(this.btnKolorWypelnienia);
            this.gbAtrybutyGraficzne.Controls.Add(this.btnKolorLinii);
            this.gbAtrybutyGraficzne.Location = new System.Drawing.Point(924, 453);
            this.gbAtrybutyGraficzne.Name = "gbAtrybutyGraficzne";
            this.gbAtrybutyGraficzne.Size = new System.Drawing.Size(367, 271);
            this.gbAtrybutyGraficzne.TabIndex = 3;
            this.gbAtrybutyGraficzne.TabStop = false;
            this.gbAtrybutyGraficzne.Text = "Atrybuty graficzne";
            // 
            // btnKolorLinii
            // 
            this.btnKolorLinii.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKolorLinii.Location = new System.Drawing.Point(28, 34);
            this.btnKolorLinii.Name = "btnKolorLinii";
            this.btnKolorLinii.Size = new System.Drawing.Size(100, 35);
            this.btnKolorLinii.TabIndex = 0;
            this.btnKolorLinii.Text = "Kolor linii";
            this.btnKolorLinii.UseVisualStyleBackColor = true;
            this.btnKolorLinii.Click += new System.EventHandler(this.btnKolorLinii_Click);
            // 
            // btnKolorWypelnienia
            // 
            this.btnKolorWypelnienia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKolorWypelnienia.Location = new System.Drawing.Point(27, 116);
            this.btnKolorWypelnienia.Name = "btnKolorWypelnienia";
            this.btnKolorWypelnienia.Size = new System.Drawing.Size(97, 50);
            this.btnKolorWypelnienia.TabIndex = 1;
            this.btnKolorWypelnienia.Text = "Kolor \r\nwypełnienia";
            this.btnKolorWypelnienia.UseVisualStyleBackColor = true;
            this.btnKolorWypelnienia.Click += new System.EventHandler(this.btnKolorWypelnienia_Click);
            // 
            // btnCofnij
            // 
            this.btnCofnij.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCofnij.Location = new System.Drawing.Point(200, 53);
            this.btnCofnij.Name = "btnCofnij";
            this.btnCofnij.Size = new System.Drawing.Size(130, 59);
            this.btnCofnij.TabIndex = 2;
            this.btnCofnij.Text = "Cofnij ostatnią\r\nfigurę";
            this.btnCofnij.UseVisualStyleBackColor = true;
            // 
            // txtKolorLinii
            // 
            this.txtKolorLinii.BackColor = System.Drawing.Color.Blue;
            this.txtKolorLinii.Location = new System.Drawing.Point(28, 75);
            this.txtKolorLinii.Name = "txtKolorLinii";
            this.txtKolorLinii.Size = new System.Drawing.Size(100, 20);
            this.txtKolorLinii.TabIndex = 3;
            // 
            // txtKolorWypelnienia
            // 
            this.txtKolorWypelnienia.BackColor = System.Drawing.Color.Green;
            this.txtKolorWypelnienia.Location = new System.Drawing.Point(28, 172);
            this.txtKolorWypelnienia.Name = "txtKolorWypelnienia";
            this.txtKolorWypelnienia.Size = new System.Drawing.Size(100, 20);
            this.txtKolorWypelnienia.TabIndex = 4;
            // 
            // cmbStylLinii
            // 
            this.cmbStylLinii.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbStylLinii.FormattingEnabled = true;
            this.cmbStylLinii.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "DashDot",
            "DashDotDot"});
            this.cmbStylLinii.Location = new System.Drawing.Point(200, 24);
            this.cmbStylLinii.Name = "cmbStylLinii";
            this.cmbStylLinii.Size = new System.Drawing.Size(130, 23);
            this.cmbStylLinii.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Grubość linii";
            // 
            // trSuwakGrubosciLinii
            // 
            this.trSuwakGrubosciLinii.Location = new System.Drawing.Point(209, 152);
            this.trSuwakGrubosciLinii.Minimum = 1;
            this.trSuwakGrubosciLinii.Name = "trSuwakGrubosciLinii";
            this.trSuwakGrubosciLinii.Size = new System.Drawing.Size(104, 45);
            this.trSuwakGrubosciLinii.TabIndex = 22;
            this.trSuwakGrubosciLinii.Value = 3;
            // 
            // KreslenieFigur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 736);
            this.Controls.Add(this.gbAtrybutyGraficzne);
            this.Controls.Add(this.gbFigury_Line);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbRysownica);
            this.Name = "KreslenieFigur";
            this.Text = "KreslenieFigur";
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbFigury_Line.ResumeLayout(false);
            this.gbFigury_Line.PerformLayout();
            this.gbAtrybutyGraficzne.ResumeLayout(false);
            this.gbAtrybutyGraficzne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trSuwakGrubosciLinii)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRysownica;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrzesunFigury;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbly0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblx0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPowrot;
        private System.Windows.Forms.GroupBox gbFigury_Line;
        private System.Windows.Forms.RadioButton rbPunkt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbFillPolygon;
        private System.Windows.Forms.RadioButton rbOsmiokat;
        private System.Windows.Forms.RadioButton rbElipsa;
        private System.Windows.Forms.RadioButton rbKolo;
        private System.Windows.Forms.RadioButton rbKwadrat;
        private System.Windows.Forms.RadioButton rbPelnyKwadrat;
        private System.Windows.Forms.RadioButton rbLiniaProsta;
        private System.Windows.Forms.RadioButton rbOkrag;
        private System.Windows.Forms.RadioButton rbLiniaCiagla;
        private System.Windows.Forms.RadioButton rbProstokat;
        private System.Windows.Forms.RadioButton rbKrzywaBeziera;
        private System.Windows.Forms.RadioButton rbDrawClosedCurve;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbAtrybutyGraficzne;
        private System.Windows.Forms.ComboBox cmbStylLinii;
        private System.Windows.Forms.TextBox txtKolorWypelnienia;
        private System.Windows.Forms.TextBox txtKolorLinii;
        private System.Windows.Forms.Button btnCofnij;
        private System.Windows.Forms.Button btnKolorWypelnienia;
        private System.Windows.Forms.Button btnKolorLinii;
        private System.Windows.Forms.TrackBar trSuwakGrubosciLinii;
        private System.Windows.Forms.Label label2;
    }
}