using System.Collections.Generic;
using System.Linq;
using Utilidades;

namespace Desafio04
{
    public class Desafio04 : IDesafio04
    {
        public List<string> Placar { get; set; }

        public Desafio04()
        {

            // Criamos uma lista de strings para armazenar o nome do vencedor (é perguntando quem ganhou e quantas vezes)
            Placar = new List<string>();

            // Encontramos a lista de partidas na biblioteca de utilidades
            var partidas = Jogadas.Partidas();

            // Percorremos a lista de partidas instanciando objetos 'Jogador' para cada partida
            foreach (var partida in partidas)
            {

                var jogador1 = new Jogador { Movimento = (Movimento)partida.MovimentoJogador1, Nome = partida.NomeJogador1 };
                var jogador2 = new Jogador { Movimento = (Movimento)partida.MovimentoJogador2, Nome = partida.NomeJogador2 };

                // Passamos os objetos para o método Jogar da classe 'PedraPapelTesouraDoSheldon' que deve nos retornar o nome do vencedor
                var vencedor = PedraPapelTesouraDoSheldon.Jogar(jogador1, jogador2);

                // adicionamos o nome do vencedor no placar
                Placar.Add(vencedor);

            }

        }

        public string Resposta()
        {

            // agrupamos a lista de resultados pelo jogador
            var agrupamento_de_resultados = Placar
                    .GroupBy(s => s)
                    .Select(group => new { Jogador = group.Key, Vitorias = group.Count() });

            // ordenamos do maior vencedor para o menor
            var maior_vencedor = agrupamento_de_resultados.OrderByDescending(f => f.Vitorias).FirstOrDefault();

            // colocamos o resultado na máscara solicitada no desafio "{vencedor},{numero_vitorias}"
            return string.Format("{0},{1}", maior_vencedor.Jogador, maior_vencedor.Vitorias);

        }
    }
}
