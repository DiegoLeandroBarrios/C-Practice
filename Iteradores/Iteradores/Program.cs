/* 
    Calcular la media y la desviación estándar de un conjunto de 10 personas.
    Tome por teclado la altura en cm de cada persona y cárguela en un arreglo.
    Presente los resultados obtenidos.
    Muestre qué alturas se encuentran por encima de la media y por debajo de ella.
    Muestre qué alturas se encuentran dentro del rango definido por la desviación estándar.
 */

Console.WriteLine("----CALCULAR LA MEDIA Y LA DESVIACION ESTANDAR----\n\n");
Console.WriteLine("----PIDIENDO ALTURA EN CM----");
int[] variable = new int[10];
int total = 0;
int numeroactual = 0;
double varianza = 0;
int desviacionEstandar = 0;

for (int i = 0; i < 10; i++)  //Se ingresan las alturas de los alumnos 
{
    Console.WriteLine("ingrese altura de alumnos:");
    variable[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Datos Completos.");
int n = 0;

foreach (int i in variable)   //se muestran los datos 
{
    Console.WriteLine($"Persona: {n}, altura:{i} Cm.\n");
    n++;
}
for (int i = 0; i < 10; i++)  //sumo todas las alturas para calcular la media
{
    numeroactual = variable[i];
    total += numeroactual;
}

int media = total / 10;
Console.WriteLine($"el calculo de la media es: {media} \n");

for (int i = 0; i < 10; i++) //se muestran alturas por encima y por debajo de la media  
{
    if (media < variable[i])
    {
        Console.WriteLine($"La altura {variable[i]} CM se encuentra por ENCIMA de la media\n");
    }
    else
    {
        Console.WriteLine($"La altura {variable[i]} CM se encuentra por DEBAJO de la media\n");
    }
}

for (int i = 0; i < 10; i++) //metodo para calcular la varianza
{
    int numeroActual = variable[i];
    int resultado = numeroActual - media;
    double cuadrado = Math.Pow(resultado, 2);
    varianza += cuadrado;
}

desviacionEstandar = (int)Math.Round(Math.Sqrt(varianza)); //calculo de desviacion media
Console.WriteLine($"La desviacion estandar es {desviacionEstandar}Cm");
int rangoInf = media - desviacionEstandar;
int rangoSup = media + desviacionEstandar;
Console.WriteLine($"Rango Inferior {rangoInf}Cm");
Console.WriteLine($"Rango Superior {rangoSup}Cm");
Console.WriteLine("ALTURAS DENTRO DEL RANGO DEFINIDO POR LA DESVIACION ESTANDAR");
for (int i = 0; i < 10; i++)  //lista alturas dentro del rango
{
    int num = variable[i];
    if (num >= rangoInf && num <= rangoSup)
    {
        Console.WriteLine($"{num}Cm");
    }
}




