namespace QulixSystemsTestTask.Services.Queries
{
    public interface IEmployeeCommands
    {
        string GetEmployees { get; }
        string GetEmployeeById { get; }
        string AddEmployee { get; }
        string UpdateEmployee { get; }
        string RemoveEmployeeById { get; }
        string GetAllPositions { get; }
    }
}