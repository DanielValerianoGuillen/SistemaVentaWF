using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            comboEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            comboEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            comboEstado.DisplayMember = "Texto";
            comboEstado.ValueMember = "Valor";
            comboEstado.SelectedIndex = 0;


            List<Rol> listaRol = new RolNegocio().Listar();

            foreach (Rol item in listaRol)
            {
                comboRol.Items.Add(new OpcionCombo() { Valor = item.IdRol, Texto = item.Descripcion });
            }
            comboRol.DisplayMember = "Texto";
            comboRol.ValueMember = "Valor";
            comboRol.SelectedIndex = 0;



            foreach (DataGridViewColumn columna in dgvDataUsuarios.Columns)
            {

                if (columna.Visible == true && columna.Name != "btnSeleccionar")
                {
                    comboBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }

            comboBusqueda.DisplayMember = "Texto";
            comboBusqueda.ValueMember = "Valor";
            comboBusqueda.SelectedIndex = 0;



            List<Usuario> listaUsuario = new UsuarioNegocio().Listar();

            foreach (Usuario item in listaUsuario)
            {

                dgvDataUsuarios.Rows.Add(new object[] {"",item.IdUsuario,item.Documento,item.NombreCompleto,item.Correo,item.Clave,
                    item.oRol.IdRol,
                    item.oRol.Descripcion,
                    item.Estado == true ? 1 : 0 ,
                    item.Estado == true ? "Activo" : "No Activo"
                });
            }




        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dgvDataUsuarios.Rows.Add(new object[] {"",txtId.Text,txtDocumento.Text,txtNombreCompleto.Text,txtCorreo.Text,txtClave.Text,
                ((OpcionCombo)comboRol.SelectedItem).Valor.ToString(),
                ((OpcionCombo)comboRol.SelectedItem).Texto.ToString(),
                ((OpcionCombo)comboEstado.SelectedItem).Valor.ToString(),
                ((OpcionCombo)comboEstado.SelectedItem).Texto.ToString()
                });

            LimpiarFormulario();
        }



        private void LimpiarFormulario()
        {
            txtIndice.Text = "-1";
            txtId.Text = "0";
            txtDocumento.Text = "";
            txtNombreCompleto.Text = "";
            txtCorreo.Text = "";
            txtClave.Text = "";
            txtConfirmarClave.Text = "";
            comboRol.SelectedIndex = 0;
            comboEstado.SelectedIndex = 0;
        }

        private void dgvDataUsuarios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check20.Width;
                var h = Properties.Resources.check20.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check20, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvDataUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDataUsuarios.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    txtId.Text = dgvDataUsuarios.Rows[indice].Cells["IdUsuario"].Value.ToString();
                    txtDocumento.Text = dgvDataUsuarios.Rows[indice].Cells["Documento"].Value.ToString();
                    txtNombreCompleto.Text = dgvDataUsuarios.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    txtCorreo.Text = dgvDataUsuarios.Rows[indice].Cells["Correo"].Value.ToString();
                    txtClave.Text = dgvDataUsuarios.Rows[indice].Cells["Clave"].Value.ToString();
                    txtConfirmarClave.Text = dgvDataUsuarios.Rows[indice].Cells["Clave"].Value.ToString();
                }

                foreach (OpcionCombo oc in comboRol.Items)
                {

                    if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvDataUsuarios.Rows[indice].Cells["IdRol"].Value))
                    {
                        int indice_combo = comboRol.Items.IndexOf(oc);
                        comboRol.SelectedIndex = indice_combo;
                        break;
                    }
                }

                foreach (OpcionCombo oc in comboEstado.Items)
                {
                    if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvDataUsuarios.Rows[indice].Cells["EstadoValor"].Value))
                    {
                        int indice_combo = comboEstado.Items.IndexOf(oc);
                        comboEstado.SelectedIndex = indice_combo;
                        break;
                    }
                }




            }
        }
    }
}
