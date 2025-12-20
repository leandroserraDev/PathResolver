// See https://aka.ms/new-console-template for more information

using DocumentPathResolver.Entities;
using DocumentPathResolver.Resolver.Engine;
using DocumentPathResolver.Resolver.Engine.Person;
using DocumentPathResolver.Resolver.Provider;
using DocumentPathResolver.Resolver.Provider.Person;
using DocumentPathResolver.Resolver.Specification;
using DocumentPathResolver.Resolver.Specification.Age;
using DocumentPathResolver.Resolver.Specification.Document;
using DocumentPathResolver.Resolver.Specification.LastName;
using DocumentPathResolver.Resolver.Specification.Name;
using Microsoft.Extensions.DependencyInjection;


// See https://aka.ms/new-console-template for more information

var services = new ServiceCollection();


services.AddScoped(typeof(IPathBuilder<>), typeof(PathBuilder<>));
services.AddScoped(typeof(IFilePathOrchestrator<>), typeof(FilePathOrchestrator<>));
services.AddScoped(typeof(IPathDecisionEngine<>), typeof(PathDecisionEngine<>));

services.AddScoped<IAgeSpecification, AgeSpecification>();
services.AddScoped<INameSpecification, NameSpecification>();
services.AddScoped<IAgeSegmentProvider, AgeSegmentProvider>();
services.AddScoped<INameSegmentProvider, NameSegmentProvider>();

services.AddScoped<IPathRules<Person>>(sp =>
    new NamePathRules(
        sp.GetRequiredService<INameSegmentProvider>(),
        sp.GetRequiredService<INameSpecification>()
        ));

services.AddScoped<IPathRules<Person>>(sp =>
    new AgePathRules(
        sp.GetRequiredService<IAgeSpecification>(),
        sp.GetRequiredService<IAgeSegmentProvider>()));


// construir o ServiceProvider
var provider = services.BuildServiceProvider();



var pathBuilder = provider.GetRequiredService<IFilePathOrchestrator<Person>>();



var person = new Person("Leandro", "Serra", 18, "12345678");
var result = pathBuilder.BuildFilePath(person);


Console.WriteLine(result);


