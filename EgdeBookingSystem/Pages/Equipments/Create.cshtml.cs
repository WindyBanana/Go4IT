using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EgdeBookingSystem.Data;
using EgdeBookingSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EgdeBookingSystem.Pages.Equipments
{
    public class CreateModel : PageModel
    {
        private readonly EgdeBookingSystem.Data.ApplicationDbContext _context;

        

        public CreateModel(EgdeBookingSystem.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        public SelectList Categories { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            IQueryable<string> categoryQuery = from c in _context.Category
                                            orderby c.Name
                                            select c.Name;
            Categories = new SelectList(await categoryQuery.ToListAsync());

            return Page();
        }

        [BindProperty]
        public Equipment Equipment { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Equipment.Add(Equipment);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
