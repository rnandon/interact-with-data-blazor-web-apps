namespace BlazingPizza.Services;

public class OrderState 
{
    public bool ShowingConfigureDialog { get; set; }
    public Pizza ConfiguringPizza { get; set; }
    public Order Order { get; set; } = new Order();

    public void ShowConfigurePizzaDialog(PizzaSpecial special) 
    {
        ConfiguringPizza = new Pizza
        {
            Special = special,
            SpecialId = special.Id,
            Size = Pizza.DefaultSize,
            Toppings = new List<PizzaTopping>()
        };

        ShowingConfigureDialog = true;
    }

    public void CancelConfigurePizzaDialog() 
    {
        ConfiguringPizza = null;

        ShowingConfigureDialog = false;
    }

    public void ConfirmConfigurePizzaDialog() 
    {
        Order.Pizzas.Add(ConfiguringPizza);
        ShowingConfigureDialog = false;
        ConfiguringPizza = null;

    }
}