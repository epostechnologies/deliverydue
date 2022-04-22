
namespace DeliveryDude.Models
{
    public class PaymentMethodDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool ShowCardOptions { get; set; }
        public bool SystemGenerated { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
