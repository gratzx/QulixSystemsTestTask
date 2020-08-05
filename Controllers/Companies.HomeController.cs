using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using QulixSystemsTestTask.Models;

namespace QulixSystemsTestTask.Controllers
{
    public partial class HomeController : Controller
    {
        public async Task<IActionResult> Companies()
        {
            var companies = await _repository.GetAllCompanies();

            return View(
                "Companies",
                companies
            );
        }

        public async Task<IActionResult> AddCompany()
        {
            var companyViewModel = new CompanyViewModel
            {
                CompanyTypes = await _repository.GetAllCompanyTypes()
            };

            ViewData["title"] = "Добавить компанию";
            ViewBag.actionName = "AddCompany";

            return View(
                "Company",
                companyViewModel
            );
        }

        [HttpPost]
        public async Task<IActionResult> AddCompany(Company company)
        {
            if (!ModelState.IsValid)
            {
                return await AddCompany();
            }

            await _repository.AddCompany(company);

            return await Companies();
        }

        public async Task<IActionResult> UpdateCompany(long id)
        {
            var companyViewModel = new CompanyViewModel
            {
                Company = await _repository.GetCompany(id),
                CompanyTypes = await _repository.GetAllCompanyTypes()
            };

            ViewData["title"] = "Изменить компанию";
            ViewBag.actionName = "UpdateCompany";
            ViewBag.editMode = true;

            return View(
                "Company",
                companyViewModel
            );

        }

        [HttpPost]
        public async Task<IActionResult> UpdateCompany(Company company)
        {
            if (ModelState.IsValid)
            {
                await _repository.UpdateCompany(company);
            }

            return await Companies();
        }

        public async Task<IActionResult> DeleteCompany(long id)
        {
            await _repository.RemoveCompany(id);

            return await Companies();
        }
    }
}