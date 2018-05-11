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
    public partial class FORMEXERCICIO01 : Form
    {
        
        int numero = 0; 
        public FORMEXERCICIO01()
        {
            InitializeComponent();
        }



        private void RBSUCESSOR_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void BTNRESPOSTA_Click(object sender, EventArgs e)
        {
            NumeroEscolha();
            if (RBSUCESSOR.Checked)
            {
                Sucessor();
            }

            else if (RBANTECESSOR.Checked)
            {
                Antecessor();
            }
        }

        private void NumeroEscolha()
        {
            numero = Convert.ToInt32(TXTNUMERO.Text);
        }


        public void Sucessor()
        {

            int sucessor = numero + 1;
            MessageBox.Show("Sucessor: " + sucessor);
        }

        public void Antecessor()
        {
            int antecessor = numero - 1;
            MessageBox.Show("Antecessor: " + antecessor);
        }
    }
}
