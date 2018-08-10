using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Runtime.Session;
using System;
using System.Threading.Tasks;
using Thaco.Peugeot.Authorization.Roles;
using Thaco.Peugeot.Authorization.Users;
using Thaco.Peugeot.Appointment.Dto;

namespace Thaco.Peugeot.Appointment
{
    [AbpAuthorize()]
    public class AppointmentAppService :  AsyncCrudAppService<Thaco.Peugeot.Entities.Appointment,AppointmentDto,int, 
        PagedResultRequestDto, Thaco.Peugeot.Appointment.Dto.CreateAppointmentDto, AppointmentDto>
    {
        private readonly RoleManager _roleManager;
        private readonly UserManager _userManager;
        public AppointmentAppService(IRepository<Thaco.Peugeot.Entities.Appointment> repository, 
            RoleManager roleManager, UserManager userManager)
           : base(repository)
        {
            
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public override async Task<AppointmentDto> Update(AppointmentDto input)
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
        protected override void MapToEntity(AppointmentDto input, Thaco.Peugeot.Entities.Appointment appointment)
        {
            ObjectMapper.Map(input, appointment);
            //news.SetNormalizedNames();
        }
    }
}
