using Ligue_4.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ligue_4
{
    public partial class jnl_jogo : Form
    {
        private Jogador[] jogadores = new Jogador[2];
        private Jogador jogador_atual;

        private PictureBox[,] imagens_slots = new PictureBox[7, 6];
        private int[] Pecas_Colunas = new int[7] {0, 0, 0, 0, 0, 0, 0};

        private int Num_Rodada = 1;

        public jnl_jogo()
        {
            InitializeComponent();

            #region Matriz de Picture Box
            // Adicionar imagens ao imagens_slots 

            // Coluna 0
                imagens_slots[0, 0] = img_slot0;
                imagens_slots[1, 0] = img_slot1;
                imagens_slots[2, 0] = img_slot2;
                imagens_slots[3, 0] = img_slot3;
                imagens_slots[4, 0] = img_slot4;
                imagens_slots[5, 0] = img_slot5;
                imagens_slots[6, 0] = img_slot6;

            // Coluna 1
                imagens_slots[0, 1] = img_slot7;
                imagens_slots[1, 1] = img_slot8;
                imagens_slots[2, 1] = img_slot9;
                imagens_slots[3, 1] = img_slot10;
                imagens_slots[4, 1] = img_slot11;
                imagens_slots[5, 1] = img_slot12;
                imagens_slots[6, 1] = img_slot13;

            // Coluna 2
                imagens_slots[0, 2] = img_slot14;
                imagens_slots[1, 2] = img_slot15;
                imagens_slots[2, 2] = img_slot16;
                imagens_slots[3, 2] = img_slot17;
                imagens_slots[4, 2] = img_slot18;
                imagens_slots[5, 2] = img_slot19;
                imagens_slots[6, 2] = img_slot20;

            // Coluna 3
                imagens_slots[0, 3] = img_slot21;
                imagens_slots[1, 3] = img_slot22;
                imagens_slots[2, 3] = img_slot23;
                imagens_slots[3, 3] = img_slot24;
                imagens_slots[4, 3] = img_slot25;
                imagens_slots[5, 3] = img_slot26;
                imagens_slots[6, 3] = img_slot27;

            // Coluna 4
                imagens_slots[0, 4] = img_slot28;
                imagens_slots[1, 4] = img_slot29;
                imagens_slots[2, 4] = img_slot30;
                imagens_slots[3, 4] = img_slot31;
                imagens_slots[4, 4] = img_slot32;
                imagens_slots[5, 4] = img_slot33;
                imagens_slots[6, 4] = img_slot34;

            // Coluna 5
                imagens_slots[0, 5] = img_slot35;
                imagens_slots[1, 5] = img_slot36;
                imagens_slots[2, 5] = img_slot37;
                imagens_slots[3, 5] = img_slot38;
                imagens_slots[4, 5] = img_slot39;
                imagens_slots[5, 5] = img_slot40;
                imagens_slots[6, 5] = img_slot41;
            #endregion
        }

        private void jnl_jogo_Load(object sender, EventArgs e)
        {
            jogadores[0] = new Jogador("Amarelo", Resources.peca_amarelo, true);
            jogadores[1] = new Jogador("Vermelho", Resources.peca_vermelho);

            jogador_atual = new Jogador(jogadores[0].Nome,
                                        jogadores[0].Peca,
                                        jogadores[0].Jogando);
        }
        private void jnl_jogo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1:
                    btn_colocar_peca_Click(btn_colocar_peca0, e);
                    break;
                case Keys.D2:
                    btn_colocar_peca_Click(btn_colocar_peca1, e);
                    break;
                case Keys.D3:
                    btn_colocar_peca_Click(btn_colocar_peca2, e); 
                    break;
                case Keys.D4:
                    btn_colocar_peca_Click(btn_colocar_peca3, e);
                    break;
                case Keys.D5:
                    btn_colocar_peca_Click(btn_colocar_peca4, e);
                    break;
                case Keys.D6:
                    btn_colocar_peca_Click(btn_colocar_peca5, e);
                    break;
                case Keys.D7:
                    btn_colocar_peca_Click(btn_colocar_peca6, e);
                    break;
                case Keys.Escape:
                    Environment.Exit(1);
                    break;
            }
        }
        private void jnl_jogo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
        private void btn_colocar_peca_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            byte coluna = byte.Parse(botao.Name.Last().ToString());

            Colocar_Peca(coluna);

            if (Pecas_Colunas[coluna] == 6)
                botao.Enabled = false;
        }
        private bool Colocar_Peca(int coluna)
        {
            Image peca = jogador_atual.Peca;

            if (coluna >= 0 && coluna <= 6)
            {
                if (Pecas_Colunas[coluna] < 6)
                {
                    for (int i = 6 - 1; i >= 0; i--)
                    {
                        if (imagens_slots[coluna, i].Image == null)
                        {
                            imagens_slots[coluna, i].Image = peca;
                            tocarSom("colocar_peca");
                            Pecas_Colunas[coluna]++;
                            Passar_Rodada();

                            return true;
                        }
                    }
                }
            }
            return false;
        }
        private void tocarSom(string som)
        {
            string caminho = AppDomain.CurrentDomain.BaseDirectory;
            caminho = Path.GetFullPath(Path.Combine(caminho, @"..\..\Resources"));
            caminho = Path.GetFullPath(Path.Combine(caminho, $@"{som}.wav"));
            SoundPlayer simpleSound = new SoundPlayer(caminho);
            simpleSound.Play();
        }
        private void Passar_Rodada()
        {
            if (Num_Rodada > 6)
                if (Verificar_Vitoria())
                    Vitoria();

            Num_Rodada++;

            jogadores[1].Passar_Vez();
            jogadores[0].Passar_Vez();

            if (jogadores[0].Jogando)
                jogador_atual = jogadores[0];
                
            else
                jogador_atual = jogadores[1];
            img_vez_jogador.Image = jogador_atual.Peca;
        }
        private bool Verificar_Vitoria()
        {
            PictureBox[] pecas_ganhadoras = new PictureBox[4];

            void Mostrar_Ganhadoras()
            {
                Setar_Todas_Imagens();
                foreach (PictureBox pecas in pecas_ganhadoras)
                {
                    pecas.Image = jogador_atual.Peca;
                }
            }

            void Setar_Tudo_Nulo()
            {
                for (int i = 0; i < 4; i++)
                {
                    pecas_ganhadoras.SetValue(null, i);
                }
            }

            for (int coluna = 0; coluna < imagens_slots.GetLength(0); coluna++)
            {
                for (int andar = 0; andar < imagens_slots.GetLength(1); andar++)
                {
                    if (imagens_slots[coluna, andar].Image != null)
                    {
                        // Esquerda -> Direita
                            if (coluna < 4)
                            {
                                int pontos = 1;
                                int coluna_vizinha = coluna;
                                int andar_vizinho = andar;

                                for (int k = 1; k < 4; k++)
                                {
                                    coluna_vizinha = coluna + k;
                                    andar_vizinho = andar;

                                    if (imagens_slots[coluna, andar].Image == imagens_slots[coluna_vizinha, andar_vizinho].Image)
                                    {
                                        if (pontos  == 1)
                                        {
                                            pecas_ganhadoras[pontos - 1] = imagens_slots[coluna, andar];
                                        }
                                        pontos++;
                                        pecas_ganhadoras[pontos - 1] = imagens_slots[coluna_vizinha, andar_vizinho];
                                    }
                                    else
                                    {
                                        Setar_Tudo_Nulo();
                                        break;
                                    }
                                }


                                if (pontos >= 4)
                                {
                                    Mostrar_Ganhadoras();
                                    return true;
                                }
                            }

                        ////  Baixo -> Cima
                            if (andar > 2)
                            {
                                int pontos = 1;
                                int coluna_vizinha = coluna;
                                int andar_vizinho = andar;

                                for (int k = 1; k < 4; k++)
                                {
                                    andar_vizinho = andar - k;

                                    if (imagens_slots[coluna, andar].Image == imagens_slots[coluna_vizinha, andar_vizinho].Image)
                                    {
                                        if (pontos == 1)
                                        {
                                            pecas_ganhadoras[pontos - 1] = imagens_slots[coluna, andar];
                                        }
                                        pontos++;
                                        pecas_ganhadoras[pontos - 1] = imagens_slots[coluna_vizinha, andar_vizinho];
                                    }
                                    else
                                    {
                                        Setar_Tudo_Nulo();
                                        break;
                                    }
                                }

                                if (pontos >= 4)
                                {
                                    Mostrar_Ganhadoras();
                                    return true;
                                }
                            }

                        // Seta Diagonal 
                            if (andar > 2 && coluna < 4)
                            {
                                int pontos = 1;
                                int andar_vizinho = andar;
                                int coluna_vizinha = coluna;

                                for (int k = 1; k < 4; k++)
                                {
                                    andar_vizinho = andar - k;
                                    coluna_vizinha = coluna + k;

                                    if (imagens_slots[coluna, andar].Image == imagens_slots[coluna_vizinha, andar_vizinho].Image)
                                    {
                                        if (pontos == 1)
                                        {
                                            pecas_ganhadoras[pontos - 1] = imagens_slots[coluna, andar];
                                        }
                                        pontos++;
                                        pecas_ganhadoras[pontos - 1] = imagens_slots[coluna_vizinha, andar_vizinho];
                                    }
                                    else
                                    {
                                        Setar_Tudo_Nulo();
                                        break;
                                    }  
                                }

                                if (pontos >= 4)
                                {
                                    Mostrar_Ganhadoras();
                                    return true;
                                }
                            }
                        
                        // Seta Diagonal Invertida
                            if (andar > 2 && coluna > 2)
                            {
                                int pontos = 1;
                                int andar_vizinho = andar;
                                int coluna_vizinha = coluna;

                                for (int k = 1; k < 4; k++)
                                {
                                    andar_vizinho = andar - k;
                                    coluna_vizinha = coluna - k;

                                    if (imagens_slots[coluna, andar].Image == imagens_slots[coluna_vizinha, andar_vizinho].Image)
                                    {
                                        if (pontos == 1)
                                        {
                                            pecas_ganhadoras[pontos - 1] = imagens_slots[coluna, andar];
                                        }
                                        pontos++;
                                        pecas_ganhadoras[pontos - 1] = imagens_slots[coluna_vizinha, andar_vizinho];
                                    }
                                    else
                                    {
                                        Setar_Tudo_Nulo();
                                        break;
                                    }
                                }

                                if (pontos >= 4)
                                {
                                    Mostrar_Ganhadoras();
                                    return true;
                                }
                            }

                        // Empate
                            if (Num_Rodada == 42)
                            {
                                Empate();
                            }
                    }
                }
            }

            return false;
        }
        private void Vitoria()
        {
            btn_colocar_peca0.Hide();
            btn_colocar_peca1.Hide();
            btn_colocar_peca2.Hide();
            btn_colocar_peca3.Hide();
            btn_colocar_peca4.Hide();
            btn_colocar_peca5.Hide();
            btn_colocar_peca6.Hide();

            tocarSom("ganhar");
            MessageBoxButtons botao = MessageBoxButtons.OK;
            DialogResult resultado = MessageBox.Show($"O jogador {jogador_atual.Nome} ganhou!", "Vitória!", botao);

            if (resultado == DialogResult.OK)
            {
                Environment.Exit(1);
            }

        }
        private void Empate()
        {
            btn_colocar_peca0.Hide();
            btn_colocar_peca1.Hide();
            btn_colocar_peca2.Hide();
            btn_colocar_peca3.Hide();
            btn_colocar_peca4.Hide();
            btn_colocar_peca5.Hide();
            btn_colocar_peca6.Hide();

            tocarSom("empatar");
            MessageBoxButtons botao = MessageBoxButtons.OK;
            DialogResult resultado = MessageBox.Show("O jogo empatou!", "Empate", botao);

            if (resultado == DialogResult.OK)
            {
                Environment.Exit(1);
            }
        }
        private void Setar_Todas_Imagens(Image imagem = null)
        {
            foreach (PictureBox slot in imagens_slots)
            {
                slot.Image = imagem;
            }
        }
        private void Empatar_Teste()
        {
            for (int k = 0; k < 3; k++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        Colocar_Peca(i + k * 2);
                    }
                }
            }
            Colocar_Peca(6);
            Colocar_Peca(6);
            Colocar_Peca(6);
            for (int k = 0; k < 3; k++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        Colocar_Peca(i + k * 2);
                    }
                }
            }
        }
    }
}
