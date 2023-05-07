using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPT
{
    public abstract class Metodos
    {
        public string Tipo { get; set; }

        public Metodos()
        {
        }
        public virtual string MetodoParaJugar(Metodos e)
        {
            return "";
        }
    }
    
}
