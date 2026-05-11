using DonahuellasSi.dao;
using DonahuellasSi.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonahuellasSi.vista.Forms
{
    public partial class FormDonantes : Form
    {
        private DAODonante daoDonante = new DAODonante();
        // Variable para metodos actualizar - eliminar
        private int idDonante = -1;
        public FormDonantes()
        {
            InitializeComponent();
            customProperties();
            
        }

        private void FormDonantes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'donaHuellasDataSet5.donante' Puede moverla o quitarla según sea necesario.
            this.donanteTableAdapter.Fill(this.donaHuellasDataSet5.donante);

        }

        private void customProperties()
        {
            lblId.Text = "Id del donante: " + daoDonante.listar().Count.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtRut.Text) || string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }

            string nombre = "";
            string rut ="";
            string tel = "";

            try
            {
                nombre = txtNombre.Text;
                rut = txtRut.Text;
                tel = txtTelefono.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Compruebe los campos e inténtelo de nuevo.\n" + ex.Message);
            }

            Donante d = new Donante();
            d.NombreDonante = nombre;
            d.RutDonante = rut;
            d.TelefonoDonante = tel;

            bool confirmacion = false;

            foreach (Donante donante in daoDonante.listar()) 
            {
                if(donante.RutDonante.Equals(rut) || donante.TelefonoDonante.Equals(tel))
                {
                    MessageBox.Show("Ya existe un donante con el mismo RUT o teléfono");
                    return;
                }
            }
            
            try
            {
                confirmacion = daoDonante.insertar(d);
            } catch(Exception ex)
            {
                MessageBox.Show("Error al agregar el donante: " + ex.Message);
                return;
            }

            if (confirmacion)
            {
                MessageBox.Show($"Donante {d.NombreDonante} agregado correctamente");
               
            }
            else
            {
                MessageBox.Show("No se pudo agregar el donante");
                return;
            }
            this.donanteTableAdapter.Fill(this.donaHuellasDataSet5.donante);
        }

        private void tablaDonantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0)
            {
                MessageBox.Show("Seleccione una fila válida");
                return;
            }
            DataGridViewRow row = tablaDonantes.Rows[e.RowIndex];
            int id;
            string nombre ="";

            string rut ="";

            string telefono ="";

            try
            {
                id = Convert.ToInt32(row.Cells[0].Value);
                idDonante = id;
            } catch(Exception ex)
            {
                MessageBox.Show("Error al obtener el ID del donante: " + ex.Message);
                return;
            }

            try
            {
                nombre = row.Cells[1].Value.ToString();
                rut = row.Cells[2].Value.ToString();
                telefono = row.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron obtener los datos seleccionados");
                return;
            }

            if(string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(rut) || string.IsNullOrEmpty(telefono))
            {
                MessageBox.Show("La fila seleccionada contiene datos vacíos");
                return;
            }
            lblId.Text += $" {idDonante}";
            txtNombre.Text = nombre;
            txtRut.Text = rut;
            txtTelefono.Text = telefono;

        }

        // Metodos para actualizar el label del id del donante al limpiar los campos
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtNombre.Text) && string.IsNullOrEmpty(txtRut.Text) && string.IsNullOrEmpty(txtTelefono.Text))
            {
                lblId.Text = "Id del donante: " + daoDonante.listar().Count.ToString();
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) && string.IsNullOrEmpty(txtRut.Text) && string.IsNullOrEmpty(txtTelefono.Text))
            {
                lblId.Text = "Id del donante: " + daoDonante.listar().Count.ToString();
            }
        }

        private void txtRut_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) && string.IsNullOrEmpty(txtRut.Text) && string.IsNullOrEmpty(txtTelefono.Text))
            {
                lblId.Text = "Id del donante: " + daoDonante.listar().Count.ToString();
            }
        }
        // </Metodos para actualizar el label del id del donante al limpiar los campos

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(idDonante == -1)
            {
                MessageBox.Show("Seleccione un donante de la tabla primero");
                return;
            }

            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtRut.Text) || string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }

            Donante d = new Donante();
            d.IdDonante = idDonante;
            d.NombreDonante = txtNombre.Text;
            d.RutDonante = txtRut.Text;
            d.TelefonoDonante = txtTelefono.Text;

            try
            {
                bool confirmacion = daoDonante.actualizar(d);
                if (confirmacion)
                {
                    MessageBox.Show($"Donante actualizado correctamente");
                    idDonante = -1;
                    donanteTableAdapter.Fill(donaHuellasDataSet5.donante);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el donante");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idDonante == -1)
            {
                MessageBox.Show("Seleccione un donante de la tabla primero");
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro que desea eliminar al donante?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    bool resultado = daoDonante.eliminar(idDonante);
                    if (resultado)
                    {
                        MessageBox.Show("Donante eliminado correctamente");
                        idDonante = -1;
                        txtNombre.Clear();
                        txtRut.Clear();
                        txtTelefono.Clear();
                        donanteTableAdapter.Fill(donaHuellasDataSet5.donante);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el donante");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}