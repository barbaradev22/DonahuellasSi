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
        private int idAporte = -1;

        public FormAportes()
        {
            InitializeComponent();
            customProperties();
        }

        private void cargarAportes()
        {
            List<AporteDetalle> lista = daoAD.listarTodo();
            BindingList<AporteDetalle> bindingList = new BindingList<AporteDetalle>(lista);
            tablaPrincipal.AutoGenerateColumns = true;
            tablaPrincipal.DataSource = bindingList;
            actualizarLabel();
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
            cbDonantes.DisplayMember = "NombreRut";
            cbDonantes.ValueMember = "IdDonante";
            cbDonantes.DataSource = lista;
        }

        private void cargarComboProyectos()
        {
            List<Proyecto> lista = daoP.listar();
            cbProyectos.DisplayMember = "NombreProyecto";
            cbProyectos.ValueMember = "IdProyecto";
            cbProyectos.DataSource = lista;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cbDonantes.SelectedIndex == -1 || cbProyectos.SelectedIndex == -1 || spnMonto.Value <= 0)
            {
                MessageBox.Show("Antes de agregar un aporte debe seleccionar:\n*Donante\n*Proyecto\nY un aporte no puede ser menor o igual a 0.");
                return;
            }

            Proyecto p = (Proyecto)cbProyectos.SelectedItem;
            Donante d = (Donante)cbDonantes.SelectedItem;

            Aporte a = new Aporte();
            a.IdProyecto = p.IdProyecto;
            a.IdDonante = d.IdDonante;
            a.CantidadDonada = (int)spnMonto.Value;

            try
            {
                bool confirmacion = daoA.insertar(a);
                if (confirmacion)
                    MessageBox.Show("Aporte ingresado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el aporte: " + ex.Message);
                return;
            }

            cargarAportes();
        }
        private void actualizarLabel()
        {
            if (idAporte == -1)
                lblId.Text = "Id del aporte: " + (daoAD.listarTodo().Count + 1);
            else
                lblId.Text = "Id del aporte: " + idAporte;
        }

        private void tablaPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }

            DataGridViewRow fila = tablaPrincipal.Rows[e.RowIndex];

            try
            {
                idAporte = Convert.ToInt32(fila.Cells[0].Value);
                int idProyecto = Convert.ToInt32(fila.Cells[1].Value);
                int idDonante = Convert.ToInt32(fila.Cells[2].Value);
                int cantidad = Convert.ToInt32(fila.Cells[3].Value);
                cbProyectos.SelectedValue = idProyecto;
                cbDonantes.SelectedValue = idDonante;
                spnMonto.Value = cantidad;
                actualizarLabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el aporte seleccionado: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idAporte == -1) { MessageBox.Show("Seleccione un aporte de la tabla primero."); return; }

            Aporte a = new Aporte();
            a.Id = idAporte;
            a.IdProyecto = ((Proyecto)cbProyectos.SelectedItem).IdProyecto;
            a.IdDonante = ((Donante)cbDonantes.SelectedItem).IdDonante;
            a.CantidadDonada = (int)spnMonto.Value;

            try
            {
                bool confirmacion = daoA.actualizar(a);
                if (confirmacion)
                {
                    MessageBox.Show("Aporte actualizado correctamente.");
                    idAporte = -1;
                    cargarAportes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el aporte: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idAporte == -1) { MessageBox.Show("Seleccione un aporte de la tabla primero."); return; }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea eliminar el aporte seleccionado?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    bool confirmacion = daoA.eliminar(idAporte);
                    if (confirmacion)
                    {
                        MessageBox.Show("Aporte eliminado correctamente.");
                        idAporte = -1;
                        cargarAportes();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el aporte: " + ex.Message);
                }
            }
        }
    }
}