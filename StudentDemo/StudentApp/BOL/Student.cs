namespace BOL;

public class Student 
{
    public int ID{get;set;}
    public string Fname{get;set;}
    public string Lname{get;set;}
    public int Standard{get;set;}


    public Student()
    {
       this.ID = 1;
       this.Fname = "Proxy";
       this.Lname = "Proxy";
       this.Standard = 1;
    }
    public Student(int id,string fn,string ln,int sd)
    {
        
       this.ID = id;
       this.Fname = fn;
       this.Lname = ln;
       this.Standard = sd;
    }

}
