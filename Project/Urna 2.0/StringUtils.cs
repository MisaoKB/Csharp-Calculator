using System;
using System.Linq;

namespace Urna_2._0
{
    public static class StringUtils
    {
        // Classe de funções uteis relacionadas a manipulação de strings
        public static bool stringContemSomenteLetras(string str)
        {
            foreach (char caractere in str)
            {
                if (char.IsLetter(caractere) || char.IsWhiteSpace(caractere))
                    continue;
                else
                    return false;
            }

            return true;
        }
        public static bool stringContemSomenteNumeros(string str)
        {
            foreach (char caractere in str)
            {
                if (char.IsDigit(caractere))
                    continue;
                else
                    return false;
            }

            return true;
        }
        public static bool nomeValido(string Nome, uint Max, uint Min = 0)
        {
            if (string.IsNullOrEmpty(Nome) ||
                string.IsNullOrWhiteSpace(Nome) ||
                !stringContemSomenteLetras(Nome) ||
                Nome.Length < Min ||
                Nome.Length > Max)
            {
                return false;
            }

            return true;
        }
        public static bool stringValida(string mensagem)
        {
            if (string.IsNullOrEmpty(mensagem))
                return false;
            else if (string.IsNullOrWhiteSpace(mensagem))
                return false;

            return true;
        }
        public static string Capitalizar(string str)
        {
            if (!nomeValido(str, (uint)str.Length))
            {
                throw new ArgumentException("Erro na Capitalização: " +
                                           $"A string \"{str}\" não é uma string" +
                                           $"válida para capitalização.");
            }

            if (char.IsUpper(str.First()))
            {
                throw new ArgumentException("Erro na Capitalização: " +
                                           $"A string \"{str}\" já está " +
                                           $"capitalizada.");
            }

            return string.Concat(char.ToUpper(str.First()), str.Substring(1));
        }
    }
}
