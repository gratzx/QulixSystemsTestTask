using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using QulixSystemsTestTask.Models;

namespace QulixSystemsTestTask.Controllers
{
    public partial class HomeController : Controller
    {
        public async Task<IActionResult> Employees()
        {
            var employees = await _repository.GetAllEmployees();

            return View(
                "Employees",
                employees
            );
        }

        public async Task<IActionResult> AddEmployee()
        {
            var employeeViewModel = new EmployeeViewModel
            {
                Companies = await _repository.GetAllCompanies(),
                Positions = await _repository.GetAllPositions()
            };

            ViewData["title"] = "Добавить сотрудника";
            ViewBag.actionName = "AddEmployee";

            return View(
                "Employee",
                employeeViewModel
            );
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return await AddEmployee();
            }

            await _repository.AddEmployee(employee);

            return await Employees();
        }
        public async Task<IActionResult> UpdateEmployee(long id)
        {
            var employeeViewModel = new EmployeeViewModel
            {
                Employee = await _repository.GetEmployee(id),
                Companies = await _repository.GetAllCompanies(),
                Positions = await _repository.GetAllPositions()
            };

            ViewData["title"] = "Изменить сотрудника";
            ViewBag.actionName = "UpdateEmployee";
            ViewBag.editMode = true;

            return View(
                "Employee",
                employeeViewModel
            );
        }

        [HttpPost]
        public async Task<IActionResult> UpdateEmployee(Employee employee)
        {
            if (ModelState.IsValid)
            {
                await _repository.UpdateEmployee(employee);
            }

            return await Employees();
        }

        public async Task<IActionResult> DeleteEmployee(long id)
        {
            await _repository.RemoveEmployee(id);

            return await Employees();
        }
    }
}