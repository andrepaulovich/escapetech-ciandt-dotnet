using System;
using System.Collections.Generic;
using System.Text;

namespace Utilidades
{
    public static class Musica
    {
        private static string SoftKittySong = "soft kitty warm kitty little ball of fur happy kitty sleepy kitty purr purr purr";

        public static string ValidarMusica(string letraMusica)
        {
            if (letraMusica == SoftKittySong)
            {
                return "Shhh! O Sheldon Dormiu!";
            }
            else
            {
                return "Ainda não!! Ele não para de reclamar!!!";
            }
        }
    }
}
