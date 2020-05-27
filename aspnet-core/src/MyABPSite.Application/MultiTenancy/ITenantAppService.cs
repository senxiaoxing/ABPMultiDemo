using Abp.Application.Services;
using MyABPSite.MultiTenancy.Dto;

namespace MyABPSite.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

