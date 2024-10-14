using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Government.Services.Authorization.Permissions;
using Government.Services.Formalities.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Government.Services.Formalities
{
    /// <summary>
    /// Application service for managing Formality entities.
    /// </summary>
    [AbpAuthorize(PermissionNames.Pages_Formalities)]
    public class FormalityAppService : ApplicationService, IFormalityAppService
    {
        private readonly IRepository<Formality> _repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="FormalityAppService"/> class.
        /// </summary>
        public FormalityAppService(IRepository<Formality> repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Retrieves all Formality entities asynchronously.
        /// </summary>
        public async Task<PagedResultDto<FormalityDto>> GetAllAsync()
        {
            var formalities = (await _repository.GetAllAsync()).ToList();
            return new(formalities.Count, ObjectMapper.Map<List<FormalityDto>>(formalities));
        }
    }
}
