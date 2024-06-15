﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace AccesoDatos
{
    public class Seguridades
    {
        public static bool sesionActiva(object user)
        {
            Usuario usuario = user != null ? (Usuario)user : null;
            if (user != null && usuario.Id != 0)
            {
                return true;
            }
            else { return false; }
        }

        public static bool esAdmin(object user)
        {
            if (user != null)
            {
                Usuario usuario = user != null ? (Usuario)user : null;
                return usuario.TipoUsuario;
            }
            return false;
        }
    }
}