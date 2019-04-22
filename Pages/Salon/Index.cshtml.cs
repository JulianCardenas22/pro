using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using pro.Data;
using pro.Model;

namespace pro.Pages.Salon
{
    public class IndexModel : PageModel
    {
        private AppDbContext _db;
        public List<pro.Model.Salon> Salones { get; set; }

        public IndexModel (AppDbContext _db)
        {
            this._db = _db;
        }

        public IActionResult OnGet()
        {
            Salones = _db.Salon.ToList();
            return Page();
        }
    }
}