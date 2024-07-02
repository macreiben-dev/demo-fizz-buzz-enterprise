using FizzBuzzService.Enterprise;

namespace WebApplication1;

public static class ServicesConfiguration
{
    public static void Configure(IServiceCollection builderServices)
    {
        builderServices.AddMediatR(
            cfg => cfg.RegisterServicesFromAssembly(typeof(FizzBuzzServiceImpl).Assembly));

        builderServices.AddScoped<IFizzBuzzServiceImpl, FizzBuzzServiceImpl>();
    }
}