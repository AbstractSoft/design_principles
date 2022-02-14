namespace Before;

public class DataAccessFactory
{
    public static EmployeeDataAccess GetEmployeeDataAccessObj()
    {
        return new EmployeeDataAccess();
    }
}