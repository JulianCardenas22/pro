using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using pro.Data;
using pro.Model;

namespace pro.src.Service
{
    public class MaestroService : IMaestro
    {
        private readonly AppDbContext _db;
        
        public MaestroService(AppDbContext _db)
        {
            this._db = _db;
        }
        public bool BorrarMaestro(Maestro maestroBorrar)
        {
            var maestro = _db.Maestro.Find(maestroBorrar.MaestroId);
            _db.Maestro.Remove(maestro);
            _db.SaveChanges();
            return true;
        }

        public Maestro CrearMaestro(Maestro maestro)
        {
            _db.Maestro.Add(maestro);
            _db.SaveChanges();
            return maestro;
        }

        public Maestro EditarMaestro(Maestro maestroActualizar)
        {
            var maestro = _db.Maestro.Find(maestroActualizar.MaestroId);
            maestro.Nombre = maestroActualizar.Nombre;
            maestro.Titulo = maestroActualizar.Titulo;
            _db.Update(maestro);
            _db.SaveChanges();
            return maestro;
        }
    }
}
