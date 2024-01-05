namespace BOL;
public class TimeSheet{
    public string TDate{get;set;}
    public string TWorkDesc{get;set;}
    public int Duration{get;set;}
    public string Status{get;set;}
    public TimeSheet()
    {
        this.TDate = "0";
        this.TWorkDesc = "work";
        this.Duration = 0;
        this.Status = "not completed";
    }
    public TimeSheet(string TDate, string TWorkDesc,int Duration,string Status)
    {
        this.TDate = TDate;
        this.TWorkDesc = TWorkDesc;
        this.Duration = Duration;
        this.Status = Status;
    }
}
