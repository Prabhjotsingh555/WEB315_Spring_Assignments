using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using cars.Models;

namespace cars.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new carsContext(
                serviceProvider.GetRequiredService<DbContextOptions<carsContext>>()))
            {
                // Look for any cars1s.
                if (context.cars1.Any())
                {
                    return;   // DB has been seeded
                }

                context.cars1.AddRange(
                    new cars1
                    {
                        Name = "Ford Mustang",
                        BuildYear = new DateTime(1964),
                        Company = "Ford",
                        Engine = "V8 engine",
                        Country = "United States",
                        Features = "Iconic muscle car known for its powerful performance and sleek design.",
                        Price = 20000.00M
                    },

                    new cars1
                    {
                        Name = "Chevrolet Corvette",
                        BuildYear = new DateTime(1953),
                        Company = "Chevrolet",
                        Engine = "V8 engine",
                        Country = "United States",
                        Features = "America's sports car, known for its speed, style, and performance.",
                        Price = 10000.00M
                    },

                    new cars1
                    {
                        Name = "Volkswagen Beetle",
                        BuildYear = new DateTime(1938),
                        Company = "Volkswagen",
                        Engine = "Flat-four engine",
                        Country = "Germany",
                        Features = "Recognizable for its distinctive round shape, the Beetle became one of the most successful and iconic cars in automotive history.",
                        Price = 5000.00M
                    },

                    new cars1
                    {
                        Name = "Jaguar E-Type",
                        BuildYear = new DateTime(1961),
                        Company = "Jaguar",
                        Engine = "Inline-six engine",
                        Country = "United Kingdom",
                        Features = "Often referred to as one of the most beautiful cars ever made, the E-Type combines stunning design with impressive performance.",
                        Price = 70000.00M
                    },

                    new cars1
                    {
                        Name = "Porsche 911",
                        BuildYear = new DateTime(1963),
                        Company = "Porsche",
                        Engine = "Flat-six engine",
                        Country = "Germany",
                        Features = "Renowned for its timeless design and exceptional handling, the 911 has become an automotive icon.",
                        Price = 50000.00M
                    },

                    new cars1
                    {
                        Name = "Rolls-Royce Silver Ghost",
                        BuildYear = new DateTime(1906),
                        Company = "Rolls-Royce",
                        Engine = "Inline-six engine",
                        Country = "United Kingdom",
                        Features = "Considered one of the most luxurious and prestigious cars of its time, the Silver Ghost set new standards for refinement and reliability.",
                        Price = 1000000.00M
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
