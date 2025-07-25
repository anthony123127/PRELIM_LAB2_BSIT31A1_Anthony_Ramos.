using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PRELIM_LAB2_IT_Elective_Ramos_.Models;

namespace PRELIM_LAB2_IT_Elective_Ramos_.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            book myBook = new book
            {
                Id = 1,
                Title = "The Alchemist",
                Author = "Paulo Coelho"
            };

            // Create Customer instance
            customer myCustomer = new customer
            {
                FirstName = "Anthony",
                MiddleName = "S.",
                LastName = "Ramos",
                Title = "Mr.",
                Email = "anthony.ramos@example.com"
            };

            // Use Tuple to pass both
            var model = Tuple.Create(myBook, myCustomer);

            return View(model);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
