using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pro.Model
{
    public class Salon
    {
        public long SalonId { get; set; }
        public string Nombre { get; set; }
        public ICollection<MaestroSalon> SalonMaestro { get; set; }
    }
}
