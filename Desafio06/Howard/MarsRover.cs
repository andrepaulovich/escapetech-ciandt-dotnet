using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidadorMovimento;

namespace Desafio06.Howard
{
    public class MarsRover : QuadroIdeias
    {

        public List<Movimento> RotaFinal;

        public void DescobrirMarte()
        {

            RotaFinal = new List<Movimento>();

            // Percorremos o plano 32 x 32 = 1024 (32 pois temos os números negativos)
            for (int ordemMovimento = 1; ordemMovimento <= 1024; ordemMovimento++)
            {
                BuscaPosicao(RotaFinal, ordemMovimento);
            }

            var rotaCorreta = Rota(RotaFinal);

        }

        public void BuscaPosicao(List<Movimento> rotaFinal, int proximoMovimento)
        {
            /// É falado que a rota esta contida num plano cartesiano de -16 a 16 (X e Y)
            
            // ENTÃO vamos testar os movimentos possíveis no plano primeiramente em X
            for (int eixoX = -16; eixoX <= 16; eixoX++)
            {
                                
                // EM SEGUIDA COMBINAR com as possibilidades de Y
                for (int eixoY = -16; eixoY <= 16; eixoY++)
                {

                    // TEMOS UM MÉTODO que valida o caminho do carro e diz se o movimento está na roda definida ou não.
                    if (CaminhoCarro(new Movimento { TranslacaoX = eixoX, TranslacaoY = eixoY, OrdemMovimentacao = proximoMovimento }))
                    {

                        // Se o método de validação do movimento retornar TRUE... adicionamos o movimento à rota!
                        rotaFinal.Add(new Movimento { TranslacaoX = eixoX, TranslacaoY = eixoY, OrdemMovimentacao = proximoMovimento });
                        return;

                    }
                }
            }
        }
    }
}
