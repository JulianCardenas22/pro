using Microsoft.AspNetCore.Mvc;
using pro.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pro.Model;
using pro.src.Service;
using Microsoft.EntityFrameworkCore;

namespace pro.Controller
{
    [Route("api/maestro")]
    public class MaestroController : ControllerBase
    {
        private AppDbContext _db { get; set; }
        private IMaestro _maestro;
        //private IList<MaestroSalon> MaestroSalons { get; set; }
        

        public MaestroController(AppDbContext _db,
            IMaestro _maestro) {
            this._db = _db;
            this._maestro = _maestro;
        }

        [HttpGet]
        [Route("maestros")]
        public ActionResult Get()
        {
            var maestros = _db.Maestro
                .Include(m => m.MaestroSalon)
                .ThenInclude(m => m.Salon)
                .ToList();
            return Ok(maestros);


        }

        [HttpPost]
        [Route("maestros")]
        public ActionResult Insert([FromBody] Maestro maestro)
        {
            var ma = _maestro.CrearMaestro(maestro);
            //_db.Maestro.Add(maestro);
            //_db.SaveChanges();
            return Ok("/Maestro");
        }

        [HttpPut]
        [Route("maestros")]
        public ActionResult Update([FromBody] Maestro maestroActualizado)
        {
            var ma = _maestro.EditarMaestro(maestroActualizado);
            //var maestro = _db.Maestro.FirstOrDefault(m => m.Id == maestroActualizado.Id);
            /*var maestro = _db.Maestro.Find(maestroActualizado.Id);
            maestro.Nombre = maestroActualizado.Nombre;
            maestro.NickName = maestroActualizado.NickName;
            maestro.StringIdentifier = maestroActualizado.StringIdentifier;
            _db.Update(maestro);
            _db.SaveChanges();*/
            return Ok("/Maestro");
        }

        [HttpDelete]
        [Route("maestros")]
        public ActionResult Delete([FromBody] Maestro maestroBorrar)
        {
            bool respuesta = _maestro.BorrarMaestro(maestroBorrar);
            /*var maestro = _db.Maestro.Find(maestroBorrar.Id);
            _db.Maestro.Remove(maestro);
            _db.SaveChanges();*/
            return Ok("/Maestro");
        }
    }
}
