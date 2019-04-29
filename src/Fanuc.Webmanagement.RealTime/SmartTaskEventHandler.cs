using Abp.Dependency;
using Abp.Events.Bus.Handlers;
using Fanuc.Webmanagement.Common;
using Fanuc.Webmanagement.TaskPlan.Dto;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fanuc.Webmanagement.RealTime
{
    public class SmartTaskEventHandler : IEventHandler<SmartTaskEventData>, ITransientDependency
    {
        private Rabbitmq rabbitmqConfig;
        private static string exchangeName = "consumer-channel";
        private static string routingKey = "consumer.r";

        public SmartTaskEventHandler(IOptions<AppSettings> _options)
        {
            rabbitmqConfig = _options.Value.Rabbitmq;
        }
        public void HandleEvent(SmartTaskEventData eventData)
        {
            var factory = new ConnectionFactory()
            {
                HostName = rabbitmqConfig.ServiceName,
                UserName = rabbitmqConfig.User,
                Password = rabbitmqConfig.Pwd,
                VirtualHost = rabbitmqConfig.VirtualPath
            };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                
                string message = JsonConvert.SerializeObject(eventData.SmartTask) ;
                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish(exchange: exchangeName,
                                     routingKey: routingKey,
                                     basicProperties: null,
                                     body: body);
            }
        }
    }
}
