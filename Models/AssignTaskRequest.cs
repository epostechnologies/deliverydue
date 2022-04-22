using System;
using System.Collections.Generic;
using System.Text;

namespace DeliveryDude.Models
{
    public class AssignTaskRequest
    {
        public int ID { get; set; }
        public string ClientTaskId { get; set; }
        public int CarrierId { get; set; }
        public string ExternalCarrierId { get; set; }
    }
}
