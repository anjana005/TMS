using Microsoft.EntityFrameworkCore;
using TMS.Components;
using TMS.Data.Context;
using TMS.Service;
using TMS.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<TaskDataService>();


//Connection to the DB
builder.Services.AddDbContext<ApplicationDbContext> (item => item.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection")));

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
