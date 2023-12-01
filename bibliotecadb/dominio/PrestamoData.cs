using bibliotecadb.datos;
using bibliotecadb.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecadb.dominio
{
    internal class PrestamoData : IPrestamo
    {
        private conexion conn = new conexion();
        public PrestamoData()
        {

        }
        public void agregarPrestamo(prestamos _prestamo)
        {
            throw new NotImplementedException();
        }

        public lectores buscarPrestamo(string _id_ejemplar)
        {
            throw new NotImplementedException();
        }

        public lectores buscarPrestamoXid(string _id_Prestamo)
        {
            throw new NotImplementedException();
        }

        public void eliminarPrestamo(int _id_Prestamo)
        {
            throw new NotImplementedException();
        }

        public List<prestamos> listarPrestamos()
        {
            throw new NotImplementedException();
        }

        public void modificarPrestamo(prestamos _prestamo)
        {
            throw new NotImplementedException();
        }
    }
}
