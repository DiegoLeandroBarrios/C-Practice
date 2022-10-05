using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Auto
    {
        public int Id { get; set; }
        public string Marca{ get; set; }
        public int Km { get; set; }
        public int Precio { get; set; }

        public Auto(int id,string marca,int km, int precio) 
        {
            this.Id = id;
            this.Marca = marca;
            this.Km = km;
            this.Precio = precio;
        }
        public string toString()
        { return "Id: " + Id + " Marca: " + Marca + " Km: " + Km + " Precio: " + Precio; }
    }
}
