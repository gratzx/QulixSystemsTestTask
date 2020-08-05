using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;

using QulixSystemsTestTask.Models;
using QulixSystemsTestTask.Services.Repository;

namespace QulixSystemsTestTask.Controllers
{
    public partial class HomeController : Controller
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(
            ICompanyRepository companyRepository,
            IEmployeeRepository employeeRepository
        )
        {
            _companyRepository = companyRepository;
            _employeeRepository = employeeRepository;
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}