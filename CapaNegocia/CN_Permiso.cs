﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaData;
using CapaEntidad;

namespace CapaNegocia
{
    public  class CN_Permiso
    {
        private CD_Permiso objcd_Permiso = new CD_Permiso();

        public List<Permiso>Listar(int IdUsuario)
        {
            return objcd_Permiso.Listar(IdUsuario );
        }
    }
}
