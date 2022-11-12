List<Persona> lst = new List<Persona>() {
    new Persona() { Edad = 40, Nombre = "Juancin" },
    new Persona() { Edad = 30, Nombre = "Pablito" },
    new Persona() { Edad = 18, Nombre = "Fernando" },
    new Persona() { Edad = 23, Nombre = "Vergotas" },
};
List<Persona> lstSoloTexto = new List<Persona>()
{   
    new Persona() { Edad = 21, Nombre = "Dieguin" },
    new Persona() { Edad = 42, Nombre = "Leito" },
    new Persona() { Edad = 23, Nombre = "Florencia" },
    new Persona() { Edad = 55, Nombre = "Boludiño" }
};
List<string> solonombres = (from i in lst
                            select i)
                           .Union(lstSoloTexto)
                           .OrderBy(i => i.Nombre)
                           .Select(i => i.EdadyNombre)
                           .ToList();
foreach (var i in solonombres) 
{
    Console.WriteLine(i);
}

public class Persona
{
    public int Edad { get; set; }
    public string Nombre { get; set; }

    public string EdadyNombre 
    {
        get 
        {
            return Edad + "-" + Nombre;
        }
    }
}
