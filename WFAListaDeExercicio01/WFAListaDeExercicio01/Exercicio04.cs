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
    public partial class Exercicio04 : Form
    {
        int numero = 0;
        
        public Exercicio04()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void BTNCHECAR_Click(object sender, EventArgs e)
        {

            string textao = "";
            
            for (int i = 0; i < 10; i++)
            {
                ArmazenarInformacao();
                double tabuada = numero * i;
                textao = textao + string.Format("{0} x {1} = {2}\r\n", numero , i, tabuada); 
            }

            

           TXTRESULTADO.Text = textao;
        }

        private void ArmazenarInformacao()
        {
            numero = Convert.ToInt32(TXTNUMERO.Text);
            
        }

       

        
            
    }
}
