
Console.WriteLine("Hello, World!");
string nombreDelArchivo = "miPrimerArchivo.txt";//nombre del archivo
string rutaDelArchivo = Path.Combine(Directory.GetCurrentDirectory(), nombreDelArchivo);//la ruta del archivo se guarda 
string textoDelArchivo = "EMPEZANDO CON ARCHIVOS..."; 
File.WriteAllText(rutaDelArchivo, textoDelArchivo);//escribe lo que esta en textoarchivo en la ruta donde se guarda
string NuevaCarpeta = "NuevaCarpeta";
Directory.CreateDirectory(NuevaCarpeta);//se crea un directorio o sea una carpetacontenedora
string ElementoUnoDelDirectorio = "primerArchivoEnElDirectorio.txt";//se crea el archivo en este caso .txt
rutaDelArchivo = Path.Combine(NuevaCarpeta, ElementoUnoDelDirectorio);//se añade a la direccion del directorio "nuevacarpeta"
textoDelArchivo = "PRIMER ARCHIVO DE LA CARPETITA...";//se escribe el texto que va en el archivo.txt
File.WriteAllText(rutaDelArchivo, textoDelArchivo);//se guarda en la ruta
for (int i = 1; i < 5; i++)//usamos un for para crear 5 archivos en el directorio NuevaCarpeta
{
    nombreDelArchivo = $"archivoNumero{i}.txt";//el nombre de cada archivo
    rutaDelArchivo = Path.Combine(NuevaCarpeta, nombreDelArchivo);//ruta donde se guarda el archivo
    textoDelArchivo = "CREANDO ARCHIVOS CON UN FOR ESTE ES EL : " + i.ToString();//contenido de cada archivo.txt
    File.WriteAllText(rutaDelArchivo, textoDelArchivo);//se guarda el contenido en la ruta.
}