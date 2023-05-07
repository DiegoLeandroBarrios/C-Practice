using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPT
{
    public class Tijera : Metodos
    {
        public Tijera() 
        {
            Tipo = "tijera";
        }
        public override string MetodoParaJugar(Metodos e)
        {
            var result = "";
            if (e.Tipo == "papel")
            {
                result = "gana";
            }
            else if (e.Tipo == "piedra")
            {
                result = "pierde";
            }
            else
            {
                result = "empata";
            }
            return result;
        }
    }
}
