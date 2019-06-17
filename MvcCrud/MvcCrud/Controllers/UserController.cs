using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCrud.Models;

namespace MvcCrud.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        [HttpGet]
        public ActionResult AddOrEdit(int id=0)
        {
            User userModel = new User();
            return View(userModel);
        }
        [HttpPost]
        public ActionResult AddOrEdit(User userModel)
        {
            using (DbModels1 dbModel1 = new DbModels1())
            {
                dbModel1.Users.Add(userModel);
                dbModel1.SaveChanges();
            }
            ModelState.Clear();
           
            return View("AddOrEdit", new User());
        }
    }
}