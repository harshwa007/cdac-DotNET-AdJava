namespace DAL.Connected;
using BOL;
using MySql.Data.MySqlClient;
public static class DBManager{
    public static string conString = @"Server=localhost; port=3306; user=root; password=1122; database=simple";
    public static bool AddStudent(int id, string fname,string lname, int std)
    {
        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = conString;
        string query = "insert into student value(@Id,@Fname,@Lname,@Std)";
        //string query = "insert into student value(2,'hasrsh','bgi',10)";
        try
        {
            MySqlCommand cmd = new MySqlCommand(query,conn);
            cmd.Parameters.AddWithValue("@Id",id);
            cmd.Parameters.AddWithValue("@Fname",fname);
            cmd.Parameters.AddWithValue("@Lname",lname);
            cmd.Parameters.AddWithValue("@Std",std);
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = query;
            Console.WriteLine("1");
            cmd.ExecuteNonQuery();
            Console.WriteLine("3");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("3");
            return false;
        }
        finally{
            conn.Close();
        }
        return true;
    }
    public static bool DeleteStudent(int id)
    {
        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = conString;
        string query = "delete from student where id =@Id";
        //string query = "insert into student value(2,'hasrsh','bgi',10)";
        try
        {
            MySqlCommand cmd = new MySqlCommand(query,conn);
            cmd.Parameters.AddWithValue("@Id",id);
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = query;
            Console.WriteLine("1");
            cmd.ExecuteNonQuery();
            Console.WriteLine("3");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("3");
            return false;
        }
        finally{
            conn.Close();
        }
        return true;
    }
    public static bool UpdateStudent(int id, string fname,string lname, int std)
    {
        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = conString;
        string query = "update student set Fname=@Fname,Lname=@Lname,std=@Std where Id=@Id";
        //string query = "insert into student value(2,'hasrsh','bgi',10)";
        try
        {
            MySqlCommand cmd = new MySqlCommand(query,conn);
            cmd.Parameters.AddWithValue("@Id",id);
            cmd.Parameters.AddWithValue("@Fname",fname);
            cmd.Parameters.AddWithValue("@Lname",lname);
            cmd.Parameters.AddWithValue("@Std",std);
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = query;
            Console.WriteLine("1");
            cmd.ExecuteNonQuery();
            Console.WriteLine("3");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("3");
            return false;
        }
        finally{
            conn.Close();
        }
        return true;
    }
    public static List<Student> FindStudent(int id)
    {
        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = conString;
        List<Student> list = new List<Student>();
        string query = "select * from student where id=@Id";
        //string query = "insert into student value(2,'hasrsh','bgi',10)";
        try
        {
            MySqlCommand cmd = new MySqlCommand(query,conn);
            cmd.Parameters.AddWithValue("@Id",id);
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = query;
            Console.WriteLine("1");
            Console.WriteLine("3");
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                int id1 = int.Parse(reader["Id"].ToString());
                string fnm=reader["Fname"].ToString();
                string lnm = reader["Lname"].ToString();
                int std1 = int.Parse(reader["std"].ToString());
                Student s = new Student(id1,fnm,lnm,std1);
                list.Add(s);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("3");
        }
        finally{
            conn.Close();
        }
        return list;
    }
       public static List<Student> GetAll()
    {
        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = conString;
        List<Student> list = new List<Student>();
        string query = "select * from student";
        //string query = "insert into student value(2,'hasrsh','bgi',10)";
        try
        {
            MySqlCommand cmd = new MySqlCommand(query,conn);
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = query;
            Console.WriteLine("1");
            Console.WriteLine("3");
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                int id1 = int.Parse(reader["Id"].ToString());
                string fnm=reader["Fname"].ToString();
                string lnm = reader["Lname"].ToString();
                int std1 = int.Parse(reader["std"].ToString());
                Student s = new Student(id1,fnm,lnm,std1);
                list.Add(s);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("3");
        }
        finally{
            conn.Close();
        }
        return list;
    }
}