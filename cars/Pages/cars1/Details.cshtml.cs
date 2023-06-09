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
    public class DetailsModel : PageModel
    {
        private readonly carsContext _context;

        public DetailsModel(carsContext context)
        {
            _context = context;
        }

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
    }
}
