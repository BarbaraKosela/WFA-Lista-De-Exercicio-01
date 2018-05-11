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
    public partial class Exercicio03 : Form
    {
        int numero1 = 0, numero2 = 0, numeroProduto = 0;
        public Exercicio03()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArmazenarInformacao();

            if (RBSOMA.Checked)
            {
                Somar();
            }

            else if (RBSUBTRACAO.Checked)
            {
                Subtracao();
            }

            else if (RBMULTIPLICACAO.Checked)
            {
                Multiplicacao();
            }
            else if (RBDIVISAO.Checked)
            {
                Divisao();
            }

            else if (RBPRODUTODOSVALORES.Checked)
            {
                ProdutoDosValores();
            }

            else
            {
                MessageBox.Show("Você não escolheu nenhuma das opções");
            }


            
        }

        private void ArmazenarInformacao()
        {
            numero1 = Convert.ToInt32(TXTNUMERO1.Text);
            numero2 = Convert.ToInt32(TXTNUMERO2.Text);
        }

        public void Somar()
        {
            double soma = numero1 + numero2;
            MessageBox.Show("A soma é: " + soma);
        }

        public void Subtracao()
        {
            double subtracao = numero1 - numero2;
            MessageBox.Show("A subtração é: " + subtracao);
        }

        public void Multiplicacao()
        {
            double multiplicacao = numero1 * numero2;
            MessageBox.Show("A multiplicação é: " + multiplicacao);
        }

        public void Divisao()
        {
            double divisao = numero1 / numero2;
            MessageBox.Show("A divisão é: " + divisao);
        }

        public void ProdutoDosValores()
        {
            double produtoValoresPrimeiro = numero1 * numero1;
            double produtoValoresSegundo = numero2 * numero2;
            MessageBox.Show("O produto do valor de seu primeiro número escolhido é de: " + produtoValoresPrimeiro +
                "\r\nO produto do valor de seu segundo número escolhido é de: " + produtoValoresSegundo);
        }

    }
}
