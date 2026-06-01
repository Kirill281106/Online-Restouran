using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RestaurantOrderApp.Models;

namespace RestaurantOrderApp
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<Category> Categories ;
        public DbSet<Dish> Dishes;
        public DbSet<Order> Orders;
        public DbSet<OrderDish> OrderDishes;
        public DbSet<User> Users;
        public ApplicationDbContext() : base()//используется дли миграций и иногда для дизайна
        {
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }// базовый класс IdentityDbContext
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<OrderDish>()
                .HasKey(od => new { od.OrderId, od.DishId });
            builder.Entity<OrderDish>()
                .HasOne(od => od.Order)
                .WithMany(o => o._OrderDishes)
                .HasForeignKey(od =>od.OrderId);
            builder.Entity<OrderDish>()
                .HasOne(od => od.Dish)
                .WithMany(o => o._OrderDishes)
                .HasForeignKey(od => od.DishId);
        }
    }
}
