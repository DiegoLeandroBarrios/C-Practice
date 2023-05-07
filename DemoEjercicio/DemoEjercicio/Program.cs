using DemoEjercicio;
using System.Security.Cryptography;

var coleccionDeAlumnos = new List<Alumno>();
for (int i = 0; i < 100000; i++)
{
    Alumno pj = new Alumno();
    pj.Nombre = i;
    pj.Apellido = i.ToString();
    pj.Legajo = i;
    coleccionDeAlumnos.Add(pj);
}
/*foreach (var item in coleccionDeAlumnos)
{
    Console.WriteLine("nombre: {0} , apellido: {1} , legajo: {2}", item.Nombre, item.Apellido, item.Legajo);
}*/
var separarAlumnos = (from e in coleccionDeAlumnos
                      where e.Apellido.EndsWith("11")
                      select e).ToList().Count();

Console.WriteLine("lista de alumnos con apellido 11 al final son: {0}",separarAlumnos);
