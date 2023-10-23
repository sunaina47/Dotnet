using CodingFinger.Data;
using Microsoft.EntityFrameworkCore;

namespace CodingFinger.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CodingFingerContext(
                serviceProvider.GetRequiredService<DbContextOptions<CodingFingerContext>>()))
            {
                //Look for employer info
                if (context.Employer.Any())
                {
                    return;
                }
                context.Employer.AddRange(
                    new Employer
                    {
                        EmployerNum = 8,
                        EmployerName = "Srinivas Acharya",
                        EmployerDesignation = "Implementation Engineer",
                        EmployerAge = "24",
                        EmployerSalary = 23000
                    },
                    new Employer
                    {
                        EmployerNum = 9,
                        EmployerName = "Bhakti Naik",
                        EmployerDesignation = "Trainee Software Engineer",
                        EmployerAge = "32",
                        EmployerSalary = 18000
                    });
                context.SaveChanges();
            }
        }
    }
}
