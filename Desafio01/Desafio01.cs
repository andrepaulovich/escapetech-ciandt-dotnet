using System;
using System.Collections.Generic;
using Utilidades;

namespace Desafio01
{
    public class Desafio01 : IDesafio01
    {
        public string Resposta()
        {

            // Ao encontrar o número 17 fora da sequencia no quadro de fibonacci encontrar o valor correspondente ao mesmo.
            var decimo_setimonumero_de_fibonacci = CalcularFibonacci(18);

            // Encontrar a lista de apartamentos na biblioteca de utilidades
            var lista_apartamentos = Enderecos.ObterListaApartamentos();
            
            // Filtrar os apartamentos usando a chave de fibonacci encontrada
            var apartamento = FiltrarApartamentos(decimo_setimonumero_de_fibonacci, lista_apartamentos);

            return apartamento;

        }
        
        public int CalcularFibonacci(int posicao)
        {

            // implementação simples de fibonacci

            int a = 0, b = 1, c = 0;

            // Prints na tela apenas para ajudar no raciocínio

            Console.WriteLine("1º {0}", a);

            Console.WriteLine("2º {0}", b);

            // As três primeiras posicoes são fixas 0, 1, 1, ...
            for (int i = 3; i < posicao; i++)
            {
                c = a + b;

                // Prints das demais posições
                Console.WriteLine("{0}º {1}", i, c);
                a = b;
                b = c;
            }

             return c;

        }

        public string FiltrarApartamentos(int chave, List<KeyValuePair<int, string>> lista)
        {

            /// Basta agora encontrar qual dos apartamentos possui a chave do número de fibonacci
            var apartamento_escolhido = lista.Find(f => f.Key == chave);

            return apartamento_escolhido.Value;

        }
    }
}
