namespace BLL.EmployeeManager;
using BOL.Employee;
using DAL.connected;
public static class EmployeeManager{

    public static bool Add(int id, string name,string city,string address)
    {
        bool status = DBManager.AddEmp(id,name,city,address);
        return status;
    }
    public static bool Update(int id, string name,string city,string address)
    {
        bool status = DBManager.UpdateEmp(id,name,city,address);
        return status; 
    }
    public static bool Delete(int id)
    {
        bool status = DBManager.DeleteEmp(id);
        return status; 
    }
    public static List<Employee> FindEmp(int id)
    {
        List<Employee> list = new List<Employee>();
        list = DBManager.FindById(id);
        return list;
    }
    public static List<Employee> GetList()
    {
        List<Employee> list = new List<Employee>();
        list = DBManager.GettAll();
        return list;
    }
}