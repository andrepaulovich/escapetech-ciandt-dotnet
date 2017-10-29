using System;
using System.Collections.Generic;
using Utilidades;

//DrCooperS - Então, como vamos nos comunicar via código, acho adequado que usemos os recursos que a linguagem permite.

//LHofstadter - Sheldon, por favor, nós só queremos resolver esse problema, não crie mais dificuldades!

//PennyActress1985 - Por quê quando vocês escrevem, a cor muda?

namespace Desafio01 
{
    //Wololowitz - Alguém ensina a Penny a comentar o código ? Isso nunca vai compilar desse jeito.

    //NeuroAmy - BFF, o ideal é utilizar de duas barras antes de escrever qualquer coisa para que não tenhamos problemas com o código.
    public class Program 
    {
        //PennyActress1985 //- //Assim //?

        //Wololowitz - Isso vai longe….

        //BrownDynamite - ….

        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //MicroBioBernie - Howie, o Raj ainda não consegue falar com mulheres ?

            //DrCooperS - Se vocês já se cansaram de brincar, para cumprirmos nossa missão precisamos do combustível de foguetes que o Leonard quase entregou para aquela espiã norte-coreana com a qual ele estava saindo.

            Console.WriteLine("Precisamos encontrar a posicao X de fibonacci?! é isso mesmo?!");
            
            //Wololowitz - A gente pode se comunicar de outra forma mais fácil?!

            //DrCooperS - Só se vc não consegue! Mas se você quer uma dica... 

            //Wololowitz - Proporção áurea guarda o segredo do número do apartamento!
            
            var desafio = new Desafio01();
            
            Console.WriteLine(string.Format("A fórmula de combustível balístico está no {0}", desafio.Resposta()));

            Console.ReadKey();

        }

    }
}
