using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Dao.Interfaz
{
    public interface IClienteDao<T>
    {
        DataTable getComboTipoDocumento(string tabla);
        bool Create(Cliente cliente);
        IList<Cliente> GetAll();
        IList<T> GetConFiltro(string filtro);
        bool Update(Cliente oCliente);
    }
}
