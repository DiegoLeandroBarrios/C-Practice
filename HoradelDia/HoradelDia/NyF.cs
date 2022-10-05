using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoradelDia
{
    internal class NyF
    {
        public DateTime fechasActual = new DateTime();
        public Random Random = new Random();
        public int[] arregloRandom = new int[5];
        public NyF()
        {
            fechasActual = DateTime.Now;
            for(int i= 0; i<5; i++)
            {
                arregloRandom[i] = Random.Next(51);
                for(int j = 0; j<5; j++) 
                {
                    if (arregloRandom[i] == arregloRandom[j]) 
                    {
                        arregloRandom[i] = Random.Next(51);
                    }
                }
            }
        }
    }
}
