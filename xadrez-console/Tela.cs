using System;
using tabuleiro;

namespace xadrez_console
{
    internal class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for(int i = 0; i < tab.Linha; i++)
            {
                for (int j = 0; j < tab.Coluna; j++)
                {
                    if (tab.peca(new Posicao(i, j)) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.peca(new Posicao(i, j))+ " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
