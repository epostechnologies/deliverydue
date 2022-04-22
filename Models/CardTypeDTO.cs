using System;
using System.Collections.Generic;
using System.Text;

namespace DeliveryDude.Models
{
    public class CardTypeDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool SystemGenerated { get; set; } = false;
        public bool IsActive { get; set; } = true;
    }
}
