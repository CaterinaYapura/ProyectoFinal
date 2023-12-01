using bibliotecadb.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecadb.dominio
{
    internal interface ILibro
    {
        void agregarLibro(libros _libro);
        void eliminarLibro(int _id_Libro);
        void modificarLibro(libros _libro);
        List<libros> listarlibros();
        lectores buscarLibro(string _isbn);
        lectores buscarLibroXid(string _id_Libro);
    }
}
