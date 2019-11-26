using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    class Personal
    {
        private string[] personal;
        private string[,] datos;

        public void AgregarPersonal()
        {
            int i = 0;
            personal = new string[100];
            datos = new string[1, 10];
            Console.WriteLine("¿Cuantas personas desea agregar?");
            int n;
            n = int.Parse(Console.ReadLine());
            Personal.CantidadDoctores(+n);
            int c = 0;
            c = Personal.CantidadDoctores();
            if (c < 100)
            {
                for (i = 0; i < n; i++)
                {
                    Console.WriteLine("Ingrese el nombre completo del empleado");
                    personal[i] = Console.ReadLine();
                    for (int j = 0; j < n; j++)
                    {
                        Console.WriteLine("Fecha de nacimiento");
                        datos[i, 1] = Console.ReadLine();
                        Console.WriteLine("Edad");
                        datos[i, 2] = Console.ReadLine();
                        Console.WriteLine("RFC");
                        datos[i, 3] = Console.ReadLine();
                        Console.WriteLine("CURP");
                        datos[i, 4] = Console.ReadLine();
                        Console.WriteLine("Dirección");
                        datos[i, 5] = Console.ReadLine();
                        Console.WriteLine("Teléfono");
                        datos[i, 6] = Console.ReadLine();
                        Console.WriteLine("Celular");
                        datos[i, 7] = Console.ReadLine();
                        Console.WriteLine("Numero de seguro");
                        datos[i, 8] = Console.ReadLine();
                        Console.WriteLine("Fecha de contratación");
                        datos[i, 9] = Console.ReadLine();

                    }
                }
            }
            else
            {
                Console.WriteLine("Ha superado el limite de personal");
                    }
        }
        public static int CantidadDoctores( int n = 0)
        {
            
            return n;
        }
        public void BuscarPersonal()
        {

        }


    }
}
