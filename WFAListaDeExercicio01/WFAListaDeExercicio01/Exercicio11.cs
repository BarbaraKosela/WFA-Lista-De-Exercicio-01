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
    public partial class Exercicio11 : Form
    {
        int dia = 0, mes = 0, ano = 0;
        
        public Exercicio11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArmazenarInformacao();

            string texto = "";
            int anosVivo = 2018 - ano;
            int diasVivo = anosVivo * 365;
            int mesesVivo = 12 * anosVivo;
            int horasVivo = 24 * diasVivo;
            int minutosVivo = 60 * horasVivo;
            int segundoVivo = 3600 * minutosVivo;
            texto = texto + string.Format("Anos vivo: {0}\r\nDias vivo: {1}\r\nMeses vivo: {2}\r\nHoras vivo: {3}\r\nMinutos vivo: {4}\r\nSegundos vivo: {5}",
                anosVivo, diasVivo, mesesVivo, horasVivo, minutosVivo, segundoVivo);
            TXTRESULTADO.Text = texto;



        }

        private void ArmazenarInformacao()
        {
            try
            {
                
                dia = Convert.ToInt32(TXTDIA.Text);
            }

            catch
            {
               
                MessageBox.Show("Os dias devem apenas conter números reais");
                TXTDIA.Focus();
                return;
            }

            try
            {
                mes = Convert.ToInt32(TXTMES.Text);

            }

            catch
            {
                MessageBox.Show("Os meses devem apenas conter números reais");
                TXTMES.Focus();
                return;
            }

            try
            {
                ano = Convert.ToInt32(TXTANO.Text);
            }

            catch
            {
                MessageBox.Show("Os anos devem conter apenas números reais");
                TXTANO.Focus();
                return;
            }
        }
    }
}
