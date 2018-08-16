using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using Thaco.Peugeot.Authorization.Roles;
using Thaco.Peugeot.Authorization.Users;
using Thaco.Peugeot.District.Dto;
using Thaco.Peugeot.Irepo;

namespace Thaco.Peugeot.District
{
    [AbpAuthorize()]
    public class DistrictAppService :  AsyncCrudAppService<Thaco.Peugeot.Entities.District,DistrictDto,int, 
        PagedResultRequestDto, DistrictDto,DistrictDto>
    {
        private readonly IDistrictRepository _districtRepository;
        private readonly RoleManager _roleManager;
        private readonly UserManager _userManager;
        public DistrictAppService(IDistrictRepository repository, 
            RoleManager roleManager, UserManager userManager)
           : base(repository)
        {
            _districtRepository = repository;
            _roleManager = roleManager;
            _userManager = userManager;
        }
        protected override void MapToEntity(DistrictDto input, Thaco.Peugeot.Entities.District district)
        {
            ObjectMapper.Map(input, district);
            //news.SetNormalizedNames();
        }
        public Task<ListResultDto<DistrictDto>> GetAllDistrictsWithCity(int? cityId)
        {
            var districts = _districtRepository.GetAllWithCity(cityId);
            return Task.FromResult(new ListResultDto<DistrictDto>(ObjectMapper.Map<List<DistrictDto>>(districts)) 
            ); 
        }
        public Task<ListResultDto<DistrictDto>> GetAllDistrictsWithCity()
        {
            int? cityId = 124;
            var districts = _districtRepository.GetAllWithCity(cityId);
            return Task.FromResult(new ListResultDto<DistrictDto>(ObjectMapper.Map<List<DistrictDto>>(districts))
            );
        }
    }
}
