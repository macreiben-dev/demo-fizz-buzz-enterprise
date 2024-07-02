# Demo FizzBuzz Enterprise with MediatR

This project is a bit of a troll to show how much is generated due to structural complexity.

The Domain is the actual business domain model using a procedural style - FizzBuzz is not that complicated.

Under Enterprise, you'll find all the "glue work" added by the framework MediatR framework.

Api is ... the API.

## More fun facts

### MediatR and the hiding of dependencies

One really interesting thing using this framework is that you inject always the same component - IMediator - at controller level.

No more multiple constructor in the controller then.

The trick is, you instanciate request - aka events - that you pass to the MediatR. 

#### Hiding code smell with structural complexity

This way, by breaking Dependency inversion principle in the process, one cannot see the controller dependency. You have to look for what handler handles what request.

... and we can happily have a monolithic controller that does everything because we cannot see what the actual dependency are. So we do not have any reason to split code anymore :P - there is just one dependency ! FREEDOM !

That is what the mediator design pattern does. It regroups the communication complexity in one place. 

But it was no supposed to hide "too many dependency code smell" aswell.

#### IoC as orchestrator  

Anyway, it's really beautiful. It's all declarative with the magic line:

```Csharp
uilderServices.AddMediatR(
    cfg => cfg.RegisterServicesFromAssembly(typeof(FizzBuzzServiceContainer).Assembly));
```

The request-requestHandler is created by analyzing inheritancy structure. Oh yeah ... .
