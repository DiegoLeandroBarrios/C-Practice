//LINQ

Complejo[] lst =
{
    new Complejo(1, "patito"),
    new Complejo(9, "angelito"),
    new Complejo(4, "perro"),
    new Complejo(88, "cerdito"),
    new Complejo(2, "chamaquitop"),
};
var lista = (from i in lst
             orderby i.Numero
             select i);

foreach (var i in lista) 
{
    Console.WriteLine(i.Imprime());
}
public class Complejo 
{
    public int Numero { get; set; }
    public string Cadena { get; set; }

    public Complejo(int numero, string cadena)
    {
        this.Numero = numero;
        this.Cadena = cadena;
    }
    public string Imprime() 
    {
        return Numero + " " + Cadena;
    }
}