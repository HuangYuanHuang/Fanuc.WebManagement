using System.Threading.Tasks;
using Abp.Application.Services;
using Fanuc.Webmanagement.Authorization.Accounts.Dto;

namespace Fanuc.Webmanagement.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
