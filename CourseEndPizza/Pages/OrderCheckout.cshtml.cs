using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class OrderCheckoutModel : PageModel
{
    [BindProperty(SupportsGet = true)]
    public string SelectedPizza { get; set; }

    [BindProperty(SupportsGet = true)]
    public int Quantity { get; set; }

    public double TotalPrice => CalculateTotalPrice();
    public void OnGet(string pizza, int quantity)
    {
        SelectedPizza = pizza;
        Quantity = quantity;
    }
    public IActionResult OnPostPlaceOrder()
    {
        return RedirectToPage("OrderConfirmation", new { orderId = 123, Amount = TotalPrice, pizza = SelectedPizza});
    }

    private double CalculateTotalPrice()
    {
        double pizzaPrice = 10.0;
        return Quantity * pizzaPrice;
    }
}

