namespace Notification;
public static class NotificationService{
    public static void SendEmail(string to,string content)
    {
        Console.WriteLine("Mail sent.....");
    }
    public static void SendSMS(string to, string content)
    {
        Console.WriteLine("SMS sent....");
    }
    public static void SendWhatsApp(string to, string content)
    {
        Console.WriteLine("sent what's app msg...");
    }
} 