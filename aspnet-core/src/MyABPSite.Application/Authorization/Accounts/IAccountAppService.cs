using System.Threading.Tasks;
using Abp.Application.Services;
using MyABPSite.Authorization.Accounts.Dto;

namespace MyABPSite.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
