using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Fanuc.Webmanagement.TaskPlan.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fanuc.Webmanagement.TaskPlan
{
    public interface ISmartTaskConfigAppService : IAsyncCrudAppService<SmartTaskConfigDto, string, PagedResultRequestDto, CreateSmartTaskConfigDto, UpdateSmartTaskConfig>
    {
        ListResultDto<SmartTaskConfigDto> GetProductTaskConfigs(string productID);
    }
}
