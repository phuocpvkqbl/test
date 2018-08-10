using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using System;
using System.Threading.Tasks;
using Thaco.Peugeot.Authorization.Roles;
using Thaco.Peugeot.Authorization.Users;
using Thaco.Peugeot.Notification.Dto;

namespace Thaco.Peugeot.Notification
{
    [AbpAuthorize()]
    public class NotificationAppService :  AsyncCrudAppService<Thaco.Peugeot.Entities.Notification,NotificationDto,int, 
        PagedResultRequestDto, Thaco.Peugeot.Notification.Dto.CreateNotificationDto,NotificationDto>
    {
        private readonly RoleManager _roleManager;
        private readonly UserManager _userManager;
        public NotificationAppService(IRepository<Thaco.Peugeot.Entities.Notification> repository, 
            RoleManager roleManager, UserManager userManager)
           : base(repository)
        {
            
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public override async Task<NotificationDto> Update(NotificationDto input)
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
        protected override void MapToEntity(NotificationDto input, Thaco.Peugeot.Entities.Notification notification)
        {
            ObjectMapper.Map(input, notification);
            //news.SetNormalizedNames();
        }
    }
}
