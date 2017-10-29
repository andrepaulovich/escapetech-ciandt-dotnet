using System;
using System.Collections.Generic;
using System.Linq;

namespace ValidadorMovimento
{
    public class Validador
    {

        private List<Movimento> listMovimento;

        protected List<Movimento> ListMovimento
        {
            get
            {
                return CriarLista();
            }
            set
            {
                ListMovimento = listMovimento;
            }
        }
      
        protected List<Movimento> CriarLista()
        {
            listMovimento = new List<Movimento>();
            listMovimento.Add(new Movimento { TranslacaoX = 0, TranslacaoY = 0, OrdemMovimentacao = 1 });
            listMovimento.Add(new Movimento { TranslacaoX = 1, TranslacaoY = 1, OrdemMovimentacao = 2 });
            listMovimento.Add(new Movimento { TranslacaoX = 2, TranslacaoY = 2, OrdemMovimentacao = 3 });
            listMovimento.Add(new Movimento { TranslacaoX = 3, TranslacaoY = 2, OrdemMovimentacao = 4 });
            listMovimento.Add(new Movimento { TranslacaoX = 4, TranslacaoY = 2, OrdemMovimentacao = 5 });
            listMovimento.Add(new Movimento { TranslacaoX = 5, TranslacaoY = 2, OrdemMovimentacao = 6 });
            listMovimento.Add(new Movimento { TranslacaoX = 5, TranslacaoY = 1, OrdemMovimentacao = 7 });
            listMovimento.Add(new Movimento { TranslacaoX = 5, TranslacaoY = 0, OrdemMovimentacao = 8 });
            listMovimento.Add(new Movimento { TranslacaoX = 5, TranslacaoY = -1, OrdemMovimentacao = 9 });
            listMovimento.Add(new Movimento { TranslacaoX = 5, TranslacaoY = -2, OrdemMovimentacao = 10 });
            listMovimento.Add(new Movimento { TranslacaoX = 4, TranslacaoY = -2, OrdemMovimentacao = 11 });
            listMovimento.Add(new Movimento { TranslacaoX = 3, TranslacaoY = -2, OrdemMovimentacao = 12 });
            listMovimento.Add(new Movimento { TranslacaoX = 3, TranslacaoY = -3, OrdemMovimentacao = 13 });
            listMovimento.Add(new Movimento { TranslacaoX = 2, TranslacaoY = -3, OrdemMovimentacao = 14 });
            listMovimento.Add(new Movimento { TranslacaoX = 2, TranslacaoY = -4, OrdemMovimentacao = 15 });
            listMovimento.Add(new Movimento { TranslacaoX = 1, TranslacaoY = -4, OrdemMovimentacao = 16 });
            listMovimento.Add(new Movimento { TranslacaoX = 0, TranslacaoY = -4, OrdemMovimentacao = 17 });
            listMovimento.Add(new Movimento { TranslacaoX = -1, TranslacaoY = -4, OrdemMovimentacao = 18 });
            listMovimento.Add(new Movimento { TranslacaoX = -2, TranslacaoY = -4, OrdemMovimentacao = 19 });
            listMovimento.Add(new Movimento { TranslacaoX = -3, TranslacaoY = -4, OrdemMovimentacao = 20 });
            listMovimento.Add(new Movimento { TranslacaoX = -4, TranslacaoY = -4, OrdemMovimentacao = 21 });
            listMovimento.Add(new Movimento { TranslacaoX = -4, TranslacaoY = -5, OrdemMovimentacao = 22 });
            listMovimento.Add(new Movimento { TranslacaoX = -5, TranslacaoY = -5, OrdemMovimentacao = 23 });
            listMovimento.Add(new Movimento { TranslacaoX = -6, TranslacaoY = -5, OrdemMovimentacao = 24 });
            listMovimento.Add(new Movimento { TranslacaoX = -7, TranslacaoY = -5, OrdemMovimentacao = 25 });
            listMovimento.Add(new Movimento { TranslacaoX = -7, TranslacaoY = -4, OrdemMovimentacao = 26 });
            listMovimento.Add(new Movimento { TranslacaoX = -7, TranslacaoY = -3, OrdemMovimentacao = 27 });
            listMovimento.Add(new Movimento { TranslacaoX = -7, TranslacaoY = -2, OrdemMovimentacao = 28 });
            listMovimento.Add(new Movimento { TranslacaoX = -7, TranslacaoY = -1, OrdemMovimentacao = 29 });
            listMovimento.Add(new Movimento { TranslacaoX = -7, TranslacaoY = 0, OrdemMovimentacao = 30 });
            listMovimento.Add(new Movimento { TranslacaoX = -7, TranslacaoY = 1, OrdemMovimentacao = 31 });
            listMovimento.Add(new Movimento { TranslacaoX = -7, TranslacaoY = 2, OrdemMovimentacao = 32 });
            listMovimento.Add(new Movimento { TranslacaoX = -7, TranslacaoY = 3, OrdemMovimentacao = 33 });
            listMovimento.Add(new Movimento { TranslacaoX = -6, TranslacaoY = 4, OrdemMovimentacao = 34 });
            listMovimento.Add(new Movimento { TranslacaoX = -5, TranslacaoY = 5, OrdemMovimentacao = 35 });
            listMovimento.Add(new Movimento { TranslacaoX = -4, TranslacaoY = 6, OrdemMovimentacao = 36 });
            listMovimento.Add(new Movimento { TranslacaoX = -3, TranslacaoY = 6, OrdemMovimentacao = 37 });
            listMovimento.Add(new Movimento { TranslacaoX = -2, TranslacaoY = 6, OrdemMovimentacao = 38 });
            listMovimento.Add(new Movimento { TranslacaoX = -2, TranslacaoY = 5, OrdemMovimentacao = 39 });
            listMovimento.Add(new Movimento { TranslacaoX = -1, TranslacaoY = 5, OrdemMovimentacao = 40 });
            listMovimento.Add(new Movimento { TranslacaoX = 0, TranslacaoY = 5, OrdemMovimentacao = 41 });
            listMovimento.Add(new Movimento { TranslacaoX = 1, TranslacaoY = 5, OrdemMovimentacao = 42 });
            listMovimento.Add(new Movimento { TranslacaoX = 2, TranslacaoY = 5, OrdemMovimentacao = 43 });
            listMovimento.Add(new Movimento { TranslacaoX = 3, TranslacaoY = 5, OrdemMovimentacao = 44 });
            listMovimento.Add(new Movimento { TranslacaoX = 4, TranslacaoY = 5, OrdemMovimentacao = 45 });
            listMovimento.Add(new Movimento { TranslacaoX = 5, TranslacaoY = 5, OrdemMovimentacao = 46 });
            listMovimento.Add(new Movimento { TranslacaoX = 6, TranslacaoY = 5, OrdemMovimentacao = 47 });
            listMovimento.Add(new Movimento { TranslacaoX = 7, TranslacaoY = 6, OrdemMovimentacao = 48 });
            listMovimento.Add(new Movimento { TranslacaoX = 8, TranslacaoY = 7, OrdemMovimentacao = 49 });
            listMovimento.Add(new Movimento { TranslacaoX = 9, TranslacaoY = 7, OrdemMovimentacao = 50 });
            listMovimento.Add(new Movimento { TranslacaoX = 10, TranslacaoY = 7, OrdemMovimentacao = 51 });
            listMovimento.Add(new Movimento { TranslacaoX = 11, TranslacaoY = 7, OrdemMovimentacao = 52 });
            listMovimento.Add(new Movimento { TranslacaoX = 12, TranslacaoY = 6, OrdemMovimentacao = 53 });
            listMovimento.Add(new Movimento { TranslacaoX = 13, TranslacaoY = 5, OrdemMovimentacao = 54 });
            listMovimento.Add(new Movimento { TranslacaoX = 14, TranslacaoY = 4, OrdemMovimentacao = 55 });
            listMovimento.Add(new Movimento { TranslacaoX = 15, TranslacaoY = 3, OrdemMovimentacao = 56 });
            listMovimento.Add(new Movimento { TranslacaoX = 16, TranslacaoY = 2, OrdemMovimentacao = 57 });

            return listMovimento;
        }

        public bool ValidadorMovimento(Movimento movimento)
        {
            var movimentoPosicao = ListMovimento.Where(x => x.OrdemMovimentacao == movimento.OrdemMovimentacao);

            var existeNaRota = movimentoPosicao.Any(x => x.TranslacaoX == movimento.TranslacaoX && x.TranslacaoY == movimento.TranslacaoY && movimento.OrdemMovimentacao == x.OrdemMovimentacao);

            return existeNaRota;
        }

        public bool ValidarRota(List<Movimento> caminho)
        {
            return ListMovimento.SequenceEqual(caminho);
        }

    }
}
