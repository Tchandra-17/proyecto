using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Elija una opción");
                Console.WriteLine("1.- Agregar personal médico");
                Console.WriteLine("2.- Buscar personal médico");
                Console.WriteLine("3.- Ejercicio 3");
                Console.WriteLine("4.- Ejercicio 4");
                Console.WriteLine("5.- Ejercicio 5");
                Console.WriteLine("6.- Ejercicio 6");
                Console.WriteLine("7.- Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Personal ma = new Personal();
                        ma.PersonalHospital();

                        break;
                    case 2:
                        Console.Clear();

                        break;
                    case 3:
                        Console.Clear();

                        break;
                    case 4:
                        Console.Clear();

                        break;
                    case 5:
                        Console.Clear();

                        break;
                    case 6:
                        Console.Clear();

                        break;
                    case 7:
                        Console.WriteLine("SALIR");
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("OPCIÓN NO VÁLIDA");
                        Console.WriteLine("Pulse una tecla para elegir de nuevo");
                        Console.ReadLine();
                        break;
                }

            } while (opcion == 1 || opcion == 2 || opcion == 3 || opcion == 4 || opcion == 5 || opcion == 6 || opcion != 7);
            Console.Clear();
            Console.WriteLine();

            if (opcion == 7)
            {
                Console.WriteLine("Pulse una tecla para salir del programa");
            }
            Console.ReadKey();
        }
    }
}
