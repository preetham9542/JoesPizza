
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

public class PizzaModel : PageModel
{
    [BindProperty]
    public string SelectedPizza { get; set; }

    [BindProperty]
    public int Quantity { get; set; }

    public List<SelectListItem> PizzaTypes { get; } = new List<SelectListItem>
    {
        new SelectListItem("Margherita", "Margherita"),
        new SelectListItem("Pepperoni", "Pepperoni"),
        new SelectListItem("Vegetarian", "Vegetarian"),
        new SelectListItem("Barbeque chicken","Barbeque chicken"),
        new SelectListItem("onion","onion"),
        new SelectListItem("CheeseBurst","CheeseBurst"),
        new SelectListItem("Tandoori Paneer","Tandoori Paneer"),
        new SelectListItem("Corn & Capcicum","Corn & Capcicum")
      
    };

    public IActionResult OnPostAddToCart()
    {
        return RedirectToPage("OrderCheckout", new { pizza = SelectedPizza, quantity = Quantity });
    }
}

