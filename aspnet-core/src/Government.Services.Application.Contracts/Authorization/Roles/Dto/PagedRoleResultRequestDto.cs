using Abp.Application.Services.Dto;

namespace Government.Services.Authorization.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}


