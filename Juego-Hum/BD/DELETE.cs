using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Juego_Hum.BD
{
    class DELETE
    {
        OleDbConnection conexion = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BASE_DATOS.mdb;Persist Security Info=False");
        OleDbCommand comand = new OleDbCommand();
        public DELETE()
        {

        }
        public bool Cuestionario(int Id)
        {
            try
            {
                conexion.Open();
                string query = "DELETE FROM CUESTIONARIO WHERE Id = ?";
                OleDbDataAdapter delete = new OleDbDataAdapter();
                var accessDltCommand = new OleDbCommand(query, conexion);
                accessDltCommand.Parameters.AddWithValue("Id", Id); 
                delete.DeleteCommand = accessDltCommand;
                delete.DeleteCommand.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Pregunta(int Id)
        {
            try
            {
                conexion.Open();
                string query = "DELETE FROM PREGUNTAS WHERE Id = ?";
                OleDbDataAdapter delete = new OleDbDataAdapter();
                var accessDltCommand = new OleDbCommand(query, conexion);
                accessDltCommand.Parameters.AddWithValue("Id", Id);
                delete.DeleteCommand = accessDltCommand;
                delete.DeleteCommand.ExecuteNonQuery();
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
