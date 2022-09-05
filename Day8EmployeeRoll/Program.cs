namespace Day8EmployeeRoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welecome Employee Wages");
            Console.WriteLine("Choose Option\n 1. Check absent present\n2.daily wages\n3.part time wages\n4.switch loop");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    EmpPersentAbsent.EmployeeAttendance();
                    break;
                    case 2:
                    dailyWages.CalculateDailyWage();
                    break;
                case 3:
                    PartTime.CalculatePercentage();
                    break;
                case 4:
                    switchStatment.CalculateWage();
                    break;
            }
        }
    }
}