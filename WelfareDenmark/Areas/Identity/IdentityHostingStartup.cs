using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WelfareDenmark.Areas.Identity.Data;
using WelfareDenmark.Models;

[assembly: HostingStartup(typeof(WelfareDenmark.Areas.Identity.IdentityHostingStartup))]
namespace WelfareDenmark.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<WelfareDenmarkContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("WelfareDenmarkContextConnection")));

                services.AddDefaultIdentity<WelfareDenmarkUser>()
                    .AddEntityFrameworkStores<WelfareDenmarkContext>();
            });
        }
    }
}