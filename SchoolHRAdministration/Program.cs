using HRAdministrationAPI;

namespace SchoolHRAdministration
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalSalaries = 0;
            var employees = new List<IEmployee>();

            SeedData(employees);

            foreach (var employee in employees)
            {
                totalSalaries += employee.Salary;
            }

            Console.WriteLine($"Total Annual Salaries (including bonus): {totalSalaries}");

            Console.ReadKey();

        }

        static void SeedData(List<IEmployee> employees)
        {
            IEmployee teacher1 = new Teacher
            {
                Id = 1,
                FirstName = "Bob",
                LastName = "Fisher",
                Salary = 40000
            };

            employees.Add(teacher1);

            IEmployee teacher2 = new Teacher
            {
                Id = 1,
                FirstName = "Jenny",
                LastName = "Thomas",
                Salary = 40000
            };

            employees.Add(teacher2);

            IEmployee headOfDepartment = new HeadOfDepartment
            {
                Id = 1,
                FirstName = "Brenda",
                LastName = "Mullins",
                Salary = 50000
            };

            employees.Add(headOfDepartment);

            IEmployee deputyHeadMaster = new DeputyHeadMaster
            {
                Id = 1,
                FirstName = "Devlin",
                LastName = "Brown",
                Salary = 60000
            };

            employees.Add(deputyHeadMaster);

            IEmployee headMaster = new HeadMaster
            {
                Id = 1,
                FirstName = "Damien",
                LastName = "Jones",
                Salary = 80000
            };

            employees.Add(headMaster);
        }
    }

    class Teacher : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.02m); }
    }

    class HeadOfDepartment : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.03m); }
    }
    class DeputyHeadMaster : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.04m); }
    }

    class HeadMaster : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.05m); }
    }
}