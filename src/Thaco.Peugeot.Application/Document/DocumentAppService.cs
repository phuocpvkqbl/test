using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Runtime.Session;
using System;
using System.Threading.Tasks;
using Thaco.Peugeot.Authorization.Roles;
using Thaco.Peugeot.Authorization.Users;
using Thaco.Peugeot.Document.Dto;

namespace Thaco.Peugeot.Document
{
    [AbpAuthorize()]
    public class DocumentAppService :  AsyncCrudAppService<Thaco.Peugeot.Entities.Document,DocumentDto,int, 
        PagedResultRequestDto, Thaco.Peugeot.Document.Dto.CreateDocumentDto, DocumentDto>
    {
        private readonly RoleManager _roleManager;
        private readonly UserManager _userManager;
        public DocumentAppService(IRepository<Thaco.Peugeot.Entities.Document> repository, 
            RoleManager roleManager, UserManager userManager)
           : base(repository)
        {
            
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public override async Task<DocumentDto> Update(DocumentDto input)
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
        protected override void MapToEntity(DocumentDto input, Thaco.Peugeot.Entities.Document document)
        {
            ObjectMapper.Map(input, document);
            //news.SetNormalizedNames();
        }
    }
}
