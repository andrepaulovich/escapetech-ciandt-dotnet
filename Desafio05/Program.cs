using System;

namespace Desafio05
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //DrCooperS - AAAAAHHHHH NÃO ACREDITO QUE PERDI PARA O HOWARD!!!

            //LHofstadter - Calma Sheldon, acontece...

            //DrCooperS - COMO VOU VIVER SABENDO DESTE FATO?!?!1

            //DrCooperS - COMOOOOOOO?!!?1

            //LHofstadter - Penny, o Sheldon está muito nervoso! Canta aquela música que faz ele dormir, rápido!!

            var desafio = new Desafio05();

            Console.WriteLine("Penny canta para ele...");

            var musica = desafio.CantarParaSheldon();

            Console.WriteLine("Ele já se acalmou?!");

            // Validar o que a Penny disse depois de cantar para o Sheldon
            Console.WriteLine("O que a penny disse? " + desafio.Resposta(musica));
            
            Console.ReadLine();

        }
    }
}