using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraForms
{
    public partial class Calculadora : Form
    {
        decimal calculo;
        bool adicao = false;
        bool subtracao = false;
        bool multiplicacao = false;
        bool divisao = false;
        bool resultado = false;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextResult.Text += "1";
            TextOperação.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextResult.Text += "2";
            TextOperação.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextResult.Text += "3";
            TextOperação.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TextResult.Text += "4";
            TextOperação.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TextResult.Text += "5";
            TextOperação.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TextResult.Text += "6";
            TextOperação.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TextResult.Text += "7";
            TextOperação.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TextResult.Text += "8";
            TextOperação.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TextResult.Text += "9";
            TextOperação.Text += "9";
        }

        private void Virgula_Click(object sender, EventArgs e)
        {
            TextResult.Text += ",";
            TextOperação.Text += ",";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            TextResult.Text += "0";
            TextOperação.Text += "0";
        }

        private void Apagar_Click(object sender, EventArgs e)
        {
            TextResult.Text = "";
            TextOperação.Text =  "";
        }

        private void Mais_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(TextResult.Text);

            TextOperação.Text += "+";

            TextResult.Text = "";

            adicao = true;
            subtracao = false;
            multiplicacao = false;
            divisao = false;
        }

        private void Menos_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(TextResult.Text);

            TextOperação.Text += "-";
            TextResult.Text = "";

            adicao = false;
            subtracao = true;
            multiplicacao = false;
            divisao = false;
        }

        private void Vezes_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(TextResult.Text);
            TextOperação.Text += "X";
            TextResult.Text = "";

            adicao = false;
            subtracao = false;
            multiplicacao = true;
            divisao = false;
        }

        private void Divisao_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(TextResult.Text);
            TextOperação.Text += "÷";
            TextResult.Text = "";

            adicao = false;
            subtracao = false;
            multiplicacao = false;
            divisao = true;
        }

        private void Resultado_Click(object sender, EventArgs e)
        {
            resultado = true;

            TextOperação.Text += "=";

            if(adicao == true)
            {
                TextResult.Text = Convert.ToString(Convert.ToDecimal(TextResult.Text) + calculo);
                TextOperação.Text = TextResult.Text;
            }

            if (subtracao == true)
            {
                TextResult.Text = Convert.ToString(Convert.ToDecimal(TextResult.Text) - calculo);

                TextOperação.Text += TextResult.Text;
            }


            if (multiplicacao == true)
            {
                TextResult.Text = Convert.ToString(Convert.ToDecimal(TextResult.Text) * calculo);

                TextOperação.Text += TextResult.Text;
            }


            if (divisao == true)
            {
                TextResult.Text = Convert.ToString(calculo / Convert.ToDecimal(TextResult.Text));

                TextOperação.Text += TextResult.Text;
            } 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                string Apagar = TextResult.Text;

                Apagar = Apagar.Remove(Apagar.Length - 1);

                TextResult.Text = Apagar;

                TextOperação.Text = Apagar;
            }

            catch(Exception)
            {

            }
        }
    }
}
