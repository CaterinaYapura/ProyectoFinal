using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using bibliotecadb.datos;

namespace bibliotecadb.datos
{
    internal class conexion
    {
        private static string servidor = "127.0.0.1";
        private static string usuario = "root";
        private static string password = "";
        private static string BaseDatos = "dbbiblioteca";

        private static string CadenaConexion = "server=" + servidor + ";DataBase=" + BaseDatos + ";Uid=" + usuario + ";Pwd=" + password;

        //private static string CadenaConexion = "Server=127.0.01;DataBase=dbbiblioteca;Uid=root;Pwd=";
        public conexion()
        {

        }
        public MySqlConnection conn;
        public MySqlConnection GetConexion()
        {
            if (conn == null)
            {
                try
                {
                    conn = new MySqlConnection(CadenaConexion);
                    conn.Open();
                }
                catch (MySqlException error)
                {
                    throw;
                }

            }
            return conn;
        }
        public void setConexion()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public ConnectionState estadoConexion()
        {
            return (conn.State);
        }
    }
}
    





