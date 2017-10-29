using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public class SheldonException : Exception
    {
        public Spot Spot { get { return new Spot(); } }

        public SheldonException() : base() { }

        public SheldonException(string message) : base(message) { }

        public SheldonException(string message, Exception inner) : base(message, inner) { }

    }
}
