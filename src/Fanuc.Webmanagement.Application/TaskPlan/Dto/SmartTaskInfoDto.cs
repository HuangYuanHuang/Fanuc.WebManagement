using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fanuc.Webmanagement.TaskPlan.Dto
{
    [AutoMapTo(typeof(SmartTaskInfo))]

    public class SmartTaskInfoDto : EntityDto<long>
    {
        public int TaskID { get; set; }

        public string TaskName { get; set; }

        public int Priority { get; set; }

        public bool IsSuccess { get; set; }
        public DateTime? FinishTime { get; set; }
        public DateTime CreationTime { get; set; }
    }
    [AutoMapTo(typeof(SmartTaskInfo))]

    public class CreateTaskInfoDto
    {
        public int TaskID { get; set; }

        public string TaskName { get; set; }

        public int Priority { get; set; }

    

    }
    [AutoMapTo(typeof(SmartTaskInfo))]

    public class UpdateTaskInfoDto : EntityDto<long>
    {
        public bool IsSuccess { get; set; }
        public DateTime? FinishTime { get; set; }
    }
}
