namespace BLL;
using BOL;
using DAL;
using DAL.Connected;
public class CatalogManager{
    public List<Product> GetAll()
    {
        List<Product> plist = new List<Product>();
        plist = DBmanager.GetAllProduct();

        return plist;
    }
}