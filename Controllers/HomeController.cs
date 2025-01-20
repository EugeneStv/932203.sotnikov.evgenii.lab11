using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication2.Models;

namespace WebApplication2.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult UsingModel()
        {
            OperationsModel data = Get();
            return View(data);
        }

        public IActionResult UsingViewData()
        {
            ViewData["data"] = Get();
            return View();
        }

        public IActionResult UsingViewBag()
        {
            ViewBag.data = Get();
            return View();
        }

        public IActionResult UsingServiceInjection()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public OperationsModel Get()
        {
            Random random = new Random();
            (var firstNumber, var secondNumber) = (random.Next(11), random.Next(11));

            return new OperationsModel
            {
                FirstNumb = firstNumber,
                SecondNumb = secondNumber,
                Sum = firstNumber + secondNumber,
                Sub = firstNumber - secondNumber,
                Mul = firstNumber * secondNumber,
                Div = checkDivisionByZero(firstNumber, secondNumber)
            };
        }
        public int checkDivisionByZero(int firstNumber, int secondNumber)
        {
            try
            {
                var divResult = firstNumber / secondNumber;
                return divResult;
            }
            catch (DivideByZeroException)
            {
                return -1;
            }
        }
    }
}
