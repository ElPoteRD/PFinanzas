using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using PFinanzas.Data;
using PFinanzas.Data.Context;
using PFinanzas.Data.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddDbContext<MyDbContext>();
builder.Services.AddScoped<IMyDbContext, MyDbContext>();
builder.Services.AddScoped<IUsuarioServices, UsuarioServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
