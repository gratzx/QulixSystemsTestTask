namespace QulixSystemsTestTask.Services.Queries
{
    public class CommandText : ICommandText
    {
        string ICommandText.GetEmployees => @"
            select
                Employees.Id as Id,
                Employees.Name as Name,
                Employees.Surname as Surname,
                Employees.Patronymic as Patronymic,
                Employees.EmploymentDate as EmploymentDate,
                Positions.Name as Position,
                Companies.Name as Company
            from
                [Qulix].[dbo].[Employees] Employees
                left outer join
                    [Qulix].dbo.Positions Positions
                on
                    Employees.PositionId = Positions.Id
                left outer join
                    Qulix.dbo.Companies Companies
                on
                    Employees.CompanyId = Companies.Id
        ";
        string ICommandText.GetEmployeeById => "";
        string ICommandText.AddEmployee => "";
        string ICommandText.UpdateEmployee => "";

        string ICommandText.RemoveEmployeeById => "delete from [Qulix].[dbo].[Employees] where Employees.Id = @id";

        string ICommandText.GetAllCompanies => @"
            select
                Companies.Id as Id,
                Companies.Name as Name,
                Companies.Size as Size,
                CompanyTypes.Name as Type
            from
                [Qulix].[dbo].[Companies] Companies
                left outer join
                    [Qulix].[dbo].[CompanyTypes] CompanyTypes
                on
                    Companies.CompanyTypeId = CompanyTypes.Id
        ";

        string ICommandText.GetCompanyById => @"";

        string ICommandText.AddCompany => "";

        string ICommandText.UpdateCompany => "";

        string ICommandText.RemoveCompanyById => "delete from [Qulix].[dbo].[Companies] where Companies.Id = @id";
    }
}