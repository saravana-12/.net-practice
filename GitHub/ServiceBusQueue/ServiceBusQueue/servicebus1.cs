using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ServiceBus.Messaging;

namespace ServiceBusQueue
{
    class servicebus1
    {
        static void Main(string[] args)
        {
            sendmessage();
            Console.ReadLine();
            receivemessage();
        }
        public static void sendmessage()
        {
            var connectionString = "Endpoint=sb://saravanaqueue.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=R4JZKi0i3IsIs/XR6mcYMEjHxL1lx7iZ/VzmuMvoFAw=";
            var queueName = "saravanaqueue";

            var client = QueueClient.CreateFromConnectionString(connectionString, queueName);
            var message = new BrokeredMessage("hi there this is Saravana");

            client.Send(message);
        }
        public static void receivemessage()
        {
            var connectionString = "Endpoint=sb://saravanaqueue.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=R4JZKi0i3IsIs/XR6mcYMEjHxL1lx7iZ/VzmuMvoFAw=";
            var queueName = "saravanaqueue";

            var client = QueueClient.CreateFromConnectionString(connectionString, queueName);

            client.OnMessage(message =>
            {
                Console.WriteLine(String.Format("Message body: {0}", message.GetBody<String>()));
                Console.WriteLine(String.Format("Message id: {0}", message.MessageId));
            });

            Console.ReadLine();
        }
    }
}
