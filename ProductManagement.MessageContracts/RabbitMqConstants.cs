using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.MessageContracts
{
    public class RabbitMqConstants
    {
        public const string RabbitMqUri = "amqps://nffmrcga:3NAPGIvNDjmvbF_Wquh9ORNtYm6C9kOf@woodpecker.rmq.cloudamqp.com/nffmrcga";
        public const string Username = "nffmrcga";
        public const string Password = "3NAPGIvNDjmvbF_Wquh9ORNtYm6C9kOf";
        public const string RegistrationServiceQueue = "registration.service";
        public const string NotificationServiceQueue = "notification.service";
        public const string FacebookServiceQueue = "facebook.service";
        public const string InstagramServiceQueue = "instagram.service";
    }
}
