using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPT
{
    public class Papel : Metodos
    {
        public Papel() 
        {
            Tipo = "papel";
        }
        public override string MetodoParaJugar(Metodos e)
        {
            var result = "";
            if (e.Tipo == "papel")
            {
                result = "empate";
            }
            else if (e.Tipo == "tijera")
            {
                result = "pierde";
            }
            else 
            {
                result = "gana";
            }
            return result;
        }
    }
}
