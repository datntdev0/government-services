using Abp.Application.Services;
using Government.Services.MultiTenancy.Dto;

namespace Government.Services.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}


