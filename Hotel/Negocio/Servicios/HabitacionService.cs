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
    public class HabitacionService
    {
        private IhabitacionDao<Habitacion> habService;
        public HabitacionService()
        {
            habService = new habitacionDao();
        }

        public IList<Habitacion> ObtenerTodos()
        {
            return habService.GetAll();
        }

        public DataTable combpgetCombOCategoria(string tabla)
        {
            return habService.getCombOCategoria(tabla);
        }

        public DataTable getCombOTipoHab(string tabla)
        {
            return habService.getCombOTipoHab(tabla);
        }

        public DataTable getCombOEstado(string tabla)
        {
            return habService.getCombOEstado(tabla);
        }
        public bool CrearHabitacion(Habitacion oHabitacion)
        {
            return habService.Create(oHabitacion);
        }

        public bool ActualizarHabitacion(Habitacion oHabitacion)
        {
            return habService.Update(oHabitacion);
        }

        public bool EliminarHabitacion(Habitacion oHabitacion)
        {
            return habService.Delete(oHabitacion);
        }
    }
}