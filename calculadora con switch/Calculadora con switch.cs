using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_con_switch
{
    public partial class Calculadoraconswitch : Form
    {
        Conversion c = new Conversion();
        public Calculadoraconswitch()
        {
            InitializeComponent();
        }
        double num1 = 0;
        double num2 = 0;
        double resultado;
        string operaciones;
        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text == "0.")
            {
                txtresultado.Text = "1";
            }
            else
            {
                txtresultado.Text = txtresultado.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text == "0.")
            {
                txtresultado.Text = "2";
            }
            else
            {
                txtresultado.Text = txtresultado.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text == "0.")
            {
                txtresultado.Text = "3";
            }
            else
            {
                txtresultado.Text = txtresultado.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text == "0.")
            {
                txtresultado.Text = "4";
            }
            else
            {
                txtresultado.Text = txtresultado.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text == "0.")
            {
                txtresultado.Text = "5";
            }
            else
            {
                txtresultado.Text = txtresultado.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text == "0.")
            {
                txtresultado.Text = "6";
            }
            else
            {
                txtresultado.Text = txtresultado.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text == "0.")
            {
                txtresultado.Text = "7";
            }
            else
            {
                txtresultado.Text = txtresultado.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text == "0.")
            {
                txtresultado.Text = "8";
            }
            else
            {
                txtresultado.Text = txtresultado.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text == "0.")
            {
                txtresultado.Text = "9";
            }
            else
            {
                txtresultado.Text = txtresultado.Text + "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text == "0.")
            {
                txtresultado.Text = "0";
            }
            else
            {
                txtresultado.Text = txtresultado.Text + "0";
            }
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text == "0.")
            {
                txtresultado.Text = ".";
            }
            else
            {
                txtresultado.Text = txtresultado.Text + ".";
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmas_Click(object sender, EventArgs e)
        {
            operaciones = "+";
            num1 = Convert.ToDouble(txtresultado.Text);
            txtresultado.Clear();
             num2 = 0;
        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            operaciones = "-";
            num1 = Convert.ToDouble(txtresultado.Text);
            txtresultado.Clear();
           num2 = 0;
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            operaciones = "/";
            num1 = Convert.ToDouble(txtresultado.Text);
            txtresultado.Clear();
             num2 = 0;
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            operaciones = "*";
            num1 = Convert.ToDouble(txtresultado.Text);
            txtresultado.Clear();
            num2 = 0;
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            try
            {
                if (num2 == 0)
                {
                    num2 = Convert.ToDouble(txtresultado.Text);
                }
                switch (operaciones)
                {
                    case "+":

                        resultado = num1 + num2;
                        txtresultado.Text = resultado.ToString();
                        num1 = resultado;
                        break;

                    case "-":
                        resultado = num1 - num2;
                        txtresultado.Text = resultado.ToString();
                        num1 = resultado;
                        break;

                    case "/":
                        resultado = num1 / num2;
                        txtresultado.Text = resultado.ToString();
                        num1 = resultado;
                        break;

                    case "*":
                        resultado = num1 * num2;
                        txtresultado.Text = resultado.ToString();
                        num1 = resultado;
                        break;
                }
                txtletras.Text = c.enletras(txtresultado.Text).ToLower();
            }
            catch (Exception)
            {
                MessageBox.Show("Algo Salio Mal, Verifique la informacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                return;
                throw;
            }
        }  

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "0.";
            txtletras.Clear();
        }

        private void timerhora_Tick(object sender, EventArgs e)
        {
            //lbltiempocalculadora.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
