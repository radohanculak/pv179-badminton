using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Sprint.BL.Configs;
using Sprint.BL.Dto.Role;
using Sprint.BL.Dto.User;
using Sprint.BL.Services.Identity;
using Sprint.DAL.EFCore.Data;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("SprintDatabase");
builder.Services.AddDbContext<SprintDbContext>(options => options.UseSqlite(connectionString));

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(options => options.RegisterModule(new AutofacBLConfig()));

builder.Services.AddRazorPages();
// Custom identity logic
ConfigureIdentityServices(builder.Services);

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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

static void ConfigureIdentityServices(IServiceCollection services)
{
    // Configuration of ASP.NET internals through DI
    services.AddOptions();

    // Identity & Auth
    services.AddIdentityCore<UserDto>(x =>
        {
            x.Password.RequiredLength = 4;
            x.Password.RequireNonAlphanumeric = false;
            x.Password.RequireUppercase = false;
            x.Password.RequireDigit = false;
            x.Password.RequireLowercase = false;
        })
        .AddDefaultTokenProviders()
        .AddClaimsPrincipalFactory<UserClaimsPrincipalFactory<UserDto, UserRoleDto>>();

    services.AddAuthentication(x =>
        {
            x.DefaultScheme = IdentityConstants.ApplicationScheme;
            x.DefaultSignInScheme = IdentityConstants.ApplicationScheme;
        })
        .AddIdentityCookies();

    services.ConfigureApplicationCookie(opt =>
    {
        opt.LoginPath = new PathString("/Identity/Login");
        opt.ExpireTimeSpan = TimeSpan.FromDays(14);
        opt.SlidingExpiration = true;
    });

    services.Configure<SecurityStampValidatorOptions>(options =>
    {
        options.ValidationInterval = TimeSpan.FromMinutes(5);
    });

    services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
    services.AddTransient<IUserStore<UserDto>, RepositoryUserStore>();
    services.AddTransient<ISecurityStampValidator, SecurityStampValidator<UserDto>>();
    services.AddTransient<UserManager<UserDto>, SiteUserManager>();
    services.AddTransient<IRoleStore<UserRoleDto>, RepositoryRoleStore>();
    services.AddTransient<RoleManager<UserRoleDto>>();
    services.AddTransient<SignInManager<UserDto>>();
    services.AddTransient<IPasswordHasher<UserDto>, PasswordChecker>();
}