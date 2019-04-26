using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Fanuc.Webmanagement.MultiTenancy.Dto;

namespace Fanuc.Webmanagement.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

