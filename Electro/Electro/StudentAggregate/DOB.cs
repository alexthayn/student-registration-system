namespace Electro.StudentAggregate
{
    public class DOB
    {
        public int Month { get; set; }
        public int Day { get; set; }
        public int Year { get; set; }

        public DOB(int month, int day, int year)
        {
            //Validation of data

            Month = month;
            Day = day;
            Year = year;
        }
    }
}