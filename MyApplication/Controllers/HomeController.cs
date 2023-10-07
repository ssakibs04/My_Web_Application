using MyApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyApplication.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			

			return View();
		}
		[HttpGet]
		public ActionResult Login()
		{
			return View();
		}
		[HttpPost]
		public ActionResult Login(Login l )
		{
			if(ModelState.IsValid){
				return RedirectToAction("Dash", "Dashboard");
			}
			return View(l);
		}

		[HttpGet]
		public ActionResult SignUp()
		{


			return View();
		}
		[HttpPost]
		public ActionResult SignUp(SignUp s)
		{
			if(ModelState.IsValid)
			{
				return RedirectToAction("Login");
			}
			return View(s);
		}
	}
}