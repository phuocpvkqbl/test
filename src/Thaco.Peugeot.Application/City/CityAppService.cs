using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Runtime.Session;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Thaco.Peugeot.Authorization.Roles;
using Thaco.Peugeot.Authorization.Users;
using Thaco.Peugeot.City.Dto;
using Thaco.Peugeot.District.Dto;

namespace Thaco.Peugeot.City
{
    [AbpAuthorize()]
    public class CityAppService:  AsyncCrudAppService<Thaco.Peugeot.Entities.City,CityDto,int, 
        PagedResultRequestDto, CityDto,CityDto>
    {
        private readonly RoleManager _roleManager;
        private readonly UserManager _userManager;
        public CityAppService(IRepository<Thaco.Peugeot.Entities.City> repository, 
            RoleManager roleManager, UserManager userManager)
           : base(repository)
        {
            
            _roleManager = roleManager;
            _userManager = userManager;
        }
        protected override void MapToEntity(CityDto input, Thaco.Peugeot.Entities.City city)
        {
            ObjectMapper.Map(input, city);
            //news.SetNormalizedNames();
        }
    }
}
