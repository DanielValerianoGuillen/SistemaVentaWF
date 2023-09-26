using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class RolNegocio
    {
        private RolDatos objcd_rol = new RolDatos();
        public List<Rol> Listar()
        {
            return objcd_rol.Listar();
        }
    }
}
