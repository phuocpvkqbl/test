using Abp.AutoMapper;
using Thaco.Peugeot.Authentication.External;

namespace Thaco.Peugeot.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
