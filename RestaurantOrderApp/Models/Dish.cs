namespace RestaurantOrderApp.Models
{
    public class Dish
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Price { get; set; }
        public bool IsVegan { get; set; }
        public bool IsSpicy { get; set; }
        public bool IsActive { get; set; }
        public byte[]? Image { get; set; }
        public string? ImageContentType { get; set; }
        public Guid CategoryId { get; set; }

        // Навигационные свойства
        public Category Category { get; set; } = null!;
        public ICollection<OrderDish> _OrderDishes { get; set; } = new List<OrderDish>();
    }
}