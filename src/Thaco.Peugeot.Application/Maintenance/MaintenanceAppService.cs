using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Runtime.Session;
using System;
using System.Threading.Tasks;
using Thaco.Peugeot.Authorization.Roles;
using Thaco.Peugeot.Authorization.Users;
using Thaco.Peugeot.Maintenance.Dto;

namespace Thaco.Peugeot.Maintenance
{
    [AbpAuthorize()]
    public class MaintenanceAppService :  AsyncCrudAppService<Thaco.Peugeot.Entities.Maintenance,MaintenanceDto,int, 
        PagedResultRequestDto, Thaco.Peugeot.Maintenance.Dto.CreateMaintenanceDto, MaintenanceDto>
    {
        private readonly RoleManager _roleManager;
        private readonly UserManager _userManager;
        public MaintenanceAppService(IRepository<Thaco.Peugeot.Entities.Maintenance> repository, 
            RoleManager roleManager, UserManager userManager)
           : base(repository)
        {
            
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public override async Task<MaintenanceDto> Update(MaintenanceDto input)
        {
            try
            {
                CheckUpdatePermission();

                var entity = await GetEntityByIdAsync(input.Id);
                
              MapToEntity(input, entity);
                await CurrentUnitOfWork.SaveChangesAsync();

                return MapToEntityDto(entity);
            }
            catch(Exception ex)
            {
                return null;
            }

        }
        protected override void MapToEntity(MaintenanceDto input, Thaco.Peugeot.Entities.Maintenance maintenance)
        {
            ObjectMapper.Map(input, maintenance);
            //news.SetNormalizedNames();
        }
    }
}
