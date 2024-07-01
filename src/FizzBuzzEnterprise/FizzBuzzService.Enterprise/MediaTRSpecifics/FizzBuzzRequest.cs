using MediatR;

namespace FizzBuzzService.Enterprise.MediaTRSpecifics;

public class FizzBuzzRequest : IRequest<string>
{
    public FizzBuzzRequest(int original)
    {
        Original = original;
    }
    
    public int Original { get;  }    
}