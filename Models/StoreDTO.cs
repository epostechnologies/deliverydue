using System;
using System.Collections.Generic;
using System.Text;

namespace DeliveryDude.Models
{
    public class StoreDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
