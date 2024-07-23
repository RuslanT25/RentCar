using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Car : BaseEntity
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Image { get; set; }
        public short Passanger {  get; set; }
        public bool CarStatus { get; set; }
        public int TransmissionId { get; set; }
        public Transmission Transmission { get; set; }
        public bool AirConditioning { get; set; }
        public int Mileage {  get; set; }
        public bool Insurance { get; set; }
        public double Price { get; set; }
    }
}
