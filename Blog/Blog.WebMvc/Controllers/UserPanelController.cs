using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.BusinessLayer.Manager;
using Blog.DataAccessLayer.EntityFramework;

namespace Blog.WebMvc.Controllers
{
    public class UserPanelController : Controller
    {

        private UserManager um;

        public UserPanelController()
        {
           um = new UserManager(new EfUserRepository());
        }
        // GET: UserPanel
        public ActionResult Index()
        {
            var user = um.GetModelById(3);

            return View(user);
        }
    }
}