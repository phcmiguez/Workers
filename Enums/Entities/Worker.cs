using Enums.Entities.Enums;

namespace Enums.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<Contract> Contracts { get; set; } = new List<Contract>();

        public Worker() { }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Level = level;
            BaseSalary = baseSalary;
            Department = department ?? throw new ArgumentNullException(nameof(department));
        }

        public void AddContract(Contract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(Contract contract)
        {
            Contracts.Remove(contract);
        }

        public double GetIncoming(int year, int month)
        {
            double sum = BaseSalary;
            foreach (Contract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
