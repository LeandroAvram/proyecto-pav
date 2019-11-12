using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Cache
{
    public static class UserLoginCache
    {
        public static int IdUser { get; set; }
        public static string nombre { get; set; }
        public static string apellido { get; set; }
        public static string email { get; set; }
        public static string telefono { get; set; }
        public static string pass { get; set; }

        public static int IdRolUsuario { get; set; }
    }
}
