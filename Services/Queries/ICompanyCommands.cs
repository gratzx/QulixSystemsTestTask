namespace QulixSystemsTestTask.Services.Queries
{
    public interface ICompanyCommands
    {
        string GetAllCompanies { get; }
        string GetCompanyById { get; }
        string AddCompany { get; }
        string UpdateCompany { get; }
        string RemoveCompanyById { get; }
        string GetAllCompanyTypes { get; }
    }
}