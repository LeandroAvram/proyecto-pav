using Entidades;
using System.Collections.Generic;
using System.Data;

namespace DataAccess.Dao.Interfaz
{
    public interface IUserDao<T>
    {
        DataTable getComboRol(string tabla);

       bool Create(Usuario oUsuario);

        IList<Usuario> GetAll();

        bool Update(Usuario oUsuario);
    }
}
