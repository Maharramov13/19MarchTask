class Product
{
    string name;
    double price;
    double count;
    public double TotalIncome=0;


public Product(string name,double price,int count)
{
    this.name=name;
    this.price=price;
    this.count=count;
    TotalIncome=0;

}
public void Sell(double quantity)
{
    if(quantity<=0)
    {
        System.Console.WriteLine("xetali miqdar girishi: ");
        return;
    }
    if(count<quantity)
    {
        System.Console.WriteLine("Kifayet qeder mehsul yoxdu");
        return;
    }

    count-=quantity;

    TotalIncome+= price * quantity;
    System.Console.WriteLine($"{quantity} eded {name} satildi");
}
}