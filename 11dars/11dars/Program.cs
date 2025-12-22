using Dars11;

namespace _11dars;

internal class Program
{
    static List<Employee> employees = new List<Employee>();
    static void Main(string[] args)
    {
        Employee employee1 = new Employee
        {
            GuidId = Guid.NewGuid(),
            FirstName = "John",
            LastName = "Doe",
            Position = "Developer",
            Salary = 60000,
            Age = 30
        };

        Employee employee2 = new Employee
        {
            GuidId = Guid.NewGuid(),
            FirstName = "Jane",
            LastName = "Smith",
            Position = "Designer",
            Salary = 55000,
            Age = 28
        };

        AddEmployee(employee1);
        AddEmployee(employee2);

        Console.WriteLine("All Employees:");
        GetAllEmployees();

        var newEmployee = new Employee
        {
            GuidId = employee1.GuidId,
            FirstName = "John",
            LastName = "Doe",
            Position = "Senior Developer",
            Salary = 80000,
            Age = 31
        };

        UpdateEmployee(employee1.GuidId, newEmployee);
        RemoveEmployee(employee2.GuidId);

    }

    static void AddEmployee(Employee emp)
    {
        employees.Add(emp);
    }

    static void RemoveEmployee(Guid GuidId)
    {
        foreach (var employer in employees)
        {
            if (employer.GuidId == GuidId)
            {
                employees.Remove(employer);
                break;
            }
        }
    }

    static void UpdateEmployee(Guid GuidId, Employee newEmp)
    {
        for (int i = 0; i < employees.Count; i++)
        {
            if (employees[i].GuidId == GuidId)
            {
                employees[i] = newEmp;
                break;
            }
        }
    }

    static void GetAllEmployees()
    {
        foreach (var employer in employees)
        {
            Console.WriteLine(employer);
        }
    }
}



