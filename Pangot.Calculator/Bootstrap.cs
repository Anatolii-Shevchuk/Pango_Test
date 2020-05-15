using Microsoft.Extensions.DependencyInjection;

namespace Pangot.Calculator
{
    public static class Bootstrap
    {
        public static IServiceCollection AddPangotCalculator(this IServiceCollection services)
        {
            return
                services.AddTransient<IPangoCalculator, PangoCalculator>();
        }
    }
}
