﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_20.Entidades
{
    public interface IXML
    {
        bool Guardar(string dato);

        bool Leer(string dato, out object objeto);
    }
}
