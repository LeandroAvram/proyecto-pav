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
            string str_sql = "INSERT INTO t_reserva (id_tipo_reserva, id_habitacion, id_usuario, id_cliente, id_estado_reserva, fecha_ingreso, fecha_egreso, cant_persona, monto)" +
                             "VALUES (@id_tipo_reserva, @id_habitacion, @id_usuario, @id_cliente, @id_estado_reserva, @fecha_ingreso, @fecha_egreso, @cant_persona, @monto)";
            var parametros = new Dictionary<string, object>();
            parametros.Add("id_tipo_reserva", oReserva.id_tipo_reserva);
            parametros.Add("id_habitacion", oReserva.id_habitacion);
            parametros.Add("id_usuario", oReserva.id_usuario);
            parametros.Add("id_cliente", oReserva.id_cliente);
            parametros.Add("id_estado_reserva", 4);
            parametros.Add("fecha_ingreso", oReserva.fecha_ingreso.ToString("yyyy/MM/dd"));
            parametros.Add("fecha_egreso", oReserva.fecha_egreso.ToString("yyyy/MM/dd"));
            parametros.Add("cant_persona", oReserva.cant_persona);
            parametros.Add("monto", oReserva.monto);

            return (DBHelper.GetDBHelper().EjecutarSQL(str_sql, parametros) == 1);
        }

        public bool ModificarEstadoReserva(int estado, int reserva)
        {
            String str_sql = " UPDATE T_Reserva SET id_estado_reserva = @idestado" +
                               " WHERE id_reserva = @id";

            var parametros = new Dictionary<string, object>();
            parametros.Add("id", reserva);
            parametros.Add("idestado", estado);


            return (DBHelper.GetDBHelper().EjecutarSQL(str_sql, parametros) == 1);
        }

        public bool RegistrarPagoReserva(ReservaDatos oReserva, int formPago, DateTime dia, int monto)
        {
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                var estado = 2; 

                string sql = "UPDATE T_Reserva SET id_estado_reserva = @idestado WHERE id_reserva = @id";
                var parametros = new Dictionary<string, object>();
                parametros.Add("id", oReserva.id_reserva);
                parametros.Add("idestado", estado);
                dm.EjecutarSQL(sql, parametros);

                string sql2 = "INSERT INTO T_Pago (id_reserva, precio, id_formapago, fechaPago) VALUES (@id_reserva, @precio, @id_formapago, @fechaPago)";
                var paramDetalle = new Dictionary<string, object>();
                paramDetalle.Add("id_reserva", oReserva.id_reserva);
                paramDetalle.Add("precio", Decimal.ToInt32(oReserva.monto));
                paramDetalle.Add("id_formapago", formPago);
                paramDetalle.Add("fechaPago", dia.ToString("yyyy/MM/dd"));
                dm.EjecutarSQL(sql2, paramDetalle);
            


                dm.Commit();

        }
            catch (Exception ex)
            {
                dm.Rollback();
                throw ex;
            }
            finally
            {
                // Cierra la conexión 
                dm.Close();
            }
            return true;
        }

        public DataTable getComboTipoReserva(string tabla)
        {
            return DBHelper.GetDBHelper().ConsultarTabla(tabla);
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
                "r.cant_persona as cantPersonas, " +
                "r.monto ",
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

        public IList<ReservaDatos> GetAllFilter(int filtro)
        {
            List<ReservaDatos> listadoReservas = new List<ReservaDatos>();

            String str_sql = string.Concat("select r.id_reserva, ",
                "h.nro_habitacion, ",
                "c.nombre + ' ' + c.apellido as nombreCompleto, ",
                "CONVERT(VARCHAR(10), r.fecha_ingreso, 103) as fechaIngreso, ",
                "CONVERT(VARCHAR(10), r.fecha_egreso, 103) as fechaEgreso, ",
                "er.nombre as estadoReserva, ",
                "r.cant_persona as cantPersonas, " +
                "r.monto ",
                "from t_reserva r ",
                "inner join t_habitacion h on r.id_habitacion = h.id_habitacion ",
                "inner join t_cliente c on r.id_cliente = c.id_cliente ",
                "inner join t_estado_reserva er on r.id_estado_reserva = er.id_estado_reserva WHERE r.id_estado_reserva = "+ filtro);
            var resultado = DBHelper.GetDBHelper().ConsultaSQL(str_sql);

            foreach (DataRow row in resultado.Rows)
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
                    monto = Convert.ToDecimal(row["monto"])
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
