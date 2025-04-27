using Ligue_4.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
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
        private int[] Pecas_Colunas = new int[7]{ 0, 0, 0, 0, 0, 0, 0 };
        private int Num_Rodada = 1;

        public jnl_jogo()
        {
            InitializeComponent();

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

                // Coluna 2
                imagens_slots[0, 3] = img_slot21;
                imagens_slots[1, 3] = img_slot22;
                imagens_slots[2, 3] = img_slot23;
                imagens_slots[3, 3] = img_slot24;
                imagens_slots[4, 3] = img_slot25;
                imagens_slots[5, 3] = img_slot26;
                imagens_slots[6, 3] = img_slot27;

                // Coluna 3
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
        }

        private void jnl_jogo_Load(object sender, EventArgs e)
        {
            jogadores[0] = new Jogador("Amarelo", Resources.peca_amarelo, true);
            jogadores[1] = new Jogador("Vermelho", Resources.peca_vermelho);

            jogador_atual = new Jogador(jogadores[0].Nome,
                                        jogadores[0].Peca, 
                                        jogadores[0].Jogando);
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
        
        private bool Colocar_Peca(int coluna)
        {
            Image peca = jogador_atual.Peca;

            if (Pecas_Colunas[coluna] < 6 && coluna >= 0 && coluna <= 6)
            { 
                for (int i = 6 - 1; i >= 0; i--)
                {
                    if (imagens_slots[coluna, i].Image == null)
                    {
                        imagens_slots[coluna, i].Image = peca;
                        Pecas_Colunas[coluna]++;
                        Passar_Rodada();

                        return true;
                    }
                }
            }
            return false;
        }

        private bool Verificar_Vitoria()
        {
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

                                for (int k = 1; k < 4; k++)
                                {
                                    coluna_vizinha = coluna + k;

                                    if (imagens_slots[coluna, andar].Image == imagens_slots[coluna_vizinha, andar].Image)
                                        pontos++;
                                    else
                                        break;
                                }

                                if (pontos >= 4)
                                    return true;
                            }

                        ////  Baixo -> Cima
                            if (andar > 2)
                            {
                                int pontos = 1;
                                int andar_vizinho = andar;

                                for (int k = 1; k < 4; k++)
                                {
                                    andar_vizinho = andar - k;

                                    if (imagens_slots[coluna, andar].Image == imagens_slots[coluna, andar_vizinho].Image)
                                        pontos++;
                                    else
                                        break;
                                }

                                if (pontos >= 4)
                                    return true;
                            }

                        // Seta Diagonal 
                            if (andar > 2 && coluna < 4)
                                {
                                    int pontos = 1;
                                    int andar_vizinho = andar;
                                    int coluna_vizinho = coluna;

                                    for (int k = 1; k < 4; k++)
                                    {
                                        andar_vizinho = andar - k;
                                        coluna_vizinho = coluna + k;

                                        if (imagens_slots[coluna, andar].Image == imagens_slots[coluna_vizinho, andar_vizinho].Image)
                                            pontos++;
                                        else
                                            break;
                                    }

                                    if (pontos >= 4)
                                        return true;
                                }
                        
                        // Seta Diagonal Invertida
                            if (andar > 2 && coluna > 2)
                            {
                                int pontos = 1;
                                int andar_vizinho = andar;
                                int coluna_vizinho = coluna;

                                for (int k = 1; k < 4; k++)
                                {
                                    andar_vizinho = andar - k;
                                    coluna_vizinho = coluna - k;

                                    if (imagens_slots[coluna, andar].Image == imagens_slots[coluna_vizinho, andar_vizinho].Image)
                                        pontos++;
                                    else
                                        break;
                                }

                                if (pontos >= 4)
                                    return true;
                            }


                        // Empate
                            if (Num_Rodada == 42)
                                Empate();
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


            MessageBoxButtons botao = MessageBoxButtons.OK;
            DialogResult resultado = MessageBox.Show("O jogo empatou!", "Empate", botao);

            if (resultado == DialogResult.OK)
            {
                Environment.Exit(1);
            }
        }
        private void btn_colocar_peca0_Click(object sender, EventArgs e)
        {
            byte coluna = 0;
            Colocar_Peca(coluna);

            if (Pecas_Colunas[coluna] == 6)
                btn_colocar_peca0.Hide();
        }

        private void btn_colocar_peca1_Click(object sender, EventArgs e)
        {
            byte coluna = 1;
            Colocar_Peca(coluna);

            if (Pecas_Colunas[coluna] == 6)
                btn_colocar_peca1.Hide();
        }

        private void btn_colocar_peca2_Click(object sender, EventArgs e)
        {
            byte coluna = 2;
            Colocar_Peca(coluna);

            if (Pecas_Colunas[coluna] == 6)
                btn_colocar_peca2.Hide();
        }

        private void btn_colocar_peca3_Click(object sender, EventArgs e)
        {
            byte coluna = 3;
            Colocar_Peca(coluna);

            if (Pecas_Colunas[coluna] == 6)
                btn_colocar_peca3.Hide();
        }

        private void btn_colocar_peca4_Click(object sender, EventArgs e)
        {
            byte coluna = 4;
            Colocar_Peca(coluna);

            if (Pecas_Colunas[coluna] == 6)
                btn_colocar_peca4.Hide();
        }

        private void btn_colocar_peca5_Click(object sender, EventArgs e)
        {
            byte coluna = 5;
            Colocar_Peca(coluna);

            if (Pecas_Colunas[coluna] == 6)
                btn_colocar_peca5.Hide();
        }

        private void btn_colocar_peca6_Click(object sender, EventArgs e)
        {
            byte coluna = 6;
            Colocar_Peca(coluna);

            if (Pecas_Colunas[coluna] == 6)
                btn_colocar_peca6.Hide();
        }

        private void jnl_jogo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
