using Framework.Message.Bus.MessageBus;
using Microsoft.Extensions.DependencyInjection;

namespace Framework.Message.Bus
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddMessageBus(this IServiceCollection services)
        {


            services.AddScoped<IMessageBus, MessageBus.MessageBus>();

            return services;
        }
    }
}
