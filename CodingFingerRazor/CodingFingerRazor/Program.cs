using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CodingFingerRazor.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<CodingFingerRazorContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CodingFingerRazorContext") ?? throw new InvalidOperationException("Connection string 'CodingFingerRazorContext' not found.")));

//builder.Services.AddScoped< DbInitializer, DbInitializer>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
//SeedDatabase();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
//void SeedDatabase() //can be placed at the very bottom under app.Run()
//{
  //  using (var scope = app.Services.CreateScope())
    //{
    //    var dbInitializer = scope.ServiceProvider.GetRequiredService<IDbInitializer>();
        //dbInitializer.Initialize();
    //}
//}