using System.Collections.Generic;
using System.Data;
using DataAccess.Dao.Implementacion;
using DataAccess.Dao.Interfaz;
using Entidades;

namespace Negocio.Servicios
{
    public class UsuarioService
    {
        private IUserDao<Usuario> userService;
        public UsuarioService()
        {
            userService = new UserDao<Usuario>();
        }

        public IList<Usuario> ObtenerTodos()
        {
            return userService.GetAll();
        }

        public bool LoginUser(string user, string pass)
        {
            return userService.Login(user, pass);
        }

        public DataTable ComboRol(string tabla)
        {
            return userService.getComboRol(tabla);
        }

        public bool CrearUsuario(Usuario oUsuario)
        {
            return userService.Create(oUsuario);
        }

        public bool ActualActualizarUsuario(Usuario oUsuario)
        {
            return userService.Update(oUsuario);
        }

        public bool ModificarEstadoUsuario(Usuario oUsuarioSelected)
        {
            oUsuarioSelected.estado = "N";

            return userService.Update(oUsuarioSelected);
        }

        public IList<Usuario> Busqueda(string filtro)
        {
            return userService.GetConFiltro(filtro);
        }
    }
}
