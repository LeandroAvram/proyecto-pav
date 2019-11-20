using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Dao.Interfaz;
using DataAccess.Helper;
using Entidades;


namespace DataAccess.Dao.Implementacion
{
    public class habitacionDao : Interfaz.IhabitacionDao<Habitacion>
    {

            public DataTable getCombOCategoria(string tabla)
            {
                return DBHelper.GetDBHelper().ConsultarTabla(tabla);
            }
            public DataTable getCombOTipoHab(string tabla)
            {
                return DBHelper.GetDBHelper().ConsultarTabla(tabla);
            }
            public DataTable getCombOEstado(string tabla)
            {
                return DBHelper.GetDBHelper().ConsultarTabla(tabla);
            }


            public bool Create(Habitacion oHabitacion)
            {
                string str_sql = "INSERT INTO T_Habitacion (nro_habitacion, precio,id_tipo_habitacion,id_cat_habitacion,id_estado_habitacion )" +
                                 "VALUES (@numero, @precio, @tipo, @categoria, @estado)";
                var parametros = new Dictionary<string, object>();

                parametros.Add("id", oHabitacion.Id_habitacion);
                parametros.Add("numero", oHabitacion.nro_habitacion);
                parametros.Add("precio", oHabitacion.precio);
                parametros.Add("tipo", oHabitacion.tipoHab.id_tipo_habitacion);
                parametros.Add("categoria", oHabitacion.catHab.id_cat_habitacion);
                parametros.Add("estado",oHabitacion.estadoHab.id_estado_habitacion);
                

                return (DBHelper.GetDBHelper().EjecutarSQL(str_sql, parametros) == 1);
            }

        public IList<Habitacion> GetAll()
        {
            List<Habitacion> listadoHab = new List<Habitacion>();

            String str_sql = string.Concat("SELECT h.id_habitacion, ",
                                           "       h.nro_habitacion, ",
                                           "       h.precio, ",
                                           "       th.id_tipo_habitacion, ",
                                           "       th.nombre as nom_tipo_habitacion, ",
                                           "       ch.id_cat_habitacion, ",
                                           "       ch.nombre as nom_cat_habitacion, ",
                                           "       e.id_estado_habitacion, ",
                                           "       e.nombre as nom_estado_habitacion",
                                            " FROM T_Habitacion h ",
                                               "INNER JOIN T_Tipo_Habitacion th ON h.id_tipo_habitacion = th.id_tipo_habitacion ",
                                               "INNER JOIN T_Categoria_Habitacion ch ON h.id_cat_habitacion = ch.id_cat_habitacion ",
                                              "INNER JOIN T_Estado_Habitacion e ON h.id_estado_habitacion = e.id_estado_habitacion "

                                               );
                var resultado = DBHelper.GetDBHelper().ConsultaSQL(str_sql);

                foreach (DataRow row in resultado.Rows)
                {
                    listadoHab.Add(ObjectMapping(row));
                }
                return listadoHab;
        }

        public IList<Habitacion> FiltrarHabitaciones(FiltrosHabitacion filtros)
        {
            List<Habitacion> listadoHab = new List<Habitacion>();

            var condiciones = new StringBuilder();

            condiciones.Append("WHERE ");

            if (filtros.Categoria > 0)
            {
                condiciones.Append("h.id_cat_habitacion = " + filtros.Categoria + " AND ");
            }

            if (filtros.Tipo > 0)
            {
                condiciones.Append("h.id_tipo_habitacion = " + filtros.Tipo + " AND ");
            }

            condiciones.Append("");//TODO validacion por fecha

            var strSql = string.Concat("SELECT h.id_habitacion, ",
                "       h.nro_habitacion, ",
                "       h.precio, ",
                "       th.id_tipo_habitacion, ",
                "       th.nombre as nom_tipo_habitacion, ",
                "       ch.id_cat_habitacion, ",
                "       ch.nombre as nom_cat_habitacion, ",
                "       e.id_estado_habitacion, ",
                "       e.nombre as nom_estado_habitacion",
                " FROM T_Habitacion h ",
                "INNER JOIN T_Tipo_Habitacion th ON h.id_tipo_habitacion = th.id_tipo_habitacion ",
                "INNER JOIN T_Categoria_Habitacion ch ON h.id_cat_habitacion = ch.id_cat_habitacion ",
                "INNER JOIN T_Estado_Habitacion e ON h.id_estado_habitacion = e.id_estado_habitacion ",
                condiciones.ToString()
            );
            var resultado = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultado.Rows)
            {
                listadoHab.Add(ObjectMapping(row));
            }
            return listadoHab;
        }

        private Habitacion ObjectMapping(DataRow row)
            {
            Habitacion oHabitacion = new Habitacion()
            {
                Id_habitacion = Convert.ToInt32(row["id_habitacion"].ToString()),
                nro_habitacion = Convert.ToInt32(row["nro_habitacion"].ToString()),
                precio = Convert.ToInt32(row["precio"].ToString()),
                tipoHab = new TipoHabitacion()
                {
                    id_tipo_habitacion = Convert.ToInt32(row["id_tipo_habitacion"].ToString()),
                    nombre = row["nom_tipo_habitacion"].ToString()
                },
                catHab = new Cathabitacion()
                {
                    id_cat_habitacion = Convert.ToInt32(row["id_cat_habitacion"].ToString()),
                    nombre = row["nom_cat_habitacion"].ToString()
                },
                estadoHab = new Estadohabit()
                {
                    id_estado_habitacion = Convert.ToInt32(row["id_estado_habitacion"].ToString()),
                    nombre = row["nom_estado_habitacion"].ToString()
                }


            };
            return oHabitacion;
            }

            public bool Update(Habitacion oHabitacion)
            {
                String str_sql = " UPDATE T_Habitacion SET nro_habitacion = @nro," +
                                 "                      precio = @precio," +
                                 "                      id_tipo_habitacion = @tipoHab," +
                                 "                      id_cat_habitacion = @categoria," +
                                 "                      id_estado_habitacion = @estado" +
                                 "  WHERE Id_habitacion = @id";

                var parametros = new Dictionary<string, object>();
                parametros.Add("id", oHabitacion.Id_habitacion);
                parametros.Add("nro", oHabitacion.nro_habitacion);
                parametros.Add("precio", oHabitacion.precio);
                parametros.Add("tipoHab", oHabitacion.tipoHab.id_tipo_habitacion);
                parametros.Add("categoria", oHabitacion.catHab.id_cat_habitacion);
                parametros.Add("estado", oHabitacion.estadoHab.id_estado_habitacion);
                

                return (DBHelper.GetDBHelper().EjecutarSQL(str_sql, parametros) == 1);
            }

            

            public bool Delete(Entidades.Habitacion oHabitacion)
            {
              String str_sql = " Delete from T_Habitacion " + 
                             "  WHERE Id_habitacion = @id";

              return (DBHelper.GetDBHelper().EjecutarSQL(str_sql) == 1);
        }
    }
    }
