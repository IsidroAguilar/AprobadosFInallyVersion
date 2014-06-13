using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Juego.BD
{
    class DELETE
    {
        OleDbConnection conexion = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BASE_DATOS.mdb;Persist Security Info=False");
        OleDbCommand comand = new OleDbCommand();
        public DELETE()
        {
                
        }
        public bool Categoria( string Nombre)
        {
            try
            {
                //int Id = int.Parse(comboBox1.Text);
                conexion.Open();
                string query = "DELETE FROM CUESTIONARIO WHERE Nombre = ?";
                OleDbDataAdapter delete = new OleDbDataAdapter();
                var accessDltCommand = new OleDbCommand(query, conexion);


                accessDltCommand.Parameters.AddWithValue("Id",Nombre ); // Replace "123" with the variable where your ID is stored. Maybe row[0] ?
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
        public bool Pregunta(string Nombre)
        {
            try
            {
                //int Id = int.Parse(comboBox1.Text);
                conexion.Open();
                string query = "DELETE FROM PREGUNTAS WHERE Pregunta = ?";
                OleDbDataAdapter delete = new OleDbDataAdapter();
                var accessDltCommand = new OleDbCommand(query, conexion);


                accessDltCommand.Parameters.AddWithValue("Pregunta", Nombre); 
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
    }
}
