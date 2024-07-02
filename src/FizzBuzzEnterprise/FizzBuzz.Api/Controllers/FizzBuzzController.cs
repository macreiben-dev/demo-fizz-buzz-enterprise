using FizzBuzzService.Enterprise.MediaTRSpecifics;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class FizzBuzzController : ControllerBase
{
    private readonly IMediator _mediator;

    public FizzBuzzController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet("{n}")]
    public ActionResult<string> Compute(int n)
    {
        var actual = _mediator.Send(new FizzBuzzRequest(n)).Result;

        return actual;
    }
}