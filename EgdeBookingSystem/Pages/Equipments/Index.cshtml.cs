using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EgdeBookingSystem.Data;
using EgdeBookingSystem.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EgdeBookingSystem.Pages.Equipments
{
    public class IndexModel : PageModel
    {
        private readonly EgdeBookingSystem.Data.ApplicationDbContext _context;

        public IndexModel(EgdeBookingSystem.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Equipment> Equipment { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Equipments { get; set; }
        [BindProperty(SupportsGet = true)]
        public string EquipmentName { get; set; }

        public async Task OnGetAsync()
        {
            Equipment = await _context.Equipment.ToListAsync();

            var equipments = from n in _context.Equipment
                         select n;
            if (!string.IsNullOrEmpty(SearchString))
            {
                equipments = equipments.Where(s => s.Name.Contains(SearchString));
            }

            Equipment = await equipments.ToListAsync();
        }

    }
}
