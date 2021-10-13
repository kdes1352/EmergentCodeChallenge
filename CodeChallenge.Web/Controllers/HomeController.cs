namespace CodeChallenge.Web.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using Data;
    using Models;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new List<Software>());
        }

        [HttpPost]
        public ActionResult Index(string versionNumber)
        {
            ViewBag.VersionInput = versionNumber;
            return View(SoftwareManager.GetAllSoftware().Where(a => a.HigherVersion(versionNumber)).OrderBy(a=>a.Name).ToList());
        }
    }
}