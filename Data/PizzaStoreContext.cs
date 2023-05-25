using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Data;

public class PizzaStoreContext : DbContext 
{
    public PizzaStoreContext(DbContextOptions options) : base(options)
    {
        
    }

    public DbSet<Topping> Toppings{ get; set; }
    public DbSet<Pizza> Pizzas { get; set; }
    public DbSet<PizzaSpecial> Specials { get; set; }
    public DbSet<Order> Orders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<PizzaTopping>().HasKey(pt => new { pt.PizzaId, pt.ToppingId });
        modelBuilder.Entity<PizzaTopping>().HasOne<Pizza>().WithMany(pt => pt.Toppings);
        modelBuilder.Entity<PizzaTopping>().HasOne(pt => pt.Topping).WithMany();
    }
}