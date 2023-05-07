// See https://aka.ms/new-console-template for more information
using PracticaPooEjer1;

Console.WriteLine("Hello, World!");
Coche coche1 = new Coche(1, "ford", "ka", "70000km", 300000);
Console.WriteLine(coche1.ToString());
Concesionario concesionario = new Concesionario();
concesionario.AñadirCoches(coche1);
concesionario.MostrarCoches();
Coche coche2 = new Coche(1, "Kia", "Centro", "23000km", 500000);
concesionario.AñadirCoches(coche2);
concesionario.MostrarCoches();
concesionario.EliminarCoche(coche1);
Coche coche3 = new Coche(1, "Nissan", "Centra", "87000km", 420000);
concesionario.AñadirCoches(coche3);
concesionario.MostrarCoches();
concesionario.VaciarCoches();
Aleatorios aleatorios = new Aleatorios();
aleatorios.GenerarUnNumeroEntreDos();
aleatorios.GenerarUnArrayDeNumerosEntreDosNumeros();

