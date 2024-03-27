internal class Program
{
    public static void Main(string[] args)
    {
        Market market=new Market ();
        System.Console.WriteLine("Qiymetleri daxil edin");

       System.Console.WriteLine("Birinci malin qiymeti:");
        double price1= Convert.ToInt16(Console.ReadLine());//20;
        System.Console.WriteLine("Ikinci malin qiymetini daxil edin");
        double price2= Convert.ToInt16(Console.ReadLine());//15;
        System.Console.WriteLine("Ucuncu malin qiymeti:");
        double price3=Convert.ToInt16(Console.ReadLine()); //10;
        double totalToPay=market.CalculateTotalToPay(price1,price2,price3);
        System.Console.WriteLine("Odenilecek mebleg: "+totalToPay);
    }
}