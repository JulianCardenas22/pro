using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using pro.Data;
using pro.Model;

namespace pro.Pages.Maestro
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _db;
        public List<pro.Model.Maestro> Maestros { get; set; }

        public IndexModel(AppDbContext _db)
        {
            this._db = _db;
        }
        public IActionResult OnGet()
        {
            Maestros = _db.Maestro.ToList();
            return Page();
        }
    }
}