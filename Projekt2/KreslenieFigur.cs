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
    public partial class KreslenieFigur : Form
    {
        const int Margiens = 10;
        const int MargiensFormularza = 2;

        Graphics Rysownica;
        Graphics RysownicaTymczasowa;

        Point Punkt;

        Pen Pioro;
        Color Kolor = Color.Blue;
        Color KolorWypelnienia = Color.Green;

        SolidBrush Pedzel;
        Pen PioroTymczasowe;

        List<Punkt> LFG = new List<Punkt>();
        public KreslenieFigur()
        {
            InitializeComponent();
            pbRysownica.BackColor = Color.Beige;
            pbRysownica.BorderStyle = BorderStyle.FixedSingle;
            pbRysownica.Image  = new Bitmap(pbRysownica.Width, pbRysownica.Height);
            Rysownica = Graphics.FromImage(pbRysownica.Image);
            RysownicaTymczasowa = pbRysownica.CreateGraphics();
            Punkt = Point.Empty;
            Pioro = new Pen(Color.Black, 1f);
            Pioro.DashStyle = DashStyle.Solid;
            Pioro.StartCap = LineCap.Round;
            Pioro.EndCap = LineCap.Round;
            PioroTymczasowe = new Pen(Color.Blue, 1);
            Pedzel = new SolidBrush(KolorWypelnienia);
        }

        private void btnPowrot_Click(object sender, EventArgs e)
        {
            foreach(Form Formularz in Application.OpenForms) 
            {
                if (Formularz.Name == "Form1")
                {
                    Hide();
                    Formularz.Show();
                    break;
                }
            }
        }

        private void pbRysownica_MouseDown(object sender, MouseEventArgs e)
        {
            lblx0.Text = e.Location.X.ToString();
            lbly0.Text = e.Location.Y.ToString();

            if (e.Button == MouseButtons.Left)
            {
                Punkt = e.Location;
                //Pioro.Color =   //Pobieramy kolor z kontrolki
                //Pobieramy Styl z kontrolki
                //Pobieramy Grubosc z kontrolki
                if (rbLiniaCiagla.Checked)
                {
                    //Pioro.Color =   //Pobieramy kolor z kontrolki
                    //Pobieramy Styl z kontrolki
                    //Pobieramy Grubosc z kontrolki
                    LFG.Add(new LiniaKreslonaMysza(Punkt, Pioro.Color, Pioro.DashStyle, (int)Pioro.Width));
                }
            }
        }

        private void pbRysownica_MouseMove(object sender, MouseEventArgs e)
        {
            lblx0.Text = e.Location.X.ToString();
            lbly0.Text = e.Location.Y.ToString();
            if(e.Button == MouseButtons.Left)
            {
                lblx0.Text = e.Location.X.ToString();
                lbly0.Text = e.Location.Y.ToString();
                int lewyGornyNaroznikX =
                    (Punkt.X > e.Location.X) ? e.Location.X : Punkt.X;
                int lewyGornyNaroznikY =
                    (Punkt.Y > e.Location.Y) ? e.Location.Y : Punkt.Y;
                int Szerokosc = Math.Abs(Punkt.X - e.Location.X);
                int Wysokosc = Math.Abs(Punkt.Y - e.Location.Y);

                if(rbPunkt.Checked)
                {

                }
                else if(rbLiniaProsta.Checked)
                {
                    RysownicaTymczasowa
                        .DrawLine(PioroTymczasowe, Punkt.X, Punkt.Y, e.Location.X, e.Location.Y);
                }
                else if (rbLiniaCiagla.Checked)
                {
                    ((LiniaKreslonaMysza)LFG[LFG.Count - 1]).DodajNowyPunktKreslonejLinii(e.Location);
                }
                else if (rbElipsa.Checked)
                {
                    RysownicaTymczasowa.DrawEllipse(PioroTymczasowe, 
                        new Rectangle(lewyGornyNaroznikX, lewyGornyNaroznikY, Szerokosc, Wysokosc));
                }
                else if (rbOkrag.Checked)
                {
                    RysownicaTymczasowa.DrawEllipse(PioroTymczasowe,
                        new Rectangle(lewyGornyNaroznikX, lewyGornyNaroznikY, Wysokosc, Wysokosc));
                }
                else if (rbKwadrat.Checked)
                {
                    RysownicaTymczasowa.DrawRectangle(PioroTymczasowe,
                        new Rectangle(lewyGornyNaroznikX, lewyGornyNaroznikY, Szerokosc, Szerokosc));
                }
                else if (rbProstokat.Checked)
                {
                    RysownicaTymczasowa.DrawRectangle(PioroTymczasowe,
                        new Rectangle(lewyGornyNaroznikX, lewyGornyNaroznikY, Szerokosc, Wysokosc));
                }
                else if (rbKolo.Checked)
                {
                    RysownicaTymczasowa.FillEllipse(Pedzel,
                        new Rectangle(lewyGornyNaroznikX, lewyGornyNaroznikY, Wysokosc, Wysokosc));
                }
                else if (rbPelnyKwadrat.Checked)
                {
                    RysownicaTymczasowa.FillRectangle(Pedzel,
                        new Rectangle(lewyGornyNaroznikX, lewyGornyNaroznikY, Wysokosc, Wysokosc));
                }

                pbRysownica.Refresh();
            }
        }

        private void pbRysownica_MouseUp(object sender, MouseEventArgs e)
        {
            lblx0.Text = e.Location.X.ToString();
            lbly0.Text = e.Location.Y.ToString();

            lblx0.Text = e.Location.X.ToString();
            lbly0.Text = e.Location.Y.ToString();
            int lewyGornyNaroznikX =
                (Punkt.X > e.Location.X) ? e.Location.X : Punkt.X;
            int lewyGornyNaroznikY =
                (Punkt.Y > e.Location.Y) ? e.Location.Y : Punkt.Y;
            int Szerokosc = Math.Abs(Punkt.X - e.Location.X);
            int Wysokosc = Math.Abs(Punkt.Y - e.Location.Y);

            if (e.Button == MouseButtons.Left)
            {
                if (rbPunkt.Checked)
                {
                    LFG.Add(new Punkt(Punkt.X, Punkt.Y));
                    LFG[LFG.Count - 1].UstalAtrybutyGraficzne(Kolor, Pioro.DashStyle,/*GruboscPunktu*/5);
                    LFG[LFG.Count - 1].Wykresl(Rysownica);
                }
                else if (rbLiniaProsta.Checked)
                {
                    LFG.Add(new Linia(Punkt.X, Punkt.Y, e.Location.X, e.Location.Y));
                    LFG[LFG.Count - 1].UstalAtrybutyGraficzne(Kolor, Pioro.DashStyle,/*GruboscLijnii*/5);
                    LFG[LFG.Count - 1].Wykresl(Rysownica);
                }
                else if (rbLiniaCiagla.Checked)
                {
                    ((LiniaKreslonaMysza)LFG[LFG.Count - 1]).DodajNowyPunktKreslonejLinii(e.Location);
                    ((LiniaKreslonaMysza)LFG[LFG.Count - 1])
                        .UstalAtrybutyGraficzne(Kolor, Pioro.DashStyle, /*GruboscLijnii*/5);
                    Punkt = e.Location;
                    LFG[LFG.Count - 1].Wykresl(Rysownica);
                }
                else if (rbElipsa.Checked)
                {
                    LFG.Add(new Elipsa(lewyGornyNaroznikX, lewyGornyNaroznikY, Wysokosc, Szerokosc));
                    LFG[LFG.Count - 1].UstalAtrybutyGraficzne(Kolor, Pioro.DashStyle,/*GruboscLijnii*/5);
                    LFG[LFG.Count - 1].Wykresl(Rysownica);
                }
                else if (rbOkrag.Checked)
                {
                    LFG.Add(new Okrag(lewyGornyNaroznikX, lewyGornyNaroznikY, Szerokosc / 2));
                    LFG[LFG.Count - 1].UstalAtrybutyGraficzne(KolorWypelnienia, Pioro.DashStyle,/*GruboscLijnii*/5);
                    LFG[LFG.Count - 1].Wykresl(Rysownica);
                }
                else if (rbKwadrat.Checked)
                {
                    LFG.Add(new Kwadrat(lewyGornyNaroznikX, lewyGornyNaroznikY, Szerokosc, Szerokosc));
                    LFG[LFG.Count - 1].UstalAtrybutyGraficzne(Kolor, Pioro.DashStyle,/*GruboscLijnii*/5);
                    LFG[LFG.Count - 1].Wykresl(Rysownica);
                }
                else if (rbProstokat.Checked)
                {
                    LFG.Add(new Prostokat(lewyGornyNaroznikX, lewyGornyNaroznikY, Szerokosc, Wysokosc));
                    LFG[LFG.Count - 1].UstalAtrybutyGraficzne(Kolor, Pioro.DashStyle,/*GruboscLijnii*/5);
                    LFG[LFG.Count - 1].Wykresl(Rysownica);
                }
                else if (rbKolo.Checked)
                {
                    LFG.Add(new Koło(lewyGornyNaroznikX, lewyGornyNaroznikY, Szerokosc/2));
                    LFG[LFG.Count - 1].UstalAtrybutyGraficzne(Kolor, Pioro.DashStyle,/*GruboscLijnii*/5);
                    LFG[LFG.Count - 1].Wykresl(Rysownica);
                }
                else if (rbPelnyKwadrat.Checked)
                {
                    LFG.Add(new PelnyKwadrat(lewyGornyNaroznikX, lewyGornyNaroznikY, Szerokosc, Szerokosc));
                    LFG[LFG.Count - 1].UstalAtrybutyGraficzne(Kolor, Pioro.DashStyle,/*GruboscLijnii*/5);
                    LFG[LFG.Count - 1].Wykresl(Rysownica);
                }
                else if(rbKrzywaBeziera.Checked)
                {
                    if (gbFigury_Line.Enabled)
                    {
                        LFG.Add(new KrzywaBeziera(Rysownica, Pioro, Punkt));
                        gbFigury_Line.Enabled = false;
                        ((KrzywaBeziera)LFG[LFG.Count - 1]).LiczbaPunktowKontrolnych = 0;
                    }
                    else
                    {
                        ((KrzywaBeziera)LFG[LFG.Count - 1]).DodajNowyPunktKontrolny(e.Location, Rysownica);
                        ((KrzywaBeziera)LFG[LFG.Count - 1]).LiczbaPunktowKontrolnych++;
                        if (((KrzywaBeziera)LFG[LFG.Count - 1]).LiczbaPunktowKontrolnych == 3)
                        {
                            gbFigury_Line.Enabled = true;
                            LFG[LFG.Count - 1].Wykresl(Rysownica);
                        }
                    }
                }
                else if(rbDrawClosedCurve.Checked)
                {
                    if (gbFigury_Line.Enabled)
                    {
                        LFG.Add(new Lamana(Rysownica, Pioro, Punkt));
                        gbFigury_Line.Enabled = false;
                        ((Lamana)LFG[LFG.Count - 1]).LiczbaPunktowKontrolnych = 0;
                    }
                    else
                    {
                        ((Lamana)LFG[LFG.Count - 1]).DodajNowyPunktKontrolny(e.Location, Rysownica);
                        ((Lamana)LFG[LFG.Count - 1]).LiczbaPunktowKontrolnych++;
                        if (((Lamana)LFG[LFG.Count - 1]).LiczbaPunktowKontrolnych == 5)
                        {
                            gbFigury_Line.Enabled = true;
                            LFG[LFG.Count - 1].Wykresl(Rysownica);
                        }
                    }
                }

                pbRysownica.Refresh();
            }
        }

        private void btnKolorLinii_Click(object sender, EventArgs e)
        {
            ColorDialog kolor = new ColorDialog();
            kolor.ShowDialog();
            Kolor = kolor.Color;
            Pioro.Color = kolor.Color;
            txtKolorLinii.BackColor = kolor.Color;
        }

        private void btnKolorWypelnienia_Click(object sender, EventArgs e)
        {
            ColorDialog kolor = new ColorDialog();
            kolor.ShowDialog();
            Pedzel.Color = kolor.Color;
            KolorWypelnienia = kolor.Color;
            txtKolorWypelnienia.BackColor = kolor.Color;
        }
    }
}
