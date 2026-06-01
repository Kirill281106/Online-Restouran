namespace RestaurantOrderApp.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public string UserId { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; }
        public double TotalPrice { get; set; }
        public string Status { get; set; } = "Новый";
        public string DeliveryAddress { get; set; } = string.Empty;
        public string PaymentMethod { get; set; } = string.Empty;
        public string? Comment { get; set; }

        // Навигационные свойства
        public User User { get; set; } = null!;
        public ICollection<OrderDish> _OrderDishes { get; set; } = new List<OrderDish>();
    }
}