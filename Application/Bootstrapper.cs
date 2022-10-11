using Application.UseCase.Conta;

namespace Application
{
    public static class Bootstrapper
    {
        public static void AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            AdicionarUseCases(services);
        }

        private static void AdicionarUseCases(IServiceCollection services)
        {
            services.AddScoped<IRegistrarConta, RegistrarConta>();
        }
    }
}
