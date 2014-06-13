using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Juego.BD
{
    class SELECT
    {
        OleDbConnection conexion = new OleDbConnection();
      

        public SELECT()
        {
            conexion.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BASE_DATOS.mdb;Persist Security Info=False";
            
        }
       
     
        public List<Cuestionario> Cuestionario()
        {
            List<Cuestionario> categorias = new List<Cuestionario>();
            OleDbCommand comand = new OleDbCommand();
            OleDbDataReader read;
            comand.Connection = conexion;
            try
            {
                string q = "SELECT*FROM CUESTIONARIO";
                comand.CommandText = q;
                conexion.Open();
                read = comand.ExecuteReader();
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        var ctg = new Cuestionario()
                        {
                            Id = int.Parse(read[0].ToString()),
                            Nombre = read[1].ToString(),
                            Status = int.Parse(read[2].ToString())
                        };
                        categorias.Add(ctg);
                    }
                }
                read.Close();
                conexion.Close();
                return categorias;
            }
            catch (OleDbException)
            {
                conexion.Close();
                return categorias;
            }
        
        }
        public List<Preguntas> Preguntas()
        {
            List<Preguntas> prg = new List<Preguntas>();
            OleDbCommand comand = new OleDbCommand();
            OleDbDataReader read;
            comand.Connection = conexion;
            int id=0;
            try
            {
                string q = "SELECT*FROM PREGUNTAS";
                comand.CommandText = q;
                conexion.Open();
                read = comand.ExecuteReader();
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        id++;
                        var pregunta = new Preguntas()
                        {
                            Id_Juego=id, Id=int.Parse(read[0].ToString()),
                            Id_cuest=int.Parse(read[1].ToString()), 
                            Pregunta=read[2].ToString(),
                            Respuesta=read[3].ToString(),
                            Opcion2=read[4].ToString(), 
                            Opcion3=read[5].ToString(), 
                            Opcion4=read[6].ToString()
                        };
                        prg.Add(pregunta);
                    }
                }
                read.Close();
                conexion.Close();
                return prg;
            }
            catch (OleDbException)
            {
                conexion.Close();
                return prg;
            }

        }
  
       
    }
}
