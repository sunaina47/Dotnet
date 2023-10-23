using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingFinger.Models
{
    public class Employer
    {
        public int Id { get; set; }
        [Range(1,100)]
        [Required]
        [Display(Name = "Employer Number")]
        public int EmployerNum { get; set; }
      
        [StringLength(50, MinimumLength = 3)]
        [Required]
        [Display(Name = "Employer Name")]
        public string EmployerName { get; set; }
        [Required]
        [Display(Name = "Designation")]
        public string EmployerDesignation { get; set; }
        [Required]
        [Display(Name = "Age")]
        public string EmployerAge { get; set; }

        [Display(Name = "Salary")]
        [Range(1,1000000000)]
        [DataType(DataType.Currency)]
        [Required]
        public double EmployerSalary { get; set; }
       
        [Display(Name ="Degree")]
        [Required]
        [StringLength(50, MinimumLength = 3)] 
        public string EmployerDegree { get; set; }  
    }
}
