namespace BOL;
public class Student{
    public int Id{get;set;}
    public string Fname{get;set;}
    public string Lname{get;set;}
    public int Std{get;set;}
    public Student()
    {
        this.Id = 0;
        this.Fname = "Sample data";
        this.Lname = "Sample data";
        this.Std =  1;
    }
    public Student(int id,string Fname,string Lname,int Std)
    {
        this.Id = id;
        this.Fname = Fname;
        this.Lname = Lname;
        this.Std = Std;
    }

}