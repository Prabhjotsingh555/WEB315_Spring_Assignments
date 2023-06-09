using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using cars.Models;

    public class carsContext : DbContext
    {
        public carsContext (DbContextOptions<carsContext> options)
            : base(options)
        {
        }

        public DbSet<cars.Models.cars1> cars1 { get; set; }
    }
