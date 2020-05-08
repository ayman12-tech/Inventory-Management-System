using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;


namespace InventoryManagementSystem.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Index(user u)
        {
            inventoryDBmvcEntities obj = new inventoryDBmvcEntities();
            var data = obj.st_getLoginDetails(u.u_username, u.u_password);
            foreach(var item in data)
            {
                if(item.Username==u.u_username && item.Password==u.u_password)
                {
                    string r = obj.st_getRoleWRTuser(u.u_username).Single();
                    Session["role"] = r;
                    Session["name"] = u.u_username;
                    return RedirectToAction("Main");
                }
                else
                {
                    
                }

            }
            return View();
        }

        public ActionResult Logout()
        {
            Session.Remove("name");
            Session.Remove("role");
            return View("Index");
        }

      

        public ActionResult Main()
        {
            if(Session["name"]==null)
            {
                return RedirectToAction("Index", "Auth");
            }
            else
            {
                return View();
            }
        }
    }
}