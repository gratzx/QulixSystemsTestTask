using System.ComponentModel.DataAnnotations;

namespace QulixSystemsTestTask.Models
{
    public class Company
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required (AllowEmptyStrings = false)]
        public string Name { get; set; }

        public int Size { get; set; }
        public string Type { get; set; }
    }
}