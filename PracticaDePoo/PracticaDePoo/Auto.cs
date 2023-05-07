using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDePoo
{
    public class Auto : Acciones
    {
        public DateTime DateDelVehiculo = DateTime.Now;
        public DateTime AñoDelVehiculo{ get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Motor { get; set; }
        public string Kilometraje { get; set; }
        public string Patente { get; set; }
        public string Tipo { get; set; }
      

        public Auto(string marca, string motor, string kilometraje, string modelo, string patente, DateTime añoDelVehiculo)
        {
            Marca = marca;
            Motor = motor;
            Kilometraje = kilometraje;
            Modelo = modelo;
            Patente = patente;
            AñoDelVehiculo = añoDelVehiculo;
        }
        public Auto()
        {
            Tipo = "Auto";
            DateDelVehiculo.ToString();
        }
        public void MostrarElementos()
        {
            Console.WriteLine(" Marca: {0}\n Modelo: {1}\n Motor: {2}\n Kilometraje: {3}\n Patente: {4}\n Tipo: {5}\n Año del vehiculo: {6}\n Hora de ingreso: {7}\n"
                          , Marca, Modelo, Motor, Kilometraje, Patente, Tipo , AñoDelVehiculo ,DateDelVehiculo);
        }
        public void CuantosAñosTieneElVehiculo()
        {
            TimeSpan diferencia = DateDelVehiculo - AñoDelVehiculo;
            Console.WriteLine("Años del vehiculo hasta el presente: {0} años de vida.", ((int)diferencia.TotalDays) / 365);
        }
        


    }
}
