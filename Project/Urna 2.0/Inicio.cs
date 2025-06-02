using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Urna_2._0.Properties;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using Application = System.Windows.Forms.Application;

namespace Urna_2._0
{
    public partial class jnl_inicio : Form
    {

        public static Dictionary<byte, Presidente> Lista_Candidatos = new Dictionary<byte, Presidente>(4);
        public static int total_votos = 0;
        public static int votos_brancos = 0;
        public static int votos_nulos = 0;
        public jnl_urna urna;
        public jnl_info info;
        public static Random rnd = new Random();

        public jnl_inicio()
        {
            InitializeComponent();

            adicionar_presidente(74, "Michael Corleone", "Tom Hagen", "Partido Corleones do Brasil");
            adicionar_presidente(91, "Hannibal Lecter", "Buffalo Bill", "Movimento Canibal Brasileiro");
            adicionar_presidente(88, "Hans Gruber", "Karl Vreski", "Partido dos Terroristas");
            adicionar_presidente(83, "Tony Montana", "Many Ribera", "Democracia Cubana");

            urna = new jnl_urna();
            info = new jnl_info();
        }

        public static Presidente maiores_votos()
        {
            Presidente maior = Lista_Candidatos.First().Value;
            foreach (var candidato in Lista_Candidatos)
            {
                if (candidato.Value.Votos > maior.Votos)
                {
                    maior = candidato.Value;
                }
            }
            return maior;
        }

        private void jnl_urna_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
            }
        }

        private void jnl_fim_voto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void votar(object sender, EventArgs e)
        {
            this.Hide();
            urna.Show();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            if (total_votos-votos_brancos < 10)
            {
                DialogResult erro = MessageBox.Show("Para ver essa opção é necessário ter, no minimo 10 votos válidos",
                                                    "Votos insuficientes",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                info.Show();
            }
        }

        private void adicionar_presidente(byte numero_candidato, string nome_presidente, string nome_vice, string partido)
        {
            System.Drawing.Image imagem_presidente;
            System.Drawing.Image imagem_vice;

            if (numero_candidato > 1)
            {
                imagem_presidente = (System.Drawing.Image)Resources.ResourceManager.GetObject(nome_presidente);
                imagem_vice = (System.Drawing.Image)Resources.ResourceManager.GetObject(nome_vice);

                if (imagem_presidente == null || imagem_vice == null)
                {
                    throw new Exception();
                }
            }
            else
            {
                imagem_presidente = Resources.Nulo;
                imagem_vice = Resources.Nulo;
            }

            Lista_Candidatos.Add(numero_candidato, new Presidente(nome_presidente, imagem_presidente, new Vice(nome_vice, imagem_vice), partido));
        }
    
        public static void voto_aleatorio()
        {
            int numero_aleatorio = rnd.Next(0, 4);

            Lista_Candidatos.ToArray()[numero_aleatorio].Value.adicionar_voto();
        }
    } 
}
