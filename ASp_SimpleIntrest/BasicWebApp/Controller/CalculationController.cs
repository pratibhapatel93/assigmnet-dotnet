using Microsoft.AspNetCore.Mvc;

namespace BasicWebApp.Services;
public class CalculationController : Controller
{
    public IActionResult Compute(double principle,int period,float rate,[FromServices]Services.IInterest cal)
    {
      ViewBag.Cal=cal.Interest(principle,period,rate);
      return View("ABC");
 
    }
}
