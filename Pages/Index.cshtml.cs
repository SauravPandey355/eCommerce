using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using eCommerce.Controller;
using eCommerce.Model;
namespace eCommerce.Pages
{
    public class IndexModel : PageModel
    {
        public MainPage? cardDetails { get; set; }
        
        public void OnGet()
        {
            MainController controller = new MainController();
            var output = controller.CardDetails();
            cardDetails = output;
        }
    }
}