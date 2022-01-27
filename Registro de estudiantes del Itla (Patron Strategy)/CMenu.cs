using System;
using System.Collections.Generic;
using System.Text;



namespace Registro_de_estudiantes_del_Itla__Patron_Strategy_
{
    class CMenu
    {
        public static void menu()
        {
            CEstudiante student = null;
            Console.WriteLine("1- Registrar Estudiante");
            Console.WriteLine("2- Salir");
            int opt = int.Parse(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    Console.WriteLine("\nIngrese su Matricula:");
                    CEstudiante.matricula = Console.ReadLine();
                    Console.WriteLine("\n Sus Nombres:");
                    CEstudiante.nombres = Console.ReadLine();
                    Console.WriteLine("\n Sus Apellidos:");
                    CEstudiante.apellidos = Console.ReadLine();
                    Console.WriteLine("\n Su Carrera:");
                    CEstudiante.carrera = Console.ReadLine();
                    Console.WriteLine("\n Su Direccion:");
                    CEstudiante.direccion = Console.ReadLine();
                    Console.WriteLine("\nSu Telefono:");
                    CEstudiante.telefono = Console.ReadLine();
                    Console.WriteLine("\nSu Email:");
                    CEstudiante.email = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Ingrese la opcion en la forma que desea guardar sus datos.");
                    Console.WriteLine("1- Formato de texto o TXT");
                    Console.WriteLine("2- Formato Excell");
                    Console.WriteLine("3- Formato Json");
                    int opc= int.Parse(Console.ReadLine());
                    switch (opc)
                    {
                        case 1:
                            CTexto txt = new CTexto();
                            student = new CEstudiante(txt);
                            
                            break;
                        case 2:
                            CExcell excell = new CExcell();
                            student = new CEstudiante(excell);
                            
                            break;
                        case 3:
                            CJson CJson = new CJson();
                            student = new CEstudiante(CJson);
                            
                            break;
                        default:
                            Console.WriteLine("Opcion Incorrecta, Presione Enter para regresar...!!");
                            Console.ReadKey();
                            Console.Clear();
                            menu();
                            break;
                    }
                    break;
                   
                case 2:
                    Console.WriteLine("Gracias por su participacion, hasta luego...");
                    Console.ReadKey();
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Opcion Incorrecta, Por favor presione Enter para continuar....");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                    
            }
            student.Ejecutar();
        }
    }
}
