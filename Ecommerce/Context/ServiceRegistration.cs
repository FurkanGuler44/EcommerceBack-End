using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Context
{
    public static class ServiceRegistration
    {
        public static void AddService(this IServiceCollection service)
        {
            service.AddDbContext<EcommerceDbContext>(opt => opt.UseSqlServer(Configuration.ConnectionString));
        }
    }
}
