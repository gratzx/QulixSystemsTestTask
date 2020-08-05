namespace QulixSystemsTestTask.Services.Queries
{
    public class EmployeeCommands : IEmployeeCommands
    {
        string IEmployeeCommands.GetEmployees => @"
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
        string IEmployeeCommands.GetEmployeeById => @"
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
        string IEmployeeCommands.AddEmployee => @"
            insert into
                [Qulix].[dbo].[Employees]
                (CompanyId, PositionId, Surname, Name, Patronymic, EmploymentDate)
            values
                (@CompanyId, @PositionId ,@Surname, @Name, @Patronymic, @EmploymentDate)
        ";
        string IEmployeeCommands.UpdateEmployee => @"
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

        string IEmployeeCommands.RemoveEmployeeById => "delete from [Qulix].[dbo].[Employees] where Employees.Id = @id";

        string IEmployeeCommands.GetAllPositions => "select Positions.Id, Positions.Name from [Qulix].[dbo].[Positions] Positions";
    }
}