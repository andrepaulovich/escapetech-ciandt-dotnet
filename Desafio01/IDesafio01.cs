using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01
{
    public interface IDesafio01
    {
        /// <summary>
        /// Recebe uma posição da sequência de fibonacci e deve retornar o número correspondente da sequência.
        /// </summary>
        /// <param name="posicao">Posição da sequência de fibonacci</param>
        /// <returns>Número inteiro com o valor da posição parametrizada</returns>
        int CalcularFibonacci(int posicao);

        string FiltrarApartamentos(int x, List<KeyValuePair<int, string>> lista);

        string Resposta();
    }
}
