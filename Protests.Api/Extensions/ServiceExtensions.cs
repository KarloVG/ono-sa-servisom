using Microsoft.Extensions.DependencyInjection;
using Protests.Api.Services;
using Protests.Core.Repositories;
using Protests.Core.Repositories.Cities;
using Protests.Core.Repositories.Comments;
using Protests.Core.Repositories.Protests;

namespace Protests.Api.Extensions
{
    public static class ServiceExtensions
    {
        public static void RegisterScopedServices(this IServiceCollection services)
        {
            services.AddScoped<IProtestRepository, ProtestRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<IDriverRepository, DriverRepository>();
            services.AddScoped<IRepairRepository, RepairRepository>();
            services.AddScoped<IRepairOptionRepository, RepairOptionRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            /*services*/
            services.AddScoped<IAuthService, AuthService>();
        }
    }
}