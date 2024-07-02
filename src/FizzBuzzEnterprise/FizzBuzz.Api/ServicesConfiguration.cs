using FizzBuzzBusiness.Domain.Contracts;
using FizzBuzzService.Enterprise;

namespace WebApplication1;

public static class ServicesConfiguration
{
    public static void Configure(IServiceCollection builderServices)
    {
        builderServices.AddMediatR(
            cfg => cfg.RegisterServicesFromAssembly(typeof(FizzBuzzServiceContainer).Assembly));

        builderServices.AddScoped<IFizzBuzzServiceContainer, FizzBuzzServiceContainer>();

        builderServices.AddScoped<IFizzBuzzService, FizzBuzzBusiness.FizzBuzzService>();
    }
}