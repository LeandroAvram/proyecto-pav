using Entidades;
using System.Collections.Generic;

namespace DataAccess.Dao.Interfaz
{
    public interface IReservaDao
    {
        bool Create(ReservaMod oReserva);

        IList<ReservaDatos> GetAll();
    }
}
