using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

namespace QulixSystemsTestTask.Controllers
{
    public partial class HomeController : Controller
    {
        public async Task<IActionResult> Companies()
        {
            var companies = await _repository.GetAllCompanies();

            return View(companies);
        }
        
        public async Task<IActionResult> DeleteCompany(long id)
        {
            await _repository.RemoveCompany(id);

            return RedirectToAction("Companies");
        }
    }
}