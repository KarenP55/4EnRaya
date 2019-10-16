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
            boton11.Enabled = false;
            Bloqueo();
            boton11.Text = circulooequis.ToString();
        }

        private void boton12_Click(object sender, EventArgs e)
        {
            boton12.Enabled = false;
            Bloqueo();
            boton12.Text = circulooequis.ToString();
        }

        private void boton13_Click(object sender, EventArgs e)
        {
            boton13.Enabled = false;
            Bloqueo();
            boton13.Text = circulooequis.ToString();
        }

        private void boton14_Click(object sender, EventArgs e)
        {
            boton14.Enabled = false;
            Bloqueo();
            boton14.Text = circulooequis.ToString();
        }

        private void boton21_Click_1(object sender, EventArgs e)
        {
            boton21.Enabled = false;
            Bloqueo();
            boton21.Text = circulooequis.ToString();
        }

        private void boton22_Click(object sender, EventArgs e)
        {
            boton22.Enabled = false;
            Bloqueo();
            boton22.Text = circulooequis.ToString();
        }

        private void boton23_Click(object sender, EventArgs e)
        {
            boton23.Enabled = false;
            Bloqueo();
            boton23.Text = circulooequis.ToString();
        }

        private void boton24_Click(object sender, EventArgs e)
        {
            boton24.Enabled = false;
            Bloqueo();
            boton24.Text = circulooequis.ToString();
        }

        private void boton31_Click(object sender, EventArgs e)
        {
            boton31.Enabled = false;
            Bloqueo();
            boton31.Text = circulooequis.ToString();
        }

        private void boton32_Click(object sender, EventArgs e)
        {
            boton32.Enabled = false;
            Bloqueo();
            boton32.Text = circulooequis.ToString();
        }

        private void boton33_Click(object sender, EventArgs e)
        {
            boton33.Enabled = false;
            Bloqueo();
            boton33.Text = circulooequis.ToString();
        }

        private void boton34_Click(object sender, EventArgs e)
        {
            boton34.Enabled = false;
            Bloqueo();
            boton34.Text = circulooequis.ToString();
        }

        private void boton41_Click(object sender, EventArgs e)
        {
            boton41.Enabled = false;
            Bloqueo();
            boton41.Text = circulooequis.ToString();
        }

        private void boton42_Click(object sender, EventArgs e)
        {
            boton42.Enabled = false;
            Bloqueo();
            boton42.Text = circulooequis.ToString();
        }

        private void boton43_Click(object sender, EventArgs e)
        {
            boton43.Enabled = false;
            Bloqueo();
            boton43.Text = circulooequis.ToString();
        }

        private void boton44_Click(object sender, EventArgs e)
        {
            boton44.Enabled = false;
            Bloqueo();
            boton44.Text = circulooequis.ToString();
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
            RevisarGanandor();
        }

        private void RevisarGanandor()
        {
            bool hay_ganador = false;

            // Revisar si hay un 4 en raya diagonal
            if ((boton11.Text == boton22.Text) && (boton22.Text == boton33.Text) && (boton33.Text == boton44.Text) && (!boton11.Enabled && !boton22.Enabled && !boton33.Enabled && !boton44.Enabled))
            {
                hay_ganador = true;
                MessageBox.Show("El ganador es " + boton11.Text.ToString(), "Hay ganador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if ((boton14.Text == boton23.Text) && (boton23.Text == boton32.Text) && (boton32.Text == boton41.Text) && (!boton14.Enabled && !boton23.Enabled && !boton32.Enabled && !boton41.Enabled))
            {
                hay_ganador = true;
                MessageBox.Show("El ganador es " + boton14.Text.ToString(), "Hay ganador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
