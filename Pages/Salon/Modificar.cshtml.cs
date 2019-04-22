using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using pro.Data;

namespace pro.Pages.Salon
{
    public class ModificarModel : PageModel
    {
        private AppDbContext _db;
        public pro.Model.Salon salon { get; set; }

        public ModificarModel(AppDbContext _db)
        {
            this._db = _db;
        }

        public IActionResult OnGet(long id)
        {
            salon = _db.Salon.Find(id);
            return Page();
        }
    }
}