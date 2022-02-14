namespace Before;

public class EmployeeDataAccess
{
    public Employee GetEmployeeDetails(int id)
    {
        // In real time get the employee details from db
        //but here we are hard coded the employee details
        return new Employee(id, "John Smith", "IT", 10000);
    }
}