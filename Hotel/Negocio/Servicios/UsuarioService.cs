﻿using System;
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
    public class UsuarioService
    {
        private IUserDao<Usuario> userService;
        public UsuarioService()
        {
            userService = new UserDao();
        }

        public IList<Usuario> ObtenerTodos()
        {
            return userService.GetAll();
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
    }
}