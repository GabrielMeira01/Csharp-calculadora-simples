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

namespace calculadora_simples
{
    public partial class Form1 : Form
    {
        Valores dados = new Valores();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Num0_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "0";
        }

        private void btn_num1_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "1";
        }

        private void btn_num2_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "2";
        }

        private void btn_num3_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "3";
        }

        private void btn_num4_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "4";
        }

        private void btn_num5_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "5";
        }

        private void btn_num6_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "6";
        }

        private void btn_num7_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "7";
        }

        private void btn_num8_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "8";
        }

        private void btn_num9_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "9";
        }

        private void btn_ponto_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += ".";
        }

        private void btn_Soma_Click(object sender, EventArgs e)
        {
            if (txt_Resultado.Text != "")
            {
                dados.valor1 = Decimal.Parse(txt_Resultado.Text, CultureInfo.InvariantCulture);
                txt_Resultado.Text = "";
                dados.operacao = "SOMA";
                lbl_Operacao.Text = "+";
            }
        }

        private void btn_Subtracao_Click(object sender, EventArgs e)
        {
            if (txt_Resultado.Text != "")
            {
                dados.valor1 = Decimal.Parse(txt_Resultado.Text, CultureInfo.InvariantCulture);
                txt_Resultado.Text = "";
                dados.operacao = "SUBTRACAO";
                lbl_Operacao.Text = "-";
            }
        }

        private void btn_Multiplicacao_Click(object sender, EventArgs e)
        {
            if (txt_Resultado.Text != "")
            {
                dados.valor1 = Decimal.Parse(txt_Resultado.Text, CultureInfo.InvariantCulture);
                txt_Resultado.Text = "";
                dados.operacao = "MULTIPLICACAO";
                lbl_Operacao.Text = "*";
            }
        }

        private void btn_Divisao_Click(object sender, EventArgs e)
        {
            if (txt_Resultado.Text != "")
            {
                dados.valor1 = Decimal.Parse(txt_Resultado.Text, CultureInfo.InvariantCulture);
                txt_Resultado.Text = "";
                dados.operacao = "DIVISAO";
                lbl_Operacao.Text = "/";
            }

        }

        private void btn_Resultado_Click(object sender, EventArgs e)
        {
            dados.valor2 = Decimal.Parse(txt_Resultado.Text, CultureInfo.InvariantCulture);

            if (dados.operacao == "SOMA")
            {
                txt_Resultado.Text = Convert.ToString(dados.valor1 + dados.valor2);
            }
            else if (dados.operacao == "SUBTRACAO")
            {
                txt_Resultado.Text = Convert.ToString(dados.valor1 - dados.valor2);
            }
            else if (dados.operacao == "MULTIPLICACAO")
            {
                txt_Resultado.Text = Convert.ToString(dados.valor1 * dados.valor2);
            }
            else
            {
                txt_Resultado.Text = Convert.ToString(dados.valor1 / dados.valor2);
            }
        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = "";
            lbl_Operacao.Text = "";
            dados.valor1 = 0;
            dados.valor2 = 0;
        }

        private void btn_Limpa_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = "";
            lbl_Operacao.Text = "";
        }
    }
}
