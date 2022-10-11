using Microsoft.AspNetCore.Connections;

namespace Infra2
{
    public static class Bootstrapper
    {
        public static void AddInfra2(this IServiceCollection services, IConfiguration configurationManager)
        {
            AddContexto(services, configurationManager);
        }

        private static void AddContexto(IServiceCollection services, IConfiguration configurationManager)
        {
            //var connextionString = new ConnectionContext();

            //services.AddDbContext<Context>(dbContextoOpcoes =>
            //{
            //    dbContextoOpcoes
            //});
        }
    }
}
