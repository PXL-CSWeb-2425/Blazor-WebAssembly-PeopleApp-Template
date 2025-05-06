using Microsoft.EntityFrameworkCore;
using PeopleApp.Data;
using PeopleApp.Data.DefaultData;
using PeopleApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddServerSideBlazor();

var connString = builder.Configuration.GetConnectionString("PeopleConnection");
builder.Services.AddDbContext<DataContext>(opts =>
{
    opts.UseSqlServer(connString);
    opts.EnableSensitiveDataLogging(true);
});
builder.Services.AddScoped<IPersonRepository, PersonRepository>();
builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
builder.Services.AddScoped<ILocationRepository, LocationRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapDefaultControllerRoute();
app.MapControllers(); // enables attribute routing
app.MapBlazorHub();
app.MapFallbackToController("/manage/{*path:nonfile}", "Index", "Blazor");

//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapDefaultControllerRoute();
//    endpoints.MapControllers(); // enables attribute routing
//    endpoints.MapBlazorHub();
//    endpoints.MapFallbackToController("/manage/{*path:nonfile}", "Index", "Blazor");
//});
SeedData.SeedDatabase(app);
app.Run();
