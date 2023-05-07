using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Papel: TipoDeElemento
    {
        public Papel() 
        {
            Tipo = "papel";
        }
        public override string ResultadoContra(TipoDeElemento e)
        {
            return e.ResultadoparaPapel();
        }
        public override string ResultadoparaTijera()
        {
            return "pierde";
        }
        public override string ResultadoparaPiedra()
        {
            return "gana";
        }
        public override string ResultadoparaPapel()
        {
            return "empate";
        }
    }
}
