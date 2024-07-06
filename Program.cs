using Api_Web;

var builder = WebApplication.CreateBuilder();

var app = builder.Build();


//app.MapGet("/ApiCs/Test/{Name}", (string Name) => new Personne(1,Name,"Rasoa","ddfjklas;"));

app.MapPost("/ApiCs/Ajout", (Personne pers) => Results.Ok(pers));

app.Run();