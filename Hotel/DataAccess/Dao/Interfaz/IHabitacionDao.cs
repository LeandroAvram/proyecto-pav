using System;
using System.Collections.Generic;
using System.Data;

using Entidades;

namespace DataAccess.Dao.Interfaz
{
  public interface IhabitacionDao<T>
        {
            DataTable getCombOCategoria(string tabla);
           DataTable getCombOTipoHab(string tabla);
           DataTable getCombOEstado(string tabla);

             bool Create(Habitacion oHabitacion);

            IList<Habitacion> GetAll();

            bool Update(Habitacion ohabitacion);
            bool Delete(Habitacion ohabitacion);
    }
    
}
