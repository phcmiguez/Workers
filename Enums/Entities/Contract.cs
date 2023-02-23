namespace Enums.Entities
{
    internal class Contract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public Contract()
        {

        }
        public Contract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}
