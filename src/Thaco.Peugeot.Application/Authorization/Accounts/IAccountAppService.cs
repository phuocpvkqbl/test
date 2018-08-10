using System.Threading.Tasks;
using Abp.Application.Services;
using Thaco.Peugeot.Authorization.Accounts.Dto;

namespace Thaco.Peugeot.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
