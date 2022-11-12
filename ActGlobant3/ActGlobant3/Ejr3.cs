using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActGlobant3
{
    internal class Ejr3
    {
        List<int> numeros = new List<int>();
        public void Generar()
        {
            Random random = new Random();

            for (int i = 0; i < 1000; i++)
            {
                int numeroAlazar = random.Next(-100, 101);

                numeros.Add(numeroAlazar);//añade los numeros ramdoms a la lista "numeros"

            }
        }

        public int NumerosPositivos() 
        {
            var positivos = (from i in numeros
                            where i > 0
                            select i).Count();//si los numeros de la lista son mayores a 0 o sea positivos, nos cuenta cuantos numeros positivos hay.

            return positivos;
        }
        public int NumerosNulos() 
        {
            var nulos = (from i in numeros
                             where i == 0
                             select i).Count();// cuenta cuantos numeros 0 hay
            return nulos;
        }
        public int SumaNegativa() 
        {
            var negativa = (from i in numeros
                            where i < 0
                            select i).Sum();//suma los numeros negativos
                                              
            return  negativa;
                            
        }
        public int Repeated()
        {
            var groups = numeros.GroupBy(x => x);//ordenar el objeto entero
            var largest = groups.OrderByDescending(x => x.Count()).First();

            return largest.Key;
        }
    }
}
