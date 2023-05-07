using ColeccionesVarias;

namespace ColeccionesTest
{
    public class UnitTest1
    {
        [Fact]
        public void PruebaConLaColeccionStack()
        {
            
            Stack<Personas> ColeccionDePilas = new Stack<Personas>();
            for (int i = 0; i<10; i++)
            {
                Personas persona = new Personas
                {
                    Nombre = "mengano",
                    Edad = 10,
                };
                ColeccionDePilas.Push(persona);
            };

            Assert.Equal(10, ColeccionDePilas.Count());
            foreach (var item in ColeccionDePilas)
            {
                var num = 1;
                Assert.Equal(item.Id, num);
                num++;
            }
        }
    }

}