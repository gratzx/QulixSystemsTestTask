namespace QulixSystemsTestTask.Services.Queries
{
    public class CompanyCommands : ICompanyCommands
    {
        string ICompanyCommands.GetAllCompanies => @"
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

        string ICompanyCommands.GetCompanyById => @"
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

        string ICompanyCommands.AddCompany => @"
            insert into
                [Qulix].[dbo].[Companies]
                (CompanyTypeId, Name, Size)
            values
                (@TypeId, @Name, @Size)
        ";

        string ICompanyCommands.UpdateCompany => @"
            update
                [Qulix].[dbo].[Companies]
            set
                CompanyTypeId = @TypeId,
                Name = @Name,
                Size = @Size
            where
                Id = @Id
        ";

        string ICompanyCommands.RemoveCompanyById => "delete from [Qulix].[dbo].[Companies] where Companies.Id = @id";

        string ICompanyCommands.GetAllCompanyTypes => "select Types.Id, Types.Name from [Qulix].[dbo].[CompanyTypes] Types";
    }
}