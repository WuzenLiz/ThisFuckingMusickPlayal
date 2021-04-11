using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThisFuckingMusickPlayal.Models;
using ThisFuckingMusickPlayal.DAL;

namespace ThisFuckingMusickPlayal.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Index(User user)
        {
            DataConnection conn = new DataConnection();
            
            if(conn.checkLogin(user))
            {
                return Redirect("/Home");
            }
            
            return View("/Login/Index");
        }
    }
}
