using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Runtime.Session;
using System;
using System.Threading.Tasks;
using Thaco.Peugeot.Authorization.Roles;
using Thaco.Peugeot.Authorization.Users;
using Thaco.Peugeot.Company.Dto;

namespace Thaco.Peugeot.Company
{
    [AbpAuthorize()]
    public class CompanyAppService :  AsyncCrudAppService<Thaco.Peugeot.Entities.Company,CompanyDto,int, 
        PagedResultRequestDto, Thaco.Peugeot.Company.Dto.CreateCompanyDto, CompanyDto>
    {
        private readonly RoleManager _roleManager;
        private readonly UserManager _userManager;
        public CompanyAppService(IRepository<Thaco.Peugeot.Entities.Company> repository, 
            RoleManager roleManager, UserManager userManager)
           : base(repository)
        {
            
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public override async Task<CompanyDto> Update(CompanyDto input)
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
        protected override void MapToEntity(CompanyDto input, Thaco.Peugeot.Entities.Company company)
        {
            ObjectMapper.Map(input, company);
            //news.SetNormalizedNames();
        }
    }
}
