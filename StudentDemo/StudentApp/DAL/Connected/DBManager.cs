using BOL;
using MySql.Data.MySqlClient;
namespace Conncted.DBManager;
public static class DBManager
{
    public static string conString = @"Server=192.168.10.150; port=3306; user=dac52; password=welcome; database=dac52;";
    public static bool AddStudent(int id, string fname, string lname, int std)
    {
        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = conString;
        string querry = "insert into NET_STUDENTS values(@Id,@Fname,@Lname,@Std)";
        try
        {
            MySqlCommand cmd = new MySqlCommand(querry, conn);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("Fname", fname);
            cmd.Parameters.AddWithValue("@Lname", lname);
            cmd.Parameters.AddWithValue("@Std", std);
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = querry;
            cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return false;
        }
        finally
        {
            conn.Close();
        }
        return true;
    }

    public static List<Student> GetAll()
    {
        List<Student> allstud = new List<Student>();

        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        string query = "select * from net_students";
        try
        {
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = int.Parse(reader["Id"].ToString());
                string fnm = reader["Fname"].ToString();
                string lnm = reader["Lname"].ToString();
                int std = int.Parse(reader["Standard"].ToString());

                Student s1 = new Student(id, fnm, lnm, std);
                if (s1 != null)
                {
                    allstud.Add(s1);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }


        return allstud;
    }
}