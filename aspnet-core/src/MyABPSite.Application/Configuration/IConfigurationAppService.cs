using System.Threading.Tasks;
using MyABPSite.Configuration.Dto;

namespace MyABPSite.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
