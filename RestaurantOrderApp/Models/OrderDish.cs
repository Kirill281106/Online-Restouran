namespace RestaurantOrderApp.Models
{
    public class OrderDish
    {
        public Guid OrderId { get; set; } 
        public Guid DishId { get; set; } 
        public int Quantity { get; set; }
        public double PriceAtOrder { get; set; }
        public Order Order { get; set; } = null!;
        public Dish Dish { get; set; } = null!;
    }
}