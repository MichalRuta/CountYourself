using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CountYourself.WebApp.Models;

namespace CountYourself.WebApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private List<BillModel> Bills;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        Bills = new List<BillModel>();
    }

    public IActionResult Index()
    {
        var billraport = new BillRaportModel();
        billraport.Bills.Add(new BillModel(1, 22.37m, "Mercadone", "Jedzenie"));
        billraport.Bills.Add(new BillModel(2, 4.5m, "Kawa", "Kawiarnia"));

        return View(billraport);
    }


    [HttpPost]
    public ActionResult Index(BillModel bill)
    {
        var billId = bill.BillId;
        var name = bill.Name;
        var type = bill.Type;
        var vlue = bill.Value;

        Bills.Add(bill);

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Privacy(BillModel bill)
    {
        Bills.Add(bill);

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

