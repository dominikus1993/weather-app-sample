using WeatherApp.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.MapGet("/weather", () =>
{
    return Results.Ok(new WeatherForecast()
    {
        TemperatureC = 21,
        Date = new WeatherDate()
        {
            Date = DateOnly.FromDateTime(DateTime.Now),
            DayOfWeek = DateTime.Now.DayOfWeek.ToString()
        },
        Summary = "Ok"
    });
});

app.Run();
