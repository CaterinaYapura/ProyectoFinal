using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecadb.modelo
{
    internal class lectores
    {
        private int idLector;
        private string apellido;
        private string nombre;
        private string dni;
        private string domicilio;
        private string telefono;
        private bool activo;

        public lectores()
        {

        }

        public lectores(string apellido, string nombre, string dni, string domicilio, string telefono, bool activo)
        {
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.Dni = dni;
            this.Domicilio = domicilio;
            this.Telefono = telefono;
            this.Activo = activo;
        }

        public lectores(int idLector, string apellido, string nombre, string dni, string domicilio, string telefono, bool activo)
        {
            this.IdLector = idLector;
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.Dni = dni;
            this.Domicilio = domicilio;
            this.Telefono = telefono;
            this.Activo = activo;
        }

        public int IdLector { get => idLector; set => idLector = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public bool Activo { get => activo; set => activo = value; }
    }
}
