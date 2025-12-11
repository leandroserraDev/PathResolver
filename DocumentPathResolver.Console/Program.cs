// See https://aka.ms/new-console-template for more information

using DocumentPathResolver.Entities;
using DocumentPathResolver.Resolver.Engine;
using DocumentPathResolver.Resolver.Engine.Person;
using DocumentPathResolver.Resolver.Provider;
using DocumentPathResolver.Resolver.Provider.Person;
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


services.AddScoped<IPathDecisionEngine<Person>, PersonPathDecisionEngine>();


services.AddScoped<IPathSegmentProvider<Person>, NameSegmentProvider>();
services.AddScoped<IPathSegmentProvider<Person>, LastNameSegmentProvider>();
services.AddScoped<IPathSegmentProvider<Person>, AgeSegmentProvider>();
services.AddScoped<IPathSegmentProvider<Person>, DocumentSegmentProvider>();


services.AddScoped<INameSpecification,  NameSpecification>();
services.AddScoped<ILastNameSpecification,  LastNameSpecification>();
services.AddScoped<IAgeSpecification,  AgeSpecification>();
services.AddScoped<IDocumentSpecification,  DocumentSpecification>();





// construir o ServiceProvider
var provider = services.BuildServiceProvider();


var person = new Person("Leandro", "Serra", 18, "12345678");

var pathBuilder = provider.GetRequiredService<IFilePathOrchestrator<Person>>();

var result = pathBuilder.BuildFilePath(person);


Console.WriteLine(result);


