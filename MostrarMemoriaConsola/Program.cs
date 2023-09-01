using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostrarMemoriaConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la ruta de la carpeta:");
            string selectedPath = Console.ReadLine();

            if (Directory.Exists(selectedPath))
            {
                string[] files = Directory.GetFiles(selectedPath);

                Console.WriteLine("Archivos en la carpeta:");
                foreach (string filePath in files)
                {
                    string fileName = Path.GetFileName(filePath);
                    Console.WriteLine(fileName);
                }
            }
            else
            {
                Console.WriteLine("La ruta no es válida o la carpeta no existe.");
            }
            Console.ReadKey();
        }
    }
}
