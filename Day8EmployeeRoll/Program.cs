namespace Day8EmployeeRoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welecome Employee Wages");
            Console.WriteLine("Choose Option\n 1. Check absent present\n2.daily wages\n3.part time wages\n4.switch loop\n5. monthly wages\n6.Monthly Wages using while loop\n7.emp wages");
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
                case 5:
                    WagesMonthly.CalculateWageForMonth();
                    break;
                case 6:
                    WagesWithWhileLop.CalculateWage();
                    break;
                case 7:
                    ComputeEmpWages.ComputeEmpWage();
                    break ;
                   
            }
        }
    }
}