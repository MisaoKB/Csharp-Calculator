using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using urna3.Properties;

namespace urna
{
    public partial class Form1 : Form
    {
        Dictionary<int, string> candidatos = new Dictionary<int, string>(6) 
        {
            {10, "feijoada"},
            {20, "hamburguer"},
            {30, "hot dog"},
            {40, "lasanha"},
            {50, "pizza"},
            {60, "strogonoff"}
        };

        public Form1()
        {
            InitializeComponent();
        }
        // botao 1
        private void botaoNumero_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            string numero = botao.Text;

            if (textBox2.Text.Length < 1)
                textBox2.Text += numero;
            else if (textBox1.Text.Length < 1)
                textBox1.Text += numero;
        }

        private void BRANCO_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Text = "Voto em BRANCO";
        }

        private void CORRIGE_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void CONFIRMA_Click(object sender, EventArgs e)
        {
            string voto_str = string.Concat(textBox2.Text, textBox1.Text);
            int voto_int = Convert.ToInt16(voto_str);
            string resultado;
            PictureBox imagem_candidato = pictureBox2;

            ResourceManager rm = new ResourceManager("", Assembly.GetExecutingAssembly());

            if (candidatos.TryGetValue(voto_int, out resultado))
            {
                textBox3.Text = $"Você votou em {resultado}";
                imagem_candidato.Image = (Image)Resources.ResourceManager.GetObject(resultado);
            }
            else
            {
                textBox3.Text = "Erro";
            }

            // Aqui você pode adicionar lógica para gravar o voto
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            string numero = botao.Text;

            if (textBox2.Text.Length < 1)
                textBox2.Text += numero;
            else if (textBox1.Text.Length < 1)
                textBox1.Text += numero;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            string numero = botao.Text;

            if (textBox2.Text.Length < 1)
                textBox2.Text += numero;
            else if (textBox1.Text.Length < 1)
                textBox1.Text += numero;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            string numero = botao.Text;

            if (textBox2.Text.Length < 1)
                textBox2.Text += numero;
            else if (textBox1.Text.Length < 1)
                textBox1.Text += numero;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            string numero = botao.Text;

            if (textBox2.Text.Length < 1)
                textBox2.Text += numero;
            else if (textBox1.Text.Length < 1)
                textBox1.Text += numero;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            string numero = botao.Text;

            if (textBox2.Text.Length < 1)
                textBox2.Text += numero;
            else if (textBox1.Text.Length < 1)
                textBox1.Text += numero;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            string numero = botao.Text;

            if (textBox2.Text.Length < 1)
                textBox2.Text += numero;
            else if (textBox1.Text.Length < 1)
                textBox1.Text += numero;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            string numero = botao.Text;

            if (textBox2.Text.Length < 1)
                textBox2.Text += numero;
            else if (textBox1.Text.Length < 1)
                textBox1.Text += numero;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            string numero = botao.Text;

            if (textBox2.Text.Length < 1)
                textBox2.Text += numero;
            else if (textBox1.Text.Length < 1)
                textBox1.Text += numero;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            string numero = botao.Text;

            if (textBox2.Text.Length < 1)
                textBox2.Text += numero;
            else if (textBox1.Text.Length < 1)
                textBox1.Text += numero;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Text = "Voto em BRANCO";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string voto = textBox2.Text + textBox1.Text;
            textBox3.Text = "Você votou em: " + voto;
            // Aqui você pode adicionar lógica para gravar o voto
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}