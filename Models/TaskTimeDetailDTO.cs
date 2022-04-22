using System;
using System.Collections.Generic;
using System.Text;

namespace DeliveryDude.Models
{
    public class TaskTimeDetailDTO
    {
        public DateTime PlacementDateTime { set; get; }
        public DateTime ExpectedPickupDateTime { set; get; }
        public DateTime ExpectedDeliveryDateTime { set; get; }
    }
}
