using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Dao.Implementacion;
using DataAccess.Dao.Interfaz;
using Entidades;

namespace Negocio.Servicios
{
    public class ReservaService
    {
        private IReservaDao reservaRepo;
        public ReservaService()
        {
            reservaRepo = new ReservaDao();
        }

        public IList<ReservaDatos> ObtenerTodos()
        {
            return reservaRepo.GetAll();
        }
    }
}
