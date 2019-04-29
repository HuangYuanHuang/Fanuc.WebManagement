using Abp.Events.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fanuc.Webmanagement.TaskPlan.Dto
{
    public class SmartTaskEventData : EventData
    {

        public SmartTaskDto SmartTask { get; set; }

        public SmartTaskEventType EventType { set; get; }
    }

    public enum SmartTaskEventType
    {
        Create,
        Finished
    }
}
