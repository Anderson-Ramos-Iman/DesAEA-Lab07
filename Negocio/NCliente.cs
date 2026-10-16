using System;
using System.Collections.Generic;
using System.Text;
using Datos;
using Entidades;

namespace Negocio
{
    public class NCliente
    {
        public List<Cliente> Listar()
        {
            DCliente dCliente = new DCliente();
            return dCliente.Listar();
        }
    }
}
