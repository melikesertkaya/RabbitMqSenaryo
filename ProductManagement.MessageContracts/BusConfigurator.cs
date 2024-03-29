﻿using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.MessageContracts
{
    public static class BusConfigurator
    {
        public static IBusControl ConfigureBus(Action<IRabbitMqBusFactoryConfigurator> registrationAction = null)
        {
            return Bus.Factory.CreateUsingRabbitMq(factory =>
            {
                factory.Host(RabbitMqConstants.RabbitMqUri, configurator =>
                {
                    configurator.Username(RabbitMqConstants.Username);
                    configurator.Password(RabbitMqConstants.Password);
                });

                registrationAction?.Invoke(factory);
            });
        }
    }
}
