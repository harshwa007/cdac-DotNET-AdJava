namespace DAL.connected;
using BOL.Employee;
using MySql.Data.MySqlClient;
public static class DBManager
{
    public static string conString = @"server=192.168.10.150; port=3306; user=dac52; password=welcome; database=dac52";
    public static bool AddEmp(int id, string name, string city, string address)
    {
        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = conString;
        string querry = "Insert into Employee values(@Id,@Name,@City,@Address)";
        try
        {
            MySqlCommand cmd = new MySqlCommand(querry, conn);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@City", city);
            cmd.Parameters.AddWithValue("@Address", address);
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
    public static bool UpdateEmp(int id, string name, string city, string address)
    {
        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = conString;
        string querry = "update employee set name=@Name, city=@City, address=@Address where id=@Id";
        try
        {
            MySqlCommand cmd = new MySqlCommand(querry, conn);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@City", city);
            cmd.Parameters.AddWithValue("@Address", address);
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
        finally{
            conn.Close();
        }
        return true;
    }
    public static bool DeleteEmp(int id)
    {
        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = conString;
        string querry = "Delete from employee where id = @Id";
        try
        {
            MySqlCommand cmd = new MySqlCommand(querry,conn);
            cmd.Parameters.AddWithValue("@Id",id);
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
    public static List<Employee> FindById(int id)
    {
        List<Employee> list=new List<Employee>();
        MySqlConnection conn=new MySqlConnection();
        conn.ConnectionString=conString;
        string querry="select id,name,city,address from employee where id=@Id";
        try
        {
            MySqlCommand cmd=new MySqlCommand(querry,conn);
            cmd.Parameters.AddWithValue("@Id",id);
            cmd.Connection=conn;
            conn.Open();
            cmd.CommandText=querry;
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                int id1= int.Parse(reader["id"].ToString());
                string name1=reader["name"].ToString();
                string city1=reader["city"].ToString();
                string address1=reader["address"].ToString();
                Employee e = new Employee(id1,name1,city1,address1);
                if(e!=null)
                {
                    list.Add(e);
                }
                
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            conn.Close();
        }
        return list;
    }
    public static List<Employee> GettAll()
    {
        List<Employee> list =new List<Employee>();
        MySqlConnection conn= new MySqlConnection();
        conn.ConnectionString=conString;
        string querry="select id,name,city,address from employee";
        try
        {
            MySqlCommand cmd = new MySqlCommand(querry,conn);
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = querry;
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                int id = int.Parse(reader["id"].ToString());
                string name = reader["name"].ToString();
                string city = reader["city"].ToString();
                string address = reader["address"].ToString();
                Employee e = new Employee(id,name,city,address);
                if(e!=null)
                {
                    list.Add(e);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally{
            conn.Close();
        }
        return list;
    }
}
