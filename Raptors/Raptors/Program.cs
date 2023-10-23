var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();


//app.MapGet("/", () => "Hello Sunaina!");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=SimpleBinding}/{id?}");

app.UseRouting();

app.Run();
