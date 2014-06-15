using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
namespace Juego_Hum.BD
{
    class UPDATE
    {
        public UPDATE()
        {

        }
        OleDbConnection conexion = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BASE_DATOS.mdb;Persist Security Info=False");

        public bool Preguntas(string Pregunta, string Respuesta, string Opcion2, string Opcion3, string Opcion4, int Id)
        {
            OleDbCommand comand = new OleDbCommand();
            try
            {
                conexion.Open();
                string query = "UPDATE [PREGUNTAS] SET Pregunta=?, Respuesta=?, Opcion2=?, Opcion3=?, Opcion4=? WHERE Id = ?";
                OleDbDataAdapter update = new OleDbDataAdapter();
                var accessUpdateCommand = new OleDbCommand(query, conexion);
                accessUpdateCommand.Parameters.AddWithValue("Pregunta", Pregunta);
                accessUpdateCommand.Parameters.AddWithValue("Respuesta", Respuesta);
                accessUpdateCommand.Parameters.AddWithValue("Opcion2", Opcion2);
                accessUpdateCommand.Parameters.AddWithValue("Opcion3", Opcion3);
                accessUpdateCommand.Parameters.AddWithValue("Opcion4", Opcion4);
                accessUpdateCommand.Parameters.AddWithValue("Id", Id);
                // Replace "123" with the variable where your ID is stored. Maybe row[0] ?
                update.UpdateCommand = accessUpdateCommand;
                update.UpdateCommand.ExecuteNonQuery();
                conexion.Close();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Cuestionario(int Id, int estado)
        {
            OleDbCommand comand = new OleDbCommand();
            try
            {
                conexion.Open();
                string query = "UPDATE [CUESTIONARIO] SET Status=? WHERE Id = ?";
                OleDbDataAdapter update = new OleDbDataAdapter();
                var accessUpdateCommand = new OleDbCommand(query, conexion);
                accessUpdateCommand.Parameters.AddWithValue("Status", estado);
                accessUpdateCommand.Parameters.AddWithValue("Id", Id);
                update.UpdateCommand = accessUpdateCommand;
                update.UpdateCommand.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
