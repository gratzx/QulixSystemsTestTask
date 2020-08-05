using System.Collections.Generic;
using System.Threading.Tasks;

using Dapper;

using QulixSystemsTestTask.Models;
using QulixSystemsTestTask.Services.ExecuteCommand;
using QulixSystemsTestTask.Services.Queries;

namespace QulixSystemsTestTask.Services.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly IExecuters _executers;
        private readonly ICompanyCommands _companyCommands;
        public CompanyRepository(
            IExecuters executers,
            ICompanyCommands companyCommands
        )
        {
            _executers = executers;
            _companyCommands = companyCommands;
        }

        ValueTask<IEnumerable<Company>> ICompanyRepository.GetAllCompanies()
        {
            return _executers.ExecuteCommandWithResult(
                connnection => connnection.QueryAsync<Company>(_companyCommands.GetAllCompanies)
            );
        }

        ValueTask<Company> ICompanyRepository.GetCompany(long id)
        {
            return _executers.ExecuteCommandWithResult(
                connnection => connnection.QueryFirstOrDefaultAsync<Company>(
                    _companyCommands.GetCompanyById,
                    new { id }
                )
            );
        }

        Task ICompanyRepository.AddCompany(Company company)
        {
            return _executers.ExecuteCommand(
                connnection => connnection.ExecuteAsync(
                    _companyCommands.AddCompany,
                    company
                )
            );
        }

        Task ICompanyRepository.UpdateCompany(Company company)
        {
            return _executers.ExecuteCommand(
                connnection => connnection.ExecuteAsync(
                    _companyCommands.UpdateCompany,
                    company
                )
            );
        }

        Task ICompanyRepository.RemoveCompany(long id)
        {
            return _executers.ExecuteCommand(
                connnection => connnection.ExecuteAsync(
                    _companyCommands.RemoveCompanyById,
                    new { id }
                )
            );
        }

        ValueTask<IEnumerable<CompanyType>> ICompanyRepository.GetAllCompanyTypes()
        {
            return _executers.ExecuteCommandWithResult(
                connection => connection.QueryAsync<CompanyType>(_companyCommands.GetAllCompanyTypes)
            );
        }
    }
}