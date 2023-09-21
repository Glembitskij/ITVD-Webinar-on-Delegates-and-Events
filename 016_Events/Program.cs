using System;

namespace _016_Events
{
    internal class Program
    {
        static void Main()
        {
            Employee employee = new Employee(25);

            employee.notification += Notifiers.NotifyViaSMS;
            employee.notification += salary => Console.WriteLine($"Notify in Telegram {salary}");
 
            employee.ShowSalary(10);

            Console.ReadKey();
        }
    }

    class Notifiers
    {
        public static void NotifyViaSMS(decimal salary)
        {
            Console.WriteLine($"Notify in SMS {salary}");
        }
    }

    class Employee
    {
        public event Action<decimal> notification;

        public decimal PayForHour { get; }

        public Employee(decimal payForHour)
        {
            PayForHour = payForHour;
        }

        private decimal CalculateSalary(int hour)
        {
            decimal result = PayForHour * hour;
            notification.Invoke(result);
            return result;
        }

        public void ShowSalary(int hour)
        {
            Console.WriteLine(CalculateSalary(hour));
        }
    }
}
