using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fanuc.Webmanagement.TaskPlan.Dto
{
    [AutoMapTo(typeof(SmartTask))]

    public class CreateSmartTaskDto
    {
        public string ProductID { get; set; }

        public string LineID { get; set; }

        public string TaskName { get; set; }

        public int Num { get; set; }

        public int Priority { get; set; }
    }
    [AutoMapTo(typeof(SmartTask))]

    public class UpdateSmartTaskDto : EntityDto<long>
    {
        public int Num { get; set; }

        public int Priority { get; set; }

    }

    [AutoMapTo(typeof(SmartTask))]

    public class FinishSmartTaskDto : EntityDto<long>
    {
        public int Status { get; set; }

        public DateTime? FinishTime { get; set; }
    }

    [AutoMapTo(typeof(SmartTask))]

    public class SmartTaskDto : EntityDto<long>
    {
        public string ProductID { get; set; }

        public string LineID { get; set; }

        public string TaskName { get; set; }

        public int Num { get; set; }

        public int Status { get; set; }

        public DateTime? FinishTime { get; set; }
        public int Priority { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
