using System.Threading.Tasks;
using Abp.Application.Services;
using MyABPSite.Sessions.Dto;

namespace MyABPSite.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
