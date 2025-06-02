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
    public partial class jnl_info : Form
    {

        public jnl_info()
        {
            InitializeComponent();
        }

        private void jnl_urna_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
            }
        }

        private void jnl_fim_voto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void jnl_info_Load(object sender, EventArgs e)
        {
            atualizar_info();
        }

        private void jnl_info_VisibleChanged(object sender, EventArgs e)
        {
            atualizar_info();
        }
        private void atualizar_info()
        {
            var candidatos_ordenados = jnl_inicio.Lista_Candidatos.OrderByDescending(x => x.Value.Votos);

            lab_candidato1.Text = candidatos_ordenados.ToArray()[0].Value.Nome;
            lab_candidato2.Text = candidatos_ordenados.ToArray()[1].Value.Nome;
            lab_candidato3.Text = candidatos_ordenados.ToArray()[2].Value.Nome;
            lab_candidato4.Text = candidatos_ordenados.ToArray()[3].Value.Nome;

            img_candidato1.Image = candidatos_ordenados.ToArray()[0].Value.Imagem;
            img_candidato2.Image = candidatos_ordenados.ToArray()[1].Value.Imagem;
            img_candidato3.Image = candidatos_ordenados.ToArray()[2].Value.Imagem;
            img_candidato4.Image = candidatos_ordenados.ToArray()[3].Value.Imagem;

            lab_votos1.Text = candidatos_ordenados.ToArray()[0].Value.Votos.ToString();
            lab_votos2.Text = candidatos_ordenados.ToArray()[1].Value.Votos.ToString();
            lab_votos3.Text = candidatos_ordenados.ToArray()[2].Value.Votos.ToString();
            lab_votos4.Text = candidatos_ordenados.ToArray()[3].Value.Votos.ToString();

            // Porcentagens
            double porcentagem_branco = 0L;
            double porcentagem_nulo = 0L;

            if (jnl_inicio.total_votos > 0)
            {

                porcentagem_branco = ((double)jnl_inicio.votos_brancos / (double)jnl_inicio.total_votos) * 100;
                porcentagem_branco = Math.Round(porcentagem_branco, 2);

                porcentagem_nulo = ((double)jnl_inicio.votos_nulos / (double)jnl_inicio.total_votos) * 100;
                porcentagem_nulo = Math.Round(porcentagem_nulo, 2);
            }
            else
            {
                if (jnl_inicio.votos_nulos > 0)
                {
                    porcentagem_nulo = 100L;
                }
            }

            lab_votos_branco.Text = $"Porcentagem de Votos Brancos: {porcentagem_branco} %";
            lab_votos_nulos.Text = $"Porcentagem de Votos Nulos: {porcentagem_nulo}%";

            // Eleito

            double porcentagem_eleito = (double)candidatos_ordenados.ToArray()[0].Value.Votos / (double) jnl_inicio.total_votos;
            porcentagem_eleito = porcentagem_eleito * 100;
            porcentagem_eleito = Math.Round(porcentagem_eleito, 2);

            lab_nome_presidente_eleito.Text = candidatos_ordenados.ToArray()[0].Value.Nome;
            lab_nome_vice_eleito.Text = candidatos_ordenados.ToArray()[0].Value.VicePresidente.Nome;
            lab_partido_eleito.Text = candidatos_ordenados.ToArray()[0].Value.Partido;
            lab_porcentagem_eleito.Text = $"Eleito com {porcentagem_eleito} % dos\nVotos Válidos";
            img_presidente_eleito.Image = candidatos_ordenados.ToArray()[0].Value.Imagem;
            img_vice_eleito.Image = candidatos_ordenados.ToArray()[0].Value.VicePresidente.Imagem;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms.Cast<Form>().FirstOrDefault(s => s is jnl_inicio).Show();
        }
    }
}
