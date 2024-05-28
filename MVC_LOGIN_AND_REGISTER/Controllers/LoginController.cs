using MVC_LOGIN_AND_REGISTER.Data;
using MVC_LOGIN_AND_REGISTER.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_LOGIN_AND_REGISTER.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LoginController()
        {
            _context = new ApplicationDbContext();
            
        }



        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            var enteruesername = username;
            var enterpassword = password;

            if(_context.Users.Any(x => x.Username == enteruesername && x.Password == enterpassword))
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Login");
            }


        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(string username, string password)
        {
            var user = new User
            {
                Username = username,
                Password = password
            };
            _context.Users.Add(user);
            _context.SaveChanges();
            return RedirectToAction("Login", "Login");

        }


    }
}