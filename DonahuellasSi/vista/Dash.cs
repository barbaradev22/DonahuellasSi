using DonahuellasSi.dao;
using DonahuellasSi.model;
using DonahuellasSi.vista.Forms;
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
            cargarProyectos();
        }

        private void cargarProyectos()
        {
            DAOProyecto daoP = new DAOProyecto();
            List<Proyecto> lista = daoP.listar();
            BindingList<Proyecto> bindingList = new BindingList<Proyecto>(lista);
            tablaPrincipal.AutoGenerateColumns = true;
            tablaPrincipal.DataSource = bindingList;
        }

        private void cargarDonantes()
        {
            DAODonante daoD = new DAODonante();
            List<Donante> lista = daoD.listar();
            BindingList<Donante> bindingList = new BindingList<Donante>(lista);
            tablaPrincipal.AutoGenerateColumns = true;
            tablaPrincipal.DataSource = bindingList;
        }

        private void cargarAportes()
        {
            DAOAporteDetalle daoAD = new DAOAporteDetalle();
            List<AporteDetalle> lista = daoAD.listarTodo();
            BindingList<AporteDetalle> bindingList = new BindingList<AporteDetalle>(lista);
            tablaPrincipal.AutoGenerateColumns = true;
            tablaPrincipal.DataSource = bindingList;
        }

        private void rBtnDonantes_CheckedChanged(object sender, EventArgs e)
        {
            cargarDonantes();
        }

        private void rBtnProyectos_CheckedChanged(object sender, EventArgs e)
        {
            cargarProyectos();
        }

        private void rBtnAportes_CheckedChanged(object sender, EventArgs e)
        {
            cargarAportes();
        }

        private void donantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDonantes ventana = new FormDonantes();
            ventana.ShowDialog();
        }

        private void aportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAportes ventana = new FormAportes();
                ventana.ShowDialog();
        }
        private void proyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProyectos ventana = new FormProyectos();
            ventana.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (rBtnAportes.Checked)
            {
                cargarAportes();
            } else if (rBtnProyectos.Checked)
            {
                cargarProyectos();
            }
            else
            {
                cargarDonantes();
            }
        }
    }
}
