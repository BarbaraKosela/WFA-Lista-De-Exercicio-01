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
    public partial class Exercicio06 : Form
    {   
      double nota1 = 0, nota2 = 0, nota3 = 0, nota4 = 0, media = 0;
        public Exercicio06()
        {
            InitializeComponent();
        }

        private void BTNREALIZARMEDIA_Click(object sender, EventArgs e)
        {
            ArmazenarInformacoes();
            string texto = "";
            media = (nota1 + nota2 + nota3 + nota4) / 4;

            texto = texto + string.Format("Nota 1: {0}\r\nNota 2: {1}\r\nNota 3: {2}\r\nNota 4: {3}\r\n\nMédia: {4}", nota1, nota2, nota3, nota4, media);

            TXTRESULTADO.Text = texto;
        }

        private void ArmazenarInformacoes()
        {
            nota1 = Convert.ToDouble(TXTNOTA1.Text);
            nota2 = Convert.ToDouble(TXTNOTA2.Text);
            nota3 = Convert.ToDouble(TXTNOTA3.Text);
            nota4 = Convert.ToDouble(TXTNOTA4.Text);
        }
    }
}
