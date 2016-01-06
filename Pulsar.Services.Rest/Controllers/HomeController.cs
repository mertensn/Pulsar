using System.Web.Mvc;

namespace Pulsar.Services.Rest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Pulsar REST Service";

            return View();
        }
    }
}
