using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonahuellasSi.vista.Forms
{
    public partial class FormProyectos : Form
    {
        public FormProyectos()
        {
            InitializeComponent();
        }

        private void FormProyectos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'donaHuellasDataSet3.proyecto' Puede moverla o quitarla según sea necesario.
            this.proyectoTableAdapter.Fill(this.donaHuellasDataSet3.proyecto);

        }
    }
}
