using Microsoft.AspNetCore.Mvc.RazorPages;

public class OrderConfirmationModel : PageModel
{
    public int OrderId { get; set; }

    public double Amount { get; set; }

    public string SelectedPizza { get; set; }

   
    public void OnGet(double amount, string pizza)
    {
        OrderId = new Random().Next(100000, 999999); ;
        Amount = amount;
        SelectedPizza = pizza;
    }
}

