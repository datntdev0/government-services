using System.Threading.Tasks;
using Abp.Application.Services;
using Government.Services.Sessions.Dto;

namespace Government.Services.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

