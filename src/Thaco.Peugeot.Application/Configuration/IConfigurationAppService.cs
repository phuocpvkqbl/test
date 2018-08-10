using System.Threading.Tasks;
using Thaco.Peugeot.Configuration.Dto;

namespace Thaco.Peugeot.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
