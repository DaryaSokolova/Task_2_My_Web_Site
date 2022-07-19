using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewSite.EF;
using NewSite24.EF;
using NewSite24.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NewSite24.Controllers
{
    public class NewsController : Controller
    {
        private norContext db;
        public NewsController(norContext context)
        {
            db = context;
        }

        public IActionResult Show(string path)
        {
            norContext db = new norContext();
            ViewBag.Directions = db.Direction.OrderBy(x => x.Name).ToList();

            if (path == null)
            {
                // в корне сайта - все публикации
                ViewBag.Stations = db.Station.OrderBy(x => x.Name).ToList();

            }
            else
            {
                ViewBag.Stations = db.Station.Where(x => x.Direction == path).OrderBy(x => x.Name).ToList();
            }

            return View();
        }

        public IActionResult Station(string path, string nick, string text)
        {
            //MyDbContext db = new MyDbContext();
            ViewBag.Directions = db.Direction.OrderBy(x => x.Name).ToList();
            ViewBag.Stations = db.Station.OrderBy(x => x.Name).ToList();

            Station p = db.Station.FirstOrDefault(x => x.Path == path);
            if (p == null)
            {
                return NotFound();
            }

            if (nick != null && text != null)
            {
                Comment comment = new Comment
                {
                    Station = p.Id,
                    DateTime = DateTime.Now,
                    Nick = nick,
                    Text = text
                };
                db.Comment.Add(comment);
                db.SaveChanges();
            }

            ViewBag.Comments = db.Comment.Where(x => x.Station == p.Id).OrderByDescending(x => x.DateTime).ToList();
            ViewBag.Station = p;
            ViewBag.Direction = db.Direction.OrderBy(x => x.Name).ToList();

            return View();
        }

        public IActionResult Search(string text)
        {

            ViewBag.Today = DateTime.Now.ToString("dd.MM.yyyy");
            ViewBag.Directions = db.Direction.OrderBy(x => x.Name).ToList();
            ViewBag.Stations = db.Station.OrderBy(x => x.Name).ToList();

            var stations = db.Station.Where(x => x.Name.IndexOf(text) >= 0 || x.Text.IndexOf(text) >= 0).ToList();
            if (stations.Count == 0)
            {
                return View("SearchNoResults");
            }

            ViewBag.Station = stations;
            return View("Search");
        }
    }
}
