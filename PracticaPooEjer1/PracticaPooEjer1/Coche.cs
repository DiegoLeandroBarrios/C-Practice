using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPooEjer1
{
    public class Coche
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string KM { get; set; }
        public int Precio { get; set; }

        public Coche(int id , string marca , string modelo , string km , int precio)
        {
            Id = id;
            Marca = marca;
            Modelo = modelo;
            KM = km;
            Precio = precio;
        }
        public override string ToString() 
        {
            return "Marca: " + Marca + ", Modelo: " + Modelo + ", Con un precio de " + Precio;
        }
    }
}
