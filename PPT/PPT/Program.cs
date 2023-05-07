// See https://aka.ms/new-console-template for more information
/*hacer que me muestre por pantalla un juego*/
using PPT;
using System.ComponentModel;

var tijera = new Tijera();
var piedra = new Piedra();
var papel = new Papel();
Random ramdom= new Random();
int elegir;
List<Metodos> elegirList = new List<Metodos>();
elegirList.Add(piedra);
elegirList.Add(papel);
elegirList.Add(tijera);
int juegoRamdom = ramdom.Next(elegirList.Count);
int contadorGanadas = 0;
int contadorPerdidas = 0;
try
{
    do
    {
        Console.WriteLine("---Introduzca numero--- " +
            "\n 1- si quieres elegir piedra." +
            "\n 2- si quieres elegir papel." +
            "\n 3- si quieres elejir tijera. " +
            "\n 0- salir del juego." +
            "\n Elije una ocpión");
        elegir = Convert.ToInt32(Console.ReadLine());
        switch (elegir)
        {
            case 1:
                {
                    var resultado = elegirList[juegoRamdom];
                    Console.WriteLine("Elegiste piedra." +
                        "\nLa pc eligio {0}\n", resultado.Tipo);
                    var result = "";
                    if (resultado.Tipo == "piedra")
                    {
                        result = "empata";

                    }
                    else if (resultado.Tipo == "tijera")
                    {
                        result = "ganaste.";
                        contadorGanadas++;
                    }
                    else
                    {
                        result = "perdiste.";
                        contadorPerdidas++;
                    }
                    Console.WriteLine("{0}\n Ganadas: {1}\n Perdidas: {2}\n", result, contadorGanadas, contadorPerdidas);
                    Console.WriteLine("Siga jugando...");

                }
                break;
            case 2:
                {
                    var resultado = elegirList[juegoRamdom];
                    Console.WriteLine("Elegiste papel." +
                        "\nLa pc eligio {0}\n", resultado.Tipo);
                    var result = "";
                    if (resultado.Tipo == "piedra")
                    {
                        result = "ganaste.";
                        contadorGanadas++;
                    }
                    else if (resultado.Tipo == "tijera")
                    {
                        result = "perdiste.";
                        contadorPerdidas++;
                    }
                    else
                    {
                        result = "empate";
                    }
                    Console.WriteLine("{0}\n Ganadas: {1}\n Perdidas: {2}\n", result, contadorGanadas, contadorPerdidas);
                    Console.WriteLine("Siga jugando...");
                }
                break;
            case 3:
                {
                    var resultado = elegirList[juegoRamdom];
                    Console.WriteLine("Elegiste tijera." +
                        "\nLa pc eligio {0}\n", resultado.Tipo);
                    var result = "";
                    if (resultado.Tipo == "piedra")
                    {
                        result = "perdiste.";
                        contadorPerdidas++;
                    }
                    else if (resultado.Tipo == "tijera")
                    {
                        result = "empate.";
                    }
                    else
                    {
                        result = "ganaste";
                        contadorGanadas++;
                    }
                    Console.WriteLine("{0}\n Ganadas: {1}\n Perdidas: {2}\n", result, contadorGanadas, contadorPerdidas);
                    Console.WriteLine("Siga jugando...");
                }
                break;
            case 0:
                Console.WriteLine("Juego terminado.\n" +
                "\n Ganadas: {0}\n Perdidas: {1}\n", contadorGanadas, contadorPerdidas);
                Console.WriteLine("Gracias por jugar..."); break;
            default: Console.WriteLine("no elejiste ninguna opcion"); break;

        }

    } while (elegir != 0);
}
catch (Exception e)
{
    Console.WriteLine("Error... pusiste un formato incorrecto. :) ");
}
//poner el metodo para optimizar el swicht.
//Console.WriteLine("tijera vs piedra: {0}", tijera.MetodoParaJugar(piedra));
//Console.WriteLine("tijera vs papel: {0}", tijera.MetodoParaJugar(papel));
//Console.WriteLine("tijera vs tijera: {0}", tijera.MetodoParaJugar(tijera));
//Console.WriteLine("piedra vs tijera: {0}", piedra.MetodoParaJugar(tijera));
//Console.WriteLine("piedra vs papel: {0}", piedra.MetodoParaJugar(papel));