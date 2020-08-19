using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversorMoeda
{
    public partial class Form1 : Form
    {

        double dolar = 5.47;
        double euro = 6.54;
        public Form1()
        {
            InitializeComponent();
        }

        private void realDolar_CheckedChanged(object sender, EventArgs e)
        {
            double valor = double.Parse(txt1.Text);
            double resultado;

            resultado = valor / dolar;
            txt2.Text = Convert.ToString(Math.Round(resultado, 2));
        }

        private void realEuro_CheckedChanged(object sender, EventArgs e)
        {
            double valor = double.Parse(txt1.Text);
            double resultado;

            resultado = valor / euro;
            txt2.Text = Convert.ToString(Math.Round(resultado, 2));
        }

        private void dolarReal_CheckedChanged(object sender, EventArgs e)
        {
            double valor = double.Parse(txt1.Text);
            double resultado;

            resultado = valor * dolar;
            txt2.Text = Convert.ToString(Math.Round(resultado, 2));
        }

        private void euroReal_CheckedChanged(object sender, EventArgs e)
        {
            double valor = double.Parse(txt1.Text);
            double resultado;

            resultado = valor * euro;
            txt2.Text = Convert.ToString(Math.Round(resultado, 2));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
