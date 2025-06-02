using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Resources;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Urna_2._0.Properties;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Urna_2._0
{
    public partial class jnl_urna : Form
    {
        Label label_selecionada;
        string tipo_voto = "";
        public jnl_fim_voto jnl_fim_voto;
        SoundPlayer som = new SoundPlayer(Properties.Resources.tecla);
        SoundPlayer fim = new SoundPlayer(Properties.Resources.fim);
        byte numero_candidato;

        public jnl_urna()
        {
            InitializeComponent();

            jnl_fim_voto = new jnl_fim_voto();
            label_selecionada = lab_digito2;
        }


        public void tocar_tecla()
        {
            som.PlaySync();
        }
        public void tocar_fim()
        {
            fim.PlaySync();
        }
        public void btn_digitos(object sender, EventArgs e)
        {
            if (lab_digito1.Text == "" && lab_seu_voto.Visible == false)
            {
                tocar_tecla();
                Button botao = sender as Button;
                string digito = botao.Name.Last().ToString();

                label_selecionada.Text = digito;

                if (label_selecionada == lab_digito1)
                {
                    label_selecionada = lab_digito2;
                }
                else if (label_selecionada == lab_digito2)
                {
                    label_selecionada = lab_digito1;
                }
            }
            if (lab_digito1.Text != "")
            {
                setar_visibilidade(true);
                verificar_numeros();
            }
        }
        private void btn_corrige_Click(object sender, EventArgs e)
        {
            tocar_tecla();
            setar_visibilidade(false);
            lab_digito1.Visible = true;
            lab_digito2.Visible = true;
            label_selecionada = lab_digito2;
            lab_digito1.Text = "";
            lab_digito2.Text = "";
            lab_nome_presidente.Text = "";
            lab_partido_presidente.Text = "";
            lab_vice_presidente.Text = "";
            lab_presidente_imagem.Text = "";
            lab_vice_imagem.Text = "";
            tipo_voto = "";
            lab_nome.Text = "Nome:";

            img_presidente.Image = null;
            img_vice.Image = null;
        }
        private void setar_visibilidade(bool set)
        {
            lab_seu_voto.Visible = set;
            lab_numero.Visible = set;
            lab_nome.Visible = set;
            lab_partido.Visible = set;
            lab_vice.Visible = set;
            img_presidente.Visible = set;
            img_vice.Visible = set;
            lab_presidente_imagem.Visible = set;
            lab_vice_imagem.Visible = set;
            lab_nome_presidente.Visible = set;
            lab_partido_presidente.Visible = set;
            lab_vice_presidente.Visible = set;
            lab_aviso.Visible = set;
        }
        private void jnl_urna_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1:
                    btn_digitos(btn_1, e);
                    break;
                case Keys.D2:
                    btn_digitos(btn_2, e);
                    break;
                case Keys.D3:
                    btn_digitos(btn_3, e);
                    break;
                case Keys.D4:
                    btn_digitos(btn_4, e);
                    break;
                case Keys.D5:
                    btn_digitos(btn_5, e);
                    break;
                case Keys.D6:
                    btn_digitos(btn_6, e);
                    break;
                case Keys.D7:
                    btn_digitos(btn_7, e);
                    break;
                case Keys.D8:
                    btn_digitos(btn_8, e);
                    break;
                case Keys.D9:
                    btn_digitos(btn_9, e);
                    break;
                case Keys.D0:
                    btn_digitos(btn_0, e);
                    break;
                case Keys.R:
                    jnl_inicio.voto_aleatorio();
                    jnl_inicio.total_votos++;
                    btn_corrige_Click(sender, e);
                    this.Hide();
                    jnl_fim_voto.Show();

                    break;
            }
        }
        private void verificar_numeros()
        {
            string str_num_candidato = string.Concat(lab_digito2.Text, lab_digito1.Text);
            numero_candidato = Byte.Parse(str_num_candidato);

            Presidente candidato_presidente;
            Vice candidato_vice;

            if (jnl_inicio.Lista_Candidatos.TryGetValue(numero_candidato, out candidato_presidente))
            {
                candidato_vice = candidato_presidente.VicePresidente;

                lab_nome_presidente.Text = candidato_presidente.Nome;
                lab_partido_presidente.Text = candidato_presidente.Partido;
                lab_vice_presidente.Text = candidato_presidente.VicePresidente.Nome;

                lab_presidente_imagem.Text = lab_nome_presidente.Text;
                lab_vice_imagem.Text = lab_vice_presidente.Text;
                img_presidente.Image = candidato_presidente.Imagem;
                img_vice.Image = candidato_presidente.VicePresidente.Imagem;
                tipo_voto = "valido";
            }
            else
            {
                voto_nulo();
            }

        }
        private void voto_branco(object sender, EventArgs e)
        {
            if (lab_digito1.Text == "" && lab_digito2.Text == "")
            {
                tocar_tecla();
                setar_visibilidade(false);
                lab_digito1.Visible = false;
                lab_digito2.Visible = false;
                lab_nome_presidente.Visible = true;
                lab_seu_voto.Visible = true;
                lab_aviso.Visible = true;
                lab_nome_presidente.Text = "VOTO EM BRANCO";
                tipo_voto = "branco";
            }
        }
        private void voto_nulo()
        {
            setar_visibilidade(false);
            lab_partido_presidente.Visible = true;
            lab_seu_voto.Visible = true;
            lab_aviso.Visible = true;
            if (lab_digito2.Text != "0" || lab_digito1.Text != "0")
            {
                lab_nome.Visible = true;
                lab_nome.Text = "NÚMERO ERRADO";
            }
            lab_partido_presidente.Text = "VOTO NULO";
            tipo_voto = "nulo";
        }
        private void confirmar_voto(object sender, EventArgs e)
        {
            tocar_tecla();
            if (tipo_voto == "")
            {
                DialogResult erro = MessageBox.Show("Insira uma opção válida de voto", 
                                                    "Voto Inválido",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Error);
                btn_corrige_Click(sender, e);
            }
            else if (tipo_voto == "valido")
            {
                jnl_inicio.Lista_Candidatos[numero_candidato].adicionar_voto();
                jnl_inicio.total_votos++;
                btn_corrige_Click(sender, e);
                this.Hide();
                jnl_fim_voto.Show();

            }
            else if (tipo_voto == "branco")
            {
                var candidatos_ordenados = jnl_inicio.Lista_Candidatos.OrderByDescending(x => x.Value.Votos);

                if (candidatos_ordenados.ToArray()[0].Value.Votos > 0 && 
                    (candidatos_ordenados.ToArray()[1].Value.Votos != candidatos_ordenados.ToArray()[0].Value.Votos))
                {
                    jnl_inicio.Lista_Candidatos[candidatos_ordenados.ToArray()[0].Key].adicionar_voto();
                }
                else
                {
                    jnl_inicio.voto_aleatorio();
                }

                    jnl_inicio.total_votos++;
                    jnl_inicio.votos_brancos++;
                btn_corrige_Click(sender, e);
                this.Hide();
                jnl_fim_voto.Show();
            }
            else if (tipo_voto == "nulo")
            {
                jnl_inicio.votos_nulos++;
                btn_corrige_Click(sender, e);
                this.Hide();
                jnl_fim_voto.Show();
            }
        }
        private void jnl_urna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            btn_corrige_Click(sender, e);
            this.Hide();
            System.Windows.Forms.Application.OpenForms.Cast<Form>().FirstOrDefault(s => s is jnl_inicio).Show();
        }
    }
}
