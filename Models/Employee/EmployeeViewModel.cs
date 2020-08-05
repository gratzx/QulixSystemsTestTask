using System.Collections.Generic;

namespace QulixSystemsTestTask.Models
{
    public class EmployeeViewModel
    {
        public Employee Employee { get; set; }

        public IEnumerable<Company> Companies { get; set; }

        public IEnumerable<Position> Positions { get; set; }

        public void Deconstruct(
            out Employee employee,
            out IEnumerable<Company> companies,
            out IEnumerable<Position> positions
        )
        {
            employee = Employee;
            companies = Companies;
            positions = Positions;
        }
    }
}