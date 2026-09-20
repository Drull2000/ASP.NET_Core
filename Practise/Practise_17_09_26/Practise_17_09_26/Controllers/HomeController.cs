using Microsoft.AspNetCore.Mvc;
using Practise_17_09_26.Models;

namespace Practise_17_09_26.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var userInfo = new UserInfoModel
            {
                FullName = "Скалозуб Владислав Андрійович",
                Phone = "+777777777",
                Email = "student@example.com",
                Group = "КИ-21",
                Speciality = "Комп'ютерна Інженерія"
            };

            ViewBag.UserInfo = userInfo;

            return View();
        }
    }
}