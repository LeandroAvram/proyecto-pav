﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Data;

namespace DataAccess.Dao.Interfaz
{
    public interface IReservaDao
    {
        bool Create(ReservaMod oReserva);

        DataTable getComboTipoReserva(string tabla);
        
        IList<ReservaDatos> GetAll();

        IList<ReservaDatos> GetAllFilter(int filtro);

        bool ModificarEstadoReserva(int estado, int reserva);

        bool RegistrarPagoReserva(ReservaDatos oReserva, int formPago, DateTime dia, int monto);
    }
}
