using Desafio06.Howard;
using System;

namespace Desafio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estamos procurando a rota para chegar ao local da GEMA!");

            //BrownDynamite - // . ... - .- -- --- ... / .- -. -.. .- -. -.. --- -.-.-- / . / .- --. --- .-. .- / .--. .- .-. .- / --- -. -.. . ..--..
            
            //LHofstadter - Como pilota isso?! 

            //Wolowizard - Fácil! o sistema é projetado para 16 posicoes no plano cartesiano X e Y... só precisamos saber o caminho correto...

            //LHofstadter - Vamos então!

            //Wolowizard - Alguém está com o mapa? Para onde? Para onde devo ir?

            //Wolowizard - Precisamos validar se nosso ponto de partida está correto!!

            var desafio = new Desafio06();

            Console.WriteLine("A gema está bem AQUI! " + desafio.Resposta());

            Console.ReadLine();
        }
    }
}