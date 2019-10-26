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
    class ReservaService
    {
        private IReservaDao<Reserva> reservaService; 

        
        public ReservaService()
        {
            reservaService = new ReservaDao();
        }

        public IList<Reserva> ObtenerTodos()
        {
            return reservaService.GetAll();
        }

        public DataTable comboGetEstados(string tabla)
        {
            return reservaService.getComboEstados(tabla);
        }

        public DataTable getComboTipoReserva(string tabla)
        {
            return reservaService.getComboTipoReserva(tabla);
        }

        public bool CrearReserva(Reserva oReserva)
        {
            return reservaService.Create(oReserva);
        }

        public bool ActualizarReserva(Reserva oReserva)
        {
            return reservaService.Update(oReserva);
        }

        public bool EliminarReserva(Reserva oReserva)
        {
            return reservaService.Delete(oReserva);
        }
    }
}

