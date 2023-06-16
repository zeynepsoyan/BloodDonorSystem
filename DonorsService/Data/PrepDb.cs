using Donors.API.Models;

namespace Donors.API.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using(var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SeedData(AppDbContext context)
        {
            if (!context.Donors.Any()) 
            {
                Console.WriteLine("-> Seeding data...");

                context.Donors.AddRange(
                    new Donor() {Name="Zeynep", BloodType="A-", City="İzmir", Town="Bornova", PhoneNumber="5051234567"},
                    new Donor() {Name="Gamze", BloodType="B+", City="İzmir", Town="Bornova", PhoneNumber="5059876543" }
                );

                context.Bloods.AddRange(
                    new Blood() {City="İzmir", Town="Bornova", BloodType="A-"},
                    new Blood() {City="İzmir", Town="Bornova", BloodType="B+"},
                    new Blood() {City="İzmir", Town="Bornova", BloodType="0+"},
                    new Blood() {City="İzmir", Town="Konak", BloodType="A-"},
                    new Blood() {City="İzmir", Town="Konak", BloodType="AB"}
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
