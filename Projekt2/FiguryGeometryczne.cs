using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt2
{
    public class FiguryGeometryczne
    {
        public class Punkt
        {
            const int DomyslnyRozmiarPunktu = 22;
            protected int X;
            protected int Y;
            protected int GruboscLinii;
            protected Color Kolor;
            protected bool Widoczny; // true - widoczny, false - nie

            protected Color KolorTla;
            protected DashStyle StylLinii;

            public Punkt(int x, int y)
            {
                X = x; 
                Y = y;
                //wartości domyślne
                Kolor = Color.Black;
                KolorTla = Color.White;
                StylLinii = DashStyle.Solid;
                GruboscLinii = DomyslnyRozmiarPunktu;
                Widoczny = false;
            }
            public Punkt(int x, int y, Color Kolor):this(x, y)
            {
                this.Kolor = Kolor;
            }
            public Punkt(int x, int y, Color Kolor, int RozmiarPunktu) : this(x, y, Kolor)
            {
                GruboscLinii = RozmiarPunktu;
            }
            public Punkt(int x, int y, DashStyle StylLinii, Color Kolor, int RozmiarPunktu) : this(x, y, Kolor, RozmiarPunktu)
            {
                this.StylLinii = StylLinii;
            }

            public virtual void UaktualnijXY(int x, int y)
            {
                X = x;
                Y = y;
            }
            public virtual void UaktualnijXY(Point NowaLokalizacja)
            {
                X = NowaLokalizacja.X;
                Y = NowaLokalizacja.Y;
            }
            public void UstalAtrybutyGraficzne(Color KolorLinii, DashStyle StylLinii, int GruboscLinii)
            {
                Kolor = KolorLinii;
                this.StylLinii = StylLinii;
                this.GruboscLinii = GruboscLinii;
            }
            public void UstalAtrybutyGraficzne(Color KolorLinii)
            {
                Kolor = KolorLinii;
            }
            public void UstalAtrybutyGraficzne(DashStyle StylLinii)
            {
                this.StylLinii = StylLinii;
            }
            public virtual void Wykresl(Graphics Rysownica)
            {
                SolidBrush Pedzel = new SolidBrush(Kolor);
                Rysownica.FillEllipse(Pedzel, X - GruboscLinii/2, Y - GruboscLinii/2, GruboscLinii, GruboscLinii);
                Widoczny = true;
                Pedzel.Dispose();
            }
            public virtual void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny) 
                {
                    SolidBrush Pedzel = new SolidBrush(Kontrolka.BackColor);
                    Rysownica.FillEllipse(Pedzel, X - GruboscLinii/2, Y - GruboscLinii/2, GruboscLinii, GruboscLinii);
                    Widoczny = false;
                    Pedzel.Dispose();
                }
            }
            public virtual void PrzesunDoNowegoXY(Control Kontrolka, Graphics Rysownica, Point NowaLokalizacja)
            {
                UaktualnijXY(NowaLokalizacja);
                Wykresl(Rysownica);
            }
            public virtual void PrzesunDoNowegoXY(Control Kontrolka, Graphics Rysownica, int x, int y)
            {
                UaktualnijXY(x, y);
                Wykresl(Rysownica);
            }
        }
        public class Linia : Punkt
        {
            int Xk, Yk;

            public Linia(int x, int y, int xk, int yk) : base(x, y)
            {
                Xk = xk;
                Yk = yk;
            }

            public Linia(int x, int y, int xk, int yk, DashStyle StylLinii, Color Kolor, int RozmiarPunktu) 
                : base(x, y, StylLinii, Kolor, RozmiarPunktu)
            {
                Xk = xk;
                Yk = yk;
            }
            public override void Wykresl(Graphics Rysownica)
            {
                Pen Pioro = new Pen(Kolor, GruboscLinii);
                Pioro.DashStyle = StylLinii;
                Rysownica.DrawLine(Pioro, X, Y, Xk, Yk);
                Widoczny = true;
                Pioro.Dispose();
            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny)
                {
                    Pen Pioro = new Pen(Kontrolka.BackColor, GruboscLinii);
                    Pioro.DashStyle = StylLinii;
                    Rysownica.DrawLine(Pioro, X, Y, Xk, Yk);
                    Widoczny = false;
                    Pioro.Dispose();
                }
            }
            public override void PrzesunDoNowegoXY(Control Kontrolka, Graphics Rysownica, int x, int y)
            {
                int dx, dy;

                if (x > X)
                    dx = x - X;
                else
                    dx = X - x;

                if (y > Y)
                    dy = y - Y;
                else
                    dy = Y - y;

                X = x;
                Y = y;

                Xk = (Xk + dx) % Kontrolka.Width;
                Yk = (Yk + dy) % Kontrolka.Height;

                Wykresl(Rysownica);
            }
        }
        public class Elipsa : Punkt
        {
            protected int OsDuza, OsMala;
            public Elipsa(int x, int y, int osMala, int osDuza) : base(x, y)
            {
                OsMala = osMala;
                OsDuza = osDuza;
            }

            public Elipsa(int x, int y, int osMala, int osDuza, DashStyle StylLinii, Color Kolor, int RozmiarPunktu) : base(x, y, StylLinii, Kolor, RozmiarPunktu)
            {
                OsMala = osMala;
                OsDuza = osDuza;
            }
            public override void Wykresl(Graphics Rysownica)
            {
                Pen Pioro = new Pen(Kolor, GruboscLinii);
                Pioro.DashStyle = StylLinii;
                Rysownica.DrawEllipse(Pioro, X, Y, OsDuza, OsMala);
                Widoczny = true;
                Pioro.Dispose();
            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny)
                {
                    Pen Pioro = new Pen(Kontrolka.BackColor, GruboscLinii);
                    Pioro.DashStyle = StylLinii;
                    Rysownica.DrawEllipse(Pioro, X, Y, OsDuza, OsMala);
                    Widoczny = false;
                    Pioro.Dispose();
                }
            }
        }
        public class Okrag : Elipsa
        {
            protected int Promien;

            public Okrag(int x, int y, int promien) : base(x, y, promien*2, promien*2)
            {
               Promien = promien;
            }

            public Okrag(int x, int y, int promien, DashStyle StylLinii, Color Kolor, 
                int RozmiarPunktu) : base(x, y, promien * 2, promien * 2, StylLinii, Kolor, RozmiarPunktu)
            {
                Promien = promien;
            }
            public override void Wykresl(Graphics Rysownica)
            {
                Pen Pioro = new Pen(Kolor, GruboscLinii);
                Pioro.DashStyle = StylLinii;
                Rysownica.DrawEllipse(Pioro, X, Y, Promien * 2, Promien * 2);
                Widoczny = true;
                Pioro.Dispose();
            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny)
                {
                    Pen Pioro = new Pen(Kontrolka.BackColor, GruboscLinii);
                    Pioro.DashStyle = StylLinii;
                    Rysownica.DrawEllipse(Pioro, X, Y, Promien*2, Promien*2);
                    Widoczny = false;
                    Pioro.Dispose();
                }
            }
        }


        public class LiniaKreslonaMysza : Punkt
        {
            List<Point> ListaPunktow = new List<Point>();
            public LiniaKreslonaMysza(Point PoczatekLinii) : base(PoczatekLinii.X, PoczatekLinii.Y)
            {
                ListaPunktow.Add(PoczatekLinii);
            }
            public LiniaKreslonaMysza(Point PoczatekLinii, Color Kolor, DashStyle StylLinii, int GruboscLinii) 
                : base(PoczatekLinii.X, PoczatekLinii.Y, Kolor, GruboscLinii)
            {
            }
            public void DodajNowyPunktKreslonejLinii(Point NowyPunkt)
            {
                ListaPunktow.Add(NowyPunkt);
            }
            public override void UaktualnijXY(int x, int y)
            {
                if (ListaPunktow.Count < 1)
                {
                    return;
                }

                int PrzyrostX = ListaPunktow[0].X - x;
                int PrzyrostY = ListaPunktow[0].Y - y;

                for (int i = 0; i < ListaPunktow.Count; i++)
                {
                    ListaPunktow[i] = new Point(ListaPunktow[i].X - PrzyrostX,
                        ListaPunktow[i].Y - PrzyrostY);
                }
            }
            public override void Wykresl(Graphics Rysownica)
            {
                Point[] TablicaPunkow = new Point[ListaPunktow.Count];

                for (int i = 0;i < ListaPunktow.Count;i++)
                {
                    TablicaPunkow[i] = ListaPunktow[i];
                }
                Pen Pioro = new Pen(Kolor, GruboscLinii);
                Pioro.DashStyle = StylLinii;

                Rysownica.DrawLines(Pioro, TablicaPunkow);
            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                Point[] TablicaPunkow = new Point[ListaPunktow.Count];

                for (int i = 0; i < ListaPunktow.Count; i++)
                {
                    TablicaPunkow[i] = ListaPunktow[i];
                }
                Pen Pioro = new Pen(Kontrolka.BackColor, GruboscLinii);
                Pioro.DashStyle = StylLinii;

                Rysownica.DrawLines(Pioro, TablicaPunkow);
            }
        }
        //Osmiokat
        //FillOsmiokat
        public class Kwadrat : Linia
        {
            int Xk, Yk;
            public Kwadrat(int Xp, int Yp, int Xk, int Yk) : base(Xp, Yp, Xk, Yk)
            {
                this.Xk = Xk;
                this.Yk = Yk;
            }

            public Kwadrat(int Xp, int Yp, int Xk, int Yk, DashStyle StylLinii, Color Kolor, 
                int RozmiarPunktu) : base(Xp, Yp, Xk, Yk, StylLinii, Kolor, RozmiarPunktu)
            {
                this.Xk = Xk;
                this.Yk = Yk;
            }
            public override void Wykresl(Graphics Rysownica)
            {
                Pen Pioro = new Pen(Kolor, GruboscLinii);
                Pioro.DashStyle = StylLinii;
                Rysownica.DrawRectangle(Pioro, X, Y, Xk, Yk);
                Widoczny = true;
                Pioro.Dispose();
            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny)
                {
                    Pen Pioro = new Pen(Kontrolka.BackColor, GruboscLinii);
                    Pioro.DashStyle = StylLinii;
                    Rysownica.DrawRectangle(Pioro, X, Y, Xk, Yk);
                    Widoczny = false;
                    Pioro.Dispose();
                }
            }
            public override void PrzesunDoNowegoXY(Control Kontrolka, Graphics Rysownica, int x, int y)
            {
                int dx, dy;

                if (x > X)
                    dx = x - X;
                else
                    dx = X - x;

                if (y > Y)
                    dy = y - Y;
                else
                    dy = Y - y;

                X = x;
                Y = y;

                Xk = (Xk + dx) % Kontrolka.Width;
                Yk = (Yk + dy) % Kontrolka.Height;

                Wykresl(Rysownica);
            }
        }
        public class Prostokat: Kwadrat
        {
            int Xk, Yk;
            public Prostokat(int Xp, int Yp, int Xk, int Yk) : base(Xp, Yp, Xk, Yk)
            {
                this.Xk = Xk;
                this.Yk = Yk;
            }

            public Prostokat(int Xp, int Yp, int Xk, int Yk, DashStyle StylLinii, Color Kolor,
                int RozmiarPunktu) : base(Xp, Yp, Xk, Yk, StylLinii, Kolor, RozmiarPunktu)
            {
                this.Xk = Xk;
                this.Yk = Yk;
            }
            public override void Wykresl(Graphics Rysownica)
            {
                Pen Pioro = new Pen(Kolor, GruboscLinii);
                Pioro.DashStyle = StylLinii;
                Rysownica.DrawRectangle(Pioro, X, Y, Xk, Yk);
                Widoczny = true;
                Pioro.Dispose();
            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny)
                {
                    Pen Pioro = new Pen(Kontrolka.BackColor, GruboscLinii);
                    Pioro.DashStyle = StylLinii;
                    Rysownica.DrawRectangle(Pioro, X, Y, Xk, Yk);
                    Widoczny = false;
                    Pioro.Dispose();
                }
            }
            public override void PrzesunDoNowegoXY(Control Kontrolka, Graphics Rysownica, int x, int y)
            {
                int dx, dy;

                if (x > X)
                    dx = x - X;
                else
                    dx = X - x;

                if (y > Y)
                    dy = y - Y;
                else
                    dy = Y - y;

                X = x;
                Y = y;

                Xk = (Xk + dx) % Kontrolka.Width;
                Yk = (Yk + dy) % Kontrolka.Height;

                Wykresl(Rysownica);
            }
        }
        public class Koło : Okrag
        {
            public Koło(int x, int y, int promien) : base(x, y, promien)
            {
                this.Promien = promien;
            }
            public Koło(int x, int y, int promien, DashStyle StylLinii,Color Kolor,
                int GruboscLinii) : base(x, y, promien, StylLinii,Kolor, GruboscLinii)
            {
                Promien = promien;
            }
            public override void Wykresl(Graphics Rysownica)
            {
                SolidBrush Pedzel = new SolidBrush(Kolor);
                Rysownica.FillEllipse(Pedzel, X, Y, OsDuza, OsMala);
                Widoczny = true;
                Pedzel.Dispose();
            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny)
                {
                    SolidBrush Pedzel = new SolidBrush(Kontrolka.BackColor);
                    Rysownica.FillEllipse(Pedzel, X, Y, OsDuza, OsMala);
                    Widoczny = true;
                    Pedzel.Dispose();
                }
            }
        }
        public class PelnyKwadrat:Linia
        {
            int Xk, Yk;

            public PelnyKwadrat(int Xp, int Yp, int Xk, int Yk) : base(Xp, Yp, Xk, Yk)
            {
                this.Xk = Xk;
                this.Yk = Yk;
            }
            public PelnyKwadrat(int Xp, int Yp, int Xk, int Yk, DashStyle StylLinii, Color Kolor, 
                int GruboscLinii) : base(Xp, Yp, Xk, Yk, StylLinii, Kolor, GruboscLinii)
            {
                this.Xk = Xk;
                this.Yk = Yk;
            }
            public override void Wykresl(Graphics Rysownica)
            {
                SolidBrush Pedzel = new SolidBrush(KolorTla);
                Rysownica.FillRectangle(Pedzel, X, Y, Xk, Yk);
                Widoczny = true;
                Pedzel.Dispose();
            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny)
                {
                    SolidBrush Pedzel = new SolidBrush(Kolor);
                    Rysownica.FillRectangle(Pedzel, X, Y, Xk, Yk);
                    Widoczny = true;
                    Pedzel.Dispose();
                }
            }
            public override void PrzesunDoNowegoXY(Control Kontrolka, Graphics Rysownica, int x, int y)
            {
                int dx, dy;

                if (x > X)
                    dx = x - X;
                else
                    dx = X - x;

                if (y > Y)
                    dy = y - Y;
                else
                    dy = Y - y;

                X = x;
                Y = y;

                Xk = (Xk + dx) % Kontrolka.Width;
                Yk = (Yk + dy) % Kontrolka.Height;

                Wykresl(Rysownica);
            }
        }
        public class KrzywaBeziera: Punkt
        {
            public List<Point> PunktyKontrolneKrzywejBeziera = new List<Point>();
            int PromienPunktuKontrolnego = 5;

            public ushort LiczbaPunktowKontrolnych { get; set; }

            Font FontOpisuPunktow = new Font("Arial", 8, FontStyle.Italic);

            public KrzywaBeziera(Graphics Rysownica, Pen Pioro, Point XYpunktu) 
                : base(XYpunktu.X, XYpunktu.Y, Pioro.DashStyle, Pioro.Color, (int)(Pioro.Width))
            {
                PunktyKontrolneKrzywejBeziera.Add(XYpunktu);
                using(SolidBrush Pedzel = new SolidBrush(Pioro.Color)) 
                {
                    Rysownica.FillEllipse(Pedzel, XYpunktu.X - PromienPunktuKontrolnego,
                        XYpunktu.Y - PromienPunktuKontrolnego, 2 * PromienPunktuKontrolnego,
                        2 * PromienPunktuKontrolnego);
                    Rysownica.DrawString("P" + (PunktyKontrolneKrzywejBeziera.Count - 1).ToString(),
                        FontOpisuPunktow, Pedzel,
                        PunktyKontrolneKrzywejBeziera[PunktyKontrolneKrzywejBeziera.Count - 1]);
                }
            }
            public virtual void DodajNowyPunktKontrolny(Point XYpunktu, Graphics Rysownica)
            {
                PunktyKontrolneKrzywejBeziera.Add(XYpunktu);
                using(SolidBrush Pedzel = new SolidBrush(Color.Orange))
                {
                    if (PunktyKontrolneKrzywejBeziera.Count == 1 || PunktyKontrolneKrzywejBeziera.Count == 4)
                    {
                        Pedzel.Color = Kolor;
                    }
                    Rysownica.FillEllipse(Pedzel, XYpunktu.X - PromienPunktuKontrolnego,
                        XYpunktu.Y - PromienPunktuKontrolnego, 2 * PromienPunktuKontrolnego
                        , 2 * PromienPunktuKontrolnego);
                    Rysownica.DrawString("P" + (PunktyKontrolneKrzywejBeziera.Count - 1).ToString(),
                        FontOpisuPunktow, Pedzel,
                        PunktyKontrolneKrzywejBeziera[PunktyKontrolneKrzywejBeziera.Count - 1]);
                }
                if (PunktyKontrolneKrzywejBeziera.Count == 4)
                {
                    Wykresl(Rysownica);
                }
            }
            public override void Wykresl(Graphics Rysownica)
            {
                using(Pen Pioro = new Pen(Kolor, GruboscLinii))
                {
                    Pioro.DashStyle = StylLinii;
                    Point[] PunktyKontrolne = new Point[PunktyKontrolneKrzywejBeziera.Count];

                    for (ushort i = 0; i < PunktyKontrolneKrzywejBeziera.Count; i++)
                    {
                        PunktyKontrolne[i] = new Point(PunktyKontrolneKrzywejBeziera[i].X,
                            PunktyKontrolneKrzywejBeziera[i].Y);
                    }
                    Rysownica.DrawBezier(Pioro, PunktyKontrolne[0], 
                        PunktyKontrolne[1], PunktyKontrolne[2], PunktyKontrolne[3]);

                    Widoczny = true;
                }
            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny)
                {
                    using(Pen Pioro = new Pen(Kontrolka.BackColor, GruboscLinii))
                    {
                        Pioro.DashStyle = StylLinii;
                        Point[] PunktyKontrolne = new Point[PunktyKontrolneKrzywejBeziera.Count];

                        for (ushort i = 0; i < PunktyKontrolneKrzywejBeziera.Count; i++)
                        {
                            PunktyKontrolne[i] = new Point(PunktyKontrolneKrzywejBeziera[i].X,
                                PunktyKontrolneKrzywejBeziera[i].Y);
                        }
                        Rysownica.DrawBezier(Pioro, PunktyKontrolne[0],
                            PunktyKontrolne[1], PunktyKontrolne[2], PunktyKontrolne[3]);

                        Widoczny = false;
                    }
                }
            }
            public override void UaktualnijXY(int x, int y)
            {
                int PrzyrostX = PunktyKontrolneKrzywejBeziera[0].X - x;
                int PrzyrostY = PunktyKontrolneKrzywejBeziera[0].Y- y;

                for (int i = 0; i < PunktyKontrolneKrzywejBeziera.Count; i++)
                {
                    PunktyKontrolneKrzywejBeziera[i] = new Point(
                        PunktyKontrolneKrzywejBeziera[i].X - PrzyrostX,
                        PunktyKontrolneKrzywejBeziera[i].Y - PrzyrostY);
                }
            }
        }
        public class Lamana : Punkt
        {
            public ushort LiczbaPunktowKontrolnych { get; set; }
            public List<Point> PunktyLamanej = new List<Point>();
            int PromienPunktuKontrolnego = 5;
            Font FontOpisuPunktow = new Font("Arial", 8, FontStyle.Italic);

            public Lamana(Graphics Rysownica, Pen Pioro, Point XYpunktu)
                : base(XYpunktu.X, XYpunktu.Y, Pioro.DashStyle, Pioro.Color, (int)(Pioro.Width))
            {
                PunktyLamanej.Add(XYpunktu);
                using (SolidBrush Pedzel = new SolidBrush(Pioro.Color))
                {
                    Rysownica.FillEllipse(Pedzel, XYpunktu.X - PromienPunktuKontrolnego,
                        XYpunktu.Y - PromienPunktuKontrolnego, 2 * PromienPunktuKontrolnego,
                        2 * PromienPunktuKontrolnego);
                }
            }
            public virtual void DodajNowyPunktKontrolny(Point XYpunktu, Graphics Rysownica)
            {
                PunktyLamanej.Add(XYpunktu);
                using (SolidBrush Pedzel = new SolidBrush(Color.Orange))
                {
                    Pedzel.Color = Kolor;
                    Rysownica.FillEllipse(Pedzel, XYpunktu.X - PromienPunktuKontrolnego,
                        XYpunktu.Y - PromienPunktuKontrolnego, 2 * PromienPunktuKontrolnego
                        , 2 * PromienPunktuKontrolnego);
                }
                if (PunktyLamanej.Count == 5)
                {
                    Wykresl(Rysownica);
                }
            }
            public override void Wykresl(Graphics Rysownica)
            {
                using (Pen Pioro = new Pen(Kolor, GruboscLinii))
                {
                    Pioro.DashStyle = StylLinii;
                    Point[] PunktyKontrolne = new Point[PunktyLamanej.Count];

                    for (ushort i = 0; i < PunktyLamanej.Count; i++)
                    {
                        PunktyKontrolne[i] = new Point(PunktyLamanej[i].X,
                            PunktyLamanej[i].Y);
                    }
                    Rysownica.DrawClosedCurve(Pioro, PunktyKontrolne);
                    Widoczny = true;
                }
            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny)
                {
                    using (Pen Pioro = new Pen(Kontrolka.BackColor, GruboscLinii))
                    {
                        Pioro.DashStyle = StylLinii;
                        Point[] PunktyLamanejRysowanie = new Point[PunktyLamanej.Count];

                        for (ushort i = 0; i < PunktyLamanej.Count; i++)
                        {
                            PunktyLamanejRysowanie[i] = new Point(PunktyLamanej[i].X,
                                PunktyLamanej[i].Y);
                        }
                        Rysownica.DrawClosedCurve(Pioro, PunktyLamanejRysowanie);
                        Widoczny = false;
                    }
                }
            }
            public override void UaktualnijXY(int x, int y)
            {
                int PrzyrostX = PunktyLamanej[0].X - x;
                int PrzyrostY = PunktyLamanej[0].Y - y;

                for (int i = 0; i < PunktyLamanej.Count; i++)
                {
                    PunktyLamanej[i] = new Point(
                        PunktyLamanej[i].X - PrzyrostX,
                        PunktyLamanej[i].Y - PrzyrostY);
                }
            }
        }
    }
}
