using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Runtime.Session;
using System;
using System.Threading.Tasks;
using Thaco.Peugeot.Authorization.Roles;
using Thaco.Peugeot.Authorization.Users;
using Thaco.Peugeot.Review.Dto;

namespace Thaco.Peugeot.Review
{
    [AbpAuthorize()]
    public class ReviewAppService :  AsyncCrudAppService<Thaco.Peugeot.Entities.Review,ReviewDto,int, 
        PagedResultRequestDto, Thaco.Peugeot.Review.Dto.CreateReviewDto,ReviewDto>
    {
        private readonly RoleManager _roleManager;
        private readonly UserManager _userManager;
        public ReviewAppService(IRepository<Thaco.Peugeot.Entities.Review> repository, 
            RoleManager roleManager, UserManager userManager)
           : base(repository)
        {
            
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public override async Task<ReviewDto> Update(ReviewDto input)
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
        protected override void MapToEntity(ReviewDto input, Thaco.Peugeot.Entities.Review review)
        {
            ObjectMapper.Map(input, review);
            //news.SetNormalizedNames();
        }
    }
}
