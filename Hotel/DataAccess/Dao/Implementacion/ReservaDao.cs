using DataAccess.Dao.Interfaz;
using DataAccess.Helper;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Dao.Implementacion
{
    public class ReservaDao : IReservaDao<Reserva>
    {
        public DataTable getComboTipoReserva(string tabla)
        {
            return DBHelper.GetDBHelper().ConsultarTabla(tabla);
        }
        public DataTable getComboEstados(string tabla)
        {
            return DBHelper.GetDBHelper().ConsultarTabla(tabla);
        }

        public bool Create(Reserva oReserva)
        {
            string str_sql="insert into T_Reserva(id_reserva,id_tipo_reserva,id_habitacion,id_usuario,id_cliente," +
                             "id_estado_reserva,fecha_ingreso,fecha_egreso,cant_persona)"+
                             "values(@id_reserva,@tipo_reserva,@id_hab,@id_usuario,@cliente,@estado,@fechaIng,@fechaEgreso,@personas)";
            var parametros = new Dictionary<string, object>();

            parametros.Add("id_reserva",oReserva.Id_reserva);
            parametros.Add("tipo_reserva",oReserva.id_TipoReser.id_tipo_reserva);
            parametros.Add("id_hab",oReserva.id_habitacion.Id_habitacion);
            parametros.Add("id_usuario",oReserva.id_usuario.Id);
            parametros.Add("cliente",oReserva.cliente);
            parametros.Add("estado",oReserva.id_estado.id_estado_reserva);
            parametros.Add("fechaIng",oReserva.fecha_ingreso);
            parametros.Add("fechaEgreso",oReserva.fecha_egreso);
            parametros.Add("personas",oReserva.cantPersonas);

            return (DBHelper.GetDBHelper().EjecutarSQL(str_sql, parametros) == 1);
        }

        public IList<Reserva> GetAll()
        {
            IList<Reserva> listaReservas = new List<Reserva>();

            string sql = string.Concat("select r.id_reserva,t.id_tipo_reserva,h.id_habitacion,u.id_usuario,r.id_cliente," +
                                        "e.id_estado_reserva,r.fecha_ingreso,r.fecha_egreso,r.cant_persona" +
                                        "from T_Reserva r inner join T_Estado_Reserva e on e.id_estado_reserva=r.id_estado_reserva" +
                                        "inner join T_Tipo_Reserva t on t.id_tipo_reserva=r.id_tipo_reserva" +
                                        "inner join T_Usuario u on u.id_usuario=r.id_usuario inner"+
                                        "inner join T_Habitacion h on h.id_habitacion=r.id_habitacion");

            var resultado = DBHelper.GetDBHelper().ConsultaSQL(sql);

            foreach (DataRow row in resultado.Rows)
            {
                listaReservas.Add(ObjectMapping(row));
            }
            return listaReservas;
        }

        private Reserva ObjectMapping(DataRow row)
        {
            Reserva oReserva = new Reserva()
            {
                Id_reserva = Convert.ToInt32(row["id_reserva"].ToString()),
                cliente = Convert.ToInt32(row["cliente"].ToString()),
                fecha_ingreso = Convert.ToDateTime(row["fecha_egreso"].ToString()),
                fecha_egreso=Convert.ToDateTime(row["fecha_ingreso"].ToString()),
                cantPersonas=Convert.ToInt32(row["cant_persona"]),
                id_estado = new EstadoReserva()
                {
                    id_estado_reserva = Convert.ToInt32(row["id_estado_reserva"].ToString()),
                    nombre = row["nombre"].ToString(),
                    descripcion = row["descripcion"].ToString()
                },
                id_TipoReser = new TipoReserva()
                {
                    id_tipo_reserva = Convert.ToInt32(row["id_tipo_reserva"].ToString()),
                    nombre = row["nombre"].ToString(),
                    descripcion = row["descripcion"].ToString()
                },
                id_habitacion = new Habitacion()
                {
                    Id_habitacion = Convert.ToInt32(row["id_habitacion"].ToString()),
                    nro_habitacion = Convert.ToInt32(row["nro_habitacion"].ToString())
                    
                },
                 id_usuario = new Usuario()
                 {
                     Id = Convert.ToInt32(row["id_usuario"].ToString()),
                    nombre=row["nombre"].ToString()

                 }


            };
            return oReserva;
        }

        public bool Update(Entidades.Reserva oReserva)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction t = null;
            int rtdo = 0;

            try
            {
                cnn.ConnectionString = DBHelper.GetDBHelper().obtenerConexionString();
                cnn.Open();
               
               string str_sql = "update T_Reserva set id_reserva=@id_reserva" +
                             ",id_tipo_reserva=@tipo_reserva," +
                             "id_habitacion=@id_hab," +
                             "id_usuario=@id_usuario," +
                             "id_cliente=@cliente," +
                             "id_estado_reserva=@estado," +
                             "fecha_ingreso=@fechaIng," +
                             "fecha_egreso=@fechaEgreso," +
                             "cant_persona=@personas)" +
                             "where id_reserva=@id_reserva";

     
                var parametros = new Dictionary<string, object>();

                parametros.Add("id_reserva", oReserva.Id_reserva);
                parametros.Add("tipo_reserva", oReserva.id_TipoReser.id_tipo_reserva);
                parametros.Add("id_hab", oReserva.id_habitacion.Id_habitacion);
                parametros.Add("id_usuario", oReserva.id_usuario.Id);
                parametros.Add("cliente", oReserva.cliente);
                parametros.Add("estado", oReserva.id_estado.id_estado_reserva);
                parametros.Add("fechaIng", oReserva.fecha_ingreso);
                parametros.Add("fechaEgreso", oReserva.fecha_egreso);
                parametros.Add("personas", oReserva.cantPersonas);

                // insert into Pagos () values -- FALTA!!!

                cmd = new SqlCommand(str_sql, cnn, t);
                rtdo = cmd.ExecuteNonQuery();
                t.Commit();

            }
            catch (Exception ex)
            {
                if (t != null)
                {
                    t.Rollback();
                    rtdo = 0;
                }
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }


           return rtdo > 0;
        }

    public bool Delete(Reserva oReserva)
    {
            String str_sql = " Delete from T_Reserva " +
                           "  WHERE Id_reserva = @id";

            return (DBHelper.GetDBHelper().EjecutarSQL(str_sql) == 1);
    }

    }
    

}




    

