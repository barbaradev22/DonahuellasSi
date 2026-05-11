using DonahuellasSi.dao;
using DonahuellasSi.model;
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
        private DAOProyecto DAOProyecto = new DAOProyecto();
        private bool filaSeleccionada = false;

        public FormProyectos()
        {
            InitializeComponent();
            customProperties();
        }

        private void FormProyectos_Load(object sender, EventArgs e)
        {
            this.proyectoTableAdapter.Fill(this.donaHuellasDataSet3.proyecto);
            
        }

        private void customProperties()
        {
            lblId.Text = "Id del proyecto: " + DAOProyecto.listar().Count.ToString();

        }

        private void tablaProyectos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = tablaProyectos.Rows[e.RowIndex];

            string nombre = row.Cells[1].Value?.ToString() ?? "";
            string descripcion = row.Cells[2].Value?.ToString() ?? "";

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(descripcion) || row.Cells[3].Value == null)
                return;

            int costo = Convert.ToInt32(row.Cells[3].Value);

            txtNombreProyecto.Text = nombre;
            txtDescripcion.Text = descripcion;
            numericCosto.Value = costo;
            filaSeleccionada = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreProyecto.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            if (numericCosto.Value <= 0)
            {
                MessageBox.Show("El costo debe ser mayor a cero.");
                return;
            }

            string nombreProyecto = txtNombreProyecto.Text.Trim();

            foreach (Proyecto proyecto in DAOProyecto.listar())
            {
                if (proyecto.NombreProyecto.Equals(nombreProyecto, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Ya existe un proyecto con ese nombre.");
                    return;
                }
            }

            Proyecto p = new Proyecto();
            p.NombreProyecto = nombreProyecto;
            p.DescripcionProyecto = txtDescripcion.Text;
            p.CostoProyecto = (int)numericCosto.Value;

            try
            {
                if (DAOProyecto.insertar(p))
                {
                    MessageBox.Show($"Proyecto {p.NombreProyecto} agregado exitosamente.");
                    this.proyectoTableAdapter.Fill(this.donaHuellasDataSet3.proyecto);
                    lblId.Text = "Id del proyecto: " + DAOProyecto.listar().Count.ToString();
                }
                else
                {
                    MessageBox.Show("Error al agregar el proyecto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el proyecto: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!filaSeleccionada)
            {
                MessageBox.Show("Seleccione un proyecto de la tabla primero.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombreProyecto.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Debe completar todos los campos.");
                return;
            }

            if (numericCosto.Value <= 0)
            {
                MessageBox.Show("El costo debe ser mayor a cero.");
                return;
            }

            int idActual = Convert.ToInt32(tablaProyectos.CurrentRow.Cells[0].Value);
            string nuevoNombre = txtNombreProyecto.Text.Trim();

            foreach (Proyecto proyecto in DAOProyecto.listar())
            {
                if (proyecto.IdProyecto != idActual &&
                    proyecto.NombreProyecto.Equals(nuevoNombre, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Ya existe otro proyecto con ese nombre.");
                    return;
                }
            }

            Proyecto p = new Proyecto();
            p.IdProyecto = idActual;
            p.NombreProyecto = nuevoNombre;
            p.DescripcionProyecto = txtDescripcion.Text;
            p.CostoProyecto = (int)numericCosto.Value;

            try
            {
                if (DAOProyecto.actualizar(p))
                {
                    MessageBox.Show("Proyecto actualizado correctamente.");
                    filaSeleccionada = false;
                    this.proyectoTableAdapter.Fill(this.donaHuellasDataSet3.proyecto);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el proyecto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error técnico: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!filaSeleccionada)
            {
                MessageBox.Show("Seleccione un proyecto de la tabla primero.");
                return;
            }
            int idProyecto = Convert.ToInt32(tablaProyectos.CurrentRow.Cells[0].Value);


            DialogResult confirmacion = MessageBox.Show(
            $"¿Está seguro que desea eliminar al donante?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
            );
            if( confirmacion == DialogResult.Yes )

                try
                {
                    bool resultado = DAOProyecto.eliminar(idProyecto);
                    if (resultado)
                    {
                        MessageBox.Show("Proyecto eliminado correctamente");
                       
                        txtNombreProyecto.Clear();
                        txtDescripcion.Clear();
                        this.proyectoTableAdapter.Fill(this.donaHuellasDataSet3.proyecto);

                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el proyecto");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
        }

        

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
