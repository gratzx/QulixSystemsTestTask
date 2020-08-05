using System.Collections.Generic;
using System.Threading.Tasks;

using Dapper;

using QulixSystemsTestTask.Models;

namespace QulixSystemsTestTask.Services.Repository
{
    public partial class Repository : IRepository
    {
        ValueTask<IEnumerable<Employee>> IRepository.GetAllEmployees()
        {
            return _executers.ExecuteCommandWithResult(
                connection => connection.QueryAsync<Employee>(_commandText.GetEmployees)
            );
        }

        ValueTask<Employee> IRepository.GetEmployee(long id)
        {
            return _executers.ExecuteCommandWithResult(
                connection => connection.QueryFirstOrDefaultAsync<Employee>(
                    _commandText.GetEmployeeById,
                    new { id }
                )
            );
        }

        Task IRepository.AddEmployee(Employee employee)
        {
            return _executers.ExecuteCommand(
                connection => connection.ExecuteAsync(
                    _commandText.AddEmployee,
                    employee
                )
            );
        }

        Task IRepository.UpdateEmployee(Employee employee)
        {
            return _executers.ExecuteCommand(
                connection => connection.ExecuteAsync(
                    _commandText.UpdateEmployee,
                    employee
                )
            );
        }

        Task IRepository.RemoveEmployee(long id)
        {
            return _executers.ExecuteCommand(
                connection => connection.ExecuteAsync(
                    _commandText.RemoveEmployeeById,
                    new { id }
                )
            );
        }

        ValueTask<IEnumerable<Position>> IRepository.GetAllPositions()
        {
            return _executers.ExecuteCommandWithResult(
                connection => connection.QueryAsync<Position>(_commandText.GetAllPositions)
            );
        }

    }
}