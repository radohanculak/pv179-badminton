using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sprint.BL.Facades;
using Sprint.DAL.EFCore.Data;
using Sprint.Infrastructure.EFCore.UnitOfWork;
using Sprint.Infrastructure.Repository;
using Sprint.Infrastructure.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<SprintDbContext>(builder => builder.UseSqlite("Data Source=/home/rado/School/pv179-badminton/Sprint/Sprint.DAL/sprint.db;Cache=Shared"));
builder.Services.AddTransient<DbContext>(x => x.GetRequiredService<SprintDbContext>());
builder.Services.AddTransient<IUserFacade, UserFacade>();
builder.Services.AddTransient<IUnitOfWork, EFUnitOfWork>();
builder.Services.AddTransient<IMapper, >();

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