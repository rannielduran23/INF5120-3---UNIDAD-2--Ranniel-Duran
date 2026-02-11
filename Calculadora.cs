using System;
using System.Windows.Forms;

namespace CalculadoraWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool ObtenerNumeros(out double n1, out double n2)
        {
            bool num1 = double.TryParse(txtNumero1.Text, out n1);
            bool num2 = double.TryParse(txtNumero2.Text, out n2);

            if (!num1 || !num2)
            {
                MessageBox.Show("Ingrese valores numéricos válidos.");
                return false;
            }
            return true;
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (ObtenerNumeros(out double n1, out double n2))
                lblResultado.Text = (n1 + n2).ToString();
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            if (ObtenerNumeros(out double n1, out double n2))
                lblResultado.Text = (n1 - n2).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (ObtenerNumeros(out double n1, out double n2))
                lblResultado.Text = (n1 * n2).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (ObtenerNumeros(out double n1, out double n2))
            {
                if (n2 == 0)
                    MessageBox.Show("No se puede dividir entre cero.");
                else
                    lblResultado.Text = (n1 / n2).ToString();
            }
        }
    }
}
