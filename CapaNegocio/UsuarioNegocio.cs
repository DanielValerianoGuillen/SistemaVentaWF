using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class UsuarioNegocio
    {
        private UsuarioDatos objcd_usuario = new UsuarioDatos();

        public List<Usuario> Listar()
        {
            return objcd_usuario.Listar();
        }
    }
}
