using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EscriturasArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("ejemplo.txt", true);
            //si el archivo no existe lo creará el elemento
            //si ya existe, escribira en el 

            string[] lines = new string[3];
                {
                Console.WriteLine("Cual es el nombre del usuario?: ");
                lines[0] = Console.ReadLine();
                Console.WriteLine("Cual es la edad?: ");
                lines[1] = Console.ReadLine();
                Console.WriteLine("Cual es su genero?: ");
                lines[2] = Console.ReadLine();
            };

            foreach (string line in lines)
            {
                sw.WriteLine(line);
            }
            sw.Close();  //se debe cerrar el archivo

            Console.WriteLine("Escribiendo en el archivo.....");
            Console.ReadLine();
        }
    }
}
