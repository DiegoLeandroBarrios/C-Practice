using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLab3
{
    
     class Personas
    {
        public LinkedList<Personas> listPersonas = new LinkedList<Personas> ();
        public string Name { get; set; }
        public int Legajo { get; set; }
        public int Notas { get; set; }

        public void agregar(Personas e) 
        {
           listPersonas.AddLast(e);
        }
        public void eliminar(int legajo)
        {
            foreach (Personas s in listPersonas)
            {
                if (s.Legajo == legajo)
                {
                    listPersonas.Remove(s);
                    Console.WriteLine("persona eliminada.");
                    break;
                } 
            }
        }
        public void mostrar() 
        {
            foreach(Personas s in listPersonas) 
            {
                Console.WriteLine(s.toSring());
            }
        }
        public string toSring() 
        {
            return "nombre: " + Name + " legajo: " + Legajo;
        }
    }
}
