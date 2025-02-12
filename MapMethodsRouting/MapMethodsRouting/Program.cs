var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/Home", async (context) =>
    {
        await context.Response.WriteAsync("Home page ........GET.............");
    });
    endpoints.MapPost("/Home", async (context) =>
    {
        await context.Response.WriteAsync("Home page ........POST.............");
    });
    endpoints.MapPut("/Home", async (context) =>
    {
        await context.Response.WriteAsync("Home page ........PUT.............");
    });
    endpoints.MapDelete("/Home", async (context) =>
    {
        await context.Response.WriteAsync("Home page ..........DELETE...........");
    });
});

//app.MapGet("/Home", () => "Hello World! - GET"); 
//app.MapPost("/Home", () => "Hello World! - POST"); 
//app.MapPut("/Home", () => "Hello World! - PUT"); 
//app.MapDelete("/Home", () => "Hello World! - DELETE"); 

//app.Map("/Home", () => "Hello World!"); 

app.Run(async (HttpContext context)=>
{
    await context.Response.WriteAsync("Page not Found");
});
app.Run();