using bibliotecadb.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecadb.dominio
{
    internal interface ILector
    {
        void agregarLector(lectores _lector);
        void eliminarLector(int _idLector);
        void modificarLector(lectores _lector);
        List<lectores> listarLectores();
        lectores buscarLector(string _dni);
        lectores buscarLectorXid(int _idLector);
    }
}
