using System;
using System.Text;
using Utilidades;

namespace Desafio02
{
    public class Desafio02 : IDesafio02
    {   
        public Desafio02()
        {
            
        }

        public string Descriptografar(string papel)
        {

            StringBuilder senha = new StringBuilder();

            // Era necessário entender que havia um separador comum entre os codigos do segredo caractere '#'
            var codigos = papel.Split('#');

            // Depois era necesário apenas apenas converter os numeros em 'char' a partir do ASCII (havia uma dica na parede sobre isso)
            foreach (var numero in codigos)
            {
                var letra = ((char)int.Parse(numero)).ToString();
                senha.Append(letra);
            }

            return senha.ToString();

        }

        public string Resposta()
        {

            var senha = string.Empty;

            // SENTAR no sofá para usar o notebook é obrigatório, então nada de try catch 'cala boca' temos que verificar o que está ocorrendo

            try
            {

                // Percebmos que é lançada uma SheldonException
                Sofa.LeonardSentaNoSofaParaUsarNotebook();

            }
            catch (SheldonException ex)
            {

                // Na exception tinha uma dica de um papel que estava no lugar do Sheldon
                var pedaco_de_papel_encontrado = ex.Spot.PedacoDePapel;

                // Descriptografamos a senha usando o ASCII
                senha = Descriptografar(pedaco_de_papel_encontrado);

            }

            return senha;

        }
    }
}
