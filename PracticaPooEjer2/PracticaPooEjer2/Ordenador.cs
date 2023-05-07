using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PracticaPooEjer2
{
    public class Ordenador
    {
        public int DiscoGB { get; set; }
        public int DiscoMAX = 3000;
        public bool Encendido { get; set;}

        public bool Encencender() 
        {
            Console.WriteLine("ORDENADOR ENCENDIDO...");
            return Encendido = true;
        }
        public bool Apagar() 
        {
            Console.WriteLine("ORDENADOR APAGADO...");
            return Encendido = false;
        }
        public void AniadirDatos(int datos)
        {
            if (Encendido == true)
            {
                DiscoGB = datos;
                if (DiscoGB > DiscoMAX)
                {
                   DiscoGB = DiscoMAX;
                    Console.WriteLine("DISCO COMPLETO {0} GB", DiscoGB);
                   datos = datos-DiscoMAX;
                    Console.WriteLine("ESPACIO QUE FALTO COMPLETAR: {0} GB", datos);
                }
                else
                {
                    var sobra = 0;
                    sobra = DiscoMAX - DiscoGB;
                    Console.WriteLine("DATOS AÑADIDOS... SOBRA ESTE ESPACIO {0} GB", sobra);
                }
            }
            else 
            {
               Console.WriteLine("El ordenador esta apagado...");
            }
        }
        public void EliminarDatos(int datos)
        {

            if (Encendido == true)
            {
                var borrar = DiscoGB - datos;
                if (borrar <= 0)
                {
                    DiscoGB = 0;
                    Console.WriteLine("DATOS COMPLETAMENTE ELIMINADOS... {0} GB", DiscoGB);
                }
                else
                {
                    Console.WriteLine("DATOS ELIMINADOS... QUEDAN {0} GB", borrar); 
                }
            }
            else
            {
                Console.WriteLine("El ordenador esta apagado...");
            }
        }
    }
}
