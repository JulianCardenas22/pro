using pro.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pro.src.Service
{
    public interface IMaestro
    {
        Maestro CrearMaestro(Maestro maestro);
        Maestro EditarMaestro(Maestro maestroActualizar);
        Boolean BorrarMaestro(Maestro maestroBorrar);
    }
}
