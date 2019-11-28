using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    class Personal
    {
        public static void PersonalHospital()
        {
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Elija una opción");
                Console.WriteLine("1.- Personal medico");
                Console.WriteLine("2.- Practicantes");
                Console.WriteLine("3.- Mantenimiento");
                Console.WriteLine("4.- Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        int opcione = 0;
                        while(opcione !=4)
                        {
                            Console.Clear();
                            Console.WriteLine("Elija una opción");
                            Console.WriteLine("1.- Doctor");
                            Console.WriteLine("2.- Enfermeras/os");
                            Console.WriteLine("3.- Especialistas");
                            Console.WriteLine("4.- Salir");
                            
                            opcione = int.Parse(Console.ReadLine());
                            switch (opcione)
                            {
                                case 1:
                                    Console.Clear();
                                    ///Declarar una variable de tipo entero con valor asignado de 0///
                                    int opSeleccionada = 0;
                                    ///Declarar una variable entera x///
                                    int x;
                                    ///Declarar 9 variables de tipo string: nombre, apellido, edad, area, curp, rfc, direccion, telefono, celular, horario///
                                    string nombre, apellido, area, curp, rfc, direccion, telefono, celular, fechan;
                                    ///Declarar un arreglo de tipo string sin tamano aun///
                                    string[] doctor;
                                    ///Utilizar la herramienta List <> para listar un nuevo arreglo, sin valor///
                                    List<string[]> doctores = new List<string[]>();
                                    ///Utilizar la estructura repetitiva While para crear un menu de acciones a realizar///
                                    while (opSeleccionada != 5)
                                    {
                                        ///Mostrar al usuario la lista de opciones a elegir///
                                        Console.WriteLine("1._ Inserte nuevo personal");
                                        Console.WriteLine("2._ Listar personal");
                                        Console.WriteLine("3._ Editar personal");
                                        Console.WriteLine("4._ Eliminar personal");
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
                                                    ///Pedir al usuario que ingrese el nombre del personal///
                                                    Console.WriteLine("Nombres");
                                                    ///Leer la variable string "nombre"///
                                                    nombre = Console.ReadLine();
                                                    ///Pedir al usuario que ingrese el apellido del personal///
                                                    Console.WriteLine("Apellidos");
                                                    ///Leer la variable string "apellido"///
                                                    apellido = Console.ReadLine();
                                                    ///Pedir al usuario que ingrese la fecha de nacimiento///
                                                    Console.WriteLine("Fecha de nacimiento");
                                                    ///Leer la variable string "edad"///
                                                    fechan = Console.ReadLine();
                                                    Console.WriteLine("Direccion");
                                                    ///Leer la variable string "nombre"///
                                                    direccion = Console.ReadLine();
                                                    ///Pedir al usuario que ingrese el apellido del personal///
                                                    Console.WriteLine("CURP");
                                                    ///Leer la variable string "apellido"///
                                                    curp = Console.ReadLine();
                                                    ///Pedir al usuario que ingrese la fecha de nacimiento///
                                                    Console.WriteLine("RFC");
                                                    ///Leer la variable string "edad"///
                                                    rfc = Console.ReadLine();
                                                    Console.WriteLine("Telefono");
                                                    ///Leer la variable string "nombre"///
                                                    telefono = Console.ReadLine();
                                                    ///Pedir al usuario que ingrese el apellido del personal///
                                                    Console.WriteLine("Celular");
                                                    ///Leer la variable string "apellido"///
                                                    celular = Console.ReadLine();
                                                    ///Pedir al usuario que ingrese la fecha de nacimiento///
                                                    Console.WriteLine("Area");
                                                    ///Leer la variable string "edad"///
                                                    area = Console.ReadLine();
                                                    ///Agregar un if, usando las herramientas trim para quitar todos los espcios
                                                    ///en blanco del valor agregado a la variable nombre, y si es igual a la una
                                                    ///variable string vacia, mostrar un mensaje que diga que los campos son obligatorios llenarlos///
                                                    ///Agregar doble barra para indicar que o si sucede con las demas variables, 
                                                    ///apellido, edad, sintomas, etc, mandar el mismo mensaje///
                                                    if (nombre.Trim() == string.Empty || apellido.Trim() == string.Empty || fechan.Trim() == string.Empty || direccion.Trim() == string.Empty || telefono.Trim() == string.Empty || celular.Trim() == string.Empty || area.Trim() == string.Empty || curp.Trim() == string.Empty || rfc.Trim() == string.Empty)
                                                    {
                                                        ///Mandar al usuario el mensaje que indica que debe llenar todos los campos///
                                                        Console.WriteLine("Los campos son obligatorios");
                                                    }
                                                    ///Si no...//
                                                    else
                                                    {
                                                        ///Agregar un tamano de cuatro posiciones al arreglo///
                                                        doctor = new string[9];
                                                        ///Guardar en cada una de las pocisiones una variable llena///
                                                        ///El arreglo en la posicion 0 va a guardar la variable nombre///
                                                        doctor[0] = nombre;
                                                        ///El arreglo en la posicion 1 va a guardar la variable apellido///
                                                        doctor[1] = apellido;
                                                        ///El arreglo en la posicion 2 va a guardar la variable fechan///
                                                        doctor[2] = fechan;
                                                        ///El arreglo en la posicion 3 va a guardar la variable direccion///
                                                        doctor[3] = direccion;
                                                        ///El arreglo en la posicion 4 va a guardar la variable curp///
                                                        doctor[4] = curp;
                                                        ///El arreglo en la posicion 5 va a guardar la variable rfc///
                                                        doctor[5] = rfc;
                                                        ///El arreglo en la posicion 6 va a guardar la variable telefono///
                                                        doctor[6] = telefono;
                                                        ///El arreglo en la posicion 7 va a guardar la variable celular///
                                                        doctor[7] = celular;
                                                        ///El arreglo en la posicion 8 va a guardar la variable area///
                                                        doctor[8] = area;
                                                        ///Agregar a la lista 'doctores' todos los datos del arreglo///
                                                        doctores.Add(doctor);
                                                    }
                                                    Console.WriteLine("ACEPTAR");
                                                    break;
                                                case 2:
                                                    Console.Clear();
                                                    ///Si el usuario ingresa el numeo 2, el programa hara lo siguiente///
                                                    ///Mostrar el encabezado 'lista de doctores'///
                                                    Console.WriteLine("-------------Lista de doctores-------------");
                                                    ///Conectar un nuevo arreglo string con lo que hay en la lista de pacientes///
                                                    foreach (string[] item in doctores)
                                                    {
                                                        ///Imprimir el nombre del doctor///
                                                        ///"Nombre" + lo que vale el arreglo item en la posicion 0, que es igual a lo que vale el 
                                                        ///arreglo doctor en la lista de doctores///
                                                        Console.WriteLine("NOMBRE:  " + item[0] + " " + item[1]);
                                                        ///Imprimir la fecha de nacimiento///
                                                        Console.WriteLine("FECHA DE NACIMIENTO: " + item[2]);
                                                        ///Imprimir la direccion///
                                                        Console.WriteLine("DIRECCION: " + item[3]);
                                                        ///Imprimir la curp///
                                                        Console.WriteLine("CURP: " + item[4]);
                                                        ///Imprimir la rfc///
                                                        Console.WriteLine("RFC: " + item[5]);
                                                        ///Imprimir el telefono///
                                                        Console.WriteLine("TELEFONO: " + item[6]);
                                                        ///Imprimir el celular///
                                                        Console.WriteLine("CELULAR: " + item[7]);
                                                        ///Imprimir el area///
                                                        Console.WriteLine("AREA: " + item[8]);
                                                        Console.WriteLine("----------------------------------------------------------");
                                                    }
                                                    Console.WriteLine("ACEPTAR");
                                                    break;
                                                case 3:
                                                    Console.Clear();
                                                    ///Si el usuario ingresa el numero 3, el programa hara lo siguiente///
                                                    ///Mostrar la lista de doctores,  indicarlo por mensaje///
                                                    Console.WriteLine("-------------Lista de doctores-------------");
                                                    ///Agregar un for que vaya desde 0 hasta el numero de elementos en la lista de pacientes///
                                                    for (int i = 0; i < doctores.Count; i++)
                                                    {
                                                        ///Mostrar por mensaje todos los datos///
                                                        ///Mostrar el numero del doctor///
                                                        ///Mostrar el  nombre: mostrar en la posicion del contador el valor que hay en la lista
                                                        ///en la posicion 0;
                                                        ///Mostrar el apellido: mostrar en la posicion del contadol el valor que hay en la lista
                                                        ///en la posicion 1
                                                        ///Mostrar la fecha de nacimiento del doctor
                                                        ///mostrar en la posicion del contador lo que hay en la lista en la posicion 2
                                                        /// Mostrar la direccion mostrar en la posicion del contador lo que hay en la lista 
                                                        /// en la posicion 3///
                                                        /// Mostrar la curp en la posicion del contador lo que hay en la lista en la posicion 4
                                                        /// Mostrar el rfc en la posicion del contador lo que hay en la lista en la posicion 5
                                                        /// Mostrar el telefono en la  posicion del contador lo que hay en la lista en la posicion 6
                                                        /// Mostrar el celular en la posicion del contador lo que hay en la lista en la posicion 7
                                                        /// Mostrar el area en la posicion del contador lo que hay en la lista en la posicion 8///
                                                        Console.WriteLine(i + ")NOMBRE:  " + doctores[i][0] + " " + doctores[i][1]);
                                                        Console.WriteLine(i + ")FECHA DE NACIMIENTO: " + doctores[i][2]);
                                                        Console.WriteLine(i + ")DIRECCION: " + doctores[i][3]);
                                                        Console.WriteLine(i + ")CURP: " + doctores[i][4]);
                                                        Console.WriteLine(i + ")RFC: " + doctores[i][5]);
                                                        Console.WriteLine(i + ")TELEFONO: " + doctores[i][6]);
                                                        Console.WriteLine(i + ")CELULAR: " + doctores[i][7]);
                                                        Console.WriteLine(i + ")AREA: " + doctores[i][8]);
                                                        Console.WriteLine("----------------------------------------------------------");
                                                    }
                                                    ///Agregar un separador de informacion///
                                                    Console.WriteLine("--------------------------------------------------");
                                                    Console.WriteLine("");///Agregar un espacio///
                                                                          ///Pedir al usuario que ingrese la persona a editar///
                                                    Console.WriteLine("Ingrese la persona que desea editar:");
                                                    ///Declarar una variable string para leer la posicion del doctor a editar///
                                                    ///Leer la variable///
                                                    string posiciondoctor1 = Console.ReadLine();
                                                    ///Agregar un if///
                                                    if (int.TryParse(posiciondoctor1, out x))
                                                    {
                                                        ///Si la variable posiciondoctor1 se convierte en entero///
                                                        ///La palabra clave out hace que///
                                                        ///La variable posiciondoctor1 tenga valor igual a 0 como la variable x y luego tome
                                                        ///el valor leido///
                                                        ///Declarar una variable entera para la posicion del doctor e igualarla a lo que vale la
                                                        ///variable string declarada para la posicion del doctor///
                                                        int posiciondoctor = int.Parse(posiciondoctor1);
                                                        ///Agregar una condicional///
                                                        if (doctores.Count <= posiciondoctor || posiciondoctor < 0)
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
                                                            ///Pedir al usuario que ingrese el nombre del personal///
                                                            Console.WriteLine("Nombres");
                                                            ///Leer la variable string "nombre"///
                                                            nombre = Console.ReadLine();
                                                            ///Pedir al usuario que ingrese el apellido del personal///
                                                            Console.WriteLine("Apellidos");
                                                            ///Leer la variable string "apellido"///
                                                            apellido = Console.ReadLine();
                                                            ///Pedir al usuario que ingrese la fecha de nacimiento///
                                                            Console.WriteLine("Fecha de nacimiento");
                                                            ///Leer la variable string "edad"///
                                                            fechan = Console.ReadLine();
                                                            Console.WriteLine("Direccion");
                                                            ///Leer la variable string "nombre"///
                                                            direccion = Console.ReadLine();
                                                            ///Pedir al usuario que ingrese el apellido del personal///
                                                            Console.WriteLine("CURP");
                                                            ///Leer la variable string "apellido"///
                                                            curp = Console.ReadLine();
                                                            ///Pedir al usuario que ingrese la fecha de nacimiento///
                                                            Console.WriteLine("RFC");
                                                            ///Leer la variable string "edad"///
                                                            rfc = Console.ReadLine();
                                                            Console.WriteLine("Telefono");
                                                            ///Leer la variable string "nombre"///
                                                            telefono = Console.ReadLine();
                                                            ///Pedir al usuario que ingrese el apellido del personal///
                                                            Console.WriteLine("Celular");
                                                            ///Leer la variable string "apellido"///
                                                            celular = Console.ReadLine();
                                                            ///Pedir al usuario que ingrese la fecha de nacimiento///
                                                            Console.WriteLine("Area");
                                                            ///Leer la variable string "edad"///
                                                            area = Console.ReadLine();
                                                            ///Agregar un if, usando las herramientas trim para quitar todos los espacios
                                                            ///en blanco del valor agregado a la variable nombre, y si es igual a la una
                                                            ///variable string vacia, mostrar un mensaje que diga que los campos son obligatorios llenarlos///
                                                            ///Agregar doble barra para indicar que o si sucede con las demas variables, 
                                                            ///apellido, edad, sintomas, etc, mandar el mismo mensaje///
                                                            if (nombre.Trim() == string.Empty || apellido.Trim() == string.Empty || fechan.Trim() == string.Empty || direccion.Trim() == string.Empty || telefono.Trim() == string.Empty || celular.Trim() == string.Empty || area.Trim() == string.Empty || curp.Trim() == string.Empty || rfc.Trim() == string.Empty)
                                                            {
                                                                ///Mandar al usuario el mensaje que indica que debe llenar todos los campos///
                                                                Console.WriteLine("Los campos son obligatorios");
                                                            }

                                                            else
                                                            {
                                                                ///Si no, agregar los nuevos datos a la lista de doctores///
                                                                ///Agregar a la lista de doctores, en la posicion ingresada en la variable 
                                                                ///declarada para ello en la posicion 0 del arreglo el nuevo nombre ingresado///
                                                                doctores[posiciondoctor][0] = nombre;
                                                                ///Agregar a la lista de doctores, en la posicion ingresada en la variable 
                                                                ///declarada para ello en la posicion 1 del arreglo el nuevo apellido ingresado///
                                                                doctores[posiciondoctor][1] = apellido;
                                                                ///Agregar a la lista de doctores, en la posicion ingresada en la variable 
                                                                ///declarada para ello en la posicion 2 del arreglo la nueva fecha igresada///
                                                                doctores[posiciondoctor][2] = fechan;
                                                                ///Agregar a la lista de doctores, en la posicion ingresada en la variable 
                                                                ///declarada para ello en la posicion 3 del arreglo la nueva direccion ingresada///
                                                                doctores[posiciondoctor][3] = direccion;
                                                                ///Agregar a la lista de doctores, en la posicion ingresada en la variable 
                                                                ///declarada para ello en la posicion 4 del arreglo la nueva curp ingresada///
                                                                doctores[posiciondoctor][4] = curp;
                                                                ///Agregar a la lista de doctores, en la posicion ingresada en la variable 
                                                                ///declarada para ello en la posicion 5 del arreglo la nueva rfc ingresada///
                                                                doctores[posiciondoctor][5] = rfc;
                                                                ///Agregar a la lista de doctores, en la posicion ingresada en la variable 
                                                                ///declarada para ello en la posicion 6 del arreglo el nuevo telefono ingresado///
                                                                doctores[posiciondoctor][6] = telefono;
                                                                ///Agregar a la lista de doctores, en la posicion ingresada en la variable 
                                                                ///declarada para ello en la posicion 7 del arreglo el nuevo celular ingresado///
                                                                doctores[posiciondoctor][7] = celular;
                                                                ///Agregar a la lista de doctores, en la posicion ingresada en la variable 
                                                                ///declarada para ello en la posicion 8 del arreglo la nueva area ingresada///
                                                                doctores[posiciondoctor][8] = area;
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
                                                    ///Informar al usuario que esta en la lista de los doctores///
                                                    Console.WriteLine("-------------Lista de doctores-------------");
                                                    ///Agregar un for que vaya desde 0 hasta el numero de elementos en la lista de doctores///
                                                    for (int i = 0; i < doctores.Count; i++)
                                                    {
                                                        ///Mostrar por mensaje todos los datos///
                                                        ///Mostrar el numero del doctor///
                                                        ///Mostrar el  nombre: mostrar en la posicion del contador el valor que hay en la lista
                                                        ///en la posicion 0;
                                                        ///Mostrar el apellido: mostrar en la posicion del contadol el valor que hay en la lista
                                                        ///en la posicion 1
                                                        ///Mostrar la fecha de nacim: mostrar en la posicion del contador lo que hay en la lista
                                                        /// en la posicion 2
                                                        /// Mostrar la direccion: mostrar en la posicion del contador lo que hay en la lista 
                                                        /// en la posicion 3///
                                                        /// Mostrar la curp:  mostrar en la posicion del contador lo que hay en la lista 
                                                        /// en la posicion 4///
                                                        /// /// Mostrar la rfc:  mostrar en la posicion del contador lo que hay en la lista 
                                                        /// en la posicion 5///
                                                        /// /// Mostrar el telefono:  mostrar en la posicion del contador lo que hay en la lista 
                                                        /// en la posicion 6///
                                                        /// Mostrar el celular:  mostrar en la posicion del contador lo que hay en la lista 
                                                        /// en la posicion 7///
                                                        /// Mostrar el area:  mostrar en la posicion del contador lo que hay en la lista 
                                                        /// en la posicion 8///
                                                        Console.WriteLine(i + ")NOMBRE:  " + doctores[i][0] + " " + doctores[i][1]);
                                                        Console.WriteLine(i + ")FECHA DE NACIMIENTO: " + doctores[i][2]);
                                                        Console.WriteLine(i + ")DIRECCION: " + doctores[i][3]);
                                                        Console.WriteLine(i + ")CURP: " + doctores[i][4]);
                                                        Console.WriteLine(i + ")RFC: " + doctores[i][5]);
                                                        Console.WriteLine(i + ")TELEFONO: " + doctores[i][6]);
                                                        Console.WriteLine(i + ")CELULAR: " + doctores[i][7]);
                                                        Console.WriteLine(i + ")AREA: " + doctores[i][8]);
                                                        Console.WriteLine("----------------------------------------------------------");
                                                    }
                                                    ///Agregar un separador de informacion///
                                                    Console.WriteLine("--------------------------------------------------");
                                                    Console.WriteLine("");///Agregar espacio vacio///
                                                                          ///Pedir al usuario que ingrese la persona a eliminar///
                                                    Console.WriteLine("Ingrese el personal que desea eliminar");
                                                    ///Declarar una variable string para leer la posicion del doctor a eliminar///
                                                    ///Leer la variable///
                                                    string posiciondoctorPE = Console.ReadLine();
                                                    ///Agregar una condicional///
                                                    if (int.TryParse(posiciondoctorPE, out x))
                                                    {
                                                        ///Si la variable posiciondoctorPE se convierte en entero///
                                                        ///La palabra clave out hace que///
                                                        ///La variable posiciondoctorPEtenga valor igual a 0 como la variable x y luego tome
                                                        ///el valor leido///
                                                        ///Declarar una variable entera para la posicion del doctor e igualarla a lo que vale la
                                                        ///variable string declarada para la posicion del doctor///
                                                        int posiciondoctor = int.Parse(posiciondoctorPE);
                                                        if (doctores.Count <= posiciondoctor || posiciondoctor < 0)
                                                        {
                                                            ///Si la cantidad de posiciones en la lista de doctores es menor o igual a lo que vale la 
                                                            ///variable entera declarada para la posicion del doctor o si esa variable es menor a 0, 
                                                            ///entonces mandar un mensaje al usuario de que esa persona no esta registrada///
                                                            Console.WriteLine("PERSONA NO REGISTRADA");
                                                        }
                                                        else
                                                        {
                                                            ///Si no, utilizar la herramienta .RemoveAt para remover de la lista de pacientes
                                                            ///la posicion del paciente ingresada///
                                                            doctores.RemoveAt(posiciondoctor);
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

                                    break;

                                case 2:
                                    Console.Clear();                      
                                    ///Declarar una variable de tipo entero con valor asignado de 0///
                                    int opSeleccionadae= 0;
                                    ///Declarar una variable entera x///
                                    int y;
                                    ///Declarar 10variables de tipo string: nombre, apellido, edad, area, curp, rfc, direccion, telefono, celular, horario///
                                    string nombree, apellidoe, areae, curpe, rfce, direccione, telefonoe, celulare, fechane, sexo;
                                    ///Declarar un arreglo de tipo string sin tamano aun///
                                    string[] enfermero;
                                    ///Utilizar la herramienta List <> para listar un nuevo arreglo, sin valor///
                                    List<string[]> enfermeros = new List<string[]>();
                                    ///Utilizar la estructura repetitiva While para crear un menu de acciones a realizar///
                                    while (opSeleccionadae != 5)
                                    {
                                        ///Mostrar al usuario la lista de opciones a elegir///
                                        Console.WriteLine("1._ Inserte nuevo personal");
                                        Console.WriteLine("2._ Listar personal");
                                        Console.WriteLine("3._ Editar personal");
                                        Console.WriteLine("4._ Eliminar personal");
                                        Console.WriteLine("5._ salir");
                                        Console.WriteLine("------------------------------------------------");
                                        Console.WriteLine("Ingrese una opcion");
                                        ///Declarar una variable string "opSeltemp1" e ingresarle un valor///
                                        string opSeltemp2 = Console.ReadLine();
                                        ///Agregar un if ///
                                        ///Convertir la variable leida a su equivalente entero///
                                        ///Utillizar palabra clave out para pasar el valor a la variable entera x///
                                        if (int.TryParse(opSeltemp2, out y))
                                        {
                                            ///La variable opSeltemp2 se convierte en entero///
                                            ///La palabra clave out hace que///
                                            ///La variable opSeltemp2 tenga el valor igual a 0 como la variable y y luego tome 
                                            ///el valor leido///
                                            ///Agregar a la variable opSeleccionada el valor de opSeltemp2///
                                            opSeleccionadae= int.Parse(opSeltemp2);
                                            ///Agregar un switch con la variable opSeleccionada///
                                            switch (opSeleccionadae)
                                            {
                                                ///Agregar los las opciones///
                                                ///Si el usuario ingresa el numeo 1, el programa hara lo siguiente///
                                                case 1:
                                                    Console.Clear();
                                                    ///Pedir al usuario que ingrese el nombre del personal///
                                                    Console.WriteLine("Nombres");
                                                    ///Leer la variable string "nombre"///
                                                    nombree= Console.ReadLine();
                                                    ///Pedir al usuario que ingrese el apellido del personal///
                                                    Console.WriteLine("Apellidos");
                                                    ///Leer la variable string "apellido"///
                                                    apellidoe= Console.ReadLine();
                                                    ///Pedir al usuario que ingrese el sexo del personal///
                                                    Console.WriteLine("Apellidos");
                                                    ///Leer la variable string "sexo"///
                                                    sexo = Console.ReadLine();
                                                    ///Pedir al usuario que ingrese la fecha de nacimiento///
                                                    Console.WriteLine("Fecha de nacimiento");
                                                    ///Leer la variable string "edad"///
                                                    fechane= Console.ReadLine();
                                                    Console.WriteLine("Direccion");
                                                    ///Leer la variable string "nombre"///
                                                    direccione= Console.ReadLine();
                                                    ///Pedir al usuario que ingrese el apellido del personal///
                                                    Console.WriteLine("CURP");
                                                    ///Leer la variable string "apellido"///
                                                    curpe= Console.ReadLine();
                                                    ///Pedir al usuario que ingrese la fecha de nacimiento///
                                                    Console.WriteLine("RFC");
                                                    ///Leer la variable string "edad"///
                                                    rfce= Console.ReadLine();
                                                    Console.WriteLine("Telefono");
                                                    ///Leer la variable string "nombre"///
                                                    telefonoe= Console.ReadLine();
                                                    ///Pedir al usuario que ingrese el apellido del personal///
                                                    Console.WriteLine("Celular");
                                                    ///Leer la variable string "apellido"///
                                                    celulare= Console.ReadLine();
                                                    ///Pedir al usuario que ingrese la fecha de nacimiento///
                                                    Console.WriteLine("Area");
                                                    ///Leer la variable string "edad"///
                                                    areae= Console.ReadLine();
                                                    ///Agregar un if, usando las herramientas trim para quitar todos los espcios
                                                    ///en blanco del valor agregado a la variable nombre, y si es igual a la una
                                                    ///variable string vacia, mostrar un mensaje que diga que los campos son obligatorios llenarlos///
                                                    ///Agregar doble barra para indicar que o si sucede con las demas variables, 
                                                    ///apellido, edad, sintomas, etc, mandar el mismo mensaje///
                                                    if (nombree.Trim() == string.Empty || apellido.Trim() == string.Empty || fechan.Trim() == string.Empty || direccion.Trim() == string.Empty || telefono.Trim() == string.Empty || celular.Trim() == string.Empty || area.Trim() == string.Empty || curp.Trim() == string.Empty || rfc.Trim() == string.Empty)
                                                    {
                                                        ///Mandar al usuario el mensaje que indica que debe llenar todos los campos///
                                                        Console.WriteLine("Los campos son obligatorios");
                                                    }
                                                    ///Si no...//
                                                    else
                                                    {
                                                        ///Agregar un tamano de cuatro posiciones al arreglo///
                                                        doctor = new string[9];
                                                        ///Guardar en cada una de las pocisiones una variable llena///
                                                        ///El arreglo en la posicion 0 va a guardar la variable nombre///
                                                        doctor[0] = nombre;
                                                        ///El arreglo en la posicion 1 va a guardar la variable apellido///
                                                        doctor[1] = apellido;
                                                        ///El arreglo en la posicion 2 va a guardar la variable fechan///
                                                        doctor[2] = fechan;
                                                        ///El arreglo en la posicion 3 va a guardar la variable direccion///
                                                        doctor[3] = direccion;
                                                        ///El arreglo en la posicion 4 va a guardar la variable curp///
                                                        doctor[4] = curp;
                                                        ///El arreglo en la posicion 5 va a guardar la variable rfc///
                                                        doctor[5] = rfc;
                                                        ///El arreglo en la posicion 6 va a guardar la variable telefono///
                                                        doctor[6] = telefono;
                                                        ///El arreglo en la posicion 7 va a guardar la variable celular///
                                                        doctor[7] = celular;
                                                        ///El arreglo en la posicion 8 va a guardar la variable area///
                                                        doctor[8] = area;
                                                        ///Agregar a la lista 'doctores' todos los datos del arreglo///
                                                        doctores.Add(doctor);
                                                    }
                                                    Console.WriteLine("ACEPTAR");
                                                    break;
                                                case 2:
                                                    Console.Clear();
                                                    ///Si el usuario ingresa el numeo 2, el programa hara lo siguiente///
                                                    ///Mostrar el encabezado 'lista de doctores'///
                                                    Console.WriteLine("-------------Lista de doctores-------------");
                                                    ///Conectar un nuevo arreglo string con lo que hay en la lista de pacientes///
                                                    foreach (string[] item in doctores)
                                                    {
                                                        ///Imprimir el nombre del doctor///
                                                        ///"Nombre" + lo que vale el arreglo item en la posicion 0, que es igual a lo que vale el 
                                                        ///arreglo doctor en la lista de doctores///
                                                        Console.WriteLine("NOMBRE:  " + item[0] + " " + item[1]);
                                                        ///Imprimir la fecha de nacimiento///
                                                        Console.WriteLine("FECHA DE NACIMIENTO: " + item[2]);
                                                        ///Imprimir la direccion///
                                                        Console.WriteLine("DIRECCION: " + item[3]);
                                                        ///Imprimir la curp///
                                                        Console.WriteLine("CURP: " + item[4]);
                                                        ///Imprimir la rfc///
                                                        Console.WriteLine("RFC: " + item[5]);
                                                        ///Imprimir el telefono///
                                                        Console.WriteLine("TELEFONO: " + item[6]);
                                                        ///Imprimir el celular///
                                                        Console.WriteLine("CELULAR: " + item[7]);
                                                        ///Imprimir el area///
                                                        Console.WriteLine("AREA: " + item[8]);
                                                        Console.WriteLine("----------------------------------------------------------");
                                                    }
                                                    Console.WriteLine("ACEPTAR");
                                                    break;
                                                case 3:
                                                    Console.Clear();
                                                    ///Si el usuario ingresa el numero 3, el programa hara lo siguiente///
                                                    ///Mostrar la lista de doctores,  indicarlo por mensaje///
                                                    Console.WriteLine("-------------Lista de doctores-------------");
                                                    ///Agregar un for que vaya desde 0 hasta el numero de elementos en la lista de pacientes///
                                                    for (int i = 0; i < doctores.Count; i++)
                                                    {
                                                        ///Mostrar por mensaje todos los datos///
                                                        ///Mostrar el numero del doctor///
                                                        ///Mostrar el  nombre: mostrar en la posicion del contador el valor que hay en la lista
                                                        ///en la posicion 0;
                                                        ///Mostrar el apellido: mostrar en la posicion del contadol el valor que hay en la lista
                                                        ///en la posicion 1
                                                        ///Mostrar la fecha de nacimiento del doctor
                                                        ///mostrar en la posicion del contador lo que hay en la lista en la posicion 2
                                                        /// Mostrar la direccion mostrar en la posicion del contador lo que hay en la lista 
                                                        /// en la posicion 3///
                                                        /// Mostrar la curp en la posicion del contador lo que hay en la lista en la posicion 4
                                                        /// Mostrar el rfc en la posicion del contador lo que hay en la lista en la posicion 5
                                                        /// Mostrar el telefono en la  posicion del contador lo que hay en la lista en la posicion 6
                                                        /// Mostrar el celular en la posicion del contador lo que hay en la lista en la posicion 7
                                                        /// Mostrar el area en la posicion del contador lo que hay en la lista en la posicion 8///
                                                        Console.WriteLine(i + ")NOMBRE:  " + doctores[i][0] + " " + doctores[i][1]);
                                                        Console.WriteLine(i + ")FECHA DE NACIMIENTO: " + doctores[i][2]);
                                                        Console.WriteLine(i + ")DIRECCION: " + doctores[i][3]);
                                                        Console.WriteLine(i + ")CURP: " + doctores[i][4]);
                                                        Console.WriteLine(i + ")RFC: " + doctores[i][5]);
                                                        Console.WriteLine(i + ")TELEFONO: " + doctores[i][6]);
                                                        Console.WriteLine(i + ")CELULAR: " + doctores[i][7]);
                                                        Console.WriteLine(i + ")AREA: " + doctores[i][8]);
                                                        Console.WriteLine("----------------------------------------------------------");
                                                    }
                                                    ///Agregar un separador de informacion///
                                                    Console.WriteLine("--------------------------------------------------");
                                                    Console.WriteLine("");///Agregar un espacio///
                                                                          ///Pedir al usuario que ingrese la persona a editar///
                                                    Console.WriteLine("Ingrese la persona que desea editar:");
                                                    ///Declarar una variable string para leer la posicion del doctor a editar///
                                                    ///Leer la variable///
                                                    string posiciondoctor1 = Console.ReadLine();
                                                    ///Agregar un if///
                                                    if (int.TryParse(posiciondoctor1, out x))
                                                    {
                                                        ///Si la variable posiciondoctor1 se convierte en entero///
                                                        ///La palabra clave out hace que///
                                                        ///La variable posiciondoctor1 tenga valor igual a 0 como la variable x y luego tome
                                                        ///el valor leido///
                                                        ///Declarar una variable entera para la posicion del doctor e igualarla a lo que vale la
                                                        ///variable string declarada para la posicion del doctor///
                                                        int posiciondoctor = int.Parse(posiciondoctor1);
                                                        ///Agregar una condicional///
                                                        if (doctores.Count <= posiciondoctor || posiciondoctor < 0)
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
                                                            ///Pedir al usuario que ingrese el nombre del personal///
                                                            Console.WriteLine("Nombres");
                                                            ///Leer la variable string "nombre"///
                                                            nombre = Console.ReadLine();
                                                            ///Pedir al usuario que ingrese el apellido del personal///
                                                            Console.WriteLine("Apellidos");
                                                            ///Leer la variable string "apellido"///
                                                            apellido = Console.ReadLine();
                                                            ///Pedir al usuario que ingrese la fecha de nacimiento///
                                                            Console.WriteLine("Fecha de nacimiento");
                                                            ///Leer la variable string "edad"///
                                                            fechan = Console.ReadLine();
                                                            Console.WriteLine("Direccion");
                                                            ///Leer la variable string "nombre"///
                                                            direccion = Console.ReadLine();
                                                            ///Pedir al usuario que ingrese el apellido del personal///
                                                            Console.WriteLine("CURP");
                                                            ///Leer la variable string "apellido"///
                                                            curp = Console.ReadLine();
                                                            ///Pedir al usuario que ingrese la fecha de nacimiento///
                                                            Console.WriteLine("RFC");
                                                            ///Leer la variable string "edad"///
                                                            rfc = Console.ReadLine();
                                                            Console.WriteLine("Telefono");
                                                            ///Leer la variable string "nombre"///
                                                            telefono = Console.ReadLine();
                                                            ///Pedir al usuario que ingrese el apellido del personal///
                                                            Console.WriteLine("Celular");
                                                            ///Leer la variable string "apellido"///
                                                            celular = Console.ReadLine();
                                                            ///Pedir al usuario que ingrese la fecha de nacimiento///
                                                            Console.WriteLine("Area");
                                                            ///Leer la variable string "edad"///
                                                            area = Console.ReadLine();
                                                            ///Agregar un if, usando las herramientas trim para quitar todos los espacios
                                                            ///en blanco del valor agregado a la variable nombre, y si es igual a la una
                                                            ///variable string vacia, mostrar un mensaje que diga que los campos son obligatorios llenarlos///
                                                            ///Agregar doble barra para indicar que o si sucede con las demas variables, 
                                                            ///apellido, edad, sintomas, etc, mandar el mismo mensaje///
                                                            if (nombre.Trim() == string.Empty || apellido.Trim() == string.Empty || fechan.Trim() == string.Empty || direccion.Trim() == string.Empty || telefono.Trim() == string.Empty || celular.Trim() == string.Empty || area.Trim() == string.Empty || curp.Trim() == string.Empty || rfc.Trim() == string.Empty)
                                                            {
                                                                ///Mandar al usuario el mensaje que indica que debe llenar todos los campos///
                                                                Console.WriteLine("Los campos son obligatorios");
                                                            }

                                                            else
                                                            {
                                                                ///Si no, agregar los nuevos datos a la lista de doctores///
                                                                ///Agregar a la lista de doctores, en la posicion ingresada en la variable 
                                                                ///declarada para ello en la posicion 0 del arreglo el nuevo nombre ingresado///
                                                                doctores[posiciondoctor][0] = nombre;
                                                                ///Agregar a la lista de doctores, en la posicion ingresada en la variable 
                                                                ///declarada para ello en la posicion 1 del arreglo el nuevo apellido ingresado///
                                                                doctores[posiciondoctor][1] = apellido;
                                                                ///Agregar a la lista de doctores, en la posicion ingresada en la variable 
                                                                ///declarada para ello en la posicion 2 del arreglo la nueva fecha igresada///
                                                                doctores[posiciondoctor][2] = fechan;
                                                                ///Agregar a la lista de doctores, en la posicion ingresada en la variable 
                                                                ///declarada para ello en la posicion 3 del arreglo la nueva direccion ingresada///
                                                                doctores[posiciondoctor][3] = direccion;
                                                                ///Agregar a la lista de doctores, en la posicion ingresada en la variable 
                                                                ///declarada para ello en la posicion 4 del arreglo la nueva curp ingresada///
                                                                doctores[posiciondoctor][4] = curp;
                                                                ///Agregar a la lista de doctores, en la posicion ingresada en la variable 
                                                                ///declarada para ello en la posicion 5 del arreglo la nueva rfc ingresada///
                                                                doctores[posiciondoctor][5] = rfc;
                                                                ///Agregar a la lista de doctores, en la posicion ingresada en la variable 
                                                                ///declarada para ello en la posicion 6 del arreglo el nuevo telefono ingresado///
                                                                doctores[posiciondoctor][6] = telefono;
                                                                ///Agregar a la lista de doctores, en la posicion ingresada en la variable 
                                                                ///declarada para ello en la posicion 7 del arreglo el nuevo celular ingresado///
                                                                doctores[posiciondoctor][7] = celular;
                                                                ///Agregar a la lista de doctores, en la posicion ingresada en la variable 
                                                                ///declarada para ello en la posicion 8 del arreglo la nueva area ingresada///
                                                                doctores[posiciondoctor][8] = area;
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
                                                    ///Informar al usuario que esta en la lista de los doctores///
                                                    Console.WriteLine("-------------Lista de doctores-------------");
                                                    ///Agregar un for que vaya desde 0 hasta el numero de elementos en la lista de doctores///
                                                    for (int i = 0; i < doctores.Count; i++)
                                                    {
                                                        ///Mostrar por mensaje todos los datos///
                                                        ///Mostrar el numero del doctor///
                                                        ///Mostrar el  nombre: mostrar en la posicion del contador el valor que hay en la lista
                                                        ///en la posicion 0;
                                                        ///Mostrar el apellido: mostrar en la posicion del contadol el valor que hay en la lista
                                                        ///en la posicion 1
                                                        ///Mostrar la fecha de nacim: mostrar en la posicion del contador lo que hay en la lista
                                                        /// en la posicion 2
                                                        /// Mostrar la direccion: mostrar en la posicion del contador lo que hay en la lista 
                                                        /// en la posicion 3///
                                                        /// Mostrar la curp:  mostrar en la posicion del contador lo que hay en la lista 
                                                        /// en la posicion 4///
                                                        /// /// Mostrar la rfc:  mostrar en la posicion del contador lo que hay en la lista 
                                                        /// en la posicion 5///
                                                        /// /// Mostrar el telefono:  mostrar en la posicion del contador lo que hay en la lista 
                                                        /// en la posicion 6///
                                                        /// Mostrar el celular:  mostrar en la posicion del contador lo que hay en la lista 
                                                        /// en la posicion 7///
                                                        /// Mostrar el area:  mostrar en la posicion del contador lo que hay en la lista 
                                                        /// en la posicion 8///
                                                        Console.WriteLine(i + ")NOMBRE:  " + doctores[i][0] + " " + doctores[i][1]);
                                                        Console.WriteLine(i + ")FECHA DE NACIMIENTO: " + doctores[i][2]);
                                                        Console.WriteLine(i + ")DIRECCION: " + doctores[i][3]);
                                                        Console.WriteLine(i + ")CURP: " + doctores[i][4]);
                                                        Console.WriteLine(i + ")RFC: " + doctores[i][5]);
                                                        Console.WriteLine(i + ")TELEFONO: " + doctores[i][6]);
                                                        Console.WriteLine(i + ")CELULAR: " + doctores[i][7]);
                                                        Console.WriteLine(i + ")AREA: " + doctores[i][8]);
                                                        Console.WriteLine("----------------------------------------------------------");
                                                    }
                                                    ///Agregar un separador de informacion///
                                                    Console.WriteLine("--------------------------------------------------");
                                                    Console.WriteLine("");///Agregar espacio vacio///
                                                                          ///Pedir al usuario que ingrese la persona a eliminar///
                                                    Console.WriteLine("Ingrese el personal que desea eliminar");
                                                    ///Declarar una variable string para leer la posicion del doctor a eliminar///
                                                    ///Leer la variable///
                                                    string posiciondoctorPE = Console.ReadLine();
                                                    ///Agregar una condicional///
                                                    if (int.TryParse(posiciondoctorPE, out x))
                                                    {
                                                        ///Si la variable posiciondoctorPE se convierte en entero///
                                                        ///La palabra clave out hace que///
                                                        ///La variable posiciondoctorPEtenga valor igual a 0 como la variable x y luego tome
                                                        ///el valor leido///
                                                        ///Declarar una variable entera para la posicion del doctor e igualarla a lo que vale la
                                                        ///variable string declarada para la posicion del doctor///
                                                        int posiciondoctor = int.Parse(posiciondoctorPE);
                                                        if (doctores.Count <= posiciondoctor || posiciondoctor < 0)
                                                        {
                                                            ///Si la cantidad de posiciones en la lista de doctores es menor o igual a lo que vale la 
                                                            ///variable entera declarada para la posicion del doctor o si esa variable es menor a 0, 
                                                            ///entonces mandar un mensaje al usuario de que esa persona no esta registrada///
                                                            Console.WriteLine("PERSONA NO REGISTRADA");
                                                        }
                                                        else
                                                        {
                                                            ///Si no, utilizar la herramienta .RemoveAt para remover de la lista de pacientes
                                                            ///la posicion del paciente ingresada///
                                                            doctores.RemoveAt(posiciondoctor);
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

                                    break;
                                case 3:
                                    Console.Clear();

                                    break;
                                case 4:
                                    Console.WriteLine("SALIR");
                                    Console.Clear();
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("OPCIÓN NO VÁLIDA");
                                    Console.WriteLine("Pulse una tecla para elegir de nuevo");
                                    Console.ReadLine();
                                    break;



                            } while (opcion == 1 || opcion == 2 || opcion == 3 || opcion != 4) ;
                            Console.Clear();
                            Console.WriteLine();
                            if (opcion == 4)
                            {
                                Console.WriteLine("Pulse una tecla para salir del programa");
                            }
                            break;
                        } 
                        break;
                    case 2:
                        Console.Clear();

                        break;
                    case 3:
                        Console.Clear();

                        break;
                    case 4:
                        Console.Clear();
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

            } while (opcion == 1 || opcion == 2 || opcion == 3 || opcion != 4 );
            Console.Clear();
            Console.WriteLine();
        }

    }
}
