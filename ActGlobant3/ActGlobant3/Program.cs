//Ejemplos de LINQ
/*Ejercicio 3. (SP 3)
Crear una nueva solución que resuelva el ejercicio de pseudocódigo del ingreso, solo que además va a tener que contemplar lo siguiente:
-Implementar una clase que tenga los siguientes métodos: 
	*Que genere 1000 números al azar (entre -100 y 100) y los guarde en una colección.
	* Que devuelva mediante LINQ la cantidad de números positivos.
	* Que devuelva mediante LINQ la cantidad de veces que aparece el número 0.
	* Que devuelva mediante LINQ la suma de los números negativos
	* Que devuelva mediante LINQ el número que se aparece más veces.
Crear una app de consola que cree una instancia de esta clase y llame a cada uno de estos métodos, mostrando en pantalla el resultado de los mismos*/
using ActGlobant3;

Ejr3 ejercicio1 = new Ejr3();
ejercicio1.Generar();
Console.WriteLine("La cantidad de los numero positivos es: " + ejercicio1.NumerosPositivos());
Console.WriteLine("La cantidad de numeros nulos son: " + ejercicio1.NumerosNulos());
Console.WriteLine("rumeros repetido: " + ejercicio1.Repeated());
Console.WriteLine("Sumatoria de Numeros negativos: " + ejercicio1.SumaNegativa());
