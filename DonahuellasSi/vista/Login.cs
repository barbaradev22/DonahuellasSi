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

namespace DonahuellasSi.vista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            customProperties();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPassw.Text;
            List<Usuario> usuario = null;


            if (user.Equals("") || pass.Equals(""))
            {
                lblValidacion.Visible= true;
                lblValidacion.Text = "Complete todos los campos";
                return;
            }

            dao.DAOUsuario usuarioDAO = new dao.DAOUsuario();
            try
            {
                usuario = usuarioDAO.listar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            if (usuario.Any(u => u.Nombre == user && u.Password == pass))
            {
                this.Hide();
                Dash dashboard = new Dash();

            }
            else
            {
                lblValidacion.Visible= true;
                lblValidacion.Text = "Usuario o contraseña incorrectos";
            }

        }

        private void customProperties()
        {
            lblValidacion.Visible = false;
        }

    }
    
}
