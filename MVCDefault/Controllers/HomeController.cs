using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDefault.Models;

namespace MVCDefault.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem { Value = "1", Text = "Kragujevac", Selected = true });
            list.Add(new SelectListItem { Value = "2", Text = "Beograd", Disabled = true });
            list.Add(new SelectListItem { Value = "3", Text = "Krusevac" });
            return View(list);
        }

        public ActionResult Calendar()
        {

            return View();
        }

        public ActionResult OurCalendar()
        {
            //string[] pasMacka = { "jedan", "dva", "tri", "cetri" };
            Dictionary<string, string> pasMacka = new Dictionary<string, string>()
            {
                {"Branislav Delić","blue"},
                {"Vukašin Davidović","yellow"},
                {"Ivan Božić Kum","green"},
                {"Kristina Ćojbašić","black"},
                {"Stefan Cvetkovic","gray"},
                {"Slavica Čikojević","red"}
            };

            List<PasMacka> nazivList = new List<PasMacka>
            {
                new PasMacka
                {
                    Id = 1,
                    Color = "#f56954",
                    Godina = 2016,
                    Mesec = 6,
                    Dan = 29,
                    Naziv = @"Posetio klijenta:\n Henkel"
                },
                new PasMacka
                {
                    Id = 2,
                    Color = "#f56954",
                    Godina = 2016,
                    Mesec = 6,
                    Dan = 27,
                    Naziv =@"Posetio klijenta:\n KocakKoca"
                },
                new PasMacka
                {
                    Id = 3,
                    Color = "#f56954",
                    Godina = 2016,
                    Mesec = 6,
                    Dan = 14,
                    Naziv = @"Posetio klijenta:\n KocakKoca"
                }
            };
           
            ViewBag.PasMacka = pasMacka;
            ViewBag.Naziv = nazivList;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}