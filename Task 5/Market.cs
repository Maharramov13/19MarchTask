class Market
{
    public double CalculateTotalToPay(double price1,double price2,double price3)
    {
        double[]prices={price1,price2,price3};
        Array.Sort(prices);
        double totalToPay=prices[1]+prices[2];
        return totalToPay;
    }
}