using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Juego.BD
{
    class INSERT
    {
        OleDbConnection conexion = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BASE_DATOS.mdb;Persist Security Info=False");
        OleDbCommand comand = new OleDbCommand();
        public INSERT()
        {
           
        }
        public bool INSERT_CUESTIONARIO(string Nombre)
        {
            try
            {
                OleDbCommand CommandQuery = new OleDbCommand("INSERT INTO CUESTIONARIO(Nombre, Status) VALUES('" + Nombre + "','" + 0 + "')", conexion);
                OleDbDataAdapter add = new OleDbDataAdapter();
                conexion.Open();
                add.InsertCommand = CommandQuery;
                add.InsertCommand.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (OleDbException)
            {
                return false;
            }
        }
        public bool INSERT_PREGUNTAS(int Id_cuest, string Pregunta, string Respuesta, string Opcion2, string Opcion3, string Opcion4)
        {
            try
            {
                OleDbCommand CommandQuery = new OleDbCommand("INSERT INTO PREGUNTAS(Id_cuest, Pregunta, Respuesta, Opcion2, Opcion3, Opcion4) VALUES('"
                    + Id_cuest + "','" + Pregunta + "','" + Respuesta + "','" + Opcion2 +"','"+Opcion3+"','"+Opcion4+ "')", conexion);
                OleDbDataAdapter add = new OleDbDataAdapter();
                conexion.Open();
                add.InsertCommand = CommandQuery;
                add.InsertCommand.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (OleDbException)
            {
                return false;
            }
        }
        
    }
}
