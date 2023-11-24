using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula08_Att3_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(quantidadeTextBox.Text);
            double numero2 = Convert.ToDouble(valorTextBox.Text);
            double resposta = numero1 * numero2;

            respostaLabel.Text = Convert.ToString(numero1 * numero2);
        }
    }
}
