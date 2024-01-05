using BOL;
using MySql.Data.MySqlClient;
namespace DAL.Connected;
public static class DBManager{
    public static string conString= @"server=192.168.10.150; port=3306; user=dac52; password=welcome; database=dac52";
    public static bool InsertDetails(string tDate, string tWorkDesc, int duration, string status)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
       string querry = "insert into timesheets values(@TDate,@TWorkDesc,@Duration,@Status)";
       // string querry = "insert into timesheets values('@TDate','@TWorkDesc',2,'@Status')";
        try
        {
            MySqlCommand cmd = new MySqlCommand(querry,con);
            cmd.Parameters.AddWithValue("@TDate",tDate);
            cmd.Parameters.AddWithValue("@TWorkDesc",tWorkDesc);
            cmd.Parameters.AddWithValue("@Duration",duration);
            cmd.Parameters.AddWithValue("@Status",status);
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = querry;
            Console.WriteLine("2");
            cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return false;            
        }
        finally{
            con.Close();
        }
        return true;
    }
    public static List<TimeSheet> GetAllDetails()
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
       string querry = "select * from timesheets";
       List<TimeSheet> list = new List<TimeSheet>();
       // string querry = "insert into timesheets values('@TDate','@TWorkDesc',2,'@Status')";
        try
        {
            MySqlCommand cmd = new MySqlCommand(querry,con);
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = querry;
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                string TDate1 = reader["t_date"].ToString();
                string TWorkDesc1 = reader["t_workDesc"].ToString();
                int dur = int.Parse(reader["t_duration"].ToString());
                string st = reader["t_status"].ToString();
                TimeSheet t = new TimeSheet(TDate1,TWorkDesc1,dur,st);
                if(t!=null)
                {
                    list.Add(t);
                }

            }
            Console.WriteLine("2");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);        
        }
        finally{
            con.Close();
        }
        return list;
    }
    public static bool UpdateDetails(string tDate, string tWorkDesc, int duration, string status)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
       string querry = "Update timesheets set t_workDesc=@TWorkDesc, t_duration=@Duration,t_status=@Status where t_date=@TDate";
       // string querry = "insert into timesheets values('@TDate','@TWorkDesc',2,'@Status')";
        try
        {
            MySqlCommand cmd = new MySqlCommand(querry,con);
            cmd.Parameters.AddWithValue("@TDate",tDate);
            cmd.Parameters.AddWithValue("@TWorkDesc",tWorkDesc);
            cmd.Parameters.AddWithValue("@Duration",duration);
            cmd.Parameters.AddWithValue("@Status",status);
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = querry;
            Console.WriteLine("2");
            cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return false;            
        }
        finally{
            con.Close();
        }
        return true;
    }
}