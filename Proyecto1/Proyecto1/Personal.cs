using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    class Personal
    {
        private string[] doctores;
        private string[,] datosd;
        private string[] enfermeras;
        private string[,] datose;
        private string[] practicantes;
        private string[,] datosp;
        private string[] mantenimiento;
        private string[,] datosm;
        private string edad, fechac, fechan, cel, tel, direc, curp, rfc;
        private string nombres;
        public void PersonalHospital()
            {
            Console.WriteLine("Agregar personal");
            Console.WriteLine("1.- Doctores");
            Console.WriteLine("2.- Enfermeras");
            Console.WriteLine("3.- Practicantes");
            Console.WriteLine("4.- Mantenimiento");
            int opcion = 0;
            opcion = int.Parse(Console.ReadLine());
            switch(opcion)
            {
                case 1:
                    doctores = new string[1];
                    datosd = new string[1, 9];
                    for (int i = 0; i < doctores.Length; i++)
                    {
                        Console.WriteLine("Ingrese el nombre completo del empleado");
                        nombres = Console.ReadLine();
                        doctores[i] = nombres;
                        for (int j = 0; j < 1; j++)
                        {
                            Console.WriteLine("Fecha de contratacion");
                            fechac = Console.ReadLine();
                            datosd[i, 1] = fechac;
                            Console.WriteLine("Edad");
                            edad = Console.ReadLine();
                            datosd[i, 2] = edad;
                            Console.WriteLine("Direccion");
                            direc = Console.ReadLine();
                            datosd[i, 3] = direc;
                            Console.WriteLine("Telefono");
                            tel = Console.ReadLine();
                            datosd[i, 4] = tel;
                            Console.WriteLine("Celular");
                           cel = Console.ReadLine();
                            datosd[i, 5] = cel;
                            Console.WriteLine("CURP");
                            curp = Console.ReadLine();
                            datosd[i, 6] = curp;
                            Console.WriteLine("RFC");
                            rfc = Console.ReadLine();
                            datosd[i, 7] = rfc;
                            Console.WriteLine("Fecha de nacimiento ");
                            fechan = Console.ReadLine();
                            datosd[i, 8] = fechan;
                        }
                    }
                    for (int i = 0; i < 1; i++)
                    {
                        Console.WriteLine(doctores[i]);
                        Console.WriteLine(datosd[i, 1]);
                        Console.WriteLine(datosd[i, 2]);
                        Console.WriteLine(datosd[i, 3]);
                        Console.WriteLine(datosd[i, 4]);
                        Console.WriteLine(datosd[i, 5]);
                        Console.WriteLine(datosd[i, 6]);
                        Console.WriteLine(datosd[i, 7]);
                        Console.WriteLine(datosd[i, 8]);
                    }
                    break;
                case 2:
                    enfermeras = new string[1];
                    datose = new string[1, 8];
                    for (int i = 0; i < enfermeras.Length; i++)
                    {
                        Console.WriteLine("Ingrese el nombre completo del empleado");
                        enfermeras[i] = Console.ReadLine();
                       
                            Console.WriteLine("Fecha de contratacion");
                            fechac = Console.ReadLine();
                            datose[i, 0] = fechac;
                            Console.WriteLine("Edad");
                            edad = Console.ReadLine();
                            datose[i, 1] = edad;
                            Console.WriteLine("Direccion");
                            direc = Console.ReadLine();
                            datose[i, 2] = direc;
                            Console.WriteLine("Telefono");
                            tel = Console.ReadLine();
                            datose[i, 3] = tel;
                            Console.WriteLine("Celular");
                            cel = Console.ReadLine();
                            datose[i, 4] = cel;
                            Console.WriteLine("CURP");
                            curp = Console.ReadLine();
                            datose[i, 5] = curp;
                            Console.WriteLine("RFC");
                            rfc = Console.ReadLine();
                            datose[i, 6] = rfc;
                            Console.WriteLine("Fecha de nacimiento ");
                            fechan = Console.ReadLine();
                            datose[i, 7] = fechan;
                        Console.WriteLine("Fecha de contratacion");
                        Console.WriteLine(datose[i, 0]);
                        Console.WriteLine("Edad");
                        Console.WriteLine(datose[i, 1]);
                        Console.WriteLine("Direccion");
                        Console.WriteLine(datose[i, 2]);
                        Console.WriteLine("Telefono");
                        Console.WriteLine(datose[i, 3]);
                        Console.WriteLine("Celular");
                        Console.WriteLine(datose[i, 4]);
                        Console.WriteLine("CURP");
                        Console.WriteLine(datose[i, 5]);
                        Console.WriteLine("RFC");
                        Console.WriteLine(datose[i, 6]);
                        Console.WriteLine("Fecha de nacimiento ");
                        Console.WriteLine(datose[i, 7]);

                    }
                    
                    break;
                case 3:
                    practicantes = new string[1];
                    datosp = new string[1, 9];
                    for (int i = 0; i < practicantes.Length; i++)
                    {
                        Console.WriteLine("Ingrese el nombre completo del practicante");
                        practicantes[i] = Console.ReadLine();
                        for (int j = 0; j < 1; j++)
                        {
                            Console.WriteLine("Fecha de contratacion");
                            fechac = Console.ReadLine();
                            datosp[i, 1] = fechac;
                            Console.WriteLine("Edad");
                            edad = Console.ReadLine();
                            datosp[i, 2] = edad;
                            Console.WriteLine("Direccion");
                            direc = Console.ReadLine();
                            datosp[i, 3] = direc;
                            Console.WriteLine("Telefono");
                            tel = Console.ReadLine();
                            datosp[i, 4] = tel;
                            Console.WriteLine("Celular");
                            cel = Console.ReadLine();
                            datosp[i, 5] = cel;
                            Console.WriteLine("CURP");
                            curp = Console.ReadLine();
                            datosp[i, 6] = curp;
                            Console.WriteLine("RFC");
                            rfc = Console.ReadLine();
                            datosp[i, 7] = rfc;
                            Console.WriteLine("Fecha de nacimiento ");
                            fechan = Console.ReadLine();
                            datosp[i, 8] = fechan;
                        }
                    }
                    for (int i = 0; i < 1; i++)
                    {
                        Console.WriteLine(datosp[i, 1]);
                        Console.WriteLine(datosp[i, 2]);
                        Console.WriteLine(datosp[i, 3]);
                        Console.WriteLine(datosp[i, 4]);
                        Console.WriteLine(datosp[i, 5]);
                        Console.WriteLine(datosp[i, 6]);
                        Console.WriteLine(datosp[i, 7]);
                        Console.WriteLine(datosp[i, 8]);
                        Console.WriteLine(datosp[i, 9]);

                    }
                    break;
                case 4:
                    mantenimiento = new string[1];
                    datosm = new string[1, 10];
                    for (int i = 0; i < mantenimiento.Length; i++)
                    {
                        Console.WriteLine("Ingrese el nombre completo del empleado");
                        doctores[i] = Console.ReadLine();
                        for (int j = 0; j < 1; j++)
                        {
                            Console.WriteLine("Fecha de contratacion");
                            fechac = Console.ReadLine();
                            datosm[i, 1] = fechac;
                            Console.WriteLine("Edad");
                            edad = Console.ReadLine();
                            datosm[i, 2] = edad;
                            Console.WriteLine("Direccion");
                            direc = Console.ReadLine();
                            datosm[i, 3] = direc;
                            Console.WriteLine("Telefono");
                            tel = Console.ReadLine();
                            datosm[i, 4] = tel;
                            Console.WriteLine("Celular");
                            cel = Console.ReadLine();
                            datosm[i, 5] = cel;
                            Console.WriteLine("CURP");
                            curp = Console.ReadLine();
                            datosm[i, 6] = curp;
                            Console.WriteLine("RFC");
                            rfc = Console.ReadLine();
                            datosm[i, 7] = rfc;
                            Console.WriteLine("Fecha de nacimiento ");
                            fechan = Console.ReadLine();
                            datosm[i, 8] = fechan;
                        }
                    }
                    for (int i = 0; i < 1; i++)
                    {
                        Console.WriteLine(datosm[i, 1]);
                        Console.WriteLine(datosm[i, 2]);
                        Console.WriteLine(datosm[i, 3]);
                        Console.WriteLine(datosm[i, 4]);
                        Console.WriteLine(datosm[i, 5]);
                        Console.WriteLine(datosm[i, 6]);
                        Console.WriteLine(datosm[i, 7]);
                        Console.WriteLine(datosm[i, 8]);
            
                    }
                    break;
                default:
                    Console.WriteLine("OPCION NO VALIDA");
                    break;
            }
        }
    }
}
