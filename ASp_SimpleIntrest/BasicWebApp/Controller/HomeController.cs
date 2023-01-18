using Microsoft.AspNetCore.Mvc;
namespace BasicWebApp.Services;
public class HomeController : Controller
{

         public IActionResult Index(string id="Hello Customer")
         {
                  return Content($"Welcome{id}");
         }
}
