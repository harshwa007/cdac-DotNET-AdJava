namespace BLL;
using DAL.Connected;
using BOL;
public static class TimeSheetManager
{
    public static bool AddDetails(string tDate, string tWorkDesc, int duration, string status)
    {
        bool condition = DBManager.InsertDetails(tDate, tWorkDesc, duration, status);
        Console.WriteLine(condition);
        return condition;
    }
    public static List<TimeSheet> GetDetails()
    {
        List<TimeSheet> list = DBManager.GetAllDetails();
        return list;
    }
    public static bool UpdateDetails(string tDate, string tWorkDesc, int duration, string status)
    {
        bool condition = DBManager.UpdateDetails(tDate, tWorkDesc, duration, status);
        Console.WriteLine(condition);
        return condition;
    }
}
