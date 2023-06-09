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
    public class IndexModel : PageModel
    {
        private readonly carsContext _context;

        public IndexModel(carsContext context)
        {
            _context = context;
        }

        public IList<cars1> cars1 { get;set; }

        public async Task OnGetAsync()
        {
            cars1 = await _context.cars1.ToListAsync();
        }
    }
}
