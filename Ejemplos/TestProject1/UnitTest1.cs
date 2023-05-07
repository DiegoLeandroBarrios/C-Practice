using ConsoleApp3;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void ListaAdd()
        {
            var alumnos = new List<Alumno>();

            alumnos.Add(new Alumno("Maria"));

            var juan = new Alumno();
            juan.Nombre = "Juan";

            var renata = new Alumno();
            renata.Nombre = "Renata";

            alumnos.Add(juan);
            alumnos.Add(renata);

            Assert.NotNull(alumnos);
            Assert.Equal(alumnos.Count, 3);
            Assert.Equal("Juan", alumnos[1].Nombre);
            Assert.Equal("Maria", alumnos.First().Nombre);
            Assert.Equal("Renata", alumnos[2].Nombre);
        }
        [Fact]
        public void ListaAdd001()
        {
            var alumnos = new List<Alumno>();

            for (int i = 0; i < 1000; i++)
            {
                alumnos.Add(new Alumno($"Alumno {i}"));//es solamente de referencia.
            }

            Assert.NotNull(alumnos);            
        }
        [Theory]
        [InlineData(1000, "Demo")]
        [InlineData(10000, "Alumno")]
        [InlineData(100000, "Otro")]
        [InlineData(99999, "Otro")]
        public void ListaAdd2(int cantidad, string nombreAlumno)
        {
            var alumnos = new List<Alumno>();
            
            //if (cantidad == 99999)
            //{
            //    throw new ArgumentException("Error basico");
            //}

            for (int i = 0; i < cantidad; i++)
            {
                alumnos.Add(new Alumno($"{nombreAlumno} {i}"));
            }

            Assert.NotNull(alumnos);
            Assert.Equal(cantidad, alumnos.Count);
        }
        public void ObtenerAlumnosConEdadPar()
        {
            var alumnos = new List<Alumno>();

            for (int i = 0; i < 1000; i++)
            {
                alumnos.Add(new Alumno($"Alumno {i}")
                {
                    Edad = i
                });
            }
            var alumnosConEdadPar = from a in alumnos
                                    where a.Edad %2 == 0
                                    select a;
            
            /*var alumnosConEdadpar2 = alumnos
                                        .Where(x => x.Edad == 100)//lo mismo de arriba pero de otra forma.
                                        .Select(x => x);*/

            Assert.NotNull(alumnos);
            Assert.Equal(1000, alumnos.Count);
            Assert.Equal(1, alumnosConEdadPar.Count());
        }
    }
}