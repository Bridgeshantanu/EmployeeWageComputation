namespace EmployeeWageComputation
{
    internal class Program
    {
         static void Main(string[] args)
         {

            Employee employee = new Employee(); 
            employee.Checkattendance();

            
            Company company1 = new Company(10, 20, 8);
            Company company2 = new Company(15, 22, 7);

            int employeeWage1 = company1.CalculateEmployeeWage(160);
            Console.WriteLine($"Employee wage for company 1: {employeeWage1}");

            int employeeWage2 = company2.CalculateEmployeeWage(154);
            Console.WriteLine($"Employee wage for company 2: {employeeWage2}");


        }
    }
}