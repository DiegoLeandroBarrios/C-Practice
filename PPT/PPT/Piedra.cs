using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPT
{
    public class Piedra : Metodos
    {
        public Piedra() 
        {
            Tipo = "piedra";
        }
        public override string MetodoParaJugar(Metodos e)
        {
            var result = "";
            if (e.Tipo == "papel")
            {
                result = "pierde";
            }
            else if (e.Tipo == "tijera")
            {
                result = "gana";
            }
            else
            {
                result = "empata";
            }
            return result;
        }
    }
}
