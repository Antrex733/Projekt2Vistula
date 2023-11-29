using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSlajder_Click(object sender, EventArgs e)
        {
            foreach (Form FormX in Application.OpenForms)
            {
                if (FormX.Name == "RysowanieFigur")
                {
                    Hide();
                    FormX.Show();
                    return;
                }
            }
            RysowanieFigur QQQ = new RysowanieFigur();
            this.Hide();
            QQQ.Show();
        }

        private void btnKreslenieFigurMysz_Click(object sender, EventArgs e)
        {
            foreach (Form Formularz in Application.OpenForms)
            {
                if (Formularz.Name == "KreslenieFigur")
                {
                    Hide();
                    Formularz.Show();
                    return;
                }
            }
            KreslenieFigur QQQ = new KreslenieFigur();
            this.Hide();
            QQQ.Show();
        }
    }
}
