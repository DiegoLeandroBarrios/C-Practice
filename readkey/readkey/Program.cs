bool salir = true;

Console.WriteLine("Ingrese un texto por favor");
string texto = Console.ReadLine();
Console.WriteLine("1- Texto en mayúscula");
Console.WriteLine("2- Texto en minúscula");
Console.WriteLine("3- Texto Original");
Console.WriteLine("Esc- salir");
do
{ 

    if (Console.KeyAvailable)
    {
            ConsoleKeyInfo opcion = Console.ReadKey(true);
            if (opcion.Key == ConsoleKey.D1) Console.WriteLine($"{texto.ToUpper()}");
            if (opcion.Key == ConsoleKey.D2) Console.WriteLine($"{texto.ToLower()}");
            if (opcion.Key == ConsoleKey.D3) Console.WriteLine($"{texto}");
            if (opcion.Key == ConsoleKey.Escape) salir = false;
    }


  


} while (salir);