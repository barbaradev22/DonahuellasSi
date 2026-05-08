using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonahuellasSi.model
{
    internal class AporteDetalle
    {
        private int id;
        private string proyecto;
        private string donante;
        private int montodonado;
        private DateTime fechaAporte;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Proyecto
        {
            get { return proyecto; }
            set { proyecto = value; }
        }

        public string Donante
        {
            get { return donante; }
            set { donante = value; }
        }

        public int Montodonado
        {
            get { return montodonado; }
            set { montodonado = value; }
        }

        public DateTime FechaAporte
        {
            get { return fechaAporte; }
            set { fechaAporte = value; }
        }

        public AporteDetalle()
        {
        }

        public AporteDetalle(int id, string proyecto, string donante, int montodonado, DateTime fechaAporte)
        {
            this.id = id;
            this.proyecto = proyecto;
            this.donante = donante;
            this.montodonado = montodonado;
            this.fechaAporte = fechaAporte;
        }
    }
}
