using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using cars.Models;

namespace cars.Pages_cars1
{
    public class CreateModel : PageModel
    {
        private readonly carsContext _context;

        public CreateModel(carsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public cars1 cars1 { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.cars1.Add(cars1);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
