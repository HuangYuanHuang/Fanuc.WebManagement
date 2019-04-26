using System.Threading.Tasks;
using Fanuc.Webmanagement.Configuration.Dto;

namespace Fanuc.Webmanagement.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
