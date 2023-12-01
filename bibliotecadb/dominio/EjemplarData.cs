using bibliotecadb.datos;
using bibliotecadb.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace bibliotecadb.dominio
{
    internal class EjemplarData : IEjemplar
    {

        private conexion conn = new conexion();
        private MySqlCommand comando;

        public EjemplarData()
        {

        }

        public void agregarEjemplar(ejemplares _ejemplar)
        {
            string sql = "INSERT INTO ejemplares(codigo,id_libro,cantidad,estado) VALUE (@codigo,@id_libro,@cantidad, TRUE);";

            comando = new MySqlCommand(sql, conn.GetConexion());

            comando.Parameters.Add("@codigo",MySqlDbType.VarChar);
            comando.Parameters["@codigo"].Value = _ejemplar.Codigo;
            comando.Parameters.Add("@id_libro", MySqlDbType.VarChar);
            comando.Parameters["@id_libro"].Value = _ejemplar.Id_libro;
            comando.Parameters.Add("@cantidad", MySqlDbType.VarChar);
            comando.Parameters["@cantidad"].Value = _ejemplar.Cantidad;
            comando.Parameters.Add("@estado", MySqlDbType.Int16);
            comando.Parameters["@estado"].Value = _ejemplar.Estado;

            try
            {
                int resultado = comando.ExecuteNonQuery();
                conn.setConexion();
            }
            catch (MySqlException error)
            {
                throw;
            }
            finally 
            {
                if(conn.estadoConexion() == System.Data.ConnectionState.Open) 
                {
                    conn.setConexion();       
                }
                comando.Dispose();
            }
        }

        public lectores buscarEjemplar(string _codigo)
        {
            throw new NotImplementedException();
        }

        public lectores buscarEjemplarXid(string _id_ejemplar)
        {
            throw new NotImplementedException();
        }

        public void eliminarEjemplar(int _id_ejemplar)
        {
            string sql = "UPDATE ejemplares SET estado= FALSE WHERE idEjemplar= @_id_ejemplar;";

            comando = new MySqlCommand(sql, conn.GetConexion());

            comando.Parameters.Add("@_id_ejemplar", MySqlDbType.VarChar);
            comando.Parameters["@_id_ejemplar"].Value = _id_ejemplar;
            
            try
            {
                int resultado = comando.ExecuteNonQuery();
                conn.setConexion();
            }
            catch (MySqlException error)
            {
                throw;
            }
            finally
            {
                if (conn.estadoConexion() == System.Data.ConnectionState.Open)
                {
                    conn.setConexion();
                }
                comando.Dispose();
            }
        }

        public List<ejemplares> listarEjemplar()
        {
            throw new NotImplementedException();
        }

        public void modificarEjemplar(ejemplares _ejemplar)
        {
            throw new NotImplementedException();
        }
    }
}
