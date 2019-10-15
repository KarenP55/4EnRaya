using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_en_raya
{
    public partial class Form1 : Form
    {
        private int turno = 0;
        private string equis = "x";
        private string circulo = "o";
        private string circulooequis;

        public Form1()
        {
            InitializeComponent();
        }


        private void button11_Click(object sender, EventArgs e)
        {
            Bloqueo();
            boton11.Text = circulooequis.ToString();
            boton11.Enabled = false;
        }

        private void boton12_Click(object sender, EventArgs e)
        {
            Bloqueo();
            boton12.Text = circulooequis.ToString();
            boton12.Enabled = false;
        }

        private void boton13_Click(object sender, EventArgs e)
        {
            Bloqueo();
            boton13.Text = circulooequis.ToString();
            boton13.Enabled = false;
        }

        private void boton14_Click(object sender, EventArgs e)
        {
            Bloqueo();
            boton14.Text = circulooequis.ToString();
            boton14.Enabled = false;
        }

        private void boton21_Click_1(object sender, EventArgs e)
        {
            Bloqueo();
            boton21.Text = circulooequis.ToString();
            boton21.Enabled = false;
        }

        private void boton22_Click(object sender, EventArgs e)
        {
            Bloqueo();
            boton22.Text = circulooequis.ToString();
            boton22.Enabled = false;
        }

        private void boton23_Click(object sender, EventArgs e)
        {
            Bloqueo();
            boton23.Text = circulooequis.ToString();
            boton23.Enabled = false;
        }

        private void boton24_Click(object sender, EventArgs e)
        {
            Bloqueo();
            boton24.Text = circulooequis.ToString();
            boton24.Enabled = false;
        }

        private void boton31_Click(object sender, EventArgs e)
        {
            Bloqueo();
            boton31.Text = circulooequis.ToString();
            boton31.Enabled = false;
        }

        private void boton32_Click(object sender, EventArgs e)
        {
            Bloqueo();
            boton32.Text = circulooequis.ToString();
            boton32.Enabled = false;
        }

        private void boton33_Click(object sender, EventArgs e)
        {
            Bloqueo();
            boton33.Text = circulooequis.ToString();
            boton33.Enabled = false;
        }

        private void boton34_Click(object sender, EventArgs e)
        {
            Bloqueo();
            boton34.Text = circulooequis.ToString();
            boton34.Enabled = false;
        }

        private void boton41_Click(object sender, EventArgs e)
        {
            Bloqueo();
            boton41.Text = circulooequis.ToString();
            boton41.Enabled = false;
        }

        private void boton42_Click(object sender, EventArgs e)
        {
            Bloqueo();
            boton42.Text = circulooequis.ToString();
            boton42.Enabled = false;
        }

        private void boton43_Click(object sender, EventArgs e)
        {
            Bloqueo();
            boton43.Text = circulooequis.ToString();
            boton43.Enabled = false;
        }

        private void boton44_Click(object sender, EventArgs e)
        {
            Bloqueo();
            boton44.Text = circulooequis.ToString();
            boton44.Enabled = false;
        }

        private void Bloqueo()
        {
            if ((turno % 2) == 0)
            {
                circulooequis = circulo;
            }
            else
            {
                circulooequis = equis;
            }

            turno = turno + 1;
        }
    }
}
