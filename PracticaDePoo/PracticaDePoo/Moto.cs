using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDePoo
{
    public class Moto : Auto 
    {
        public string Tipo { get; set; }
        public Moto()
        {
            Tipo = "Moto";
            DateDelVehiculo.ToString();
        }
        public void MostrarElementos()
        {
            Console.WriteLine(" Marca: {0}\n Modelo: {1}\n Motor: {2}\n Kilometraje: {3}\n Patente: {4}\n Tipo: {5}\n Año del vehiculo: {6}\n Hora de ingreso: {7}\n"
                          , Marca, Modelo, Motor, Kilometraje, Patente, Tipo ,AñoDelVehiculo ,DateDelVehiculo);
        }
        public void CuantosAñosTieneElVehiculo()
        {
            TimeSpan diferencia = DateDelVehiculo - AñoDelVehiculo;
            Console.WriteLine("Años del vehiculo hasta el presente: {0} años de vida.", ((int)diferencia.TotalDays) / 365);
        }
    }
}
