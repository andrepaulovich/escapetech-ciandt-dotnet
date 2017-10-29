using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidadorMovimento;

namespace Desafio06.Howard
{
    public class QuadroIdeias
    {

        private double ConsumoMedio
        {
            get{ return 8; }
            set{ ConsumoMedio = value; }
        }

        public double VelocidadeMedia(double x, double y)
        {
            return y / x;
        }

        public double MovimentoUniforme(int posicaoInicial, double velocidade, DateTime tempo)
        {
            double posicao = 0;

            var time = tempo.Hour;

            posicao = posicaoInicial + velocidade * time;

            return posicao;
            
        }

        public double PressaoSuperfiice(double forca, double area)
        {
            return forca / area;
        }

        public double Densidade(double massa, double volume)
        {
            return massa / volume;
        }

        public double ForcaGravitacional(double G, double M1, double m2, double r)
        {
            return G * (M1 * m2 / Math.Pow(r,2)); 
        }

        private string Decrypt(char r)
        {
            return r.ToString();
        }

        public bool CaminhoCarro(Movimento mov)
        {
            Validador validator = new Validador();
            return validator.ValidadorMovimento(mov);
        }

        public bool Rota(List<Movimento> rotaFinal)
        {
            Validador validator = new Validador();
            return validator.ValidarRota(rotaFinal);
        }

    }
}
