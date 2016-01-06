using System.Web.Mvc;

namespace Pulsar.Services.Rest.Controllers
{
    public class DownloadController : Controller
    {
        public ActionResult Index()
        {
            return Redirect("http://www.google.be");
        }
    }
}
