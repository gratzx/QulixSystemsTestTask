using System.Collections.Generic;
using System.Threading.Tasks;

using Dapper;

using QulixSystemsTestTask.Models;
using QulixSystemsTestTask.Services.ExecuteCommand;
using QulixSystemsTestTask.Services.Queries;

namespace QulixSystemsTestTask.Services.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IExecuters _executers;
        private readonly IEmployeeCommands _employeeCommands;
        public EmployeeRepository(
            IExecuters executers,
            IEmployeeCommands employeeCommands
        )
        {
            _executers = executers;
            _employeeCommands = employeeCommands;
        }

        ValueTask<IEnumerable<Employee>> IEmployeeRepository.GetAllEmployees()
        {
            return _executers.ExecuteCommandWithResult(
                connection => connection.QueryAsync<Employee>(_employeeCommands.GetEmployees)
            );
        }

        ValueTask<Employee> IEmployeeRepository.GetEmployee(long id)
        {
            return _executers.ExecuteCommandWithResult(
                connection => connection.QueryFirstOrDefaultAsync<Employee>(
                    _employeeCommands.GetEmployeeById,
                    new { id }
                )
            );
        }

        Task IEmployeeRepository.AddEmployee(Employee employee)
        {
            return _executers.ExecuteCommand(
                connection => connection.ExecuteAsync(
                    _employeeCommands.AddEmployee,
                    employee
                )
            );
        }

        Task IEmployeeRepository.UpdateEmployee(Employee employee)
        {
            return _executers.ExecuteCommand(
                connection => connection.ExecuteAsync(
                    _employeeCommands.UpdateEmployee,
                    employee
                )
            );
        }

        Task IEmployeeRepository.RemoveEmployee(long id)
        {
            return _executers.ExecuteCommand(
                connection => connection.ExecuteAsync(
                    _employeeCommands.RemoveEmployeeById,
                    new { id }
                )
            );
        }

        ValueTask<IEnumerable<Position>> IEmployeeRepository.GetAllPositions()
        {
            return _executers.ExecuteCommandWithResult(
                connection => connection.QueryAsync<Position>(_employeeCommands.GetAllPositions)
            );
        }
    }
}