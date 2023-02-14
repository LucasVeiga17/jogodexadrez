using tabuleiro;

namespace xadrez_console.xadrez
{
    internal class Peao : Peca
    {
        public Peao(Cor cor, Tabuleiro tab) : base(cor, tab)
        {
        }
        public override string ToString()
        {
            return "P";
        }
        private bool PodeMover(Posicao pos)
        {
            Peca p = Tab.peca(pos);
            return p.Cor != Cor;
        }
        private bool Comer(Posicao pos)
        {
            Peca p = Tab.peca(pos);
            return p != null;
        }
        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linha, Tab.Coluna];

            Posicao pos = new Posicao(0, 0);

            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            if(QteMovimentos == 0 && Tab.PosicaoValida(pos) && PodeMover(pos) && Cor == Cor.Branca)
            {
                mat[pos.Linha, pos.Coluna] = true;
                pos.DefinirValores(Posicao.Linha -2,Posicao.Coluna);
                if (Tab.PosicaoValida(pos) && PodeMover(pos) && Cor == Cor.Branca)
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
            }
            else if (Tab.PosicaoValida(pos) && PodeMover(pos) && Cor == Cor.Branca)
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos) && Cor == Cor.Branca && Comer(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos) && Cor == Cor.Branca && Comer(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            if (QteMovimentos == 0 && Tab.PosicaoValida(pos) && PodeMover(pos) && Cor == Cor.Preta)
            {
                mat[pos.Linha, pos.Coluna] = true;
                pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
                if (Tab.PosicaoValida(pos) && PodeMover(pos) && Cor == Cor.Preta)
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
            }
            else if (Tab.PosicaoValida(pos) && PodeMover(pos) && Cor == Cor.Preta)
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos) && Cor == Cor.Preta && Comer(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos) && Cor == Cor.Preta && Comer(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            return mat;
        }

        }
}
