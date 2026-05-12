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

        private void FormAportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'donaHuellasDataSet11.proyecto' Puede moverla o quitarla según sea necesario.
            this.proyectoTableAdapter.Fill(this.donaHuellasDataSet11.proyecto);
            // TODO: esta línea de código carga datos en la tabla 'donaHuellasDataSet10.donante' Puede moverla o quitarla según sea necesario.
            this.donanteTableAdapter1.Fill(this.donaHuellasDataSet10.donante);
            // TODO: esta línea de código carga datos en la tabla 'donaHuellasDataSet9.donante' Puede moverla o quitarla según sea necesario.
            this.donanteTableAdapter.Fill(this.donaHuellasDataSet9.donante);

        }

        private void tablaPrincipal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }

            DataGridViewRow fila = tablaPrincipal.Rows[e.RowIndex];

            if (fila.Cells[0].Value == null || fila.Cells[1].Value == null ||fila.Cells[2].Value == null || fila.Cells[3].Value == null)
            {
                MessageBox.Show("Seleccionaste una fila vacía, intenta con otra.");
                return;
            }
            // no nada
            int id = Convert.ToInt32(fila.Cells[0].Value);


            idAporte = id;
            string proyecto = fila.Cells[1].Value.ToString() ;
            string donante = fila.Cells[2].Value.ToString() ;
            int monto = Convert.ToInt32(fila.Cells[3].Value);

            lblId.Text = "Id del aporte: " + id;
            cbProyectos.SelectedIndex = cbProyectos.FindStringExact(proyecto);
            cbDonantes.SelectedIndex = cbDonantes.FindString(donante);
            spnMonto.Value = monto;
            



        }

        private void btnVolver_Click(object sender, EventArgs e)
        {   
            this.Close();

        }

        private void resetearFormulario()
        {
            cbDonantes.SelectedIndex = 0;
            cbProyectos.SelectedIndex = 0;
            spnMonto.Value = 0;
            idAporte = -1;
            actualizarLabel();
        }
    }
}
