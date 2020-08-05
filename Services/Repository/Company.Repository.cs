using System.Collections.Generic;
using System.Threading.Tasks;

using Dapper;

using QulixSystemsTestTask.Models;

namespace QulixSystemsTestTask.Services.Repository
{
    public partial class Repository : IRepository
    {
        ValueTask<IEnumerable<Company>> IRepository.GetAllCompanies()
        {
            return _executers.ExecuteCommandWithResult(
                connnection => connnection.QueryAsync<Company>(_commandText.GetAllCompanies)
            );
        }

        ValueTask<Company> IRepository.GetCompany(long id)
        {
            return _executers.ExecuteCommandWithResult(
                connnection => connnection.QueryFirstOrDefaultAsync<Company>(
                    _commandText.GetCompanyById,
                    new { id }
                )
            );
        }

        Task IRepository.AddCompany(Company company)
        {
            return _executers.ExecuteCommand(
                connnection => connnection.ExecuteAsync(
                    _commandText.AddCompany,
                    company
                )
            );
        }

        Task IRepository.UpdateCompany(Company company)
        {
            return _executers.ExecuteCommand(
                connnection => connnection.ExecuteAsync(
                    _commandText.UpdateCompany,
                    company
                )
            );
        }

        Task IRepository.RemoveCompany(long id)
        {
            return _executers.ExecuteCommand(
                connnection => connnection.ExecuteAsync(
                    _commandText.RemoveCompanyById,
                    new { id }
                )
            );
        }

        ValueTask<IEnumerable<CompanyType>> IRepository.GetAllCompanyTypes()
        {
            return _executers.ExecuteCommandWithResult(
                connection => connection.QueryAsync<CompanyType>(_commandText.GetAllCompanyTypes)
            );
        }
    }
}