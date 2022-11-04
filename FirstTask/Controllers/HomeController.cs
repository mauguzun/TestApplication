using FirstTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstTask.Controllers
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

        [HttpPost]
        public IActionResult Index(DateTime date)
        {
            if (date > DateTime.Now.AddYears(+1))
            {
                throw new Exception("Max this year");
            }

            var closestLeapYear = _FindClosestLeapYear(date.Year);
            var happyDays = _FindHappyDate(date.DayOfYear, closestLeapYear);

            return View(new HappyDates(closestLeapYear, happyDays));
        }

        private List<int> _FindHappyDate(int start,int stop)
        {
            var happyDays = new List<int>(); 
            for (var i = start; i < stop; i++)
            {
                if (i > 9 && i < 100)
                {
                    if (i % 11 == 0) { happyDays.Add(i); }
                }
                else if (i > 999 && i < 9999)
                {
                    var numbers  =  Array.ConvertAll(i.ToString().ToCharArray(), c => (int)Char.GetNumericValue(c));
                    if (numbers[0] + numbers[1] == numbers[2] + numbers[3])
                    {
                        happyDays.Add(i);
                    }

                }
            }
            return happyDays;
        }
        private int _FindClosestLeapYear(int year)
        {
            if (year % 4 != 0)
            {
                for (int itterYear = year; itterYear > 0; itterYear--)
                {
                    if (itterYear % 4 == 0)
                    {
                        year = itterYear;
                        break;
                    }
                }
            }
            return year;

        }
    }
}