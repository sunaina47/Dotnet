using CodingFingerRazor.Data;
using Microsoft.EntityFrameworkCore;

namespace CodingFingerRazor.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CodingFingerRazorContext(
                serviceProvider.GetRequiredService< 
                DbContextOptions < CodingFingerRazorContext>>()))
            {
                if (context.Employer.Any())
                {
                    return;
                }
                context.Employer.AddRange(
                    new Employer
                    {
                        EmployerNumber = 2,
                        EmployerName = "Neha Sawant",
                        EmployerDesignation = "TSE",
                        EmployerSalary = 23000
                    },
                    new Employer
                    {
                        EmployerNumber = 3,
                        EmployerName = "Henry James",
                        EmployerDesignation = "TSE",
                        EmployerSalary = 18500
                    });
                context.SaveChanges();
            }
        }
    }
}
