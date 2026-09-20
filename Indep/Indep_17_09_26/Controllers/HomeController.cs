using Microsoft.AspNetCore.Mvc;
using Indep_17_09_26.Models;

namespace Indep_17_09_26.Controllers
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
                    new Sight { Title = "Оперний театр", Url = "https://img.hotels24.ua/photos/ria/new_images/1023/102312/10231247/10231247m.jpg" },
                    new Sight { Title = "Потьомкінські сходи", Url = "https://chornemore.com/wp-content/uploads/2023/06/odessa-potemkin-stairs-1.jpg" },
                    new Sight { Title = "Воронцовський маяк", Url = "https://love-odessa.od.ua/wp-content/uploads/2021/04/mayak1.jpg" }
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