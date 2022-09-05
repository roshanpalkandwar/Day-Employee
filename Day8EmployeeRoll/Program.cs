namespace Day8EmployeeRoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welecome Employee Wages");
            Console.WriteLine("Choose Option\n 1. Check absent present");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    EmpPersentAbsent.EmployeeAttendance();
                    break;
            }
        }
    }
}