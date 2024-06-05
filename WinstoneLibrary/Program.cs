using Data;
using Microsoft.AspNetCore.Connections;
using Microsoft.EntityFrameworkCore;
using WinstoneLibrary.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// connection configuration
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
if(string.IsNullOrEmpty(connectionString)){
    throw new Exception("Connection String is unvalid");
}
builder.Services.AddDbContext<ApplicationDatabaseContext>(
    options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)
    ));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
