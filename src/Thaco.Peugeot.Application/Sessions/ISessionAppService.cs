using System.Threading.Tasks;
using Abp.Application.Services;
using Thaco.Peugeot.Sessions.Dto;

namespace Thaco.Peugeot.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
