using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consola1
{
    public class Calculadora
    {
        public void DemoReferencia(ref string cadena1)
        {
            cadena1= cadena1+cadena1;
            return;
        }
        public void DemoReferencia( ItemValor item) 
        {
            item.Nombre = item.Nombre + item.Nombre;
            return;
        }

        public void DemoValor(int x)
        {
             x = x * 2;
            return;
        }

        public int Sumar(int x, int i)
        {
            return x + i;
        }
    }
}
