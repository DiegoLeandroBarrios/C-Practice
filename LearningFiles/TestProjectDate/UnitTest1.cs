namespace TestProjectDate
{
    public class UnitTest1
    {
        [Fact]
        public void VerSiEsLaHoraCorrecta()
        {
            DateTime HoraDeAhora = DateTime.Now;
            DateTime cumpleaños = new DateTime(2001, 8, 16);
            string nuevoNombreDelArchivo = "ArchivoDiferente.txt";
            string nuevaCarpetaDehorasDir = "DirectorioDeHoras";
            Directory.CreateDirectory(nuevaCarpetaDehorasDir);
            string rutaNueva = Path.Combine(nuevaCarpetaDehorasDir, nuevoNombreDelArchivo);
            TimeSpan Edad = HoraDeAhora - cumpleaños;
            StreamWriter sw3 = new StreamWriter(rutaNueva);
            sw3.WriteLine("edad de dieguito : " + ((int)Edad.Days) / 365);
            sw3.Close();

            Assert.NotNull(sw3);
        }
        [Fact]
        public void HagregarUnArchivoConStreamWriter()
        {
            StreamWriter sw = new StreamWriter("datosEnStreamWriter.txt", false);//Si se establece en true, el archivo se abre en modo de agregación y cualquier texto que se escriba se agregará al final del archivo existente, en lugar de sobrescribir el contenido anterior del archivo.
            sw.WriteLine("DATO AGREGADO AL ARCHIVITO.");
            sw.Close();
            Assert.NotNull(sw);
            StreamReader rd = new StreamReader("datosEnStreamWriter.txt");
            var contenido = rd.ReadLine();
            Assert.Equal("DATO AGREGADO AL ARCHIVITO.", contenido );
            Assert.True(true);
        }
        [Fact]
        public void EscribitUnArchivoAppendAllText()
        {
            File.AppendAllText(path: "demo-2.txt", "Otro Archivo");


            Assert.True(true);
        }
    }
}