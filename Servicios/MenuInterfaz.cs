﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioRepaso.Servicios
{
    internal interface MenuInterfaz
    {
        public void mostrarMensajeBienvenida();

        public int mostrarMenuYSeleccionEmpOCli();

        public int mostrarMenuYSeleccionFunc(int controlador);

    }
}
