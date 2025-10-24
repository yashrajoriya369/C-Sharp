//Q10.Design a delegate Notifier for sending notifications.
//• Implement two methods: SendEmail and SendSMS.
//• Call both methods using delegate chaining for the message "Assignment Submitted
//Successfully".

using System;
namespace Assignment_4
{
    public delegate void Notifier(string message);
    internal class Program10
    {
        public static void SendEmail(string message)
        {
            Console.WriteLine($"Email sent with message: {message}");
        }
        public static void SendSMS(string message)
        {
            Console.WriteLine($"SMS sent with message: {message}");
        }
        static void Main(string[] args)
        {
            Notifier notifier = SendEmail;
            notifier += SendSMS;
            string message = "Assignment Submitted Successfully";
            notifier(message);
            Console.ReadLine();
        }
    }
}