using eCommerce.Model;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace eCommerce.Controller
{
    public class MainController
    {
        List<MainPage> pages = new List<MainPage>();
        public MainPage CardDetails()
        {
           MainPage mainPage = new MainPage();
            mainPage.Name = "Saurav";
            mainPage.Balance = 98999945223;
            mainPage.Image = "/Photos/20190728_112504.jpg";
            return mainPage;
        }

        public string AddItem(MainPage item)
        {
            pages.Add(item);
            return "Item added successfully";
        }
    }
}
