using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActGlobant3
{
    internal class Ejr3
    {
        List<NuevosDatos> numeros = new List<NuevosDatos>();
        Random random = new Random();
        public void Generar()
        {

            for (int i = 0; i < 1000; i++)
            {
                try
                {
                    /*
                    int numeroAlazar = random.Next(-100, 101);
                    NuevosDatos obj = new(numeroAlazar);
                    numeros.Add(obj);//añade los numeros ramdoms a la lista "numeros"
                    */
                    numeros.Add(new NuevosDatos(random.Next(-100, 101)));
                }
                catch(Exception e) 
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        /// <summary>
        /// Cuenta cuantos numero positivos hay
        /// </summary>
        /// <returns></returns>
        public int NumerosPositivos() 
        {
            var positivos = (from i in numeros
                            where i.Numero > 0
                            select i).Count();//si los numeros de la lista son mayores a 0 o sea positivos, nos cuenta cuantos numeros positivos hay.

            return positivos;
        }
        /// <summary>
        /// Cuenta cuantos numeros 0 hay
        /// </summary>
        /// <returns></returns>
        public int NumerosNulos() 
        {
            var nulos = (from i in numeros
                             where i.Numero == 0
                             select i).Count();// cuenta cuantos numeros 0 hay
            return nulos;
        }
        /// <summary>
        /// devuelve la sumatoria de los numeros negativos
        /// </summary>
        /// <returns></returns>
        public int SumaNegativa() 
        {
            var negativa = (from i in numeros
                            where i.Numero < 0
                            select i.Numero).Sum();//suma los numeros negativos
                                              
            return  negativa;
                            
        }
        /// <summary>
        /// Deveulve el numero que mas se repite en la lista
        /// </summary>
        /// <returns></returns>
        public int Repeated()
        {
            var groups = numeros.GroupBy(x => x);//ordenar el objeto entero.
            var largest = groups.OrderByDescending(x => x.Count()).First();

            return largest.Key.Numero;
        }
    }
}
