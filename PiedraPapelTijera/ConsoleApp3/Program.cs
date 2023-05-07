// See https://aka.ms/new-console-template for more information
using ConsoleApp3;
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");
var tijera = new Tijera();
var piedra = new Piedra();

Console.WriteLine("{0} {1} contra {2}",piedra.Tipo ,tijera.ResultadoContra(piedra),tijera.Tipo);//en ResultadoContra esta invertido, toma la clase
                                                                                                //que esta dentro del metodo o sea piedra gana a tijera.
