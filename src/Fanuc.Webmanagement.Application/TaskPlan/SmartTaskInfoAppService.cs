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
    public class SmartTaskInfoAppService : AsyncCrudAppService<SmartTaskInfo, SmartTaskInfoDto, long, PagedResultRequestDto, CreateTaskInfoDto, UpdateTaskInfoDto>, ISmartTaskInfoAppService
    {
        public SmartTaskInfoAppService(IRepository<SmartTaskInfo, long> _repository) : base(_repository)
        {

        }

        protected override IQueryable<SmartTaskInfo> ApplySorting(IQueryable<SmartTaskInfo> query, PagedResultRequestDto input)
        {
            return query.OrderByDescending(d => d.TaskID).ThenByDescending(d => d.CreationTime);
        }
    }
}
