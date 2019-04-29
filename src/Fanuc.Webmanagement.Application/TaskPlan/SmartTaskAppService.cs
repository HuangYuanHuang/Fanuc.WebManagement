using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Events.Bus;
using Fanuc.Webmanagement.TaskPlan.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fanuc.Webmanagement.TaskPlan
{
    public class SmartTaskAppService : AsyncCrudAppService<SmartTask, SmartTaskDto, long, PagedResultRequestDto, CreateSmartTaskDto, UpdateSmartTaskDto>, ISmartTaskAppService
    {
        IRepository<SmartTask, long> repository;
        public IEventBus EventBus { get; set; }
        public SmartTaskAppService(IRepository<SmartTask, long> _repository) : base(_repository)
        {
            repository = _repository;
            EventBus = NullEventBus.Instance;
        }

        protected override IQueryable<SmartTask> ApplySorting(IQueryable<SmartTask> query, PagedResultRequestDto input)
        {
            return query.OrderByDescending(d => d.CreationTime);
        }

        public override async Task<SmartTaskDto> Create(CreateSmartTaskDto input)
        {
            var res = await base.Create(input);
            await EventBus.TriggerAsync(new SmartTaskEventData() { SmartTask = res, EventType = SmartTaskEventType.Create });
            return res;
        }
        public async Task<SmartTaskDto> FinishSmartTask(FinishSmartTaskDto finishSmart)
        {
            var entity = ObjectMapper.Map<SmartTask>(finishSmart);
            var res = await repository.UpdateAsync(entity);
            var dto = ObjectMapper.Map<SmartTaskDto>(res);
            await EventBus.TriggerAsync(new SmartTaskEventData() { SmartTask = dto, EventType = SmartTaskEventType.Finished });
            return dto;
        }
    }
}
