using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Fanuc.Webmanagement.TaskPlan.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fanuc.Webmanagement.TaskPlan
{
    public interface ISmartTaskAppService : IAsyncCrudAppService<SmartTaskDto, long, PagedResultRequestDto, CreateSmartTaskDto, UpdateSmartTaskDto>
    {
        Task<SmartTaskDto> FinishSmartTask(FinishSmartTaskDto finishSmart);

    }

}
