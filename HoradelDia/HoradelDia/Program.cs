using HoradelDia;
Boolean limite = true;
NyF loteria1 = new NyF();
Console.WriteLine("***** JUEGO DEL SUPERMERCADITOCHINO *****");
Console.WriteLine("EL JUEGO ES DECIR 5 NUMEROS DEL 0 AL 50 Y SI ACERTAS 1 TE LLEVAS EL 10% , SI ACERTAS 2 SEGUIDOS EL 20% , EL 3 SEGUIDOS EL 30%, EL 4 SEGUIDOS EL 50%" +
    " Y SI ACERTAS 5 SEGUIDAS TENES 100% DE DESCUENTOS, A JUGAR.\n");
Random random = new Random();
int[] numerosRandoms = new int[5];//creo arrays para que almacenen numeros enteros
int[] numeroElegir = new int[5];  
int cont = 0;
Console.WriteLine("Elija 5 numeros del 0 al 50: ");//le pido que me pasen los numeros por consola
for(int i = 0; i<5; i++) //itero el arreglo para ir cargando uno por uno
{
    if (i >= 1) { Console.WriteLine("Cargue el siguiente numero: "); }
    do
    {
        numeroElegir[i] = Convert.ToInt32(Console.ReadLine());
        if (numeroElegir[i] < 0 || numeroElegir[i] > 50) //pregunta si los numeros que pasa el usaurio son de 0 a 50
        {
            Console.WriteLine("Ingrese un valor valido entre 0 y 50.");
        }else limite = false;//si se cumple deja el bucle
    } while (limite);
    
}
Console.WriteLine("Hora de Emisión: " + loteria1.fechasActual.ToString("f"));
Console.WriteLine("Numeros elejidos son.");   
for (int i = 0; i < 5; i++) //recorre el arreglo para imprimirlo
{
    Console.WriteLine(numeroElegir[i]);
}
Console.WriteLine("Numeros Randoms son.");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(loteria1.arregloRandom[i]);
}
for (int i = 0; i < 5; i++)
{
    for(int j =0; j < 5; j++) 
    {
        if (loteria1.arregloRandom[i] == numeroElegir[j]) 
        {
            Console.WriteLine($"Acertaste {loteria1.arregloRandom[i]} con {numeroElegir[j]}");
            cont++;
        }
    }
}
/*
for (int i = 0; i < 5; i++)// iterando, guarda 5 numeros randoms en un arreglo
{
    numerosRandoms[i] = random.Next(51);
    for (int j = 0; j < 5; j++)//itera dos posiciones del arreglo
    {
        if (numerosRandoms[i] == numerosRandoms[j]) //verifica si los numeros del arreglo son iguales
        {
            numerosRandoms[i] = random.Next(51);// si son iguales los cambia, pisa el valor para cambiarlo 
        }
    }
    Console.WriteLine(numerosRandoms[i]);//imprime los numeros randoms
}*/
/*
for (int i = 0; i < 5; i++)//recorre el arreglo de los numeros randoms
{
    for(int j = 0; j < 5; j++)//recorre el arreglo de los numeros ingresados en consola
    {
        if (numerosRandoms[i] == numeroElegir[j])//verifica si son iguales
        {
            Console.WriteLine($"Acertaste {numerosRandoms[i]} con {numeroElegir[j]}");
            cont++;//si son iguales me suma al contador 1 cada vez que itera.

        }
    }

}
*/
Console.WriteLine("Fallaste: " + (5 - cont));//muestra las veces que fallaste
switch (cont)
{
    case 0: Console.WriteLine("No tiene premio");break;
    case 1: Console.WriteLine("10% off en la siguiente compra "); break;
    case 2: Console.WriteLine("20% off en la siguiente compra"); break;
    case 3: Console.WriteLine("30% off en la siguiente compra"); break;
    case 4: Console.WriteLine("50% off en la siguiente compra"); break;
    case 5: Console.WriteLine("100% off en la siguiente compra (gratis)");break;
}
if(cont > 0 ) Console.WriteLine("Tiene canje hasta 30 Dias. Hasta de " + loteria1.fechasActual.AddDays(30).ToString("f"));//le suma 30 dias a fechaActual.



