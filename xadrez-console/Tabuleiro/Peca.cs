namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            Cor = cor;
            Tab = tab;
            QteMovimentos = 0;
            Posicao = null;
        }
        public void IncrementarQtdMovimentos()
        {
            QteMovimentos++;
        }
        public void DecrementarQtdMovimentos()
        {
            QteMovimentos--;
        }
        public bool ExisteMovimentoPossivel()
        {
            bool[,] mat = MovimentosPossiveis();
            for(int i = 0; i < Tab.Linha; i++)
            {
                for(int j = 0; j < Tab.Coluna; j++)
                {
                    if (mat[i,j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool MovimentoPossivel(Posicao pos)
        {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];
        }
        public abstract bool[,] MovimentosPossiveis();
    }
}
