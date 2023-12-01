using bibliotecadb.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecadb.dominio
{
    internal interface IPrestamo
    {

        void agregarPrestamo(prestamos _prestamo);
        void eliminarPrestamo(int _id_Prestamo);
        void modificarPrestamo(prestamos _prestamo);
        List<prestamos> listarPrestamos();
        lectores buscarPrestamo(string _id_ejemplar);
        lectores buscarPrestamoXid(string _id_Prestamo);
    }
}
