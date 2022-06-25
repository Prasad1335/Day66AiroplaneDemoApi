using Day66WebSite.Models.Services;
using Day66WebSite.Models.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//builder.Services.AddScoped<IHolidayBookingService, HolidayBookingService>();
builder.Services.AddHttpClient<IHolidayBookingService, HolidayBookingService>();
builder.Services.AddHttpClient<IFlightService, FlightService>(client => client.BaseAddress = new Uri("https://localhost:7081/api"));
builder.Services.AddHttpClient<ILocationService, LocationService>();
builder.Services.AddHttpClient<IPlaneService, PlaneService>(client => client.BaseAddress = new Uri("https://localhost:7081/api"));

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
