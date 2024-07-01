using FizzBuzzService.Enterprise.MediaTRSpecifics;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class FizzBuzzController
{
    private readonly IMediator _mediator;

    public FizzBuzzController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet]
    [Route("compute/{n}")]
    public string Get(int n)
    {
        var actual = _mediator.Send(new FizzBuzzRequest(n)).Result;

        return actual;
    }
}