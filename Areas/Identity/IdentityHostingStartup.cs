using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApplication4.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

[assembly: HostingStartup(typeof(WebApplication4.Areas.Identity.IdentityHostingStartup))]
namespace WebApplication4.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                var connectionString = context.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
                services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(connectionString));
                
                // Remove or comment out the following lines to avoid duplication
                // services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                //     .AddEntityFrameworkStores<ApplicationDbContext>()
                //     .AddDefaultUI();
            });
        }
    }
}