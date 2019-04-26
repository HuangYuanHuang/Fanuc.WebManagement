using Abp.AutoMapper;
using Fanuc.Webmanagement.Authentication.External;

namespace Fanuc.Webmanagement.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
