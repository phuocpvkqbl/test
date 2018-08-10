using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Runtime.Session;
using System;
using System.Threading.Tasks;
using Thaco.Peugeot.Authorization.Roles;
using Thaco.Peugeot.Authorization.Users;
using Thaco.Peugeot.News.Dto;

namespace Thaco.Peugeot.News
{
    [AbpAuthorize()]
    public class NewsAppService:  AsyncCrudAppService<Thaco.Peugeot.Entities.News,NewsDto,int, 
        PagedResultRequestDto, Thaco.Peugeot.News.Dto.CreateNewsDto,NewsDto>
    {
        private readonly RoleManager _roleManager;
        private readonly UserManager _userManager;
        public NewsAppService(IRepository<Thaco.Peugeot.Entities.News> repository, 
            RoleManager roleManager, UserManager userManager)
           : base(repository)
        {
            
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public override async Task<NewsDto> Update(NewsDto input)
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
        protected override void MapToEntity(NewsDto input, Thaco.Peugeot.Entities.News news)
        {
            ObjectMapper.Map(input, news);
            //news.SetNormalizedNames();
        }
    }
}
