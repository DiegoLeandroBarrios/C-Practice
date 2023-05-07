using PracticaDePoo;
using System.Globalization;
using System.Text.RegularExpressions;

List<Auto> concecionario = new List<Auto>();
/*for (int i = 0; i < 4; i++)
{
    Auto auto1 = new Auto();
    auto1.Marca = "Ford";
    auto1.Motor = "1,4";
    auto1.Kilometraje = "0km";
    auto1.Modelo = "Ka";

    concecionario.Add(auto1);
}
foreach (var item in concecionario)
{
    Console.WriteLine(" Marca: {0}\n Modelo: {1}\n Motor: {2}\n Kilometraje: {3}", item.Marca, item.Modelo, item.Motor, item.Kilometraje);
}
Console.WriteLine(" Se Cargaron {0} vehiculos", concecionario.Count);*/
Auto auto4 = new Auto();
auto4.Marca = "Ferrari";
auto4.Modelo = "F40";
auto4.Kilometraje = "3000km";
auto4.Patente = "AAA144";
auto4.Motor = "V8";
auto4.AñoDelVehiculo = new DateTime(1988,8,12);
auto4.MostrarElementos();
auto4.CuantosAñosTieneElVehiculo();
Moto moto1 = new Moto
{
    Marca = "Kawasaki",
    Modelo = "Ninja400",
    Kilometraje = "3000km",
    Patente = "AD23XD",
    Motor = "400CC",
    AñoDelVehiculo = new DateTime(2022,10,13)
};
moto1.MostrarElementos();
moto1.CuantosAñosTieneElVehiculo();
concecionario.Add(auto4);
concecionario.Add(moto1);
Console.WriteLine("++++ AGREGAR VEHICULO AL CONCECIONARIO ++++");
int opcion = 0;
int salida = 0;
string nombreDelVehiculo = "";
do
{
    try
    {
        Console.WriteLine("Opciones: \n1- AGREGAR VEHICULO AL CONCECIONARIO.\n" +
        "2- SACAR VEHICULO DEL CONCECIONARIO.\n" +
        "3- MOSTRAR AUTOS QUE ESTAN EN EL CCONCECIONARIO.\n" +
        "0- SALIR DE LA APP.\n" +
        "Elegir : ");
        opcion = Convert.ToInt32(Console.ReadLine());
        switch (opcion)
        {
            case 1:
                {
                    Console.WriteLine("Elijio la Opcion 1...");
                    Auto auto2 = new Auto();
                    Console.WriteLine("Agregar Marca: ");
                    auto2.Marca = Console.ReadLine();
                    Console.WriteLine("Agregar Modelo: ");
                    auto2.Modelo = Console.ReadLine();
                    Console.WriteLine("Agregar Motor: ");
                    auto2.Motor = Console.ReadLine();
                    Console.WriteLine("Agregar kilometraje: ");
                    auto2.Kilometraje = Console.ReadLine();
                    Console.WriteLine("Agregar Patente: ");
                    auto2.Patente = Console.ReadLine();
                    Console.WriteLine("Agregar año del vehiculo: año/mes/dia.");
                    auto2.AñoDelVehiculo = Convert.ToDateTime(Console.ReadLine());
                    concecionario.Add(auto2);
                    break;
                }
            case 2:
                {
                    Console.WriteLine("Elijio la Opcion 2...");
                    do
                    {
                        Console.WriteLine("Escriba la patente del vehiculo que desea sacar: ");
                        nombreDelVehiculo = Console.ReadLine();
                        foreach (var i in concecionario)
                        {


                            if (i.Patente.ToLower() == nombreDelVehiculo.ToLower())
                            {
                                concecionario.Remove(i);
                                Console.WriteLine("Auto removido: \n");
                                i.MostrarElementos();
                                salida = 0;
                               
                            }
                            else
                            {
                                Console.WriteLine("Patente no encontrada.");
                                salida = 1;
                                
                            }
                        }
                    } while (salida == 1);

                    break;
                }
            case 3:
                {
                    Console.WriteLine("Elijio la Opcion 3...");
                    Console.WriteLine("LISTA DE AUTOS EN EL CONCECIONARIO\n");
                    foreach (var item in concecionario)
                    {
                        /*Console.WriteLine(" Marca: {0}\n Modelo: {1}\n Motor: {2}\n Kilometraje: {3}\n Patente: {4}\n Tipo: {5}\n Año del vehiculo: {6}\n Dia de ingreso: {7}\n"
                          , item.Marca, item.Modelo, item.Motor, item.Kilometraje, item.Patente, item.Tipo, item.AñoDelVehiculo ,item.DateDelVehiculo);*/
                        item.MostrarElementos();
                        item.CuantosAñosTieneElVehiculo();
                        Console.WriteLine("\n");
                    }
                    Console.WriteLine("Hay {0} vehiculos en el concecionario.", concecionario.Count);
                    break;
                }
            default: Console.WriteLine("No elijio una opcion correcta."); break;
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("\nERROR: No agrego el dato correcto.\n");
    }


} while (opcion != 0);