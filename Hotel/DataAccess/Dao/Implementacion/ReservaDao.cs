using System;
using System.Collections.Generic;
using System.Data;
using DataAccess.Helper;
using Entidades;

namespace DataAccess.Dao.Implementacion
{
    public class ReservaDao : Interfaz.IReservaDao
    {
        public bool Create(ReservaMod oReserva)
        {
            //string str_sql = "INSERT INTO T_Usuario (nombre, apellido, email, telefono, contraseña, id_rol, estado)" +
            //                 "VALUES (@nombre, @apellido, @email, @telefono, @contraseña, @id_rol, @estado)";
            //var parametros = new Dictionary<string, object>();
            //parametros.Add("nombre", oUsuario.nombre);
            //parametros.Add("apellido", oUsuario.apellido);
            //parametros.Add("email", oUsuario.email);
            //parametros.Add("telefono", oUsuario.telefono);
            //parametros.Add("contraseña", oUsuario.pass);
            //parametros.Add("id_rol", oUsuario.rolUsuario.IdRolUsuario);
            //parametros.Add("estado", "S");

            //return (DBHelper.GetDBHelper().EjecutarSQL(str_sql, parametros) == 1);
            return true;
        }

        public IList<ReservaDatos> GetAll()
        {
            List<ReservaDatos> listadoReservas = new List<ReservaDatos>();

            String str_sql = string.Concat("select r.id_reserva, ",
                "h.nro_habitacion, ",
                "c.nombre + ' ' + c.apellido as nombreCompleto, ",
                "CONVERT(VARCHAR(10), r.fecha_ingreso, 103) as fechaIngreso, ",
                "CONVERT(VARCHAR(10), r.fecha_egreso, 103) as fechaEgreso, ",
                "er.nombre as estadoReserva, ",
                "r.cant_persona as cantPersonas ",
                "from t_reserva r ", 
                "inner join t_habitacion h on r.id_habitacion = h.id_habitacion ",
                "inner join t_cliente c on r.id_cliente = c.id_cliente ",
                "inner join t_estado_reserva er on r.id_estado_reserva = er.id_estado_reserva");
            var resultado = DBHelper.GetDBHelper().ConsultaSQL(str_sql);
            
            foreach(DataRow row in resultado.Rows)
            {
                listadoReservas.Add(ObjectMapping(row));
            }
            return listadoReservas;
        }

        private ReservaDatos ObjectMapping(DataRow row)
        {
            try
            {
                var oReservaDatos = new ReservaDatos()
                {
                    id_reserva = Convert.ToInt32(row["id_reserva"]),
                    nro_habitacion = Convert.ToInt32(row["nro_habitacion"]),
                    nombreCompleto = row["nombreCompleto"].ToString(),
                    fechaIngreso = DateTime.ParseExact(row["fechaIngreso"].ToString(), "dd/MM/yyyy", null),
                    fechaEgreso = DateTime.ParseExact(row["fechaEgreso"].ToString(), "dd/MM/yyyy", null),
                    estadoReserva = row["estadoReserva"].ToString(),
                    cantPersonas = Convert.ToInt32(row["cantPersonas"]),
                };

                return oReservaDatos;
            }
            catch (Exception e)
            {
                return new ReservaDatos();
            }
        }
    }
}
