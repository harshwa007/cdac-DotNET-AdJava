namespace DAL.Connected;
using BOL;
using MySql.Data.MySqlClient;
public class DBManager
{
    //public static string conn = @"server=192.168.10.150;port=3306;user=dac52;password=welcome;database=dac52";

    // public  List<Product> GetAllProduct()
    // {
    //     List<Product> plist = new List<Product>();
    //     MySqlConnection connection = new MySqlConnection();
    //     connection.ConnectionString = "server=192.168.10.150;port=3306;user=dac52;password=welcome;database=dac52";
    //    // connection.Open();
        
    //     string query = "select * from products1";
    //     MySqlCommand command = new MySqlCommand(query, connection);

    //     try
    //     {
    //         connection.Open();
    //        MySqlDataReader reader = command.ExecuteReader();

    //         while (reader.Read())
    //         {
    //             //Product p = new Product();
    //            int id = int.Parse(reader["id"].ToString());
    //             // int id = 7;
    //             // string name1="soya";
    //             // int qty1 = 10;
    //             // string desc ="fvjdasg";
    //             // int price1 = 20;
    //            string name1 = reader["name"].ToString();
    //            string desc = reader["description"].ToString();
    //            int qty1 = int.Parse(reader["qty"].ToString());
    //            int price1 = int.Parse(reader["price"].ToString());
    //             //Product p = new Product();
    //             //Product p = new Product{Id=id,name=name1, description = desc, qty=qty1,price=price1};
    //             // p.Id = id;
    //             // p.name = name1;
    //             // p.qty = qty1;
    //             // p.price = price1;
    //             // p.description = desc;
    //             Product p = new Product(id,name1,desc,qty1,price1);
    //             Console.WriteLine("Hello");
    //             Console.WriteLine("Id : " + id + " Name : " + name1 + " Decription :" + desc + " Quantity : " + qty1 + " Price : " + price1);
    //             plist.Add(p);
    //         }
    //         reader.Close();

    //     }
    //     catch (Exception e)
    //     {
    //         Console.WriteLine(e.Message);
    //     }
    //     finally
    //     {
    //         connection.Close();
    //     }
    //     return plist;
    // }

    public static string conString=@"server=localhost;port=3306;user=root; password=password;database=transflower";  
    public static List<Product> GetAllProducts(){
                  List<Product> allDepartments=new List<Product>();
            MySqlConnection con=new MySqlConnection();
            con.ConnectionString=conString;
            string query = "SELECT * FROM Products1";
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                con.Open();        
                cmd.CommandText=query;
                MySqlDataReader reader=cmd.ExecuteReader();
                while(reader.Read()){
                    int id = int.Parse(reader["id"].ToString());
                    string name = reader["name"].ToString();
                    string location = reader["location"].ToString();
                    Department dept=new Department{
                                                    Id = id,
                                                    Name = name,
                                                    Location = location
                    };
                    allDepartments.Add(dept);
                }
            }
            catch(Exception ee){
                Console.WriteLine(ee.Message);
            }
            finally{
                    con.Close();
            }

            return allDepartments;
    }
}