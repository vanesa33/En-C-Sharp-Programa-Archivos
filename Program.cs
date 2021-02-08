using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            TextWriter archivo;

            archivo = new StreamWriter("archivo.txt");

            string mensaje;

            mensaje = Console.ReadLine();

            archivo.WriteLine(mensaje);

            archivo.Close();
            Console.Clear();

            Console.WriteLine("se ha guardado el archivo..."); */

            /*
            TextReader leer_archivo;

            leer_archivo = new StreamReader("archivo.txt");
            Console.WriteLine(leer_archivo.ReadToEnd());

            leer_archivo.Close();




            Console.ReadKey();
            */

            StreamWriter archivo = File.AppendText("archivo.txt");


            string mensaje;

            mensaje = Console.ReadLine();

            archivo.WriteLine(mensaje);

            archivo.Close();
        }
    }
}
