using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Dao.Interfaz
{
    public interface IReservaDao<T>
    {
        DataTable getComboEstados(string tabla);
        DataTable getComboTipoReserva(string tabla);
        bool Create(Reserva oReserva);

        IList<Reserva> GetAll();

        bool Update(Reserva oReserva);
        bool Delete(Reserva oReserva);
    }
}
