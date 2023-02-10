using System;
using tabuleiro;
using xadrez_console.xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 7));
                tab.ColocarPeca(new Cavalo(Cor.Preta, tab), new Posicao(0, 1));
                tab.ColocarPeca(new Cavalo(Cor.Preta, tab), new Posicao(0, 6));
                tab.ColocarPeca(new Bispo(Cor.Preta, tab), new Posicao(0, 2));
                tab.ColocarPeca(new Bispo(Cor.Preta, tab), new Posicao(0, 5));
                tab.ColocarPeca(new Rainha(Cor.Preta, tab), new Posicao(0, 3));
                tab.ColocarPeca(new Rei(Cor.Preta, tab), new Posicao(0, 4));
                tab.ColocarPeca(new Peao(Cor.Preta, tab), new Posicao(1, 0));
                tab.ColocarPeca(new Peao(Cor.Preta, tab), new Posicao(1, 1));
                tab.ColocarPeca(new Peao(Cor.Preta, tab), new Posicao(1, 2));
                tab.ColocarPeca(new Peao(Cor.Preta, tab), new Posicao(1, 3));
                tab.ColocarPeca(new Peao(Cor.Preta, tab), new Posicao(1, 4));
                tab.ColocarPeca(new Peao(Cor.Preta, tab), new Posicao(1, 5));
                tab.ColocarPeca(new Peao(Cor.Preta, tab), new Posicao(1, 6));
                tab.ColocarPeca(new Peao(Cor.Preta, tab), new Posicao(1, 7));

                tab.ColocarPeca(new Torre(Cor.Branca, tab), new Posicao(7, 0));
                tab.ColocarPeca(new Torre(Cor.Branca, tab), new Posicao(7, 7));
                tab.ColocarPeca(new Cavalo(Cor.Branca, tab), new Posicao(7, 1));
                tab.ColocarPeca(new Cavalo(Cor.Branca, tab), new Posicao(7, 6));
                tab.ColocarPeca(new Bispo(Cor.Branca, tab), new Posicao(7, 2));
                tab.ColocarPeca(new Bispo(Cor.Branca, tab), new Posicao(7, 5));
                tab.ColocarPeca(new Rei(Cor.Branca, tab), new Posicao(7, 3));
                tab.ColocarPeca(new Rainha(Cor.Branca, tab), new Posicao(7, 4));
                tab.ColocarPeca(new Peao(Cor.Branca, tab), new Posicao(6, 0));
                tab.ColocarPeca(new Peao(Cor.Branca, tab), new Posicao(6, 1));
                tab.ColocarPeca(new Peao(Cor.Branca, tab), new Posicao(6, 2));
                tab.ColocarPeca(new Peao(Cor.Branca, tab), new Posicao(6, 3));
                tab.ColocarPeca(new Peao(Cor.Branca, tab), new Posicao(6, 4));
                tab.ColocarPeca(new Peao(Cor.Branca, tab), new Posicao(6, 5));
                tab.ColocarPeca(new Peao(Cor.Branca, tab), new Posicao(6, 6));
                tab.ColocarPeca(new Peao(Cor.Branca, tab), new Posicao(6, 7));

                Tela.ImprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
