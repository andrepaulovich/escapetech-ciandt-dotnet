using System;
using System.Text;

namespace Desafio03
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //LHofstadter - Podemos focar na parte importante ? Como nós vamos usar o combustível para resgatar o artefato em marte ?

            //DrCooperS - Elementar meu caro Leonard, vamos utilizar o combustível para impulsionar o C00PER1

            //Wolowizard - C00PER1 ?

            //DrCooperS - O foguete que construiremos para esta missão.

            //BrownDynamite - . ... . .-. .. --- ..--..

            //PennyActress1985 - A gente não tem menos de uma hora para resolver isso ?

            //NeuroAmy - Precisamente.

            //MicroBioBernie - Nem o meu Howie monta um foguete em menos de uma hora.

            //Wolowizard - Nenhum foguete chega em marte em menos de uma hora !

            //DrCooperS - Se vocês não tivessem perdido tanto tempo resolvendo os enigmas talvez fosse possível.

            //LHofstadter - VOCÊ CRIOU OS ENIGMAS !

            //Wolowizard - Calma Leonard, não há necessidade de usar o caps lock, somos todos adultos e EU tenho a solução !

            //BrownDynamite - .-.. .- ...- . --

            //Wolowizard - Como eu dizia, antes de ser rudemente interrompido, quando eu fui um astronauta, eu tive acesso a alguns computadores da agência espacial e pude copiar algumas senhas deles e parte do algoritmo de encriptação...

            Console.WriteLine("Descobrir a senha para pilotar o mars hover!");

            //LHofstadter - Com isso nós podemos invadir os computadores deles, controlar o rover e trazer o objeto de volta através dos foguetes de ejeção, brilhante Howard !

            //Wolowizard - Eu ia sugerir chantagear os diretores de agência com o histórico dos browsers para utilizar algum foguete protótipo super veloz mas ok. Seu plano funciona !

            //NeuroAmy - Mas essa senha…

            //MicroBioBernie - Eu não acredito…..

            // NESTE CASO HAVIA um envelope na sala com alguns numeros que correspondiam a senha do computador da NASA.

            // A DICA ERA QUE O PROCESSO DE CRIPTOGRAFIA DA SENHA ERA CONHECIDO (usamos o ASCII no desafio anterior)

            // ENCONTRANDO OS NUMEROS
            var codigos = new int[] { 066, 064, 122, 122, 049, 110, 103, 052}; // esses numeros estavam anotados em papéis no envelope escondido

            StringBuilder senha = new StringBuilder();

            // Depois era necesário apenas apenas converter os numeros em 'char' a partir do ASCII (havia uma dica na parede sobre isso)
            foreach (var numero in codigos)
            {
                var letra = ((char)numero).ToString();
                senha.Append(letra);
            }

            Console.WriteLine("A senha é " + senha);

            Console.ReadKey();

        }
    }
}