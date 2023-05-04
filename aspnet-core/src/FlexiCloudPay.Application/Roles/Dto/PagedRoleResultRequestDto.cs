using Abp.Application.Services.Dto;

namespace FlexiCloudPay.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

