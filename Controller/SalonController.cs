using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pro.Data;
using pro.Model;
using pro.src.Service;

namespace pro.Controller
{
    [Route("api/salon")]
    [ApiController]
    public class SalonController : ControllerBase
    {
        private AppDbContext _db;
        private ISalonService _salon;

        public SalonController(AppDbContext _db, ISalonService _salon)
        {
            this._db = _db;
            this._salon = _salon;
        }

        [HttpPost]
        [Route("salones")]
        public IActionResult Agregar([FromBody] Salon salon)
        {
            var s = _salon.CrearSalon(salon);
            return Ok("/Salon");
        }

        [HttpPut]
        [Route("salones")]
        public IActionResult Modificar([FromBody] Salon salon)
        {
            var s = _salon.ModificarSalon(salon);
            return Ok("/Salon");
        }

    }
}