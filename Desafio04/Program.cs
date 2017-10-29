using System;

namespace Desafio04
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //DrCooperS - ESTAMOS DENTRO! O computador da NASA é nosso!

            //Wolowizard - Agora só precisamos conectar no Rover e levá-lo até as coordenadas da GEMA!

            //PennyActress1985 - Quem vai pilotar?!

            //DrCooperS - EU!

            //Wolowizard - Não! Eu!

            //LHofstadter - Eu!

            //NeuroAmy - Nada disso... serei eu!

            //PennyActress1985 - Meninos parem de brigar!

            //DrCooperS - Mas eu encontrei a GEMA, é mais do que natural que seja eu a pilotar o Rover e trazê-la para cá.

            //Wolowizard - Peraí... é o meu trabalho! Eu ajudei a colocar esse brinquedinho em Marte... eu devê pilotá-lo.

            //DrCooperS - Vamos decidir com uma batalha de cavalheiros! Escolham suas armas!

            var desafio = new Desafio04();

            Console.WriteLine(string.Format("Quem irá pilotar o Mars Hover é {0}", desafio.Resposta()));

            Console.ReadKey();

        }
    }
}