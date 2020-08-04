using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

namespace QulixSystemsTestTask.Controllers
{
    public partial class HomeController : Controller
    {
        public ActionResult Test(long id)
        {
            return Content($"{id}");
        }
    }
}