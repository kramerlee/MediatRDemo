using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Lib.Application
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }

        public static void AddAutoMapperProfiles(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}