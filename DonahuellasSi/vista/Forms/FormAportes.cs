using DonahuellasSi.dao;
using DonahuellasSi.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonahuellasSi.vista.Forms
{
    public partial class FormAportes : Form
    {
        private DAOAporteDetalle daoAD = new DAOAporteDetalle();
        private DAOAporte daoA = new DAOAporte();
        private DAODonante daoD = new DAODonante();
        private DAOProyecto daoP = new DAOProyecto();

        public FormAportes()
        {
            InitializeComponent();
            customProperties();
        }

        private void cargarAportes()
        {
            DAOAporteDetalle daoAD = new DAOAporteDetalle();
            List<AporteDetalle> lista = daoAD.listarTodo();
            BindingList<AporteDetalle> bindingList = new BindingList<AporteDetalle>(lista);
            tablaPrincipal.DataSource = bindingList;
        }

        private void customProperties()
        {
            cargarAportes();
            cargarComboDonantes();
            cargarComboProyectos();
        }

        private void cargarComboDonantes()
        {
            List<Donante> lista = daoD.listar();
            cbDonantes.DataSource = lista;
        }

        private void cargarComboProyectos()
        {
            List<Proyecto> lista = daoP.listar();
            cbProyectos.DataSource = lista;
        }

        private void timerCheck_Tick(object sender, EventArgs e)
        {
            if (cbDonantes.SelectedIndex == -1 && cbProyectos.SelectedIndex == -1)
            {
                lblId.Text = "Id del aporte: " + daoAD.listarTodo().Count.ToString() + 1;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cbDonantes.SelectedIndex == -1 || cbProyectos.SelectedIndex == -1 || spnMonto.Value <= 0)
            {
                MessageBox.Show("Antes de agregar un aporte debe seleccionar:\n*Donante\n*Proyecto\nY un aporte no puede ser menor o igual a 0.");
            }


            Proyecto p = null;
            Donante d = null;

            try
            {
                p = (Proyecto)cbProyectos.SelectedItem;
                d = (Donante)cbDonantes.SelectedItem;
            }
            catch (Exception ex)
            { 
            MessageBox.Show("Error al obtener el proyecto o donante seleccionado: " + ex.Message);
            return;
            }

            if(p == null || d == null)
            {
                MessageBox.Show("");
                return;
            }

            int monto = 0;
            int idP = 0;
            int idD = 0;

            List<Proyecto> listP = daoP.listar();
            List<Donante> listD = daoD.listar();


        }
    }
}