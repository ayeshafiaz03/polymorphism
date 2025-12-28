using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Base class
class Notification
        {
            public virtual void Send(string message)
            {
                Console.WriteLine("Sending notification: " + message);
            }
        }

        // Derived class 1
        class EmailNotification : Notification
        {
            public override void Send(string message)
            {
                Console.WriteLine("Email sent: " + message);
            }
        }

        // Derived class 2
        class SmsNotification : Notification
        {
            public override void Send(string message)
            {
                Console.WriteLine("SMS sent: " + message);
            }
        }

        // Derived class 3
        class AppNotification : Notification
        {
            public override void Send(string message)
            {
                Console.WriteLine("App notification sent: " + message);
            }
        }

        // Main class
        class Program
        {
            static void Main()
            {
                Notification notify;

                notify = new EmailNotification();
                notify.Send("Your order is confirmed.");

                notify = new SmsNotification();
                notify.Send("Your OTP is 1234.");

                notify = new AppNotification();
                notify.Send("You have a new message.");
            }
        }
