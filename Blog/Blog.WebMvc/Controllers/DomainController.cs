using Blog.BusinessLayer.Manager;
using Blog.DataAccessLayer.EntityFramework;
using Blog.EntitesLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.WebMvc.Controllers
{
    public class DomainController : Controller
    {
        private DomainManager dm = new DomainManager(new EfDomainRepository());
        // GET: Domain
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            var domains = dm.GetAll();
            return View(domains);
        }

        public ActionResult Delete(int id)
        {
            var domain = dm.GetModelById(id);
            if (domain == null)
                return HttpNotFound();
            domain.DomainStatus = false;

            dm.Update(domain);

            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var domain = dm.GetModelById(id);
            if (domain == null)
                return HttpNotFound();

            return View("FormDomain", domain);
        }

        [HttpGet]
        public ActionResult New()
        {
            return View("FormDomain", new Domain { DomainId = 0 });
        }

        [HttpPost]
        public ActionResult AddOrUpdate(Domain pDomain)
        {
            pDomain.DomainStatus = true;
            if (pDomain.DomainId == 0)
            {
                // Ekleme
                dm.Add(pDomain);
            }
            else
            {
                //Guncelleme
                dm.Update(pDomain);
            }

            return RedirectToAction("List");
        }
    }
}