using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonahuellasSi.model
{
    internal class Donante
    {
        private int idDonante;
        private string nombreDonante;
        private string telefonoDonante;
        private string rutDonante;

        public int IdDonante
        {
            get { return idDonante; }
            set { idDonante = value; }
        }

        public string NombreDonante
        {
            get { return nombreDonante; }
            set { nombreDonante = value; }
        }

        public string TelefonoDonante
        {
            get { return telefonoDonante; }
            set { telefonoDonante = value; }
        }

        public string RutDonante
        {
            get { return rutDonante; }
            set { rutDonante = value; }
        }

        public Donante() { }

        public Donante(int idDonante, string nombreDonante, string telefonoDonante, string rutDonante)
        {
            this.idDonante = idDonante;
            this.nombreDonante = nombreDonante;
            this.telefonoDonante = telefonoDonante;
            this.rutDonante = rutDonante;
        }

        public string NombreRut => $"{NombreDonante} - {RutDonante}";
    }
}
