using MediatR;

namespace FizzBuzzService.Enterprise.MediaTRSpecifics;

public class FizzBuzzRequestHandler : IRequestHandler<FizzBuzzRequest, string>
{
    private readonly IFizzBuzzServiceContainer _fizzBuzzService;

    public FizzBuzzRequestHandler(IFizzBuzzServiceContainer fizzBuzzService)
    {
        _fizzBuzzService = fizzBuzzService;
    }
    
    public Task<string> Handle(FizzBuzzRequest request, CancellationToken cancellationToken)
    {
       var actual = _fizzBuzzService.Compute(request);

       return Task.FromResult(actual);
    }
}