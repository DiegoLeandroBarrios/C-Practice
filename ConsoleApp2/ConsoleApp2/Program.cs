using ConsoleApp2;
Auto auto1 = new Auto(230405, "Volskwagen", 12000, 30000);
Auto auto3 = new Auto(230402, "Ford", 19000, 40000);
Auto auto2 = new Auto(230406, "Chevrolet", 40000, 38000);
Auto auto4 = new Auto(230401, "PEPA", 40000, 38000);
Auto auto5 = new Auto(230423, "CACA", 40000, 38000);
Concecionario concecionario1 = new Concecionario();
concecionario1.añadirAuto(auto1);
concecionario1.añadirAuto(auto2);
concecionario1.añadirAuto(auto3);
concecionario1.añadirAuto(auto4);
concecionario1.añadirAuto(auto5);
concecionario1.mostrarAutos();
concecionario1.eliminarAuto(230402);
Console.WriteLine("Muestro los autos de nuevo.");
concecionario1.mostrarAutos();