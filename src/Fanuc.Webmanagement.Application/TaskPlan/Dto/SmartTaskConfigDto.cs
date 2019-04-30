using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fanuc.Webmanagement.TaskPlan.Dto
{
    [AutoMapTo(typeof(SmartTaskConfig))]

    public class SmartTaskConfigDto : EntityDto<string>
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string TaskName { get; set; }

        public string TaskTag { get; set; }

        public string CMD { get; set; }

        public string Parms { get; set; }
        public string Type { get; set; }
        public DateTime CreationTime { get; set; }
    }

    [AutoMapTo(typeof(SmartTaskConfig))]
    public class CreateSmartTaskConfigDto
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string TaskName { get; set; }

        public string TaskTag { get; set; }

        public string CMD { get; set; }

        public string Parms { get; set; }
    }


    [AutoMapTo(typeof(SmartTaskConfig))]
    public class UpdateSmartTaskConfig : EntityDto<string>
    {

        public string TaskTag { get; set; }

        public string CMD { get; set; }

        public string Parms { get; set; }
    }
}
