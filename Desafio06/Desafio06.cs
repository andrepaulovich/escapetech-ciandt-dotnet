using Desafio06.Howard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Desafio06
{
    class Desafio06 : IDesafio06
    {

        private MarsRover marsHover;

        public Desafio06()
        {
            marsHover = new MarsRover();
        }

        public string Resposta()
        {
            // Desbravamos o plano cartesiano
            marsHover.DescobrirMarte();

            // Pegamos a rota final e ordenamos ao contrário para pegar o ultimo movimento (onde estará a Jóia do Infinito)
            var ultimo_movimento_possivel = marsHover.RotaFinal.OrderByDescending(f => f.OrdemMovimentacao).FirstOrDefault();

            // Colocamos a resposta na máscara solicitada no desafio
            return string.Format("{0},{1}", ultimo_movimento_possivel.TranslacaoX, ultimo_movimento_possivel.TranslacaoY);
        }

    }
}
