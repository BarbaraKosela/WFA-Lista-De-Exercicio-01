using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAListaDeExercicio01
{
    public partial class Exercicio08 : Form
    {
        double valorLuz = 0, valorAgua = 0, valorNET = 0, valorVIVO = 0, valorOI = 0, valorIPTU = 0, valorIPVA = 0, valorSeguro = 0; 
        public Exercicio08()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void ArmazenarInformacoes()
        {

            try
            {

                valorLuz = Convert.ToDouble(TXTVALORLUZ.Text);
            }
            catch
            {
                MessageBox.Show("O valor da luz deve conter somente números");
                TXTVALORLUZ.Focus();
                return;
            }

            try
            {

                valorAgua = Convert.ToDouble(TXTVALORAGUA.Text);
            }
            catch
            {
                MessageBox.Show("O valor da água deve conter somente números");
                TXTVALORAGUA.Focus();
                return;
            }

            try
            {

                valorNET = Convert.ToDouble(TXTVALORNET.Text);
                
            }
            catch
            {
                MessageBox.Show("O valor da NET deve conter somente números");
                TXTVALORNET.Focus();
                return;
            }
            try
            {

                valorVIVO = Convert.ToDouble(TXTVALORVIVO.Text);
                
            }
            catch
            {
                MessageBox.Show("O valor da VIVO deve conter somente números");
                TXTVALORVIVO.Focus();
                return;
            }

            try
            {

                valorOI = Convert.ToDouble(TXTVALOROI.Text);
                
            }
            catch
            {
                MessageBox.Show("O valor da OI deve conter somente números");
                TXTVALOROI.Focus();
                return;
            }
            try
            {

                valorIPTU = Convert.ToDouble(TXTVALORIPTU.Text);
                
                
            }
            catch
            {
                MessageBox.Show("O valor do IPTU deve conter somente números");
                TXTVALORIPTU.Focus();
                return;
            }

            try
            {

                valorIPVA = Convert.ToDouble(TXTVALORIPVA.Text);
                
            }
            catch
            {
                MessageBox.Show("O valor do IPVA deve conter somente números");
                TXTVALORIPVA.Focus();
                return;
            }

            try
            {

                valorSeguro = Convert.ToDouble(TXTVALORSEGURO.Text);
            }
            catch
            {
                MessageBox.Show("O valor do seguro deve conter somente números");
                TXTVALORSEGURO.Focus();
                return;
            }
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (RBVALORTELEFONE.Checked)    
            {
                ValorContasTelefone();
            }

            else if (RBVALORIMPOSTO.Checked)
            {
                ValorContasImpostos();
            }

            else if (RBVALOREXTRAS.Checked)
            {
                ValorContasExtras();
            }

            else if (RBTOTAL.Checked)
            {
                Total();
            }

            else
            {
                MessageBox.Show("Você não escolheu nenhuma das opções");
            }
        }
        public void ValorContasTelefone()
        {
            ArmazenarInformacoes();
            double ValorContasTelefone = (valorNET + valorOI + valorVIVO);
            MessageBox.Show("Valor total de suas contas de telefone: R$" + ValorContasTelefone);
        }

        public void ValorContasImpostos()
        {
            ArmazenarInformacoes();
            double valorContasImposto = (valorIPTU + valorIPVA);
            MessageBox.Show("Valor total de seus impostos: R$" + valorContasImposto);
        }

        public void ValorContasExtras()
        {
            ArmazenarInformacoes();
            double valorContasExtras = valorAgua + valorSeguro + valorLuz;
            MessageBox.Show("Valor das contas extras: R$" + valorContasExtras);
        }

        public void Total()
        {
            ArmazenarInformacoes();
            double total = valorAgua + valorIPTU + valorIPVA + valorLuz + valorNET + valorOI + valorSeguro + valorVIVO;
            MessageBox.Show("Valor total das contas: R$" + total);
        }
    }
}
