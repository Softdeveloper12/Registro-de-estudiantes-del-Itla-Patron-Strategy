using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using SpreadsheetLight;

namespace Registro_de_estudiantes_del_Itla__Patron_Strategy_
{
    class CExcell: IStrategy
    {
        public void persistir(string matricula, string nombres, string apellidos, string carrera, string direccion, string telefono, string email)
        {

            string file = AppDomain.CurrentDomain.BaseDirectory + "Formulario Strategy.xlsx";

            SLDocument exc = new SLDocument();

            System.Data.DataTable table = new System.Data.DataTable();

            table.Columns.Add("Matricula", typeof(string));
            table.Columns.Add("Nombre", typeof(string));
            table.Columns.Add("Apellido", typeof(string));
            table.Columns.Add("Carrera", typeof(string));
            table.Columns.Add("Dirección", typeof(string));
            table.Columns.Add("Telefono", typeof(string));
            table.Columns.Add("Email", typeof(string));

            table.Rows.Add($"{matricula}", $"{nombres}", $"{apellidos}", $"{carrera}", $"{direccion}", $"{telefono}", $"{email}");
            if (File.Exists(file) != true)
            {
                SLDocument document = new SLDocument();
                document.SaveAs(file);

            }
           
            int celda = 2;
            SLDocument exc2 = new SLDocument(file);
            System.Data.DataTable table2 = new System.Data.DataTable();
            while (!string.IsNullOrEmpty(exc2.GetCellValueAsString(celda, 1)))
            {

                matricula = exc2.GetCellValueAsString(celda, 1);
                nombres = exc2.GetCellValueAsString(celda, 2);
                apellidos = exc2.GetCellValueAsString(celda, 3);
                carrera = exc2.GetCellValueAsString(celda, 4);
                direccion = exc2.GetCellValueAsString(celda, 5);
                telefono = exc2.GetCellValueAsString(celda, 6);
                email = exc2.GetCellValueAsString(celda, 7);

                table.Rows.Add(matricula, nombres, apellidos, carrera, direccion, telefono, email);

                celda++;
            }

            exc.ImportDataTable(1, 1, table, true);
            exc2.ImportDataTable(1, 1, table2, false);
            exc.SaveAs(file);
            Console.WriteLine("Listo");
        }
        }
    }

