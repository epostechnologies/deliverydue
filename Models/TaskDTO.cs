using System;
using System.Collections.Generic;
using System.Text;

namespace DeliveryDude.Models
{
    public class TaskDTO
    {
        public int ID { get; set; }
        public string ClientTaskId { get; set; }
        public string TaskNumber { get; set; }
        public CustomerDTO Customer { get; set; }
        public StoreDTO Store { get; set; }
        public TaskTimeDetailDTO TaskTimeDetail { get; set; }
        public string DeliveryInstruction { get; set; }
        public List<TaskItemDTO> TaskItems { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TaxRate { get; set; }
        public decimal TaxAmount { get; set; } 
        public decimal DeliveryFee { get; set; }
        public decimal Tip { get; set; }
        public decimal CashTip { get; set; }
        public decimal NetAmount { get; set; }
        public string CreditCardId { get; set; }

    }

}
