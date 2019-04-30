using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Fanuc.Webmanagement.TaskPlan.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fanuc.Webmanagement.TaskPlan
{
    public class SmartTaskConfigAppService : AsyncCrudAppService<SmartTaskConfig, SmartTaskConfigDto, string, PagedResultRequestDto, CreateSmartTaskConfigDto, UpdateSmartTaskConfig>, ISmartTaskConfigAppService
    {
        IRepository<SmartTaskConfig, string> repository;
        public SmartTaskConfigAppService(IRepository<SmartTaskConfig, string> _repository) : base(_repository)
        {
            repository = _repository;
        }

        public ListResultDto<SmartTaskConfigDto> GetProductTaskConfigs(string productID)
        {
            var list = repository.GetAllIncluding().Where(d => d.ProductID==productID);
            return new ListResultDto<SmartTaskConfigDto>(ObjectMapper.Map<List<SmartTaskConfigDto>>(list.ToList()));
        }

        protected override IQueryable<SmartTaskConfig> ApplySorting(IQueryable<SmartTaskConfig> query, PagedResultRequestDto input)
        {
            return query.OrderByDescending(d => d.CreationTime);
        }
    }
}
