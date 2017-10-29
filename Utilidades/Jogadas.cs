using System;
using System.Collections.Generic;
using System.Text;

namespace Utilidades
{
    public static class Jogadas
    {
        public static List<Partida> Partidas()
        {
            return new List<Partida>()
            {
                new Partida{ MovimentoJogador1 = 2, MovimentoJogador2 = 1, NomeJogador1 = "Sheldon", NomeJogador2 = "Howard"},
                new Partida{ MovimentoJogador1 = 1, MovimentoJogador2 = 1, NomeJogador1 = "Sheldon", NomeJogador2 = "Rajesh"},
                new Partida{ MovimentoJogador1 = 2, MovimentoJogador2 = 2, NomeJogador1 = "Sheldon", NomeJogador2 = "Howard"},
                new Partida{ MovimentoJogador1 = 1, MovimentoJogador2 = 2, NomeJogador1 = "Rajesh", NomeJogador2 = "Howard"},
                new Partida{ MovimentoJogador1 = 1, MovimentoJogador2 = 1, NomeJogador1 = "Sheldon", NomeJogador2 = "Howard"},
                new Partida{ MovimentoJogador1 = 3, MovimentoJogador2 = 2, NomeJogador1 = "Sheldon", NomeJogador2 = "Rajesh"},
                new Partida{ MovimentoJogador1 = 1, MovimentoJogador2 = 5, NomeJogador1 = "Sheldon", NomeJogador2 = "Howard"},
                new Partida{ MovimentoJogador1 = 4, MovimentoJogador2 = 2, NomeJogador1 = "Sheldon", NomeJogador2 = "Penny"},
                new Partida{ MovimentoJogador1 = 3, MovimentoJogador2 = 2, NomeJogador1 = "Rajesh", NomeJogador2 = "Howard"},
                new Partida{ MovimentoJogador1 = 2, MovimentoJogador2 = 4, NomeJogador1 = "Sheldon", NomeJogador2 = "Howard"},
                new Partida{ MovimentoJogador1 = 1, MovimentoJogador2 = 2, NomeJogador1 = "Leonard", NomeJogador2 = "Howard"},
                new Partida{ MovimentoJogador1 = 4, MovimentoJogador2 = 2, NomeJogador1 = "Penny", NomeJogador2 = "Sheldon"},
                new Partida{ MovimentoJogador1 = 1, MovimentoJogador2 = 3, NomeJogador1 = "Sheldon", NomeJogador2 = "Howard"},
                new Partida{ MovimentoJogador1 = 5, MovimentoJogador2 = 2, NomeJogador1 = "Sheldon", NomeJogador2 = "Howard"},
                new Partida{ MovimentoJogador1 = 1, MovimentoJogador2 = 2, NomeJogador1 = "Sheldon", NomeJogador2 = "Penny"},
                new Partida{ MovimentoJogador1 = 4, MovimentoJogador2 = 3, NomeJogador1 = "Penny", NomeJogador2 = "Howard"},
                new Partida{ MovimentoJogador1 = 1, MovimentoJogador2 = 2, NomeJogador1 = "Sheldon", NomeJogador2 = "Howard"},
                new Partida{ MovimentoJogador1 = 1, MovimentoJogador2 = 4, NomeJogador1 = "Sheldon", NomeJogador2 = "Howard"},
                new Partida{ MovimentoJogador1 = 2, MovimentoJogador2 = 2, NomeJogador1 = "Sheldon", NomeJogador2 = "Penny"},
                new Partida{ MovimentoJogador1 = 1, MovimentoJogador2 = 1, NomeJogador1 = "Sheldon", NomeJogador2 = "Howard"},
                new Partida{ MovimentoJogador1 = 1, MovimentoJogador2 = 2, NomeJogador1 = "Sheldon", NomeJogador2 = "Rajesh"},
                new Partida{ MovimentoJogador1 = 2, MovimentoJogador2 = 2, NomeJogador1 = "Sheldon", NomeJogador2 = "Howard"},
                new Partida{ MovimentoJogador1 = 1, MovimentoJogador2 = 5, NomeJogador1 = "Rajesh", NomeJogador2 = "Rajesh"},
                new Partida{ MovimentoJogador1 = 3, MovimentoJogador2 = 4, NomeJogador1 = "Sheldon", NomeJogador2 = "Howard"},
                new Partida{ MovimentoJogador1 = 1, MovimentoJogador2 = 2, NomeJogador1 = "Sheldon", NomeJogador2 = "Rajesh"},
                new Partida{ MovimentoJogador1 = 1, MovimentoJogador2 = 2, NomeJogador1 = "Sheldon", NomeJogador2 = "Howard"},
                new Partida{ MovimentoJogador1 = 4, MovimentoJogador2 = 2, NomeJogador1 = "Rajesh", NomeJogador2 = "Howard"},
                new Partida{ MovimentoJogador1 = 1, MovimentoJogador2 = 2, NomeJogador1 = "Sheldon", NomeJogador2 = "Rajesh"},
                new Partida{ MovimentoJogador1 = 4, MovimentoJogador2 = 2, NomeJogador1 = "Rajesh", NomeJogador2 = "Howard"},
                new Partida{ MovimentoJogador1 = 1, MovimentoJogador2 = 4, NomeJogador1 = "Sheldon", NomeJogador2 = "Howard"},
                new Partida{ MovimentoJogador1 = 5, MovimentoJogador2 = 2, NomeJogador1 = "Rajesh", NomeJogador2 = "Penny"},
                new Partida{ MovimentoJogador1 = 2, MovimentoJogador2 = 3, NomeJogador1 = "Sheldon", NomeJogador2 = "Howard"},
                new Partida{ MovimentoJogador1 = 1, MovimentoJogador2 = 2, NomeJogador1 = "Sheldon", NomeJogador2 = "Rajesh"},
                new Partida{ MovimentoJogador1 = 4, MovimentoJogador2 = 2, NomeJogador1 = "Penny", NomeJogador2 = "Howard"},
                new Partida{ MovimentoJogador1 = 1, MovimentoJogador2 = 3, NomeJogador1 = "Rajesh", NomeJogador2 = "Howard"},
                new Partida{ MovimentoJogador1 = 5, MovimentoJogador2 = 2, NomeJogador1 = "Sheldon", NomeJogador2 = "Howard"},
                new Partida{ MovimentoJogador1 = 3, MovimentoJogador2 = 4, NomeJogador1 = "Penny", NomeJogador2 = "Howard"},
                new Partida{ MovimentoJogador1 = 1, MovimentoJogador2 = 2, NomeJogador1 = "Sheldon", NomeJogador2 = "Rajesh"},
                new Partida{ MovimentoJogador1 = 2, MovimentoJogador2 = 2, NomeJogador1 = "Sheldon", NomeJogador2 = "Howard"},
                new Partida{ MovimentoJogador1 = 1, MovimentoJogador2 = 3, NomeJogador1 = "Penny", NomeJogador2 = "Howard"},
                new Partida{ MovimentoJogador1 = 4, MovimentoJogador2 = 4, NomeJogador1 = "Sheldon", NomeJogador2 = "Howard"},
                new Partida{ MovimentoJogador1 = 1, MovimentoJogador2 = 2, NomeJogador1 = "Sheldon", NomeJogador2 = "Howard"},
                new Partida{ MovimentoJogador1 = 4, MovimentoJogador2 = 2, NomeJogador1 = "Penny", NomeJogador2 = "Sheldon"},
                new Partida{ MovimentoJogador1 = 1, MovimentoJogador2 = 2, NomeJogador1 = "Sheldon", NomeJogador2 = "Howard"},
                new Partida{ MovimentoJogador1 = 1, MovimentoJogador2 = 2, NomeJogador1 = "Sheldon", NomeJogador2 = "Howard"},
                new Partida{ MovimentoJogador1 = 1, MovimentoJogador2 = 3, NomeJogador1 = "Sheldon", NomeJogador2 = "Howard"},
                new Partida{ MovimentoJogador1 = 1, MovimentoJogador2 = 2, NomeJogador1 = "Sheldon", NomeJogador2 = "Howard"},
                new Partida{ MovimentoJogador1 = 1, MovimentoJogador2 = 5, NomeJogador1 = "Rajesh", NomeJogador2 = "Penny"},
                new Partida{ MovimentoJogador1 = 3, MovimentoJogador2 = 2, NomeJogador1 = "Sheldon", NomeJogador2 = "Howard"},
                new Partida{ MovimentoJogador1 = 5, MovimentoJogador2 = 2, NomeJogador1 = "Sheldon", NomeJogador2 = "Howard"},
            };
        }
    }
}
                                                                                                                               