using System.Security.Cryptography.X509Certificates;

namespace FileManager.Tests
{
    public class UnitTest1
    {
        [Fact]
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
        }
    }
}