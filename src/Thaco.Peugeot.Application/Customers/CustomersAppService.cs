using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Runtime.Session;
using System;
using System.Threading.Tasks;
using Thaco.Peugeot.Authorization.Roles;
using Thaco.Peugeot.Authorization.Users;
using Thaco.Peugeot.Customers.Dto;
using Thaco.Peugeot.News.Dto;

namespace Thaco.Peugeot.Customers
{
    [AbpAuthorize()]
    public class CustomerAppService:  AsyncCrudAppService<Thaco.Peugeot.Entities.Customer,CustomerDto,int, 
        PagedResultRequestDto, Thaco.Peugeot.Customers.Dto.CreateCustomersDto,CustomerDto>
    {
        private readonly RoleManager _roleManager;
        private readonly UserManager _userManager;
        public CustomerAppService(IRepository<Thaco.Peugeot.Entities.Customer> repository, 
            RoleManager roleManager, UserManager userManager)
           : base(repository)
        {
            
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public override async Task<CustomerDto> Update(CustomerDto input)
        {
            try
            {
                CheckUpdatePermission();

                var entity = await GetEntityByIdAsync(input.Id);

                MapToEntity(input, entity);
                await CurrentUnitOfWork.SaveChangesAsync();

                return MapToEntityDto(entity);
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        protected override void MapToEntity(CustomerDto input, Thaco.Peugeot.Entities.Customer entity)
        {
            entity.FirstName = input.FirstName;
            entity.LastName = input.LastName;
            entity.Email = input.Email;
            entity.MobileNumber = input.MobileNumber;
            entity.Address = input.Address;
            entity.Birthday = input.Birthday;
            entity.Website = input.Website;
            entity.TaxCode = input.TaxCode;
          
        }
    }
}
