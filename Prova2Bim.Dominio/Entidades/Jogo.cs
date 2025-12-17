using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova2Bim.Dominio.Entidades
{
    public class Jogo
    {
        public int idJogo { get; set; }

        public int Valor1 { get; set; }
        public int Valor2 { get; set; }
        public int Valor3 { get; set; }
        public int Valor4 { get; set; }
        public int Valor5 { get; set; }
        public int Valor6 { get; set; }
        public DateTime DataJogo { get; set; }

        public Jogo(int idJogo, int valor1, int valor2, int valor3, int valor4, int valor5, int valor6, DateTime dataJogo)
        {
            this.idJogo = idJogo;
            Valor1 = valor1;
            Valor2 = valor2;
            Valor3 = valor3;
            Valor4 = valor4;
            Valor5 = valor5;
            Valor6 = valor6;
            DataJogo = dataJogo;
        }
    }
}
