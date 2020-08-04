using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using QulixSystemsTestTask.Models;

namespace QulixSystemsTestTask.Controllers
{
    public partial class HomeController : Controller
    {
        public async Task<IActionResult> Employees()
        {
            var data = await _repository.GetAllEmployees();

            return View(data);
        }

        public async Task<IActionResult> AddEmployee(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            await _repository.AddEmployee(employee);

            return Ok();
        }

        public async Task<IActionResult> UpdateEmployee(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            await _repository.UpdateEmployee(employee);

            return Ok();
        }

        public async Task<IActionResult> DeleteEmployee(long id)
        {
            await _repository.RemoveEmployee(id);

            return RedirectToAction("Employees");
        }
    }
}