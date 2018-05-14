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
    public partial class Exercicio10 : Form
    {  int idade = 0;
        public Exercicio10()
        {
            InitializeComponent();
        }

        private void BTNCHECAR_Click(object sender, EventArgs e)
        {
            ArmazenarInformacoes();
            int ano = 2018 - idade;
            MessageBox.Show("A idade é: " + ano);
        }

        private void ArmazenarInformacoes()
        {
            try
            {
                idade = Convert.ToInt32(TXTDATA.Text);

            }

            catch
            {
                MessageBox.Show("O ano de nascimento deve conter apenas números reais");
                TXTDATA.Focus();
                return;
            }
        }
    }
}
