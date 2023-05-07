using System.Security.Cryptography.X509Certificates;
using System.Globalization;
namespace FileManager.Tests
{
    public class DirectoriUnitTest
    {
        /*[Fact]
        public void CrearUnArhivo()
        {
            var writer = new System.IO.StreamWriter(
                                        path:"demo.txt",
                                        append:false);//creamos y abrimos la coneccion al archivo.
            writer.Write("Demo demo");
            
            writer.Close();

            Assert.True(true);
        }

        [Fact]
        public void LeerUnArchivo()
        {
            var reader = new System.IO.StreamReader(
                                        path: "demo.txt");//creamos y abrimos la coneccion al archivo.
            var contenido = reader.ReadToEnd();

            reader.Close();

            Assert.Equal("Demo demo", contenido);

            Assert.True(true);
        }*/
        [Fact]
        public void CrearDirectorioConFechas()
        {
            var fecha = new DateTime();
            Directory.CreateDirectory("Fecha");
            var f = new DirectoryInfo("Fecha");

            f.CreateSubdirectory($"{fecha.ToLongDateString()}");

            Assert.NotNull(f);
        }

    }
}