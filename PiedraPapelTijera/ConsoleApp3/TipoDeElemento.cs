using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public abstract class TipoDeElemento
    {
        public string Tipo { get; set; }

        public TipoDeElemento() { }
       
        public virtual string ResultadoContra(TipoDeElemento e)
        {
            return "";
        }
        public virtual string ResultadoparaTijera() 
        {
            return "";
        }
        public virtual string ResultadoparaPiedra()
        {
            return "";
        }
        public virtual string ResultadoparaPapel()
        {
            return "";
        }
       
    }
}
