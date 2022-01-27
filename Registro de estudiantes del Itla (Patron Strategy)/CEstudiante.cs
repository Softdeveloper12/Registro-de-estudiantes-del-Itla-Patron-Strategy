using System;
using System.Collections.Generic;
using System.Text;

namespace Registro_de_estudiantes_del_Itla__Patron_Strategy_
{
    class CEstudiante
    {
        public CEstudiante(IStrategy mistrategy)
        {
            strategy = mistrategy;
                
        }

        IStrategy strategy=null;
        public static string matricula { get; set; }
        public static string nombres{ get; set; }
        public static string apellidos { get; set; }
        public static string carrera { get; set; }
        public static string direccion { get; set; }
        public static string telefono { get; set; }
        public static string email { get; set; }
        public void Ejecutar()
        {
            strategy.persistir( matricula, nombres, apellidos, carrera, direccion, telefono,email);
        }

    }
    
}
