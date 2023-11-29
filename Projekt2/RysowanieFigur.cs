using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Projekt2.FiguryGeometryczne;

namespace Projekt2
{
    public partial class RysowanieFigur : Form
    {
        Graphics Rysownica;
        Punkt[] TFG;
        int IndexTFG;
        const int Margines = 30;
        const int MarginesFormularza = 6;
        public RysowanieFigur()
        {
            InitializeComponent();
            //lokalizacja i zwymiarowanie formularza
            this.Location =
                new Point(Screen.PrimaryScreen.Bounds.X + MarginesFormularza,
                          Screen.PrimaryScreen.Bounds.Y + MarginesFormularza);
            this.Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.90f);
            this.Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.85f);
            //lokalizacja i zwymiarowanie formularza według podanych ustawień
            this.StartPosition = FormStartPosition.Manual;
            //ustawienie stanu braku aktywności przycisków Maksymalizacji i Minimalizacji
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            //lokalizacja kontrolki PictureBox
            pbRysownica.Location =
                new Point(btnStart.Left + btnStart.Width + MarginesFormularza, lblN.Top);
            pbRysownica.Width = (int)(this.Width * 0.5f);
            pbRysownica.Height = (int)(this.Height * 0.6f);
            //ustawienie koloru tła kontrolki PictureBox
            pbRysownica.BackColor = Color.Beige;
            //ustalenie obramowania (Jedno wierszowe obramowanie) kontrolki PictureBox
            pbRysownica.BorderStyle = BorderStyle.FixedSingle;
            //utworzenie mapy Bitowej i podpięcie jej do kontrolki PictureBox
            pbRysownica.Image =
                new Bitmap(pbRysownica.Width, pbRysownica.Height);

