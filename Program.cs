
using GraphQlCSharp;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGraphQLServer().AddQueryType<Query>();

var app = builder.Build();
app.UseRouting().UseEndpoints(options => options.MapGraphQL());

app.UseHttpsRedirection();
app.Run();

public record Author(String Name);
public record Book(String Title, Author Author);

