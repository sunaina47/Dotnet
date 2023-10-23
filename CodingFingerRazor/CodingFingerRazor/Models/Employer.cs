using System.ComponentModel.DataAnnotations;

namespace CodingFingerRazor.Models
{
    public class Employer
    {
        public int ID { get; set; }
        [Required]
        [Display (Name= "Sr no.")]
        public int EmployerNumber {get; set; }
        [Required]
        [Display(Name = "Name")]
        public string EmployerName { get; set; }
        [Required]
        [Display(Name = "Designation")]
        public string EmployerDesignation { get; set; }
        [Required]
        [Display(Name = "Salary")]
        public double EmployerSalary { get; set; }
        [Required]
        [Display(Name = "College")]
        public int EmployerAge { get; set; }
    }
}
