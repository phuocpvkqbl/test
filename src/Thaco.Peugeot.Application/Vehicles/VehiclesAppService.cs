using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using System;
using System.Threading.Tasks;
using Thaco.Peugeot.Authorization.Roles;
using Thaco.Peugeot.Authorization.Users;
using Thaco.Peugeot.Vehicles.Dto;

namespace Thaco.Peugeot.Vehicles
{
    [AbpAuthorize()]
    public class VehiclesAppService:  AsyncCrudAppService<Thaco.Peugeot.Entities.Vehicle,VehiclesDto,int, 
        PagedResultRequestDto, Thaco.Peugeot.Vehicles.Dto.CreateVehiclesDto,VehiclesDto>
    {
        private readonly RoleManager _roleManager;
        private readonly UserManager _userManager;
        public VehiclesAppService(IRepository<Thaco.Peugeot.Entities.Vehicle> repository, 
            RoleManager roleManager, UserManager userManager)
           : base(repository)
        {
            
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public override async Task<VehiclesDto> Update(VehiclesDto input)
        {
            try
            {
                CheckUpdatePermission();

                var entity = await GetEntityByIdAsync(input.Id);
                
              // MapToEntity(input, entity);
                await CurrentUnitOfWork.SaveChangesAsync();

                return MapToEntityDto(entity);
            }
            catch(Exception ex)
            {
                return null;
            }

        }
        protected override void MapToEntity(VehiclesDto input, Thaco.Peugeot.Entities.Vehicle vehicle)
        {
            ObjectMapper.Map(input, vehicle);
            //news.SetNormalizedNames();
        }
    }
}
