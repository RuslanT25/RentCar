using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTOs.CarDTO
{
    public class CarGetDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }
        public short Passanger { get; set; }
        public List<string> Baggages { get; set; }
        public string Transmission { get; set; }
        public bool AirConditioning { get; set; }
        public int Mileage { get; set; }
        public bool Insurance { get; set; }
        public double Price { get; set; }
        public bool CarStatus { get; set; }
    }
}
