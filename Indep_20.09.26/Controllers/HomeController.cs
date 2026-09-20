using Microsoft.AspNetCore.Mvc;
using Indep_20_09_26.Models;

namespace Indep_20_09_26.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var cityData = new CityModel
            {
                Name = "Одеса",
                Country = "Україна",
                FoundationYear = 1794,
                Description = "Морська столиця України, відома своєю історією, архітектурою та гумором.",
                Sights = new List<Sight>
                {
                    new Sight { Title = "Оперний театр", Url = "https://images.unsplash.com/photo-1596484552834-6a58f850e0a1?auto=format&fit=crop&w=600&q=80" },
                    new Sight { Title = "Потьомкінські сходи", Url = "https://images.unsplash.com/photo-1579783902614-a3fb3927b675?auto=format&fit=crop&w=600&q=80" },
                    new Sight { Title = "Воронцовський маяк", Url = "https://images.unsplash.com/photo-1565008447742-97f6f38c985c?auto=format&fit=crop&w=600&q=80" }
                }
            };

            var bookData = new BookModel
            {
                Title = "1984",
                Author = "Джордж Орвелл",
                Genre = "Антиутопія",
                Pages = 328,
                Reviews = new List<Review>
                {
                    new Review { Id = 1, Author = "Олексій М.", Text = "Неймовірний роман, який залишається актуальним у будь-які часи." },
                    new Review { Id = 2, Author = "Олена К.", Text = "Глибока книга з потужною атмосферою." },
                    new Review { Id = 3, Author = "Дмитро П.", Text = "Шедевр світової літератури." }
                }
            };

            ViewBag.CityData = cityData;
            ViewBag.BookData = bookData;

            return View();
        }
    }
}