using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Escriturasarchivos2
{
    class Program
    {
        public class Trabajador
        {
           public string Nombre, Apellidos, Carrera;
           public int Edad, DNI;
           public long NumeroDecelular;

            public Trabajador(string Nombre, string Apellidos, string Carrera, int Edad, int DNI, long NumeroDecelular)
            {
                this.Nombre = Nombre;
                this.Apellidos = Apellidos;
                this.Carrera = Carrera;
                this.Edad = Edad;
                this.DNI = DNI;
                this.NumeroDecelular = NumeroDecelular;
            }
            public void Empleado()
            {
                Console.WriteLine("-------Datos del Trabajor son----------");
                Console.WriteLine("El Nombre del trabajador es: {0} ", Nombre);
                Console.WriteLine("Sus Apellidos son: {0}", Apellidos);
                Console.WriteLine("La carrera que curso es: {0} ", Carrera);
                Console.WriteLine("Su edad es: {0}", Edad);
                Console.WriteLine("Su DNI es: {0}", DNI);
                Console.WriteLine("Su numero celular es: {0}", NumeroDecelular);
            }
        }

        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("ejemplo.txt", true);

            string Nombre, Apellidos, Carrera;
            int Edad, DNI;
            long NumeroDecelular;

            Console.WriteLine("Poner sus siguientes datos: ");
            Console.Write("Ingrese su nombre: ");
            Nombre = Console.ReadLine();
            Console.Write("Ingrese sus apellidos, iniciando con el paterno: ");
            Apellidos = Console.ReadLine();
            Console.Write("Ingrese la carrera que ingreso: ");
            Carrera = Console.ReadLine();
            Console.Write("Ingrese su edad: ");
            Edad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese su DNI: ");
            DNI = int.Parse(Console.ReadLine());
            Console.Write("Ingrese su numero de celular: ");
            NumeroDecelular = long.Parse(Console.ReadLine());

            Console.Clear();

            Trabajador trabajador = new Trabajador(Nombre, Apellidos, Carrera, Edad, DNI, NumeroDecelular);
            trabajador.Empleado();

            sw.WriteLine("Empleado: "+ trabajador.Nombre+ " "+ trabajador.Apellidos +  "Carrera: "+ trabajador.Carrera+ "Edad y DNI: "+ trabajador.Edad, " "+ trabajador.DNI+ "Numero del cel: "+ trabajador.NumeroDecelular);
            sw.Close();
            Console.WriteLine("Presiona ENTER para continuar...");
            Console.ReadKey();

        }
    }
}
