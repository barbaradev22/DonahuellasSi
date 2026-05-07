using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonahuellasSi.model
{
    internal class Aporte
    {
        private int id;
        private int idProyecto;
        private int idDonante;
        private int cantidadDonada;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int IdProyecto
        {
            get { return idProyecto; }
            set { idProyecto = value; }
        }

        public int IdDonante
        {
            get { return idDonante; }
            set { idDonante = value; }
        }

        public int CantidadDonada
        {
            get { return cantidadDonada; }
            set { cantidadDonada = value; }
        }

        public Aporte() { }

        public Aporte(int id, int idProyecto, int idDonante, int cantidadDonada)
        {
            this.id = id;
            this.idProyecto = idProyecto;
            this.idDonante = idDonante;
            this.cantidadDonada = cantidadDonada;
        }
    }
}
