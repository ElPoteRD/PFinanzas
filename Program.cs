using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
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
builder.Services.AddScoped<IIngresoServices, IngresoServices>();
builder.Services.AddScoped<IGastoServices, GastoServices>();
builder.Services.AddScoped<IPresupuestoServices, PresupuestoServices>();
builder.Services.AddScoped<ICategoriaDeIngresoServices, CategoriaDeIngresoServices>();
builder.Services.AddScoped<ICategoriaDeGastoServices, CategoriaDeGastoServices>();
builder.Services.AddScoped<ICategoriaDePresupuestoServices, CategoriaDePresupuestoServices>();


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

using (var serviceScope = app.Services.GetService<IServiceScopeFactory>()!.CreateScope())
{
    var dbContext = serviceScope.ServiceProvider.GetRequiredService<MyDbContext>();
    dbContext.Database.Migrate();
    await PFinanzasDbContextSeeder.Inicializar(dbContext);
}

app.Run();
