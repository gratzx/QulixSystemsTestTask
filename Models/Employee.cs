using System;
using System.ComponentModel.DataAnnotations;

namespace QulixSystemsTestTask.Models
{
    public class Employee
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public string Surname { get; set; }

        [Required (AllowEmptyStrings = false)]
        public string Name { get; set; }

        public string Patronymic { get; set; }

        public DateTime? EmploymentDate { get; set; }

        public string Position { get; set; }

        public string Company { get; set; }
    }
}