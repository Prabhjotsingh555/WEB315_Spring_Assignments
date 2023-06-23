using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Names { get; set; }
        [BindProperty(SupportsGet = true)]
        public string cars1Name { get; set; }

        public async Task OnGetAsync()
{
        // Use LINQ to get list of genres.
        IQueryable<string> nameQuery = from m in _context.cars1
                                    orderby m.Name
                                    select m.Name;

        var carss = from m in _context.cars1
                    select m;

        if (!string.IsNullOrEmpty(SearchString))
        {
            carss = carss.Where(s => s.Name.Contains(SearchString));
        }

        if (!string.IsNullOrEmpty(cars1Name ))
        {
            carss = carss.Where(x => x.Name == cars1Name   );
        }

        Names = new SelectList(await nameQuery.Distinct().ToListAsync());
        cars1 = await carss.ToListAsync();
}
    }
}
