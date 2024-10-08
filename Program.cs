using LiveWeather.Models;
using LiveWeather.Components;
using LiveWeather.Services;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.Configure<WeatherApiOptions>(builder.Configuration.GetSection("WeatherApi"));
builder.Services.AddHttpClient<WeatherService>((sp, client) =>
{
    var options = sp.GetRequiredService<IOptions<WeatherApiOptions>>().Value;
    client.BaseAddress = new Uri(options.BaseUrl);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

// Map components and set default routing
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Set up routing for the welcome page
app.MapGet("/", (NavigationManager navigationManager) =>
{
    navigationManager.NavigateTo("/welcome");
});

app.Run();
