using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecadb.modelo
{
    internal class prestamos
    {
        private int id_Prestamo {  get; set; }
        private int id_lector {  get; set; }
        private int id_ejemplar { get; set; }
        private DateTime fechaPrestamos { get; set; }
        private DateTime fechaEntrega {  get; set; }
         private bool estado {  get; set; }

        public prestamos()
        {
        }

        public prestamos(int id_lector, int id_ejemplar, DateTime fechaPrestamos, DateTime fechaEntrega, bool estado)
        {
            this.id_lector = id_lector;
            this.id_ejemplar = id_ejemplar;
            this.fechaPrestamos = fechaPrestamos;
            this.fechaEntrega = fechaEntrega;
            this.estado = estado;
        }

        public prestamos(int id_Prestamo, int id_lector, int id_ejemplar, DateTime fechaPrestamos, DateTime fechaEntrega, bool estado)
        {
            this.id_Prestamo = id_Prestamo;
            this.id_lector = id_lector;
            this.id_ejemplar = id_ejemplar;
            this.fechaPrestamos = fechaPrestamos;
            this.fechaEntrega = fechaEntrega;
            this.estado = estado;
        }
    }
}
