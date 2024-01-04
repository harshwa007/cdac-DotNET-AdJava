namespace BLL;
using BOL;
using DAL.Connected;
public static class StudentManager
{
    public static bool Add(int id, string fname, string lname, int std)
    {
        bool status = DBManager.AddStudent(id, fname, lname, std);
        return status;
    }
    public static bool Delete(int id)
    {
        bool status = DBManager.DeleteStudent(id);
        return status;
    }
    public static bool Update(int id, string fname, string lname, int std)
    {
        bool status = DBManager.UpdateStudent(id, fname, lname, std);
        return status;
    }
    public static List<Student> Find(int id)
    {
        List<Student> status = DBManager.FindStudent(id);
        return status;
    }
    public static List<Student> All()
    {
        List<Student> status = DBManager.GetAll();
        return status;
    }
}