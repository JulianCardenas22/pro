using pro.Data;
using pro.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pro.src.Service
{
    public class SalonService : ISalonService
    {
        private AppDbContext _db;

        public SalonService(AppDbContext _db)
        {
            this._db = _db;
        }

        public bool BorrarSalon(Salon salon)
        {
            throw new NotImplementedException();
        }

        public Salon CrearSalon(Salon salon)
        {
            _db.Salon.Add(salon);
            _db.SaveChanges();
            return salon;
        }

        public Salon ModificarSalon(Salon salon)
        {
            var s = _db.Salon.Find(salon.SalonId);
            s.Nombre = salon.Nombre;
            _db.Update(s);
            _db.SaveChanges();
            return salon;
        }
    }
}
