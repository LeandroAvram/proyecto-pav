using Entidades;
using System.Collections.Generic;
using System.Data;

namespace DataAccess.Dao.Interfaz
{
    public interface IReservaDao
    {
        bool Create(ReservaMod oReserva);

        DataTable getComboTipoReserva(string tabla);
        
        IList<ReservaDatos> GetAll();

        bool ModificarEstadoReserva(int estado, int reserva);
    }
}
