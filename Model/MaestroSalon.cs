using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace pro.Model
{
    public class MaestroSalon
    {
        public long MaestroId { get; set; }
        public Maestro Maestro { get; set; }
        public long SalonId { get; set; }
        public Salon Salon { get; set; }
    }
}
