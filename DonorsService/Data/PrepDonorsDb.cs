using Donors.API.Models;

namespace Donors.API.Data
{
    public static class PrepDonorsDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using(var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<DonorDbContext>());
            }
        }

        private static void SeedData(DonorDbContext context)
        {
            if (!context.Donors.Any()) 
            {
                Console.WriteLine("-> Seeding data...");

                context.Donors.AddRange(
                    new Donor() {Name="Zeynep", BloodType="A-", City="İzmir", Town="Bornova", PhoneNumber="5051234567"},
                    new Donor() {Name="Gamze", BloodType="B+", City="İzmir", Town="Bornova", PhoneNumber="5059876543" }
                );

                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("-> We already have data");
            }
        }
    }
}
