using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EgdeBookingSystem.Data;
using EgdeBookingSystem.Models;

namespace EgdeBookingSystem.Pages.Equipments
{
    public class IndexModel : PageModel
    {
        private readonly EgdeBookingSystem.Data.ApplicationDbContext _context;

        public IndexModel(EgdeBookingSystem.Data.ApplicationDbContext context)
        {
            _context = context;
        }


        public IList<Equipment> EquipmentSearch { get;set; }
        public IList<Equipment> Equipment { get; set; }
        public IList<Category> Categories { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }


        public async Task OnGetAsync()
        {
            Equipment = await _context.Equipment.AsNoTracking().ToListAsync();
            Categories = await _context.Category.AsNoTracking().ToListAsync();

            EquipmentSearch = await _context.Equipment.ToListAsync();

            var equipments = from n in _context.Equipment
                             select n;
            if (!string.IsNullOrEmpty(SearchString))
            {
                equipments = equipments.Where(s => s.Name.Contains(SearchString));
            }

            EquipmentSearch = await equipments.ToListAsync();
        }

        //protected void Page_Load(object sender, EventArgs e)
        //{

        //}
        //protected void TextBox2_TextChanged(object sender, EventArgs e)
        //{
        //    int sum = Convert.ToInt32(TextBox1.Text) + Convert.ToInt32(TextBox2.Text);
        //    lblsum.Text = "The Sum = " + sum.ToString();
        //    TextBox1.Text = "";
        //    TextBox2.Text = "";
        //}
    }
}
