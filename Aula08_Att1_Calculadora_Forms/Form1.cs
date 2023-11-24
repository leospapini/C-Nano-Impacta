using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula08_Att1_Calculadora_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void SomarButton_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(numero1TextBox.Text);
            int numero2 = Convert.ToInt32(numero2TextBox.Text);
            int resposta = numero1 + numero2;

            RespostaLabel.Text = Convert.ToString(resposta);
        }

        private void SubtrairButton_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(numero1TextBox.Text);
            int numero2 = Convert.ToInt32(numero2TextBox.Text);
            int resposta = numero1 - numero2;

            RespostaLabel.Text = Convert.ToString(resposta);
        }

        private void MultiplicarButton_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(numero1TextBox.Text);
            int numero2 = Convert.ToInt32(numero2TextBox.Text);
            int resposta = numero1 * numero2;

            RespostaLabel.Text = Convert.ToString(resposta);
        }

        private void DividirButton_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(numero1TextBox.Text);
            int numero2 = Convert.ToInt32(numero2TextBox.Text);
            double resposta = Convert.ToDouble(numero1) / numero2;

            RespostaLabel.Text = Convert.ToString(resposta);
        }

    }
}
