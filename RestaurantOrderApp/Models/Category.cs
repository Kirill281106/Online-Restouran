namespace RestaurantOrderApp.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int SortCategory { get; set; }
        public bool IsActive { get; set; }
    }
}
