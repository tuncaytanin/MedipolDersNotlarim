using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.BusinessLayer.Manager;
using Blog.DataAccessLayer.EntityFramework;
using Blog.EntitesLayer.Concrate;

namespace Blog.WebMvc.Controllers
{
    public class UserController : Controller
    {
        private UserManager um = new UserManager(new EfUserRepository());
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User pUser)
        {
            // pUser kontrollerim varsa  burada yapmalıyız


            var users = um.GetAllByFilter(x => x.UserEmail == pUser.UserEmail.ToLower().Trim(), null);
            if (users.Count > 0)
            {
                return View();
            }

            pUser.CreateDate= DateTime.Now;
            pUser.DomainId = 1;
            pUser.UserStatus = true;
            
            um.Add(pUser);
            return RedirectToAction("Index", "Login");
        }


        [HttpGet]
        public ActionResult FormUser(int id)
        {
            var user = um.GetModelById(4);


            return View(user);
        }

        [HttpPost]
        public ActionResult FormUser(User pUser)
        {
            var user = um.GetModelById(pUser.UserId);
            user.UserName = pUser.UserName;
            user.UserLastName = pUser.UserLastName;
            user.UserEmail = pUser.UserEmail;
            user.UserPassword = pUser.UserPassword;
            um.Update(user);

            return RedirectToAction("Index", "UserPanel");
        }
    }
}