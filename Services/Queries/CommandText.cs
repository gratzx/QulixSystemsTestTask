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
                Positions.Id as PositionId,
                Positions.Name as PositionName,
                Companies.Id as CompanyId,
                Companies.Name as CompanyName
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
        string ICommandText.GetEmployeeById => @"
            select
                Employees.Id as Id,
                Employees.Name as Name,
                Employees.Surname as Surname,
                Employees.Patronymic as Patronymic,
                Employees.EmploymentDate as EmploymentDate,
                Positions.Id as PositionId,
                Positions.Name as PositionName,
                Companies.Id as CompanyId,
                Companies.Name as CompanyName
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
            where
                Employees.Id = @Id
        ";
        string ICommandText.AddEmployee => @"
            insert into
                [Qulix].[dbo].[Employees]
                (CompanyId, PositionId, Surname, Name, Patronymic, EmploymentDate)
            values
                (@CompanyId, @PositionId ,@Surname, @Name, @Patronymic, @EmploymentDate)
        ";
        string ICommandText.UpdateEmployee => @"
            update
                [Qulix].[dbo].[Employees]
            set
                CompanyId = @CompanyId,
                PositionId = @PositionId,
                Surname = @Surname,
                Name = @Name,
                Patronymic = @Patronymic,
                EmploymentDate = @EmploymentDate
            where
                Id = @Id
        ";

        string ICommandText.RemoveEmployeeById => "delete from [Qulix].[dbo].[Employees] where Employees.Id = @id";

        string ICommandText.GetAllPositions => "select Positions.Id, Positions.Name from [Qulix].[dbo].[Positions] Positions";

        string ICommandText.GetAllCompanies => @"
            select
                Companies.Id as Id,
                Companies.Name as Name,
                Companies.Size as Size,
                CompanyTypes.Id as TypeId,
                CompanyTypes.Name as TypeName
            from
                [Qulix].[dbo].[Companies] Companies
                left outer join
                    [Qulix].[dbo].[CompanyTypes] CompanyTypes
                on
                    Companies.CompanyTypeId = CompanyTypes.Id
        ";

        string ICommandText.GetCompanyById => @"
            select
                Companies.Id as Id,
                Companies.Name as Name,
                Companies.Size as Size,
                CompanyTypes.Id as TypeId,
                CompanyTypes.Name as TypeName
            from
                [Qulix].[dbo].[Companies] Companies
                left outer join
                    [Qulix].[dbo].[CompanyTypes] CompanyTypes
                on
                    Companies.CompanyTypeId = CompanyTypes.Id
            where
                Companies.Id = @Id
        ";

        string ICommandText.AddCompany => @"
            insert into
                [Qulix].[dbo].[Companies]
                (CompanyTypeId, Name, Size)
            values
                (@TypeId, @Name, @Size)
        ";

        string ICommandText.UpdateCompany => @"
            update
                [Qulix].[dbo].[Companies]
            set
                CompanyTypeId = @TypeId,
                Name = @Name,
                Size = @Size
            where
                Id = @Id
        ";

        string ICommandText.RemoveCompanyById => "delete from [Qulix].[dbo].[Companies] where Companies.Id = @id";

        string ICommandText.GetAllCompanyTypes => "select Types.Id, Types.Name from [Qulix].[dbo].[CompanyTypes] Types";
    }
}