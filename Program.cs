using DesafioPOO.Models;


public class Program
{
    public static void Main(string[] args)
    {
        Iphone iphone = new Iphone("123", "Iphone 12", "123d34a", 128);
        Nokia nokia = new Nokia("1453", "nokia 12", "123d34a", 128);

        nokia.Ligar();
        iphone.Ligar();
        Console.WriteLine($"{iphone.Memoria} {nokia.Memoria} {iphone.Imei}");
    }
}
