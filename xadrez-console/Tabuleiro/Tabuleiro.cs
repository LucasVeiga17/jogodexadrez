﻿namespace tabuleiro
{
    internal class Tabuleiro
    {
        public int Linha { get; set; }
        public int Coluna { get; set;}
        private Peca[,] Pecas;

        public Tabuleiro(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
            Pecas = new Peca[Linha, Coluna];
        }
    }
}
