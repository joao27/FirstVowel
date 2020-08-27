using FirstVowel.Domain.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace FirstVowel.Domain
{
    public static class Bootstraper
    {
        public static IServiceCollection AddDomain(this IServiceCollection services) =>
            services.AddScoped<IStream, Stream>();
    }
}
