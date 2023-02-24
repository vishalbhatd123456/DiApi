using DIApi.Data;
using DIAPI.Data;

var builder = WebApplication.CreateBuilder(args);

//dependencies we are building on
//registering the services
//whenever anyone asks for IDataRepo, we are going to return the SqlDataRepo
builder.Services.AddScoped<IDataRepo, SqlDataRepo>();
builder.Services.AddScoped<IDataRepo, NoSqlDataRepo>();
//if we have the services that are mapped to rwo different Classes, the latest service will be registered!

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/getdata", (IDataRepo repo) =>
{
    //var repo = new SqlDataRepo();
    //var repo = new NoSqlDataRepo();
    repo.ReturnData();
    return Results.Ok();
});

app.Run();

