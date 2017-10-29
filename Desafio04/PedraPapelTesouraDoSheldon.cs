using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio04
{
    public class PedraPapelTesouraDoSheldon
    {

        public static string Jogar(Jogador jogador1, Jogador jogador2)
        {

            // Prints para facilitar o desenvolvimento do racionício
            Console.WriteLine("{0} escolheu {1}", jogador1.Nome, jogador1.Movimento);
            Console.WriteLine("{0} escolheu {1}", jogador2.Nome, jogador2.Movimento);


            // Encontramos este algorítimo na primeira página do google 
            var resultado = (5 + jogador1.Movimento - jogador2.Movimento) % 5; // https://stackoverflow.com/questions/9553058/scalable-solution-for-rock-paper-scissor

            // Com o resultado do algorítimo verificamos o vencedor
            return DefinirResultado(resultado, jogador1, jogador2);

        }

        private static string DefinirResultado(int resultado, Jogador jogador1, Jogador jogador2)
        {

            /// resultado = 1 or resultado = 3 => jogador 1 wins
            /// resultado = 2 or resultado = 4 => jogador 2 wins
            /// resultado = 0 => tie

            var vencedor = string.Empty;

            switch (resultado)
            {
                case 1:
                case 3:
                    vencedor = jogador1.Nome;                    
                    break;
                case 2:
                case 4:
                    vencedor = jogador2.Nome;                    
                    break;                
            }

            if (!string.IsNullOrEmpty(vencedor))
            {
                Console.WriteLine("Resultado: {0} venceu!", vencedor);
            }
            else
            {
                vencedor = "Empate";
                Console.WriteLine("Resultado: {0}!", vencedor);
            }
            
            return vencedor;

        }
    }
}
