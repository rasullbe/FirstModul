using Dars11;

namespace _11dars;

internal class Program
{
    static List<Employee> employees = new List<Employee>();
    static void Main(string[] args)
    {

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

            }
        }
    }

    
}