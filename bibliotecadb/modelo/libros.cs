using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecadb.modelo
{
    internal class libros
    {
        private int id_Libro {  get; set; }
        private string isbn {  get; set; }
        private string nombre {  get; set; }
        private string tipo {  get; set; }
        private string editorial { get; set; }
        private string autor { get; set; }
        private bool estado { get; set; }

        public libros()
        {

        }
        public libros(string isbn, string nombre, string tipo, string editorial, string autor, bool estado)
        {
            this.isbn = isbn;
            this.nombre = nombre;
            this.tipo = tipo;
            this.editorial = editorial;
            this.autor = autor;
            this.estado = estado;
        }

        public libros(int id_Libro, string isbn, string nombre, string tipo, string editorial, string autor, bool estado)
        {
            this.id_Libro = id_Libro;
            this.isbn = isbn;
            this.nombre = nombre;
            this.tipo = tipo;
            this.editorial = editorial;
            this.autor = autor;
            this.estado = estado;
        }
    }
}
