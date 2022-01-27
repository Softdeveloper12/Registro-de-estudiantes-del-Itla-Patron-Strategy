using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace Registro_de_estudiantes_del_Itla__Patron_Strategy_
{
    class CJson:IStrategy
    {
        public void persistir(string matricula, string nombres, string apellidos, string carrera, string direccion, string telefono, string email)
        {
            string ruta = AppDomain.CurrentDomain.BaseDirectory + "Patron Estrategia.json";
            string mijson = JsonConvert.SerializeObject((matricula, nombres, apellidos, carrera, direccion, telefono, email), Formatting.Indented);
            if (File.Exists(ruta) != true)
            {
                File.Create(ruta);
            }
            var forJson= File.ReadAllText(ruta);
            if (forJson.Length!=0 && forJson.Length< 500)
            {
                forJson = forJson.Remove(forJson.Length - 3) + "," + mijson + "]";
                File.WriteAllText(ruta, string.Empty);
                File.WriteAllText(ruta, forJson);
            }
            else if (forJson.Length > 500)
            {
                forJson = forJson.Remove(forJson.Length - 1) + "," + mijson + "]";
                File.WriteAllText(ruta, string.Empty);
                File.WriteAllText(ruta, forJson);
            }
            else
            {
                StreamWriter streamWriter = File.AppendText(ruta);
                streamWriter.WriteLine("["+mijson+"]");
                streamWriter.Close();
                Console.WriteLine("Listo");

            }
        }
    }
}
