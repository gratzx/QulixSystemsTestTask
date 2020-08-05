namespace QulixSystemsTestTask.Services.Queries
{
    public interface ICommandText
    {
        string GetEmployees { get; }
        string GetEmployeeById { get; }
        string AddEmployee { get; }
        string UpdateEmployee { get; }
        string RemoveEmployeeById { get; }
        string GetAllPositions { get; }

        string GetAllCompanies { get; }
        string GetCompanyById { get; }
        string AddCompany { get; }
        string UpdateCompany { get; }
        string RemoveCompanyById { get; }
        string GetAllCompanyTypes { get; }
    }
}