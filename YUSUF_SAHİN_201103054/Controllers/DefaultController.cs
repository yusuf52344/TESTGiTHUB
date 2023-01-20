using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace YUSUF_SAHİN_201103054.Controllers
{
    public class DefaultController : Controller
    {

        public class ExampleDb : DbContext
        {
            public DbSet<Urunler2> Urunler2 { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-KVIRVD3\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        public class Urunler2
        {
            public int Id { get; set; }
            public string name { get; set; }
        }

        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Kurumsal()
        {
            return View();
        }

        public ActionResult Cozumortaklarimiz()
        {
            return View();
        }

        public ActionResult Iletisim()
        {
            return View();
        }

        public ActionResult Urunler()
        {
            return View();
        }

        public ActionResult urunalt()
        {
            return View();
        }

        public ActionResult Blog()
        {
            return View();
        }

        public ActionResult Blogalt()
        {
            return View();
        }


    }
}