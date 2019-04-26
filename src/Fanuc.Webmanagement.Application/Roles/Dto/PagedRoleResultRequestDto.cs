using Abp.Application.Services.Dto;

namespace Fanuc.Webmanagement.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

