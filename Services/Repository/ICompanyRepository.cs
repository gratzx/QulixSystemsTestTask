using System.Collections.Generic;
using System.Threading.Tasks;

using QulixSystemsTestTask.Models;

namespace QulixSystemsTestTask.Services.Repository
{
    public interface ICompanyRepository
    {
        ValueTask<IEnumerable<Company>> GetAllCompanies();

        ValueTask<Company> GetCompany(long id);

        Task AddCompany(Company company);

        Task UpdateCompany(Company company);

        Task RemoveCompany(long id);

        ValueTask<IEnumerable<CompanyType>> GetAllCompanyTypes();
    }
}