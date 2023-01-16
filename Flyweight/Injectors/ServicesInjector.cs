using DataLayer.Context;
using DataLayer.Implementations;
using DataLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace UnitOfWork.Injectors
{
    public static class ServicesInjector
    {
        public static void Inject(IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<SampleDbContext>(options =>
            {
                options.UseSqlServer("YourConnectionString");
            });

            serviceCollection.AddScoped<IPersonRepository, PersonRepository>();
            serviceCollection.AddScoped<DataLayer.Context.UnitOfWork>();
        }
    }
}
