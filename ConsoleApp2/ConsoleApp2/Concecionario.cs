using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Concecionario
    {
        public Auto[] autos = new Auto[10];
        public int Cont;
        public Concecionario()
        {
            Cont = 0;
        }
        public void añadirAuto(Auto i) 
        {
            autos[Cont] = i;
            Cont++;
            Console.WriteLine("vehiculo añadido.");
        }
        public void mostrarAutos() 
        {
            for(int i = 0; i < Cont; i++)
            {
                Console.WriteLine(autos[i].toString());
            }
        }
        public void eliminarAuto(int id)
        {
            for(int i = 0; i< Cont; i++) 
            {
                if (autos[i].Id == id)
                {
                    autos[i] = null;
                    Cont--;
                    Console.WriteLine("vehiculo Eliminado.");
                }
            } 
        }

    }
}
