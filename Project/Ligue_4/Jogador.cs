using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ligue_4
{
    internal class Jogador
    {
        public Jogador(string nome, Image peca, bool jogando = false)
        {
            Nome = nome;
            Peca = peca;
            Jogando = jogando;
        }

        public void Passar_Vez()
        {
            if (Jogando)
                Jogando = false;
            else
                Jogando = true;
        }

        public string Nome { get; }
        public bool Jogando { get; private set; }
        public Image Peca { get; }
    }
}
