using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore;
using Castle.Facilities.Logging;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Thaco.Peugeot.Web.API.Startup
{
    public class Startup
    {
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            //...

            //Configure Abp and Dependency Injection. Should be called last.
            return services.AddAbp<PeugeotWebAPIModule>(options =>
            {
                //Configure Log4Net logging (optional)
                //options.IocManager.IocContainer.AddFacility<LoggingFacility>(
                //    f => f.UseLog4Net().WithConfig("log4net.config")
                //);
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            //Initializes ABP framework and all modules. Should be called first.
            app.UseAbp();

            //...
        }
    }
}
