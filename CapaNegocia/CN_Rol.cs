﻿using CapaData;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaNegocia
{
    public class CN_Rol
    {
        private CD_Rol objcd_Rol= new CD_Rol();

        public List<Rol> Listar()
        {
            return objcd_Rol.Listar();
        }
    }
}
