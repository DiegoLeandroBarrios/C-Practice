// See https://aka.ms/new-console-template for more information
/*5. Crea una clase Ordenador con los siguientes atributos:

– tamanio disco (GB)
– tamanio disco max (GB)
– encendido

Los metodos a añadir son:

– aniadirDatos(int datos): añade informacion al disco duro, si supera el maximo del tamaño del disco, el tamanio del disco sera el maximo posible. Solo si esta encendido el ordenador.
– eliminarDatos(int datos): elimina informacion al disco duro, si el tamaño del disco es menor que 0, el tamanio del disco se quedara a 0. Solo si esta encendido el ordenador.
– encender(): enciende el ordenador.
– apagar(): apaga el ordenador.

— Ordenador*/
using PracticaPooEjer2;

Console.WriteLine("Hello, World!");
Ordenador ordenador = new Ordenador();
Ordenador ordenador2 = new Ordenador();
ordenador.Encencender();
ordenador.AniadirDatos(4000);
ordenador.Apagar();
ordenador.AniadirDatos(4000);
ordenador.Encencender();
ordenador.AniadirDatos(2800);
ordenador.EliminarDatos(2700);
