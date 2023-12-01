using bibliotecadb.datos;
using bibliotecadb.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecadb.dominio
{
    internal class LibroData : ILibro
    {
        private conexion conn = new conexion();
        public LibroData()
        {

        }

        public void agregarLibro(libros _libro)
        {
            throw new NotImplementedException();
        }

        public lectores buscarLibro(string _isbn)
        {
            throw new NotImplementedException();
        }

        public lectores buscarLibroXid(string _id_Libro)
        {
            throw new NotImplementedException();
        }

        public void eliminarLibro(int _id_Libro)
        {
            throw new NotImplementedException();
        }

        public List<libros> listarlibros()
        {
            throw new NotImplementedException();
        }

        public void modificarLibro(libros _libro)
        {
            throw new NotImplementedException();
        }
    }
}
