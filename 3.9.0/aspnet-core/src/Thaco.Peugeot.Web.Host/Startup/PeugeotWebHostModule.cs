using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Thaco.Peugeot.Configuration;

namespace Thaco.Peugeot.Web.Host.Startup
{
    [DependsOn(
       typeof(PeugeotWebCoreModule))]
    public class PeugeotWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PeugeotWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PeugeotWebHostModule).GetAssembly());
        }
    }
}
