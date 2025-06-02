using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urna_2._0
{
    public class Vice
    {
        public string Nome { get; }
        public Image Imagem { get; }

        public Vice(string nome, Image imagem)
        {
            if (!StringUtils.nomeValido(nome, 25, 2))
            {
                throw new ArgumentException();
            }

            //if (imagem == null)
            //{
            //    throw new ArgumentNullException();
            //}

            Nome = nome;
            Imagem = imagem;
        }
    }
}
