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
    public partial class Exercicio02 : Form
    {
        double litrosConsumidos = 0, valorPorLitro = 0, quantidadeLitrosConsumidos = 0;
        int anosConsumidos = 0; 
        public Exercicio02()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArmazenarInformacao();
            if (RBQTDLITROSCONSUMIDOS.Checked)
            {
                QtdLitrosConsumidos();
            }

            else if (RBVALORTOTAL.Checked)
            {
                ValorTotalPago();
            }
            
        }
        private void ArmazenarInformacao()
        {
            litrosConsumidos = Convert.ToDouble(TXTLITROS.Text);
            anosConsumidos = Convert.ToInt32(TXTANOS.Text);
            valorPorLitro = Convert.ToDouble(TXTVALORPORLITRO.Text);
            quantidadeLitrosConsumidos = (litrosConsumidos * 365 * 17);
        }

        public void QtdLitrosConsumidos()
        {
            
            MessageBox.Show("Quantidade de litros consumidos: " + quantidadeLitrosConsumidos + " litros.");
        }

        public void ValorTotalPago()
        {
            double valorTotalPago = (quantidadeLitrosConsumidos * valorPorLitro);
            MessageBox.Show("Valor total pago: R$" + valorTotalPago);
        }
    }
}
