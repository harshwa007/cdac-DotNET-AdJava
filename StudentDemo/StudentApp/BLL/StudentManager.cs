using System.ComponentModel;
using BOL;
using Conncted.DBManager;
using Org.BouncyCastle.Bcpg;
namespace BLL.StudentManager;
public static class StudentManager{
    public static bool Add(int id,string fname,string lname,int std)
    {
        bool status = DBManager.AddStudent(id,fname,lname,std);
        return status;
    }

    public static List<Student> GetAll()
    {
        List<Student> s2 = DBManager.GetAll();
        return s2;
    }
}