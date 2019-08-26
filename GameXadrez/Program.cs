using System;
using tabuleiro;

namespace GameXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(2, 2);

            Tela.imprimirTabuleiro(tab);
        }
    }
}
