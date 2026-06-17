var builder = WebApplication.CreateBuilder(args);

//All services register here
builder.Services.AddMvc();

var app = builder.Build();

//app.Use((context, next) =>
//{
//    context.Response.WriteAsync("This is Use1 middleware and now call the next middleware.\n");
//    return next();
//});

//app.Use((context, next) =>
//{
//    context.Response.WriteAsync("This is Use2 middleware and now call the next middleware.\n");
//    return next();
//});

//app.Run((context) => context.Response.WriteAsync("it is terminates the pipline means run middleware"));

//app.MapGet("/", () => "Hello World!");

//app.MapGet("/first", () => "Hello World first!");
//app.MapGet("/second", () => "Hello World second!");
//app.MapGet("/third", () => "Hello World third!");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
