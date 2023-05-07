// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography;

Stack<int> stack = new Stack<int>();
Console.WriteLine("----AGREGANDO ELEMENTOS TIPO ENTEROS DE LA PILA----");
for (int i = 1; i < 11; i++) 
{
    stack.Push(i);
    Console.WriteLine("Elemtos agregados: {0}" , i);
}
Console.WriteLine("----ELEMENTOS DE LA PILA----");
foreach (var item in stack)
{
    Console.WriteLine("Muestro los elementos de la coleccion de pila: {0}" , item);
}
Console.WriteLine("SUMA CON LINQ...");
var elementosSumadosDeLaPila = (from i in stack
                               select i).Sum();
var elementosParesDeLaPila = (from i in stack
                              where i % 2 == 0
                              select i).ToList();
var losQueTerminanEn4 = (from i in stack
                         where i.ToString().EndsWith("4")
                         select i).ToList().Count();
Console.WriteLine("SUMA DE LOS NUMEROS DE LA LISTA DE ENTEROS: {0}", elementosSumadosDeLaPila);
Console.WriteLine("PARES CON LINQ...");
Console.WriteLine("NUMEROS PARES DE LA LISTA DE ENTEROS: {0}", elementosParesDeLaPila.Count);
foreach (var item in elementosParesDeLaPila)
{
    Console.WriteLine("Pares de los numeros de la lista de enteros: {0}", item);
}
Console.WriteLine("CANTIDAD DE NUMEROS QUE TERMINAN EN 4: {0}", losQueTerminanEn4);
Console.WriteLine("----ELEMENTOS SACADOS DE LA PILA----");
for (int i = 1; i < 11; i++)
{
    var sacar = 0;
    stack.TryPop(out sacar);
    Console.WriteLine("elementos sacados de la pila: {0}" , sacar);
}
Console.WriteLine("----TERMINO----");


