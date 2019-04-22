using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using pro.Data;

namespace pro.Pages.Maestro
{
    public class EliminarModel : PageModel
    {
        private AppDbContext _db;
        public pro.Model.Maestro maestro { get; set; }

        public EliminarModel(AppDbContext _db)
        {
            this._db = _db;
        }
        public IActionResult OnGet(long id)
        {
            maestro = _db.Maestro.Find(id);
            return Page();
        }
    }
}