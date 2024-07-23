using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Customer : BaseEntity
    {
        public string Gender { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email {  get; set; }
        public string Phone { get; set; }
        public double Payment { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public string PickUpLocation { get; set; }
        public string DropOffLocation { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
