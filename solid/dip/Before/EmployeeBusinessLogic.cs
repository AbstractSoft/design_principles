namespace Before;

public class EmployeeBusinessLogic
{
    private EmployeeDataAccess employeeDataAccess;
    
    public EmployeeBusinessLogic()
    {
        employeeDataAccess = DataAccessFactory.GetEmployeeDataAccessObj();
    }
    
    public Employee GetEmployeeDetails(int id)
    {
        return employeeDataAccess.GetEmployeeDetails(id);
    }
}