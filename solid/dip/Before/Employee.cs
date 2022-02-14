namespace Before;

public class Employee
{
    public Employee(int id, string name, string department, double salary)
    {
        Id = id;
        Name = name;
        Department = department;
        Salary = salary;
    }

    public int Id { get; init; }
    public string Name { get; init; }
    public string Department { get; init; }
    public double Salary { get; init; }
}