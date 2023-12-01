using bibliotecadb.datos;
using bibliotecadb.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using bibliotecadb.modelo;


namespace bibliotecadb.dominio
{
    internal class LectorData : ILector
    {
        private conexion conn;
        private MySqlCommand comando;
        public LectorData()
        {
            conn = new conexion();
        }

        public void agregarLector(lectores _lector)
        {
            string consulta = "INSERT INTO lectores(apellido,nombre,dni,domicilio,telefono,estado) VALUE (@apellido,@nombre,@dni,@domicilio,@telefono, TRUE);";

            comando= new MySqlCommand(consulta,conn.GetConexion());
            comando.Parameters.Add("@apellido",MySqlDbType.VarChar);
            comando.Parameters["@apellido"].Value = _lector.Apellido;
            comando.Parameters.Add("@nombre",MySqlDbType.VarChar);
            comando.Parameters["@nombre"].Value = _lector.Nombre;
            comando.Parameters.Add("@dni", MySqlDbType.VarChar);
            comando.Parameters["@dni"].Value = _lector.Dni;
            comando.Parameters.Add("@domicilio", MySqlDbType.VarChar);
            comando.Parameters["@domicilio"].Value = _lector.Domicilio;
            comando.Parameters.Add("@telefono", MySqlDbType.VarChar);
            comando.Parameters["@telefono"].Value = _lector.Telefono;
            comando.Parameters.Add("@estado", MySqlDbType.Int16);
            comando.Parameters["@estado"].Value = _lector.Activo;

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

        public lectores buscarLector(string _dni)
        {

            throw new NotImplementedException();
        }

        public lectores buscarLectorXid(int _idLector)
        {

            throw new NotFiniteNumberException();
        }

        public void eliminarLector(int _idLector)
        {
            string consulta = "UPDATE lectores SET activo= 0 WHERE idLector= @_idLector;";
            comando = new MySqlCommand(consulta, conn.GetConexion());
            
            comando.Parameters.Add("@estado", MySqlDbType.Int16);
            comando.Parameters["@estado"].Value = _idLector;

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

        public List<lectores> listarLectores()
        {
            List<lectores> listaLectores= new List<lectores> ();
            string consulta = "SELECT *FROM lectores WHERE estado=1;";
            comando = new MySqlCommand(consulta,conn.GetConexion());
            try
            {
                MySqlDataReader puntero = comando.ExecuteReader();
                while (puntero.Read())
                {
                    lectores _lector = new lectores();
                    _lector.IdLector = puntero.GetInt16(0);
                    _lector.Apellido = puntero.GetString(1);
                    _lector.Nombre = puntero.GetString(2);
                    _lector.Dni = puntero.GetString(3);
                    _lector.Domicilio = puntero.GetString(4);
                    _lector.Telefono = puntero.GetString(5);
                    _lector.Activo = puntero.GetBoolean(6);

                    listaLectores.Add(_lector);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return (listaLectores);

        }

        public void modificarLector(lectores _lector)
        {
            throw new NotImplementedException();
        }
    }
}
