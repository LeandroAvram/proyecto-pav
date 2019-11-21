using System;
using System.Collections.Generic;
using System.Data;
using DataAccess.Helper;
using Entidades;

namespace DataAccess.Dao.Implementacion
{
    public class ClienteDao : Interfaz.IClienteDao<Cliente>
    {
        public DataTable getComboTipoDocumento(string tabla)
        {
            return DBHelper.GetDBHelper().ConsultarTabla(tabla);
        }

        public bool Create(Cliente oCliente)
        {
            string str_sql = "INSERT INTO T_Cliente (nombre, apellido, mail, telefono, id_tipo_documento, nro_documento, id_vehiculo, estado)" +
                             "VALUES (@nombre, @apellido, @mail, @telefono, @id_tipo_documento, @nro_documento, @id_vehiculo, @estado)";
            var parametros = new Dictionary<string, object>();
            parametros.Add("nombre", oCliente.Nombre);
            parametros.Add("apellido", oCliente.Apellido);
            parametros.Add("mail", oCliente.Email);
            parametros.Add("telefono", oCliente.Telefono);
            parametros.Add("id_tipo_documento", oCliente.TipoDocumento.Id);
            parametros.Add("nro_documento", oCliente.NroDocumento);
            parametros.Add("id_vehiculo", 1);
            parametros.Add("estado", "S");
            return (DBHelper.GetDBHelper().EjecutarSQL(str_sql, parametros) == 1);
        }

        public IList<Cliente> GetAll()
        {
            List<Cliente> listadoUsuarios = new List<Cliente>();

            String str_sql = string.Concat("SELECT id_cliente, ",
                                           "       c.nombre, ",
                                           "       apellido, ",
                                           "       mail, ",
                                           "       telefono, ",
                                           "       c.id_tipo_documento, ",
                                           "       nro_documento, ",
                                           "       td.nombre as nombreTipo ",
                                           "FROM T_Cliente c " +
                                           "INNER JOIN T_TIPO_DOCUMENTO td on c.id_tipo_documento = td.id_tipo_documento " +
                                           "WHERE c.estado = 'S'");
            var resultado = DBHelper.GetDBHelper().ConsultaSQL(str_sql);

            foreach(DataRow row in resultado.Rows)
            {
                listadoUsuarios.Add(ObjectMapping(row));
            }
            return listadoUsuarios;
        }

        public IList<Cliente> GetConFiltro(string filtro)
        {
            List<Cliente> listadoUsuarios = new List<Cliente>();

            String str_sql = string.Concat("SELECT id_cliente, ",
                                           "       c.nombre, ",
                                           "       apellido, ",
                                           "       mail, ",
                                           "       telefono, ",
                                           "       c.id_tipo_documento, ",
                                           "       nro_documento, ",
                                           "       td.nombre as nombreTipo ",
                                           "FROM T_Cliente c " +
                                           "INNER JOIN T_TIPO_DOCUMENTO td on c.id_tipo_documento = td.id_tipo_documento " +
                                           "WHERE c.estado = 'S' and (id_cliente like '%" + filtro + "%' or c.nombre like '%" + filtro + "%' or apellido like '%" + filtro + "%' or mail like '%" + filtro + "%' or telefono like '%" + filtro + "%' or nro_documento like '%" + filtro + "%' or td.nombre like '%" + filtro + "%')");
            var resultado = DBHelper.GetDBHelper().ConsultaSQL(str_sql);
            if (resultado.Rows.Count == 0)
            {
                return listadoUsuarios;
            }

            foreach (DataRow row in resultado.Rows)
            {
                listadoUsuarios.Add(ObjectMapping(row));
            }
            return listadoUsuarios;
        }


        private Cliente ObjectMapping(DataRow row)
        {
            Cliente oCliente = new Cliente()
            {
                Id = Convert.ToInt32(row["id_cliente"].ToString()),
                Nombre = row["nombre"].ToString(),
                Apellido = row["apellido"].ToString(),
                Email = row["mail"].ToString(),
                Telefono = row["telefono"].ToString(),
                TipoDocumento = new TipoDocumento {
                    Id = Convert.ToInt32(row["id_tipo_documento"].ToString()),
                    Nombre = row["nombreTipo"].ToString()
                },
                NroDocumento = row["nro_documento"].ToString()
            };
            return oCliente;
        }

        public bool Update(Cliente oCliente)
        {
            String str_sql = " UPDATE T_Cliente SET nombre = @nombre," +
                             "                      apellido = @apellido," +
                             "                      mail = @mail," +
                             "                      telefono = @telefono," +
                             "                      id_tipo_documento = @id_tipo_documento," +
                             "                      nro_documento = @nro_documento, " +
                             "                      estado = @estado " +
                             "  WHERE id_cliente = @id_cliente";

            var parametros = new Dictionary<string, object>();
            parametros.Add("id_cliente", oCliente.Id);
            parametros.Add("nombre", oCliente.Nombre);
            parametros.Add("apellido", oCliente.Apellido);
            parametros.Add("mail", oCliente.Email);
            parametros.Add("telefono", oCliente.Telefono);
            parametros.Add("id_tipo_documento", oCliente.TipoDocumento.Id);
            parametros.Add("nro_documento", oCliente.NroDocumento);
            parametros.Add("estado", oCliente.Estado);

            return (DBHelper.GetDBHelper().EjecutarSQL(str_sql, parametros) == 1);
        }

        public bool NoExisteHuesped(string dni)
        {
            var str_sql = "select * from T_Cliente where nro_documento = " + dni;
            var resultado = DBHelper.GetDBHelper().ConsultaSQL(str_sql);
            return resultado.Rows.Count == 0;
        }
    }
}
