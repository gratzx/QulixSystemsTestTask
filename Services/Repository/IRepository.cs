using System.Collections.Generic;
using System.Threading.Tasks;

using QulixSystemsTestTask.Models;

namespace QulixSystemsTestTask.Services.Repository
{
    public interface IRepository
    {
        public ValueTask<IEnumerable<Employee>> GetAllEmployees();

        public ValueTask<Employee> GetEmployee(long id);

        public Task AddEmployee(Employee employee);

        public Task UpdateEmployee(Employee employee);

        public Task RemoveEmployee(long id);

        public ValueTask<IEnumerable<Company>> GetAllCompanies();

        public ValueTask<Company> GetCompany(long id);

        public Task AddCompany(Company company);

        public Task UpdateCompany(Company company);

        public Task RemoveCompany(long id);
    }
}