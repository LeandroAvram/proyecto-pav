﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public int telefono { get; set; }
        public string pass { get; set; }
        public RolUsuario rolUsuario { get; set; }
        public string estado { get; set; }

        public override string ToString()
        {
            return nombre;
        }

        public Usuario()
        {

        }

    }
}