using System;
using System.ComponentModel.DataAnnotations;

namespace cars.Models
{
    public class cars1
    {
        public int ID { get; set; }
        [DataType(DataType.Date)]
        public DateTime BuildYear { get; set; }
        public decimal Price { get; set; }
        public int Rating { get; set;}
        public string Name { get; set; }
        public string Company { get; set; }
        public string Engine { get; set; }
        public string Country { get; set; }
        public string Features { get; set; }       
        public string Colour {get; set;}
    }
}