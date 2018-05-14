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
    public partial class Exercicio09 : Form
    {
        int numero1 = 0, numero2 = 0;
        public Exercicio09()
        {
            InitializeComponent();
        }

        private void BTNCHECAR_Click(object sender, EventArgs e)
        {
            string texto = ""; 
            ArmazenarNumero();
            texto = texto + string.Format("Primeiro número: {0}\r\nSegundo número: {1}", numero2, numero1);
            txtresultado.Text = texto;
        }

        private void ArmazenarNumero()
        {
            try
            {
            numero1 = Convert.ToInt32(TXTNUMERO1.Text);

            }

            catch
            {
                MessageBox.Show("O primeiro número deve conter apenas números reais");
                TXTNUMERO1.Focus();
                return;
            }
            try
            {
                numero2 = Convert.ToInt32(TXTNUMERO2.Text);

            }

            catch
            {
                MessageBox.Show("O segundo número deve conter apenas números reais");
                TXTNUMERO2.Focus();
                return;
            }

        }
    }
}
