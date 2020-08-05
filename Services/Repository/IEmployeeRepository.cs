using System.Collections.Generic;
using System.Threading.Tasks;

using QulixSystemsTestTask.Models;

namespace QulixSystemsTestTask.Services.Repository
{
    public interface IEmployeeRepository
    {
        ValueTask<IEnumerable<Employee>> GetAllEmployees();

        ValueTask<Employee> GetEmployee(long id);

        Task AddEmployee(Employee employee);

        Task UpdateEmployee(Employee employee);

        Task RemoveEmployee(long id);

        ValueTask<IEnumerable<Position>> GetAllPositions();
    }
}