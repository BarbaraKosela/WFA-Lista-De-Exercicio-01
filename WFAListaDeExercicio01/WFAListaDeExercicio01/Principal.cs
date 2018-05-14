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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FORMEXERCICIO01 exemplo01 = new FORMEXERCICIO01();
            exemplo01.Show();
        }

        private void BTNEXERCICIO02_Click(object sender, EventArgs e)
        {
            Exercicio02 exercicio02 = new Exercicio02();
            exercicio02.Show();
        }

        private void BTNEXERCICIO03_Click(object sender, EventArgs e)
        {
            Exercicio03 exercicio03 = new Exercicio03();
            exercicio03.Show();
        }

        private void BTNEXERCICIO04_Click(object sender, EventArgs e)
        {
            Exercicio04 exercicio04 = new Exercicio04();
            exercicio04.Show();
        }

        private void BTNEXERCICIO05_Click(object sender, EventArgs e)
        {
            Exercicio05 exercicio05 = new Exercicio05();
            exercicio05.Show();
        }

        private void BTNEXERCICIO06_Click(object sender, EventArgs e)
        {
            Exercicio06 exercicio06 = new Exercicio06();
            exercicio06.Show();
        }

        private void BTNEXERCICIO7_Click(object sender, EventArgs e)
        {
            Exercicio07 exercicio07 = new Exercicio07();
            exercicio07.Show();
        }

        private void BTNEXERCICIO08_Click(object sender, EventArgs e)
        {
            Exercicio08 exercicio08 = new Exercicio08();
            exercicio08.Show();
        }

        private void BTNEXERCICIO09_Click(object sender, EventArgs e)
        {
            Exercicio09 exercicio09 = new Exercicio09();
            exercicio09.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Exercicio10 exercicio10 = new Exercicio10();
            exercicio10.Show();
        }

    }
}
