using System;
using System.Collections.Generic;
using System.Text;

namespace Fanuc.Webmanagement.Common
{
    public class AppSettings
    {
        public Rabbitmq Rabbitmq { get; set; }
    }

    public class Rabbitmq
    {
      
        public string ServiceName { get; set; }

        public string User { get; set; }

        public string Pwd { get; set; }

        public string VirtualPath { get; set; }


    }
}
