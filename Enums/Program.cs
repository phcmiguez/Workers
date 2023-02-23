using Enums.Entities;
using Enums.Entities.Enums;

namespace Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Enter department's name:");
            string department = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter worker data:");
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Level: (Junior/MidLevel/Senior):");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Base Salary:");
            double baseSalary = double.Parse(Console.ReadLine());
            Console.Clear();
            Department dept = new Department(department);
            Worker worker = new Worker(name, level, baseSalary, dept);
            Console.Clear();
            Console.WriteLine("Number of contracts for this worker:");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                Console.Clear();
                Console.WriteLine($"Enter contract #{i} data:");
                Console.WriteLine("Date (DD/MM/YYY):");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Value per Hour:");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.WriteLine("Duration (Hours):");
                int duration = int.Parse(Console.ReadLine());
                Contract contract = new Contract(date, valuePerHour, duration);
                worker.AddContract(contract);
            }
            Console.Clear();
            Console.WriteLine("Enter month and year to calculate income (MM/YYYY):");
            string[] tmpDate = Console.ReadLine().Split('/');
            int month = int.Parse(tmpDate[0]);
            int year = int.Parse(tmpDate[1]);

            Console.Clear();
            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($"Income for ({month}/{year}): R$ {worker.GetIncoming(year, month)}.");
        }
    }
}