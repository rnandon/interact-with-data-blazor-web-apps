namespace BlazingPizza.Services;

public class PizzaSpecialService 
{
    public async Task<PizzaSpecial[]> GetPizzaSpecialsAsync() 
    {
        var client = new HttpClient();
        var response = await client.GetAsync("localhost:5000/specials");
        if (response is not null && response.Content is not null) 
        {
            return await response.Content.ReadFromJsonAsync<PizzaSpecial[]>();
        }

        var pizzas = new PizzaSpecial[]
        {
            new PizzaSpecial { Name = "The Baconatorizor", BasePrice =  110.99M, Description = "It has EVERY kind of bacon", ImageUrl="img/pizzas/bacon.jpg"},
            new PizzaSpecial { Name = "Buffalo chicken", BasePrice =  120.75M, Description = "Spicy chicken, hot sauce, and blue cheese, guaranteed to warm you up", ImageUrl="img/pizzas/meaty.jpg"},
            new PizzaSpecial { Name = "Veggie Delight", BasePrice =  110.5M, Description = "It's like salad, but on a pizza", ImageUrl="img/pizzas/salad.jpg"},
            new PizzaSpecial { Name = "Margherita", BasePrice =  90.99M, Description = "Traditional Italian pizza with tomatoes and basil", ImageUrl="img/pizzas/margherita.jpg"},
            new PizzaSpecial { Name = "Basic Cheese Pizza", BasePrice =  110.99M, Description = "It's cheesy and delicious. Why wouldn't you want one?", ImageUrl="img/pizzas/cheese.jpg"},
            new PizzaSpecial { Name = "Classic pepperoni", BasePrice =  100.5M, Description = "It's the pizza you grew up with, but Blazing hot!", ImageUrl="img/pizzas/pepperoni.jpg" }               
        };
        return pizzas;
    }
}