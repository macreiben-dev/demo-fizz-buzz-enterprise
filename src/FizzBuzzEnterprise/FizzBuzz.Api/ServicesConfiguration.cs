using FizzBuzzService.Enterprise;

public static class ServicesConfiguration
{
    public static void Configure(IServiceCollection builderServices)
    {
        builderServices.AddMediatR(
            cfg => cfg.RegisterServicesFromAssembly(typeof(FizzBuzzServiceImpl).Assembly));

        builderServices.AddScoped<FizzBuzzServiceImpl>();
    }
}