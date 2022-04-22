using System;
using System.Collections.Generic;
using System.Text;

namespace DeliveryDude.Models
{
    public class TaskItemDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Rate { get; set; }
        public List<TaskItemAddonDTO> Addons { get; set; }
    }
}
