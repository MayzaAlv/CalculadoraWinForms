using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : System.Windows.Forms.Form
    {

        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains("."))
            {
                txtResultado.Text += ".";
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SUB";
                lblOperacao.Text = "-";
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "MULT";
                lblOperacao.Text = "X";
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "DIV";
                lblOperacao.Text = "/";
            }
        }

        private void btnResto_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "RESTO";
                lblOperacao.Text = "%";
            }
        }

        private void btnTrocaSinal_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = Convert.ToString(valor1 * (-1));
            }
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperacao.Text = "";
            valor1 = 0;
            valor2 = 0;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperacao.Text = "";
        }


        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                switch (operacao)
                {
                    case "SOMA":
                        txtResultado.Text = Convert.ToString(valor1 + valor2);
                        break;

                    case "SUB":
                        txtResultado.Text = Convert.ToString(valor1 - valor2);
                        break;

                    case "MULT":
                        txtResultado.Text = Convert.ToString(valor1 * valor2);
                        break;

                    case "DIV":
                        txtResultado.Text = Convert.ToString(valor1 / valor2);
                        break;

                    case "RESTO":
                        txtResultado.Text = Convert.ToString(valor1 % valor2);
                        break;

                    default:
                        break;
                }
            }
        }

        private void Calculadora_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1:
                case Keys.NumPad1:
                    btnUm.PerformClick();
                    break;

                case Keys.D2:
                case Keys.NumPad2:
                    btnDois.PerformClick();
                    break;

                case Keys.D3:
                case Keys.NumPad3:
                    btnTres.PerformClick();
                    break;

                case Keys.D4:
                case Keys.NumPad4:
                    btnQuatro.PerformClick();
                    break;

                case Keys.D5:
                case Keys.NumPad5:
                    btnCinco.PerformClick();
                    break;

                case Keys.D6:
                case Keys.NumPad6:
                    btnSeis.PerformClick();
                    break;

                case Keys.D7:
                case Keys.NumPad7:
                    btnSete.PerformClick();
                    break;

                case Keys.D8:
                case Keys.NumPad8:
                    btnOito.PerformClick();
                    break;

                case Keys.D9:
                case Keys.NumPad9:
                    btnCinco.PerformClick();
                    break;

                case Keys.D0:
                case Keys.NumPad0:
                    btnZero.PerformClick();
                    break;

                case Keys.Subtract:
                    btnSubtracao.PerformClick();
                    break;

                case Keys.Add:
                    btnSoma.PerformClick();
                    break;

                case Keys.Divide:
                    btnDividir.PerformClick();
                    break;

                case Keys.Multiply:
                    btnMultiplicacao.PerformClick();
                    break;

                case Keys.Decimal:
                    btnPonto.PerformClick();
                    break;

                default:
                    break;
            }
        }
    }
}
