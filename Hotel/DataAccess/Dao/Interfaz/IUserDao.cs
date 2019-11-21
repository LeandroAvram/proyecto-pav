using Entidades;
using System.Collections.Generic;
using System.Data;

namespace DataAccess.Dao.Interfaz
{
    public interface IUserDao<T>
    {
        DataTable getComboRol(string tabla);

       bool Create(T oUsuario);

        IList<T> GetAll();
        IList<T> GetConFiltro( string filtro);

        bool Login(string user, string pass);
        bool Update(T oUsuario);
        bool NoExisteUsuario(string mail);
    }
}
