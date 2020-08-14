using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton jogador_1 = Singleton.GetInstancia;
            jogador_1.Mensagem("Jogador 1: A bola está comigo ");
            
            Singleton jogador_2 = Singleton.GetInstancia;
            jogador_1.Mensagem("Jogador 2: Recebi a bola  ");

            Singleton jogador_3 = Singleton.GetInstancia;
            jogador_1.Mensagem("Jogador 3: recebeu o lançamento na linha de fundo ");
        }
    }
}
