using System.Collections.Generic;
using System.Threading.Tasks;

using QulixSystemsTestTask.Models;

namespace QulixSystemsTestTask.Services.Repository
{
    public interface IRepository
    {
        ValueTask<IEnumerable<Employee>> GetAllEmployees();

        ValueTask<Employee> GetEmployee(long id);

        Task AddEmployee(Employee employee);

        Task UpdateEmployee(Employee employee);

        Task RemoveEmployee(long id);

        ValueTask<IEnumerable<Position>> GetAllPositions();

        ValueTask<IEnumerable<Company>> GetAllCompanies();

        ValueTask<Company> GetCompany(long id);

        Task AddCompany(Company company);

        Task UpdateCompany(Company company);

        Task RemoveCompany(long id);

        ValueTask<IEnumerable<CompanyType>> GetAllCompanyTypes();
    }
}