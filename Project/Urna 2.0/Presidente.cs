using System;
using System.Drawing;

namespace Urna_2._0
{
    public class Presidente
    {
        public string Nome { get; set; }
        public Image Imagem { get; }
        public Vice VicePresidente { get; }
        public string Partido { get; }
        public uint Votos { get; set; }

        public Presidente(string nome, Image imagem, Vice vicepresidente, string partido)
        {
            if (!StringUtils.nomeValido(nome, 25, 2))
            {
                throw new ArgumentException();
            }

            if (vicepresidente == null)
            {
                throw new ArgumentNullException();
            }

            //if (Imagem == null)
            //{
            //    throw new ArgumentNullException();
            //}

            Nome = nome;
            Imagem = imagem;
            VicePresidente = vicepresidente;
            Partido = partido;
            Votos = 0;
        }
    
        public void adicionar_voto()
        {
            Votos++;
        }

        public object Shallowcopy()
        {
            return this.MemberwiseClone();
        }
    }
}
