using System;
using Datanalys.Server.Areas.Identity.Data;
using Datanalys.Server.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Datanalys.Server.Areas.Identity.IdentityHostingStartup))]
namespace Datanalys.Server.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            /*builder.ConfigureServices((context, services) => {
                services.AddDbContext<DatanalysContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DatanalysContextConnection")));

                services.AddDefaultIdentity<DatanalysUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<DatanalysContext>();
            });*/
        }
    }
}