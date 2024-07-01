using MediatR;

namespace FizzBuzzService.Enterprise.MediaTRSpecifics;

public class FizzBuzzRequestHandler : IRequestHandler<FizzBuzzRequest, string>
{
    private readonly FizzBuzzServiceImpl _fizzBuzzService;

    public FizzBuzzRequestHandler(FizzBuzzServiceImpl fizzBuzzService)
    {
        _fizzBuzzService = fizzBuzzService;
    }
    
    public Task<string> Handle(FizzBuzzRequest request, CancellationToken cancellationToken)
    {
       var actual = _fizzBuzzService.Compute(request.Original);

       return Task.FromResult(actual);
    }
}