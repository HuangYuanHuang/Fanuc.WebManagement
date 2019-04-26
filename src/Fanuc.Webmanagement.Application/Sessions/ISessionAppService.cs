using System.Threading.Tasks;
using Abp.Application.Services;
using Fanuc.Webmanagement.Sessions.Dto;

namespace Fanuc.Webmanagement.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
