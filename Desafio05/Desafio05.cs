using System;
using System.Collections.Generic;
using System.Text;
using Utilidades;

namespace Desafio05
{
    public class Desafio05 : IDesafio05
    {

        public string[] Palavras { get; set; }

        public Desafio05()
        {
            Palavras = new string[] { "soft", "kitty", "warm", "little", "ball", "of", "fur", "happy", "sleepy", "purr" };
        }

        public string ProximaPalavra()
        {
            Random r = new Random(DateTime.Now.Millisecond);
            int index = r.Next(Palavras.Length);
            string selecionada = Palavras[index];
            return selecionada;
        }

        public string CantarParaSheldon()
        {
            var letraMusica = new string[15];

            for (int posicaoPalavra = 1; posicaoPalavra < letraMusica.Length + 1; posicaoPalavra++)
            {
                switch (posicaoPalavra)
                {
                    case 1:
                        {
                            //soft
                            var palavra = ProximaPalavra();
                            while (palavra != "soft")
                            {
                                palavra = ProximaPalavra();
                            }
                            letraMusica[posicaoPalavra - 1] = palavra;
                            break;
                        }
                    case 2:
                    case 4:
                    case 10:
                    case 12:
                        {
                            //kitty
                            var palavra = ProximaPalavra();
                            while (palavra != "kitty")
                            {
                                palavra = ProximaPalavra();
                            }
                            letraMusica[posicaoPalavra - 1] = palavra;
                            break;
                        }
                    case 3:
                        {
                            //warm
                            var palavra = ProximaPalavra();
                            while (palavra != "warm")
                            {
                                palavra = ProximaPalavra();
                            }
                            letraMusica[posicaoPalavra - 1] = palavra;
                            break;
                        }
                    case 5:
                        {
                            //little
                            var palavra = ProximaPalavra();
                            while (palavra != "little")
                            {
                                palavra = ProximaPalavra();
                            }
                            letraMusica[posicaoPalavra - 1] = palavra;
                            break;
                        }
                    case 6:
                        {
                            //ball
                            var palavra = ProximaPalavra();
                            while (palavra != "ball")
                            {
                                palavra = ProximaPalavra();
                            }
                            letraMusica[posicaoPalavra - 1] = palavra;
                            break;
                        }
                    case 7:
                        {
                            //of
                            var palavra = ProximaPalavra();
                            while (palavra != "of")
                            {
                                palavra = ProximaPalavra();
                            }
                            letraMusica[posicaoPalavra - 1] = palavra;
                            break;
                        }
                    case 8:
                        {
                            //fur
                            var palavra = ProximaPalavra();
                            while (palavra != "fur")
                            {
                                palavra = ProximaPalavra();
                            }
                            letraMusica[posicaoPalavra - 1] = palavra;
                            break;
                        }
                    case 9:
                        {
                            //happy
                            var palavra = ProximaPalavra();
                            while (palavra != "happy")
                            {
                                palavra = ProximaPalavra();
                            }
                            letraMusica[posicaoPalavra - 1] = palavra;
                            break;
                        }
                    case 11:
                        {
                            //sleepy
                            var palavra = ProximaPalavra();
                            while (palavra != "sleepy")
                            {
                                palavra = ProximaPalavra();
                            }
                            letraMusica[posicaoPalavra - 1] = palavra;
                            break;
                        }
                    case 13:
                    case 14:
                    case 15:
                        {
                            //purr
                            var palavra = ProximaPalavra();
                            while (palavra != "purr")
                            {
                                palavra = ProximaPalavra();
                            }
                            letraMusica[posicaoPalavra - 1] = palavra;
                            break;
                        }
                }
            }

            // Após montar a letra da música usando o método de palavras randomicas
            var letraMusicaString = string.Join(" ", letraMusica);

            Console.WriteLine(letraMusicaString);

            return letraMusicaString;
        }

        public string Resposta(string letraMusica)
        {
            // Validar a letra da música e verificar o que a Penny disse...
            return Musica.ValidarMusica(letraMusica);
        }
    }
}
