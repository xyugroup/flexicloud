using Abp.AutoMapper;
using FlexiCloudPay.Authentication.External;

namespace FlexiCloudPay.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
