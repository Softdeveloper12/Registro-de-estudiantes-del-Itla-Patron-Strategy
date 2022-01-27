using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Registro_de_estudiantes_del_Itla__Patron_Strategy_
{
    class CTexto: IStrategy
    {
       
        public void persistir(string matricula, string nombres, string apellidos, string carrera, string direccion, string telefono, string email)
        {
            StreamWriter archivo = new StreamWriter("Patron Strategy.txt", append:true);
            archivo.WriteLine($"-Matricula:{matricula}\n-Nombres:{nombres}\n-Apellidos:{apellidos}\n -Carrera:{carrera}\n-Direccion:{direccion}\n-Telefono:{telefono}\n-Email:{email}");
            archivo.WriteLine("--------------------------------------------------------------------");
            archivo.Close();
            Console.WriteLine("Listo");
        }
    }
}
