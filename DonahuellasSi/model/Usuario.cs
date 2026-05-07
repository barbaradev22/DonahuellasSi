using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonahuellasSi.model
{
    internal class Usuario
    {
        private int id;
        private string nombre;
        private string password;

        // Propiedades explícitas con Getters y Setters.
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        /// <summary>
        /// Constructor por defecto necesario para frameworks de serialización.
        /// </summary>
        public Usuario()
        {
        }

        /// <summary>
        /// Constructor con parámetros para inicializar el objeto rápidamente.
        /// </summary>
        public Usuario(int id, string nombre, string password)
        {
            this.id = id;
            this.nombre = nombre;
            this.password = password;
        }
    }
}
