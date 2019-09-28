using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Helper;
using Entidades;


namespace DataAccess.Dao.Implementacion
{
    public class UserDao : Interfaz.IUserDao<Usuario>
    {
        public DataTable getComboRol(string tabla)
        {
            return DBHelper.GetDBHelper().ConsultarTabla(tabla);
        }

        public bool Create(Usuario oUsuario)
        {
            string str_sql = "INSERT INTO T_Usuario (nombre, apellido, email, telefono, contraseña, id_rol, estado)" +
                             "VALUES (@nombre, @apellido, @email, @telefono, @contraseña, @id_rol, @estado)";
            var parametros = new Dictionary<string, object>();
            parametros.Add("nombre", oUsuario.nombre);
            parametros.Add("apellido", oUsuario.apellido);
            parametros.Add("email", oUsuario.email);
            parametros.Add("telefono", oUsuario.telefono);
            parametros.Add("contraseña", oUsuario.pass);
            parametros.Add("id_rol", oUsuario.rolUsuario.IdRolUsuario);
            parametros.Add("estado", "S");

            return (DBHelper.GetDBHelper().EjecutarSQL(str_sql, parametros) == 1);
        }

        public IList<Usuario> GetAll()
        {
            List<Usuario> listadoUsuarios = new List<Usuario>();

            String str_sql = string.Concat("SELECT id_usuario, ",
                                           "       u.nombre, ",
                                           "       apellido, ",
                                           "       email, ",
                                           "       telefono, ",
                                           "       contraseña, ",
                                           "       estado, ",
                                           "       u.id_rol, ",
                                           "       r.nombre as nom_rol ",
                                           "FROM T_Usuario u",
                                           " INNER JOIN T_Rol r ON u.id_rol = r.id_rol WHERE u.estado = 'S'");
            var resultado = DBHelper.GetDBHelper().ConsultaSQL(str_sql);

            foreach(DataRow row in resultado.Rows)
            {
                listadoUsuarios.Add(ObjectMapping(row));
            }
            return listadoUsuarios;
        }


        private Usuario ObjectMapping(DataRow row)
        {
            Usuario oUsuario = new Usuario()
            {
                Id = Convert.ToInt32(row["id_usuario"].ToString()),
                nombre = row["nombre"].ToString(),
                apellido = row["apellido"].ToString(),
                email = row["email"].ToString(),
                telefono = Convert.ToInt32(row["telefono"].ToString()),
                pass = row["contraseña"].ToString(),
                estado = row["estado"].ToString(),
                rolUsuario = new RolUsuario()
                {
                    IdRolUsuario = Convert.ToInt32(row["id_rol"].ToString()),
                    Nombre = row["nom_rol"].ToString(),
                }
            };
            return oUsuario;
        }

        public bool Update(Usuario oUsuario)
        {
            String str_sql = " UPDATE T_Usuario SET nombre = @nombre," +
                             "                      apellido = @apellido," +
                             "                      email = @email," +
                             "                      telefono = @telefono," +
                             "                      contraseña = @contraseña," +
                             "                      estado = @estado," +
                             "                      id_rol = @id_rol" +
                             "  WHERE id_usuario = @id_usuario";

            var parametros = new Dictionary<string, object>();
            parametros.Add("id_usuario", oUsuario.Id);
            parametros.Add("nombre", oUsuario.nombre);
            parametros.Add("apellido", oUsuario.apellido);
            parametros.Add("email", oUsuario.email);
            parametros.Add("telefono", oUsuario.telefono);
            parametros.Add("contraseña", oUsuario.pass);
            parametros.Add("estado", oUsuario.estado);
            parametros.Add("id_rol", oUsuario.rolUsuario.IdRolUsuario);

            return (DBHelper.GetDBHelper().EjecutarSQL(str_sql, parametros) == 1);
        }
    }
}
