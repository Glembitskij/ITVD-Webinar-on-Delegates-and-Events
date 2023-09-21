using System;
using System.Runtime.InteropServices;

namespace _005_Delegates
{
    // Реальний приклад використання делегатів
    internal class Program
    {
        static void Main()
        {
            Sender sender = new Sender();

            Employee employee = new Employee() { Name = "Vasa", PayForHour = 10 };
            
            employee.notification += sender.SendSms;
          
            employee.notification += (sal) =>
            {
                Console.WriteLine($"Send Telegram about salary {sal}");
            };

            employee.notification += sal => Console.WriteLine($"Send viber {sal}");

            employee.notification = null;
            employee.notification = sender.SendSms;

            employee.CalculateSalary(40);

            Console.ReadKey();
        }
    }
    class Sender {
        public void SendSms(int salary)
        {
            Console.WriteLine($"Send Sms about salary {salary}");
        }
    }

    public delegate void Notification(int salary);

    class Employee
    {
        public Notification notification = null;

        public string Name { get; set; }

        public int PayForHour { get; set; }

        public void CalculateSalary(int hour)
        {
            int res = PayForHour * hour;
            notification?.Invoke(res);

            Console.WriteLine(res);
        }
    }
}
