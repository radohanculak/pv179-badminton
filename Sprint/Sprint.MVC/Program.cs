using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Sprint.DAL.EFCore.Data;
using Sprint.BL.Configs;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<SprintDbContext>(context => context.UseSqlite(
    builder.Configuration.GetConnectionString("SprintDatabase")));
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterModule(new AutofacBLConfig()));

var app = builder.Build();
/*
// Add services to the container.

builder.Configuration.GetConnectionString("SprintDatabase");
builder.Services.AddDbContext<SprintDbContext>(context => context.UseSqlite(
    builder.Configuration.GetConnectionString("SprintDatabase")));
builder.Services.AddTransient<DbContext>(x => x.GetRequiredService<SprintDbContext>());
builder.Services.AddTransient<IUserFacade, UserFacade>();
builder.Services.AddTransient<IUnitOfWork, EFUnitOfWork>();
builder.Services.AddTransient<IMapper, >();
*/

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