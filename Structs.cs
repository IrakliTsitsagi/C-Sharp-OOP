namespace Structs
{
    internal class Structs
    {
        static void Main(string[] args)
        {
            Employee newEmployee = new Employee();
            newEmployee.employeeName = "Dejan";
            newEmployee.employeeJob = "miasniki";
            newEmployee.Salary = 10000;
            Console.WriteLine($"Emploee name is {newEmployee.employeeName} and his job is " +
                $"{newEmployee.employeeJob} xelfasi {newEmployee.Salary}");
            newEmployee.SayHi();
        }
    }

    struct Employee
    {
        public string employeeName;
        public string employeeJob;
        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public void SayHi()
        {
            Console.WriteLine("Hi from the method in struct");
        }
    }
}