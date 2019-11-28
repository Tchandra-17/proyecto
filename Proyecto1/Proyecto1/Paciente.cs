using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    class Paciente
    {
        public static void RegistrosdePacientes()
        {
            ///Declarar una variable de tipo entero con valor asignado de 0///
            int opSeleccionada = 0;
            ///Declarar una variable entera x///
            int x;
            ///Declarar 4 variables de tipo string: nombre, apellido, edad, sintomas///
            string nombre, apellido, edad, sintomas;
            ///Declarar un arreglo de tipo string sin tamano aun///
            string[] personaT;
            ///Utilizar la herramienta List <> para listar un nuevo arreglo, sin valor///
            List<string[]> paciente = new List<string[]>();
            ///Utilizar la estructura repetitiva While para crear un menu de acciones a realizar///
            while (opSeleccionada != 5)
            {
                ///Mostrar al usuario la lista de opciones a elegir///
                Console.WriteLine("1._ Inserte paciente");
                Console.WriteLine("2._ Listar paciente");
                Console.WriteLine("3._ Editar paciente");
                Console.WriteLine("4._ Eliminar paciente");
                Console.WriteLine("5._ salir");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Ingrese una opcion");
                ///Declarar una variable string "opSeltemp1" e ingresarle un valor///
                string opSeltemp1 = Console.ReadLine();
                ///Agregar un if ///
                ///Convertir la variable leida a su equivalente entero///
                ///Utillizar palabra clave out para pasar el valor a la variable entera x///
                if (int.TryParse(opSeltemp1, out x))
                {
                    ///La variable opSeltemp1 se convierte en entero///
                    ///La palabra clave out hace que///
                    ///La variable opSeltemp1 tenga el valor igual a 0 como la variable x y luego tome 
                    ///el valor leido///
                    ///Agregar a la variable opSeleccionada el valor de opSeltemp1///
                    opSeleccionada = int.Parse(opSeltemp1);
                    ///Agregar un switch con la variable opSeleccionada///
                    switch (opSeleccionada)
                    {
                        ///Agregar los las opciones///
                        ///Si el usuario ingresa el numeo 1, el programa hara lo siguiente///
                        case 1:
                            Console.Clear();
                            ///Pedir al usuario que ingrese el nombre del paciente///
                            Console.WriteLine("Ingrese el nombre del paciente");
                            ///Leer la variable string "nombre"///
                            nombre = Console.ReadLine();
                            ///Pedir al usuario que ingrese el apellido del paciente///
                            Console.WriteLine("Ingrese el apellido del paciente");
                            ///Leer la variable string "apellido"///
                            apellido = Console.ReadLine();
                            ///Pedir al usuario que ingrese la edad del paciente///
                            Console.WriteLine("Ingrese la edad del paciente");
                            ///Leer la variable string "edad"///
                            edad = Console.ReadLine();
                            ///Pedir al usuario que ingrese los sintomas del paciente///
                            Console.WriteLine("Sintomas");
                            ///Leer la variable string "apellido"///
                            sintomas = Console.ReadLine();
                            ///Agregar un if, usando las herramientas trim para quitar todos los espcios
                            ///en blanco del valor agregado a la variable nombre, y si es igual a la una
                            ///variable string vacia, mostrar un mensaje que diga que los campos son obligatorios llenarlos///
                            ///Agregar doble barra para indicar que o si sucede con las demas variables, 
                            ///apellido, edad, sintomas, etc, mandar el mismo mensaje///
                            if (nombre.Trim() == string.Empty || apellido.Trim() == string.Empty || edad.Trim() == string.Empty || sintomas.Trim() == string.Empty)
                            {
                                ///Mandar al usuario el mensaje que indica que debe llenar todos los campos///
                                Console.WriteLine("Los campos son obligatorios");
                            }
                            ///Si no...//
                            else
                            {
                                ///Agregar un tamano de cuatro posiciones al arreglo///
                                personaT = new string[4];
                                ///Guardar en cada una de las pocisiones una variable llena///
                                ///El arreglo en la posicion 0 va a guardar la variable nombre///
                                personaT[0] = nombre;
                                ///El arreglo en la posicion 1 va a guardar la variable apellido///
                                personaT[1] = apellido;
                                ///El arreglo en la posicion 2 va a guardar la variable edad///
                                personaT[2] = edad;
                                ///El arreglo en la posicion 3 va a guardar la variable sintomas///
                                personaT[3] = sintomas;
                                ///Agregar a la lista 'pacientes' todos los datos del arreglo
                                paciente.Add(personaT);
                            }
                            Console.WriteLine("ACEPTAR");
                            break;
                        case 2:
                            Console.Clear();
                            ///Si el usuario ingresa el numeo 2, el programa hara lo siguiente///
                            ///Mostrar el encabezado 'lista de pacientes'///
                            Console.WriteLine("-------------Lista de pacientes-------------");
                            ///Conectar un nuevo arreglo string con lo que hay en la lista de pacientes///
                            foreach (string[] item in paciente)
                            {
                                ///Imprimir el nombre del paciente///
                                ///"Nombre" + lo que vale el arreglo item en la posicion 0, que es igual a lo que vale el 
                                ///arreglo personaT en esa posicion en la lista pacientes///
                                Console.WriteLine("NOMBRE:  " + item[0] + " " + item[1]);
                                ///Imprimir la edad del paciente y sus sintomas///
                                ///"Edad" + lo que vale item en la posicion 2 + " sintomas" + lo que vale item en la posicion 3///
                                Console.WriteLine("EDAD: " + item[2] + " // " + "SINTOMAS: " + item[3]);
                                Console.WriteLine("----------------------------------------------------------");
                            }
                            Console.WriteLine("ACEPTAR");
                            break;
                        case 3:
                            Console.Clear();
                            ///Si el usuario ingresa el numeo 3, el programa hara lo siguiente///
                            ///Mostrar la lista de pacientes, indicarlo por mensaje///
                            Console.WriteLine("-------------Lista de pacientes-------------");
                            ///Agregar un for que vaya desde 0 hasta el numero de elementos en la lista de pacientes///
                            for (int i = 0; i < paciente.Count; i++)
                            {
                                ///Mostrar por mensaje todos los datos///
                                ///Mostrar el numero del paciente///
                                ///Mostrar el  nombre: mostrar en la posicion del contador el valor que hay en la lista
                                ///en la posicion 0;
                                ///Mostrar el apellido: mostrar en la posicion del contadol el valor que hay en la lista
                                ///en la posicion 1
                                ///Mostrar la edad del paciente: mostrar en la posicion del contador lo que hay en la lista
                                /// en la posicion 2
                                /// Mostrar los sintomas: mostrar en la posicion del contador lo que hay en la lista 
                                /// en la posicion 3///
                                Console.WriteLine(i + ")NOMBRE:  " + paciente[i][0] + " " + paciente[i][1]);
                                Console.WriteLine(i + "EDAD: " + paciente[i][2] + " // " + "SINTOMAS: " + paciente[i][3]);
                                Console.WriteLine("----------------------------------------------------------");
                            }
                            ///Agregar un separador de informacion///
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("");///Agregar un espacio///
                            ///Pedir al usuario que ingrese la persona a editar///
                            Console.WriteLine("Ingrese la persona que desea editar:");
                            ///Declarar una variable string para leer la posicion del paciente a editar///
                            ///Leer la variable///
                            string posicionPacientet1 = Console.ReadLine();
                            ///Agregar un if///
                            if (int.TryParse(posicionPacientet1, out x))
                            {
                                ///Si la variable posicionPaciente1 se convierte en entero///
                                ///La palabra clave out hace que///
                                ///La variable posicionPaciente1 tenga valor igual a 0 como la variable x y luego tome
                                ///el valor leido///
                                ///Declarar una variable entera para la posicion del paciente e igualarla a lo que vale la 
                                ///variable string declarada para la posicion del paciente///
                                int posicionPaciente = int.Parse(posicionPacientet1);
                                ///Agregar una condicional///
                                if (paciente.Count <= posicionPaciente || posicionPaciente < 0)
                                {
                                    ///Si la cantidad de posiciones en la lista de pacientes es menor o igual a lo que vale la 
                                    ///variable entera declarada para la posicion del paciente o si esa variable es menor a 0, 
                                    ///entonces mandar un mensaje al usuario de que esa persona no esta registrada///
                                    Console.WriteLine("PERSONA NO REGISTRADA");
                                }
                                else///Si no...///
                                {
                                    ///Pedir al usuario que ingrese nuevos datos///
                                    ///Usar las mismas variables ya declaradas para cada dato al inicio de la funcion///
                                    Console.WriteLine("Ingrese el nuevo nombre del paciente");
                                    nombre = Console.ReadLine();
                                    Console.WriteLine("Ingrese el nuevo apellido del paciente");
                                    apellido = Console.ReadLine();
                                    Console.WriteLine("Ingrese la nueva edad del paciente");
                                    edad = Console.ReadLine();
                                    Console.WriteLine("¿Que tiene?");
                                    sintomas = Console.ReadLine();
                                    ///Agregar un if, usando las herramientas trim para quitar todos los espcios
                                    ///en blanco del valor agregado a la variable nombre, y si es igual a la una
                                    ///variable string vacia, mostrar un mensaje que diga que los campos son obligatorios llenarlos///
                                    ///Agregar doble barra para indicar que o si sucede con las demas variables, 
                                    ///apellido, edad, sintomas, etc, mandar el mismo mensaje///
                                    if (nombre.Trim() == string.Empty || apellido.Trim() == string.Empty || edad.Trim() == string.Empty || sintomas.Trim() == string.Empty)
                                    {
                                        ///Mandar al usuario el mensaje que indica que debe llenar todos los campos///
                                        Console.WriteLine("Los campos son obligatorios");
                                    }

                                    else
                                    {
                                        ///Si no, agregar los nuevos datos a la lista de pacientes///
                                        ///Agregar a la lista de pacientes, en la posicion ingresada en la variable 
                                        ///declarada para ello en la posicion 0 del arreglo el nuevo nombre ingresado///
                                        paciente[posicionPaciente][0] = nombre;
                                        ///Agregar a la lista de pacientes, en la posicion ingresada en la variable 
                                        ///declarada para ello en la posicion 1 del arreglo el nuevo apellido ingresado///
                                        paciente[posicionPaciente][1] = apellido;
                                        ///Agregar a la lista de pacientes, en la posicion ingresada en la variable 
                                        ///declarada para ello en la posicion 2 del arreglo la nueva edad ingresada///
                                        paciente[posicionPaciente][2] = edad;
                                        ///Agregar a la lista de pacientes, en la posicion ingresada en la variable 
                                        ///declarada para ello en la posicion 3 del arreglo los nuevos sintomas ingresados///
                                        paciente[posicionPaciente][3] = sintomas;
                                        ///Informar por mensaje que la informacion ha sido actualizada///
                                        Console.WriteLine("informacion actualizada");

                                    }
                                }
                            }
                            else
                            ///Si no se agrega un valor valido, infromar al usuario que ha ingresado un dato incorrecto///
                            {
                                Console.WriteLine("Dato incorrecto");
                            }
                            Console.WriteLine("ACEPTAR");
                            break;
                        case 4:
                            Console.Clear();
                            ///Si el usuario ingresa el numero 4, el programa hara lo siguiente///
                            ///Informar al usuario que esta en lalista de los pacientes///
                            Console.WriteLine("-------------Lista de pacientes-------------");
                            ///Agregar un for que vaya desde 0 hasta el numero de elementos en la lista de pacientes///
                            for (int i = 0; i < paciente.Count; i++)
                            {
                                ///Mostrar por mensaje todos los datos///
                                ///Mostrar el numero del paciente///
                                ///Mostrar el  nombre: mostrar en la posicion del contador el valor que hay en la lista
                                ///en la posicion 0;
                                ///Mostrar el apellido: mostrar en la posicion del contadol el valor que hay en la lista
                                ///en la posicion 1
                                ///Mostrar la edad del paciente: mostrar en la posicion del contador lo que hay en la lista
                                /// en la posicion 2
                                /// Mostrar los sintomas: mostrar en la posicion del contador lo que hay en la lista 
                                /// en la posicion 3///
                                Console.WriteLine(i + ")NOMBRE:  " + paciente[i][0] + " " + paciente[i][1]);
                                Console.WriteLine(i + "EDAD: " + paciente[i][2] + " // " + "SINTOMAS: " + paciente[i][3]);
                                Console.WriteLine("----------------------------------------------------------");
                            }
                            ///Agregar un separador de informacion///
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("");///Agregar espacio vacio///
                            ///Pedir al usuario que ingrese la persona a eliminar///
                            Console.WriteLine("Ingrese la persona que desea eliminar:");
                            ///Declarar una variable string para leer la posicion del paciente a eliminar///
                            ///Leer la variable///
                            string posicionPacientet1PE = Console.ReadLine();
                            ///Agregar una condicional///
                            if (int.TryParse(posicionPacientet1PE, out x))
                            {
                                ///Si la variable posicionPacientet1PE se convierte en entero///
                                ///La palabra clave out hace que///
                                ///La variable posicionPacienteT1PE tenga valor igual a 0 como la variable x y luego tome
                                ///el valor leido///
                                ///Declarar una variable entera para la posicion del paciente e igualarla a lo que vale la 
                                ///variable string declarada para la posicion del paciente///
                                int posicionPaciente = int.Parse(posicionPacientet1PE);
                                if (paciente.Count <= posicionPaciente || posicionPaciente < 0)
                                {
                                    ///Si la cantidad de posiciones en la lista de pacientes es menor o igual a lo que vale la 
                                    ///variable entera declarada para la posicion del paciente o si esa variable es menor a 0, 
                                    ///entonces mandar un mensaje al usuario de que esa persona no esta registrada///
                                    Console.WriteLine("PERSONA NO REGISTRADA");
                                }
                                else
                                {
                                    ///Si no, utilizar la herramienta .RemoveAt para remover de la lista de pacientes
                                    ///la posicion del paciente ingresada///
                                    paciente.RemoveAt(posicionPaciente);
                                    ///Informar al usuario que la persona ha sido eliminada de la lista///
                                    Console.WriteLine("Persona eliminada correctamente");
                                }
                            }
                            else
                            ///Si no se agrega un valor valido, infromar al usuario que ha ingresado un dato incorrecto///
                            {
                                Console.WriteLine("Dato incorrecto");
                            }
                            Console.WriteLine("ACEPTAR");
                            break;
                        case 5:
                            Console.WriteLine("Vuelva pronto");
                            break;
                        default:
                            Console.WriteLine("La opcion no esta definida en el menu");
                            break;

                    }
                }
                else
                 ///Si no...
                {
                    ///La opcion seleccionada es igual a 0 y avisar al usuario que esa opcion no existe///
                    opSeleccionada = 0;
                    Console.WriteLine("La opcion asignada no existe");
                }
                if (opSeleccionada != 5)
                {
                    ///Si la opcion es diferente de 5, leer un valor///
                    Console.ReadLine();
                }
                Console.Clear();
            }


        }
    }
}
