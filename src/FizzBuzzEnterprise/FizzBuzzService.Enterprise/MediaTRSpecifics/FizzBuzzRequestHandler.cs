using MediatR;

namespace FizzBuzzService.Enterprise.MediaTRSpecifics;

public class FizzBuzzRequestHandler : IRequestHandler<FizzBuzzRequest, string>
{
    private readonly IFizzBuzzServiceImpl _fizzBuzzService;

    public FizzBuzzRequestHandler(IFizzBuzzServiceImpl fizzBuzzService)
    {
        _fizzBuzzService = fizzBuzzService;
    }
    
    public Task<string> Handle(FizzBuzzRequest request, CancellationToken cancellationToken)
    {
       var actual = _fizzBuzzService.Compute(request.Original);

       return Task.FromResult(actual);
    }
}