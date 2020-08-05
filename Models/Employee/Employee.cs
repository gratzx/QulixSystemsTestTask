using System;
using System.ComponentModel.DataAnnotations;

namespace QulixSystemsTestTask.Models
{
    public class Employee
    {
        [Key]
        [Required]
        public long Id { get; set; }

        public string Surname { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }

        public string Patronymic { get; set; }

        public DateTime? EmploymentDate { get; set; }

        public long PositionId { get; set; }
        public string PositionName { get; set; }

        public long CompanyId { get; set; }

        public string CompanyName { get; set; }
    }
}