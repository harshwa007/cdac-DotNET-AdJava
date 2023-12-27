namespace DAL;
using BOL;
using System.Text.Json;
using System.Threading.Tasks;

public class DBmanager
{
    public static List<Product> GetAllProduct()
    {
        List<Product> plist = new List<Product>();
        plist.Add(new Product { Id = 5, name = "Moti", description = "Soap", qty = 1, price = 20 });
        return plist;
    }
    public static List<Product> GetAllProductFromDB()
    {
        List<Product> plist = new List<Product>();
        return plist;
    }
    public static Product GetById(int pid)
    {
        List<Product> plist = new List<Product>();
        Product p = new Product { Id = 5, name = "Moti", description = "Soap", qty = 1, price = 20 };
        return p;
    }
}