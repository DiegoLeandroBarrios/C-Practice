using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Piedra : TipoDeElemento
    {
        public Piedra() 
        {
            Tipo = "piedra";
        }
        public override string ResultadoContra(TipoDeElemento e)
        {
            return e.ResultadoparaPiedra();
        }
        public override string ResultadoparaTijera()
        {
            return "gana";
        }
        public override string ResultadoparaPiedra()
        {
            return "empate";
        }
        public override string ResultadoparaPapel()
        {
            return "pierde";
        }
    }
}
