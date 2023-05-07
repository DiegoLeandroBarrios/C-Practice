using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPooEjer1
{
    public class Aleatorios
    {
        Random ramdom = new Random();
        public void GenerarUnNumeroEntreDos() 
        {
            var entreDos = ramdom.Next(0 , 2);
            Console.WriteLine("El numero ramdom entre dos que salio es: {0}", entreDos);
        }
        public void GenerarUnArrayDeNumerosEntreDosNumeros()
        {
            
            for (int i = 0; i < 8; i++)
            {
                var entreDos = ramdom.Next(0, 2);
                int[] arrayDenumeros = new int[8];
                arrayDenumeros[i] = entreDos;
                Console.WriteLine("Numeros ramdoms en array... : {0}", arrayDenumeros[i]);
            }
           
        }
    }
}
