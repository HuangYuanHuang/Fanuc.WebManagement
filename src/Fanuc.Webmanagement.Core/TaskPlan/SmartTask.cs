using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.EntityFramework;
namespace Fanuc.Webmanagement.TaskPlan
{
    [Table("Smart_Task")]
    public class SmartTask : Entity<long>, IHasCreationTime
    {

        public string ProductID { get; set; }

        public string LineID { get; set; }

        public string TaskName { get; set; }

        public int Num { get; set; }

        public int Status { get; set; }

        public DateTime? FinishTime { get; set; }
        public int Priority { get; set; }
        public DateTime CreationTime { get; set; }
        public SmartTask()
        {
            CreationTime = DateTime.Now;
        }
    }

    [Table("Smart_TaskInfo")]

    public class SmartTaskInfo : Entity<long>, IHasCreationTime
    {
        public int TaskID { get; set; }

        public string TaskName { get; set; }

        public int Priority { get; set; }

        public bool IsSuccess { get; set; }
        public DateTime? FinishTime { get; set; }
        public DateTime CreationTime { get; set; }
        public SmartTaskInfo()
        {
            CreationTime = DateTime.Now;
        }
    }

    [Table("Smart_TaskConfig")]

    public class SmartTaskConfig : Entity<string>, IHasCreationTime
    {
        public string ProductID { get; set; }

        public string ProductName { get; set; }
        public string TaskName { get; set; }

        public string TaskTag { get; set; }


        public string CMD { get; set; }

        public string Parms { get; set; }

        public string Type { get; set; }
        public DateTime CreationTime { get; set; }
        public SmartTaskConfig()
        {
            CreationTime = DateTime.Now;
            Type = "Console";
        }

    }
}
