using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace eTickets.Data.Enums
{
    public class AppDbInitiliazer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {

                }
                //Actors
                if (!context.Actors.Any())
                {

                }
                //Producers
                if (!context.Producers.Any())
                {

                }
                //Movies
                if (!context.Movies.Any())
                {

                }
               
                //ACtors & Movies
                if (!context.ActorMovies.Any())
                {

                }

            }
        }
    }
}
