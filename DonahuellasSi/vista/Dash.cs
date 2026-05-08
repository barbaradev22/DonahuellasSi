using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonahuellasSi.vista
{
    public partial class Dash : Form
    {
        public Dash()
        {
            InitializeComponent();
        }

        private void Dash_Load(object sender, EventArgs e)
        {
            this.proyectoTableAdapter.Fill(this.donaHuellasDataSet2.proyecto);
        }

        private void cargarProyectos()
        {
            // TODO: esta línea de código carga datos en la tabla 'donaHuellasDataSet2.proyecto' Puede moverla o quitarla según sea necesario.
            // Pintar lista con proyectos.
            this.proyectoTableAdapter.Fill(this.donaHuellasDataSet2.proyecto);

        }

        private void cargarDonantes()
        {
            // TODO: esta línea de código carga datos en la tabla 'donaHuellasDataSet1.donante' Puede moverla o quitarla según sea necesario.
            // Pintar lista con donantes.
            this.donanteTableAdapter.Fill(this.donaHuellasDataSet1.donante);


        }

        private void rBtnDonantes_CheckedChanged(object sender, EventArgs e)
        {
            cargarDonantes();
        }

        private void rBtnProyectos_CheckedChanged(object sender, EventArgs e)
        {
            cargarProyectos();
        }
    }
}
