using DemoEjercicio;

namespace TestDemoEjercicio
{
    public class UnitTest1
    {
        [Fact]
        public void FiltrarApellidos()
        {
            var coleccionDeAlumnos = new List<Alumno>();
            for (int i = 0; i < 100000; i++)
            {
                Alumno pj = new Alumno();
                pj.Nombre = i;
                pj.Apellido = i.ToString();
                pj.Legajo = i;
                coleccionDeAlumnos.Add(pj);
            }
            var separarAlumnos = (from e in coleccionDeAlumnos
                                  where e.Apellido.EndsWith("11")
                                  select e).ToList().Count();

            Assert.Equal(1000, separarAlumnos);
        }
    }
}