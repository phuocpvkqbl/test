using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Runtime.Session;
using System;
using System.Threading.Tasks;
using Thaco.Peugeot.Authorization.Roles;
using Thaco.Peugeot.Authorization.Users;
using Thaco.Peugeot.Ward.Dto;

namespace Thaco.Peugeot.Ward
{
    [AbpAuthorize()]
    public class WardAppService:  AsyncCrudAppService<Thaco.Peugeot.Entities.Ward,WardDto,int, 
        PagedResultRequestDto, WardDto,WardDto>
    {
        private readonly RoleManager _roleManager;
        private readonly UserManager _userManager;
        public WardAppService(IRepository<Thaco.Peugeot.Entities.Ward> repository, 
            RoleManager roleManager, UserManager userManager)
           : base(repository)
        {
            
            _roleManager = roleManager;
            _userManager = userManager;
        }
        protected override void MapToEntity(WardDto input, Thaco.Peugeot.Entities.Ward ward)
        {
            ObjectMapper.Map(input, ward);
            //news.SetNormalizedNames();
        }
    }
}
