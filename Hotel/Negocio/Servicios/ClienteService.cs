using System.Collections.Generic;
using System.Data;
using DataAccess.Dao.Implementacion;
using DataAccess.Dao.Interfaz;
using Entidades;

namespace Negocio.Servicios
{
    public class ClienteService
    {
        private IClienteDao<Cliente> clienteService;
        public ClienteService()
        {
            clienteService = new ClienteDao();
        }

        public IList<Cliente> ObtenerTodos()
        {
            return clienteService.GetAll();
        }

        public DataTable ComboTipoDocumento(string tabla)
        {
            return clienteService.getComboTipoDocumento(tabla);
        }

        public bool CrearUsuario(Cliente oCliente)
        {
            return clienteService.Create(oCliente);
        }

        public bool ActualActualizarCliente(Cliente oCliente)
        {
            return clienteService.Update(oCliente);
        }

        public bool EliminarCliente(Cliente cliente)
        {
            cliente.Estado = "N";
            return clienteService.Update(cliente);
        }

        public IList<Cliente> Busqueda(string filtro)
        {
            return clienteService.GetConFiltro(filtro);
        }
    }
}
