namespace After;

public class DataAccessFactory
{
    public static IEmployeeDataAccess GetEmployeeDataAccessObj()
    {
        return new EmployeeDataAccess();
    }
}