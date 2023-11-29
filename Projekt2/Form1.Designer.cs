namespace Projekt2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSlajder = new System.Windows.Forms.Button();
            this.btnKreslenieFigurMysz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSlajder
            // 
            this.btnSlajder.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSlajder.Location = new System.Drawing.Point(253, 238);
            this.btnSlajder.Name = "btnSlajder";
            this.btnSlajder.Size = new System.Drawing.Size(306, 93);
            this.btnSlajder.TabIndex = 0;
            this.btnSlajder.Text = "Prezentacja figur ze sjalderem";
            this.btnSlajder.UseVisualStyleBackColor = true;
            this.btnSlajder.Click += new System.EventHandler(this.btnSlajder_Click);
            // 
            // btnKreslenieFigurMysz
            // 
            this.btnKreslenieFigurMysz.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKreslenieFigurMysz.Location = new System.Drawing.Point(647, 238);
            this.btnKreslenieFigurMysz.Name = "btnKreslenieFigurMysz";
            this.btnKreslenieFigurMysz.Size = new System.Drawing.Size(306, 93);
            this.btnKreslenieFigurMysz.TabIndex = 1;
            this.btnKreslenieFigurMysz.Text = "Kreślenie figur i linii\r\n";
            this.btnKreslenieFigurMysz.UseVisualStyleBackColor = true;
            this.btnKreslenieFigurMysz.Click += new System.EventHandler(this.btnKreslenieFigurMysz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 683);
            this.Controls.Add(this.btnKreslenieFigurMysz);
            this.Controls.Add(this.btnSlajder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSlajder;
        private System.Windows.Forms.Button btnKreslenieFigurMysz;
    }
}

