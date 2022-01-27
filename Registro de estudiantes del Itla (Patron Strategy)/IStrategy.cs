using System;
using System.Collections.Generic;
using System.Text;

namespace Registro_de_estudiantes_del_Itla__Patron_Strategy_
{
    interface IStrategy
    {
        void persistir(string matricula, string nombres, string apellidos, string carrera, string direccion, string telefono, string email);
    }
}
