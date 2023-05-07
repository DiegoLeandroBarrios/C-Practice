
var numero = 5;
void PorValor(int valor) 
{
    valor++;
    Console.WriteLine("Retorna el valor sumado en la función : {0}", valor);
}
PorValor(numero);
Console.WriteLine("{0} , El valor de la variable sigue sindo el mismo, solo cambia en la funcion o metodo.",numero);

void PorReferencia(ref int referencia)
{
    referencia++;
    Console.WriteLine("El valor de la variable cambia dentro del metodo: " + referencia);
}

 int numref = 5;
 PorReferencia(ref numref);
 Console.WriteLine("{0} , En este caso como es por referencia cambia el valor de la variable cuando sale del metodo." , numref);
 
