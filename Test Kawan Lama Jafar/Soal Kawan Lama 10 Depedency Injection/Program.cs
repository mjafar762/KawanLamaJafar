using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soal_Kawan_Lama_10_Depedency_Injection
{
    internal class Program
    {

        
        interface IMessageService
        {
            void SendMessage(string message);
        }

      
        class EmailService : IMessageService
        {
            public void SendMessage(string message)
            {
                Console.WriteLine("Sending email: " + message);
            }
        }

        
        class NotificationService
        {
            private readonly IMessageService _messageService;

          
            public NotificationService(IMessageService messageService)
            {
                _messageService = messageService;
            }

            // Metode untuk mengirim pesan
            public void SendNotification(string message)
            {
                _messageService.SendMessage(message);
            }
        }

        static void Main(string[] args)
        {
           
            IMessageService emailService = new EmailService();

         
            NotificationService notificationService = new NotificationService(emailService);

            // Mengirim notifikasi
            notificationService.SendNotification("ini Depedency Injection!");

            Console.ReadLine();
        }
    }
}