            Rysownica = Graphics.FromImage(pbRysownica.Image);
            
        }

        private void btnPowrot_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.Name == "Form1")
                {
                    Hide();
                    item.Show();
                    return;
                }
            }
        }

        private void btnResetujRysowanieFigur_Click(object sender, EventArgs e)
        {
            txtN.Text = "";
            Rysownica.Clear(pbRysownica.BackColor);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ushort N;
            Random rnd = new Random();

            errorProvider1.Dispose();

            if (String.IsNullOrEmpty(txtN.Text.Trim()))
            {
                errorProvider1.SetError(txtN, "Podaj liczbę " +
                    "oznaczającą liczbę figur geometrycznych");
                return;
            }
            if (!ushort.TryParse(txtN.Text, out N))
            {
                errorProvider1.SetError(txtN, "Wymagana jest liczba naturalna");
                return;
            }

            TFG = new Punkt[N];
            IndexTFG = 0;

            if (chlbFiguryGeometryczne.CheckedItems.Count <= 0)
            {
                errorProvider1.SetError(chlbFiguryGeometryczne, "Zaznacz przynajmniej jedną figurę");
                return;
            }

            CheckedListBox.CheckedItemCollection WybraneFigury =
                chlbFiguryGeometryczne.CheckedItems;

            chlbFiguryGeometryczne.Enabled = false;

            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;

            int X, Y;
            Color KolorLinii;
            Color KolorWypelnienia;
            int GruboscLinii;
            int GruboscPunktu;
            DashStyle StylLinii = DashStyle.Solid;
            int Xk, Yk;
            int OsDuza, OsMala;
            int Promien;
            int WylosowanyIndex;

            for (int i = 0;i < N; i++) 
            {
                X = rnd.Next(Margines, Xmax - Margines);
                Y = rnd.Next(Margines, Ymax - Margines);

                KolorLinii = Color.FromArgb(rnd.Next(0, 256),
                                            rnd.Next(0, 256),
                                            rnd.Next(0, 256), 
                                            rnd.Next(0, 256));

                KolorWypelnienia = Color.FromArgb(rnd.Next(0, 256),
                                            rnd.Next(0, 256),
                                            rnd.Next(0, 256),
                                            rnd.Next(0, 256));

                switch(rnd.Next(1, 6))
                {
                    case 1:
                        StylLinii = DashStyle.Dot; 
                        break;
                    case 2:
                        StylLinii = DashStyle.DashDotDot;
                        break;
                    case 3:
                        StylLinii = DashStyle.Dash;
                        break;
                    case 4:
                        StylLinii = DashStyle.Solid;
                        break;
                    case 5:
                        StylLinii = DashStyle.DashDot;
                        break;
                    case 6:
                        StylLinii = DashStyle.Solid;
                        break;
                }

                GruboscLinii = rnd.Next(1, 8);
                GruboscPunktu = rnd.Next(3, 14);
                
                WylosowanyIndex = rnd.Next(WybraneFigury.Count);

                switch(WybraneFigury[WylosowanyIndex].ToString())
                {
                    case "Punkt":
                        TFG[IndexTFG] = new Punkt(X, Y);
                        TFG[IndexTFG].UstalAtrybutyGraficzne(KolorWypelnienia, StylLinii, GruboscPunktu);
                        TFG[IndexTFG].Wykresl(Rysownica);
                        IndexTFG++;
                        break;
                    case "Linia":
                        Xk = rnd.Next(Margines, Xmax - Margines);
                        Yk = rnd.Next(Margines, Ymax - Margines);
                        TFG[IndexTFG] = new Linia(X, Y, Xk, Yk);
                        TFG[IndexTFG].UstalAtrybutyGraficzne(KolorWypelnienia, StylLinii, GruboscLinii);
                        TFG[IndexTFG].Wykresl(Rysownica);
                        IndexTFG++;
                        break;
                    case "Elipsa":
                        OsDuza = rnd.Next(Margines, Xmax/4 - Margines);
                        OsMala = rnd.Next(Margines, Ymax / 4 - Margines);
                        TFG[IndexTFG] = new Linia(X, Y, OsDuza, OsMala);
                        TFG[IndexTFG].UstalAtrybutyGraficzne(KolorWypelnienia, StylLinii, GruboscLinii);
                        TFG[IndexTFG].Wykresl(Rysownica);
                        IndexTFG++;
                        break;
                    case "Okrąg":
                        Promien = rnd.Next(Margines, Ymax / 4);
                        TFG[IndexTFG] = new Okrag(X, Y, Promien);
                        TFG[IndexTFG].UstalAtrybutyGraficzne(KolorWypelnienia, StylLinii, GruboscLinii);
                        TFG[IndexTFG].Wykresl(Rysownica);
                        IndexTFG++;
                        break;
                    case "Prostokąt":
                        Xk = rnd.Next(Margines, Xmax - Margines);
                        Yk = rnd.Next(Margines, Ymax - Margines);
                        TFG[IndexTFG] = new Prostokat(X, Y, rnd.Next(5, 100), rnd.Next(5, 100));
                        TFG[IndexTFG].UstalAtrybutyGraficzne(KolorWypelnienia, StylLinii, GruboscLinii);
                        TFG[IndexTFG].Wykresl(Rysownica);
                        IndexTFG++;
                        break;
                    case "Kwadrat":
                        int bok = rnd.Next(5, 70);
                        Xk = rnd.Next(Margines, Xmax - Margines);
                        Yk = rnd.Next(Margines, Ymax - Margines);
                        TFG[IndexTFG] = new Prostokat(X, Y, bok, bok);
                        TFG[IndexTFG].UstalAtrybutyGraficzne(KolorWypelnienia, StylLinii, GruboscLinii);
                        TFG[IndexTFG].Wykresl(Rysownica);
                        IndexTFG++;
                        break;

                    default:
                        MessageBox.Show("Wylosowana figura: " + 
                            chlbFiguryGeometryczne.CheckedItems[WylosowanyIndex].ToString()+
                            " nie jest jeszcze obsługiwana");
                            return;
                }
                pbRysownica.Refresh();
            }
            pbRysownica.Refresh();
            btnPrzesunLosowo.Enabled = true;
            btnLosujAtrybuty.Enabled = true;
            btnStart.Enabled = false;
            btnWlaczanieSlajdera.Enabled = true;

        }

        private void btnPrzesunLosowo_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int Xp, Yp;
            int Xmax, Ymax;
            Rysownica.Clear(pbRysownica.BackColor);

            Xmax = pbRysownica.Width - Margines;
            Ymax = pbRysownica.Height - Margines;

            for (int i = 0; i < TFG.Length; i++)
            {
                Xp = rnd.Next(Margines, Xmax - Margines);
                Yp = rnd.Next(Margines, Ymax - Margines);

                TFG[i].PrzesunDoNowegoXY(pbRysownica, Rysownica, Xp, Yp);
            }
            pbRysownica.Refresh();
        }

        private void btnLosujAtrybuty_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;

            int Xp, Yp;
            Color KolorLinii;
            Color KolorWypelnienia;
            int GruboscLinii;
            int GruboscPunktu;
            DashStyle StylLinii = DashStyle.Solid;
            Rysownica.Clear(pbRysownica.BackColor);

            for (int i = 0; i < TFG.Length; i++)
            {
                KolorLinii = Color.FromArgb(rnd.Next(0, 256),
                                            rnd.Next(0, 256),
                                            rnd.Next(0, 256),
                                            rnd.Next(0, 256));

                KolorWypelnienia = Color.FromArgb(rnd.Next(0, 256),
                                            rnd.Next(0, 256),
                                            rnd.Next(0, 256),
                                            rnd.Next(0, 256));

                switch (rnd.Next(1, 6))
                {
                    case 1:
                        StylLinii = DashStyle.Dot;
                        break;
                    case 2:
                        StylLinii = DashStyle.DashDotDot;
                        break;
                    case 3:
                        StylLinii = DashStyle.Dash;
                        break;
                    case 4:
                        StylLinii = DashStyle.Solid;
                        break;
                    case 5:
                        StylLinii = DashStyle.DashDot;
                        break;
                    case 6:
                        StylLinii = DashStyle.Solid;
                        break;
                }

                GruboscLinii = rnd.Next(1, 8);
                GruboscPunktu = rnd.Next(3, 14);

                TFG[i].UstalAtrybutyGraficzne(KolorLinii, StylLinii, GruboscLinii);
                TFG[i].UstalAtrybutyGraficzne(KolorWypelnienia);

                Xp = rnd.Next(Margines, Xmax - Margines);
                Yp = rnd.Next(Margines, Ymax - Margines);

                TFG[i].PrzesunDoNowegoXY(pbRysownica, Rysownica, Xp, Yp);
            }
            pbRysownica.Refresh();
        }

        private void btnWlaczanieSlajdera_Click(object sender, EventArgs e)
        {
            Rysownica.Clear(pbRysownica.BackColor);

            timer1.Tag = 0;
            txtIndeksTablicyTFG.Text = 0.ToString();
            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;
            TFG[0].PrzesunDoNowegoXY(pbRysownica, Rysownica, Xmax/2, Ymax/2);
            pbRysownica.Refresh();

            if (rdbAutomatyczny.Checked)
            {
                timer1.Enabled = true;
            }
            else
            {
                btnNastepna.Enabled = true;
                btnPoprzednia.Enabled = true;
                txtIndeksTablicyTFG.Enabled = true;
            }
            btnWlaczanieSlajdera.Enabled = false;
            btnWylaczanieSlajdera.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Rysownica.Clear(pbRysownica.BackColor);
            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;
            txtIndeksTablicyTFG.Text = timer1.Tag.ToString();
            TFG[(int)(timer1.Tag)].PrzesunDoNowegoXY(pbRysownica, Rysownica, Ymax/2, Xmax/2);
            pbRysownica.Refresh();

            timer1.Tag = ((int)(timer1.Tag) + 1)%(TFG.Length);
        }

        private void btnWylaczanieSlajdera_Click(object sender, EventArgs e)
        {
            Rysownica.Clear(pbRysownica.BackColor);
            timer1.Enabled = false;
            txtIndeksTablicyTFG.Text = "";
            btnWlaczanieSlajdera.Enabled = true;
            btnWylaczanieSlajdera.Enabled = false;
            rdbAutomatyczny.Checked = true;
            btnNastepna.Enabled = false;
            btnPoprzednia.Enabled = false;
            txtIndeksTablicyTFG.Enabled = false;
            Random rnd = new Random();
            int x, y;
            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;
            for (int i = 0; i < TFG.Length; i++)
            {
                x = rnd.Next(Margines, Xmax - Margines);
                y = rnd.Next(Margines, Ymax - Margines);

                TFG[i].PrzesunDoNowegoXY(pbRysownica, Rysownica, new Point(x, y));
            }
            pbRysownica.Refresh();
        }

        private void rdbManualny_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnNastepna_Click(object sender, EventArgs e)
        {
            ushort IndexFigury;
            IndexFigury = ushort.Parse(txtIndeksTablicyTFG.Text);

            if (IndexFigury < TFG.Length - 1)
            {
                IndexFigury++;
            }
            else 
            {
                IndexFigury = 0;
            }

            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;

            TFG[IndexFigury].PrzesunDoNowegoXY(pbRysownica, Rysownica, Xmax/2, Ymax/2);

            pbRysownica.Refresh();

            txtIndeksTablicyTFG.Text = IndexFigury.ToString();
        }

        private void btnPoprzednia_Click(object sender, EventArgs e)
        {
            ushort IndexFigury;
            IndexFigury = ushort.Parse(txtIndeksTablicyTFG.Text);

            if (IndexFigury != 0)
            {
                IndexFigury--;
            }
            else
            {
                IndexFigury = (ushort)(TFG.Length - 1);
            }

            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;

            TFG[IndexFigury].PrzesunDoNowegoXY(pbRysownica, Rysownica, Xmax / 2, Ymax / 2);

            pbRysownica.Refresh();

            txtIndeksTablicyTFG.Text = IndexFigury.ToString();
        }

        private void txtIndeksTablicyTFG_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
            ushort IndexFigury;

            if (txtIndeksTablicyTFG.Text == "") return;

            if (!ushort.TryParse(txtIndeksTablicyTFG.Text, out IndexFigury))
            {
                errorProvider1.SetError(txtIndeksTablicyTFG, "ERROR: zła wartość");
                return;
            }
            if (IndexFigury > TFG.Length - 1)
            {
                errorProvider1.SetError(txtIndeksTablicyTFG, "ERROR: za duża wartość");
                return;
            }
            Rysownica.Clear(pbRysownica.BackColor);

            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;

            TFG[IndexFigury].PrzesunDoNowegoXY(pbRysownica, Rysownica, Xmax / 2, Ymax / 2);

            pbRysownica.Refresh();
        }
    }
}
