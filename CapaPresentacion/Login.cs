using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            List<Usuario> test = new UsuarioNegocio().Listar();


            Usuario? ousuario = new UsuarioNegocio().Listar().Where(u => u.Documento == txtDocumento.Text && u.Clave == txtPassword.Text).FirstOrDefault();
            

            if(ousuario != null)
            {
                Inicio inicio = new Inicio(ousuario);
                inicio.Show();
                Hide();

                inicio.FormClosing += formulario_cierra;
            }
            else
            {
                MessageBox.Show("No se Encontro al usuario","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            

        }

        private void formulario_cierra(object? sender, FormClosingEventArgs e)
        {
            txtDocumento.Text = "";
            txtPassword.Text = "";
            Show();
        }

        
    }
}
