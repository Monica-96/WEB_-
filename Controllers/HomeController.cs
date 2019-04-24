using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB_гайд.Models;

namespace WEB_гайд.Controllers
{
    public class HomeController : Controller
    {
        // создаем контекст данных для взаимодействия с БД
        TOURGUIDE_context db = new TOURGUIDE_context();

        public ActionResult Index()
        {
            // получаем из бд все объекты Poeple
            IEnumerable<People> people = db.People;
            // передаем все объекты в динамическое свойство Books в ViewBag
            ViewBag.People = people;
            // возвращаем представление
            return View();
        }
    }
}