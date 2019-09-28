using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
