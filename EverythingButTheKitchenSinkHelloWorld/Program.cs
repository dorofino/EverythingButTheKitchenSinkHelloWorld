using EverythingButTheKitchenSinkHelloWorldLibrary.BusinessLogic;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using EverythingButTheKitchenSinkHelloWorld;

using IHost host = CreatedHostBuilder(args).Build();
using var scope = host.Services.CreateScope();

var services = scope.ServiceProvider;

try
{
    services.GetRequiredService<App>().Run(args);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

static IHostBuilder CreatedHostBuilder(string[] args)
{
    return Host.CreateDefaultBuilder(args)
        .ConfigureServices((_, services) =>
        {
            services.AddSingleton<IMessages, Messages>();
            services.AddSingleton<App>();
        });
}
