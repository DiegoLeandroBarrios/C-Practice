using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPooEjer1
{
    public class Concesionario
    {
        List<Coche> concesionario01 = new List<Coche>();
        public void AñadirCoches(Coche c) 
        {
            concesionario01.Add(c);
            Console.WriteLine("Coche añadido perfectamente... Coche añadido: {0}" , c.ToString());
        }
        public void MostrarCoches() 
        {
            Console.WriteLine("Autos del Concesionario...");
            foreach (var item in concesionario01)
            {
                Console.WriteLine(item.ToString());   
            }
        }
        public void VaciarCoches() 
        {
            concesionario01.Clear();
            Console.WriteLine("Coches vaciados...");
        }
        public void EliminarCoche(Coche c) 
        {
            concesionario01.Remove(c);
            Console.WriteLine("Este coche a sido eliminado:  {0}" , c.ToString());
        }
    }
}
