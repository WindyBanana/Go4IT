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
        private readonly EgdeBookingSystem.Data.EgdeBookingSystemContext _context;

        public IndexModel(EgdeBookingSystem.Data.EgdeBookingSystemContext context)
        {
            _context = context;
        }


        public IList<Equipment> EquipmentSearch { get;set; }
        public IList<Equipment> Equipment { get; set; }
        public SelectList Categories { get; set; }
        public SelectList Locations { get; set; }
        public SelectList Status{ get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string CategoryFilter { get; set; }

        [BindProperty(SupportsGet = true)]
        public string LocationFilter { get; set; }

        [BindProperty(SupportsGet = true)]
        public string BookedFilter { get; set; } = null;



        public async Task OnGetAsync()
        {
            Equipment = await _context.Equipment.AsNoTracking().ToListAsync();

            IQueryable<string> categoryQuery = from c in _context.Category
                                               orderby c.Name
                                               select c.Name;
            Categories = new SelectList(await categoryQuery.ToListAsync());

            IQueryable<string> locationQuery = from l in _context.Location
                                               orderby l.Name
                                               select l.Name;
            Locations = new SelectList(await locationQuery.ToListAsync());

            string[] Statuses = { "ledig", "opptatt" };
            Status = new SelectList(Statuses);

            //EquipmentSearch = await _context.Equipment.ToListAsync();

            var equipments = from n in _context.Equipment
                             select n;
            if (!string.IsNullOrEmpty(SearchString))
            {
                equipments = equipments.Where(s => s.Name.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(CategoryFilter))
            {
                equipments = equipments.Where(s => s.Category.Contains(CategoryFilter));
            }
            if (!string.IsNullOrEmpty(LocationFilter))
            {
                equipments = equipments.Where(s => s.Location.Contains(LocationFilter));
            }
            if (!string.IsNullOrEmpty(BookedFilter))
            {
                if (BookedFilter == "ledig")
                {
                    equipments = equipments.Where(s => s.Booked.Equals(false));
                }
                else
                {
                    equipments = equipments.Where(s => s.Booked.Equals(true));
                }
            }

            EquipmentSearch = await equipments.ToListAsync();
        }

    }
}
