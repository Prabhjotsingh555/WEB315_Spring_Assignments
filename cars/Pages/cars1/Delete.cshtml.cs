using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using cars.Models;

namespace cars.Pages_cars1
{
    public class DeleteModel : PageModel
    {
        private readonly carsContext _context;

        public DeleteModel(carsContext context)
        {
            _context = context;
        }

        [BindProperty]
        public cars1 cars1 { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            cars1 = await _context.cars1.FirstOrDefaultAsync(m => m.ID == id);

            if (cars1 == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            cars1 = await _context.cars1.FindAsync(id);

            if (cars1 != null)
            {
                _context.cars1.Remove(cars1);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
