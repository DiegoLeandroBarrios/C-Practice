/*Desarrolle una aplicación en C#, que implemente los siguientes casos de uso.

El personal de alumnado podra dar de alta de alumnos y profesores a materias.
El profesor podra agregar entregas y exámenes a las materias y registrar las notas de los alumnos.
El profesor podra tomar asistencia, el mismo pondra la asistencia de los alumnos en cada materia*/
using TpLab3;

string nombre;
int cont = 0;
bool salir = true;
Personas alumnos = new Personas();
Personas profesores = new Personas();
Profesor profesor;
Alumno alumno;



do
{
    int respuesta;
    Console.WriteLine("Que desea hacer: ");
    Console.WriteLine("1 agregar un alumno");
    Console.WriteLine("2 agregar un profesor.");
    Console.WriteLine("3 salir");
    respuesta = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\n\n\n");

    switch (respuesta)
    {
        case 1:
            cont++;
            Console.WriteLine("Ingrese un apellido y nombre: ");
            nombre = Console.ReadLine();
            alumno = new Alumno(nombre, cont);
            alumnos.agregar(alumno);
            alumnos.mostrar();
            Console.WriteLine("\n\n\n");
            break;
        case 2:
            cont++;
            Console.WriteLine("Ingrese un apellido y nombre: ");
            nombre = Console.ReadLine();
            profesor = new Profesor(nombre, cont);
            profesores.agregar(profesor);
            profesores.mostrar();
            Console.WriteLine("\n\n\n");
            break;
        case 3:
            salir = false;
            break;
        default:
            Console.WriteLine("Ingresaste un valor incorrecto.");
            break;
    }
} while (salir);



