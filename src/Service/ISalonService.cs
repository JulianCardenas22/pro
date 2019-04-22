using pro.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pro.src.Service
{
    public interface ISalonService
    {
        Salon CrearSalon(Salon salon);
        Salon ModificarSalon(Salon salon);
        Boolean BorrarSalon(Salon salon);
    }
}
