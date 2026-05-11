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
        private    DAOAporteDetalle daoAD = new DAOAporteDetalle();
        private    DAOAporte daoA = new DAOAporte();
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
            lblId.Text = "Id del aporte: " + daoAD.listarTodo().Count.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
