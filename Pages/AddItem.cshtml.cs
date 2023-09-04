using eCommerce.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eCommerce.Pages
{
    public class AddItemModel : PageModel
    {
        public MainPage? item { get; set; }
        public bool AddItemSubmit(MainPage data)
        {
            return data != null;
        }
    }
}
