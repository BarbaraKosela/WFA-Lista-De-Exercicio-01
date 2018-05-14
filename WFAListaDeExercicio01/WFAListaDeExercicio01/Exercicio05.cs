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
    public partial class Exercicio05 : Form
    {

        string nomeCarro = "";
        double valorCarro = 0, parcelaCarro = 0;
        int qtdParcelas = 0; 

        public Exercicio05()
        {
            InitializeComponent();
        }

        private void BTNGERARRESULTADO_Click(object sender, EventArgs e)
        {
            ArmazenarInformacoes();
            string textao = "";

            double financiamento = parcelaCarro * qtdParcelas;
            double diferenca = valorCarro - financiamento;
            
            textao = textao + string.Format("Valor total de financiamento: R${0}\r\nDiferença entre o valor total do financiamento e valor do carro: R${1}",
                financiamento, diferenca);

            TXTRESULTADO.Text = textao;
        }

        private void ArmazenarInformacoes()
        {
            nomeCarro = TXTNOMECARRO.Text;
            valorCarro = Convert.ToDouble(TXTVALORCARRO.Text);
            parcelaCarro = Convert.ToDouble(TXTVALORPARCELA.Text);
            qtdParcelas = Convert.ToInt32(TXTQTDPARCELA.Text);
        }
    }
}
