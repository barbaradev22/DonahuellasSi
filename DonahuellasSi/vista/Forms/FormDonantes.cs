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
            
            string nombre = txtNombre.Text;
            string rut = txtRut.Text;
            string tel = txtTelefono.Text;

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0)
            {
                MessageBox.Show("Seleccione una fila válida");
                return;
            }
            
            DataGridViewRow row = tablaDonantes.Rows[e.RowIndex];

            string nombre = row.Cells[0].Value.ToString();

            string rut = row.Cells[1].Value.ToString();

            string telefono = row.Cells[2].Value.ToString();

            if(string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(rut) || string.IsNullOrEmpty(telefono))
            {
                MessageBox.Show("La fila seleccionada contiene datos vacíos");
                return;
            }
            txtNombre.Text = nombre;
            txtRut.Text = rut;
            txtTelefono.Text = telefono;
        }

      
    }
}
