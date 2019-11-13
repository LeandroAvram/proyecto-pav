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

        public bool CrearReserva(ReservaMod oReserva)
        {
            return reservaRepo.Create(oReserva);
        }

        public IList<ReservaDatos> ObtenerTodos()
        {
            return reservaRepo.GetAll();
        }

        public IList<ReservaDatos> ObtenerConFiltro(int filtro)
        {
            return reservaRepo.GetAllFilter(filtro);
        }
        

        public DataTable ComboTipoReserva(string tabla)
        {
            return reservaRepo.getComboTipoReserva(tabla);
        }

        public bool ModificarEstado(int estado, int reserva)
        {
            return reservaRepo.ModificarEstadoReserva(estado, reserva);
        }
    }
}
