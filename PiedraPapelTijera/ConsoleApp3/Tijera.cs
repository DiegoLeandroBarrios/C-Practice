using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Tijera : TipoDeElemento
    {
        public Tijera()
        {
            Tipo = "tijera";
        }

        public override string ResultadoContra(TipoDeElemento e) 
        {
            return e.ResultadoparaTijera();
        }
        public override string ResultadoparaTijera()
        {
            return "empate";
        }
        public override string ResultadoparaPiedra()
        {
            return "pierde";
        }
        public override string ResultadoparaPapel()
        {
            return "gana";
        }
    }
}
