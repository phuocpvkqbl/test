using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Thaco.Peugeot.Authorization;

namespace Thaco.Peugeot
{
    [DependsOn(
        typeof(PeugeotCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class PeugeotApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<PeugeotAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(PeugeotApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
