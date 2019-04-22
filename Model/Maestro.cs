using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pro.Model
{
    public class Maestro
    {
        public Maestro()
        {
            CreatedDate = DateTime.Now;
        }
        public long MaestroId { get; set; }
        public string Titulo { get; set; }
        [Required, StringLength(50)]
        public string Nombre { get; set; }
        [Required, StringLength(50)]
        public string Apellido { get; set; }
        public string NickName { get; set; }
        public string StringIdentifier { get; set; }
        public DateTime CreatedDate { get; set; }
        public ICollection<MaestroSalon> MaestroSalon { get; set; }

        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }
    }
}
