using LiveWeather.Models;
using LiveWeather.Components;
using LiveWeather.Services;
using Microsoft.Extensions.Options;
using LiveWeather.DatabaseController;
using LiveWeather.Singletons;
using MudBlazor.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Supabase;

var builder = WebApplication.CreateBuilder(args);

var supabaseUrl = "https://ppxzcuaxiedaojbyhgud.supabase.co";
var supabaseKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InBweHpjdWF4aWVkYW9qYnloZ3VkIiwicm9sZSI6ImFub24iLCJpYXQiOjE3MzAxNzc1OTAsImV4cCI6MjA0NTc1MzU5MH0.UbsUXQ30OBvh5bytRdbQWWRrVlr7mpCneQq8z64snOw";

var options = new SupabaseOptions { AutoConnectRealtime = true };
var supabaseClient = new Supabase.Client(supabaseUrl, supabaseKey, options);
builder.Services.AddSingleton(supabaseClient);
builder.Services.AddScoped<IAuthService, SupabaseAuthService>();
// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddScoped<DatabaseController>();
builder.Services.AddMudServices();
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();


builder.Services.Configure<WeatherApiOptions>(builder.Configuration.GetSection("WeatherApi"));
builder.Services.AddHttpClient<WeatherService>((sp, client) =>
{
    var options = sp.GetRequiredService<IOptions<WeatherApiOptions>>().Value;
    client.BaseAddress = new Uri(options.BaseUrl);
});
builder.Services.AddSingleton<UserStateManager>();

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
app.MapGet("/", () => Results.Redirect("/welcome"));

app.Run();
