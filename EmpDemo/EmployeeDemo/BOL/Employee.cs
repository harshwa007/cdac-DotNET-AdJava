namespace BOL.Employee;
public class Employee{
    public int Id{get;set;}
    public string Name{get;set;}
    public string City{get;set;}
    public string Address{get;set;}
    public Employee()
    {
        
    }
    public Employee(int id,string name,string city,string address)
    {
        this.Id = id;
        this.Name =name;
        this.City = city;
        this.Address = address;
    }

}