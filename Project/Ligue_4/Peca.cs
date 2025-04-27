using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ligue_4
{
    internal class Peca
    {
        public Peca(Color cor) 
        {
            Cor_Peca = cor;
        }

        public Color Cor_Peca { get; set; }
        public Image Imagem_Peca { get; set; }
    }
}
