using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonahuellasSi.model
{
    internal class Proyecto
    {
        private int idProyecto;
        private string nombreProyecto;
        private string descripcionProyecto;
        private int costoProyecto;

        public int IdProyecto
        {
            get { return idProyecto; }
            set { idProyecto = value; }
        }

        public string NombreProyecto
        {
            get { return nombreProyecto; }
            set { nombreProyecto = value; }
        }

        public string DescripcionProyecto
        {
            get { return descripcionProyecto; }
            set { descripcionProyecto = value; }
        }

        public int CostoProyecto
        {
            get { return costoProyecto; }
            set { costoProyecto = value; }
        }

        public Proyecto() { }

        public Proyecto(int idProyecto, string nombreProyecto, string descripcionProyecto, int costoProyecto)
        {
            this.idProyecto = idProyecto;
            this.nombreProyecto = nombreProyecto;
            this.descripcionProyecto = descripcionProyecto;
            this.costoProyecto = costoProyecto;
        }
    }
}

