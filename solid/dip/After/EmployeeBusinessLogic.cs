namespace After;

public class EmployeeBusinessLogic
{
    public readonly IEmployeeDataAccess employeeDataAccess;
    
    public EmployeeBusinessLogic()
    {
        employeeDataAccess = DataAccessFactory.GetEmployeeDataAccessObj();
    }
    
    public Employee GetEmployeeDetails(int id)
    {
        return employeeDataAccess.GetEmployeeDetails(id);
    }
}