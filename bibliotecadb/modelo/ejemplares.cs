using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecadb.modelo
{
    internal class ejemplares
    {
        private int id_ejemplar;
        private string codigo;
        private int id_libro;
        private bool estado;
        private int cantidad;
  

        public ejemplares()
        {
        }

        public ejemplares(string codigo, int id_libro, bool estado, int cantidad)
        {
            this.Codigo = codigo;
            this.id_libro = id_libro;
            this.estado = estado;
            this.cantidad = cantidad;
        }

        public ejemplares(int id_ejemplar, string codigo, int id_libro, bool estado, int cantidad)
        {
            id_ejemplar = id_ejemplar;
            this.Codigo = codigo;
            this.id_libro = id_libro;
            this.estado = estado;
            this.cantidad = cantidad;
        }

        public int Id_ejemplar { get => id_ejemplar; set => id_ejemplar = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public int Id_libro { get => id_libro; set => id_libro = value; }
        public bool Estado { get => estado; set => estado = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
