using System.Threading.Tasks;
using Abp.Application.Services;
using Government.Services.Authorization.Accounts.Dto;

namespace Government.Services.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

