using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Dependency;
using Government.Services.Formalities.Dto;
using System.Threading.Tasks;

namespace Government.Services.Formalities
{
    public interface IFormalityAppService : IApplicationService, ITransientDependency
    {
        Task<PagedResultDto<FormalityDto>> GetAllAsync();
    }
}
