using bibliotecadb.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecadb.dominio
{
    internal interface IEjemplar
    {
        void agregarEjemplar(ejemplares _ejemplar);
        void eliminarEjemplar(int _id_ejemplar);
        void modificarEjemplar(ejemplares _ejemplar);
        List<ejemplares> listarEjemplar();
        lectores buscarEjemplar(string _codigo);
        lectores buscarEjemplarXid(string _id_ejemplar);
    }
}
