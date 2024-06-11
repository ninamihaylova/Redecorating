class Redecorating
{
    public static void Main(string[] args)
    {
        int nylon = int.Parse(Console.ReadLine());
        int paint = int.Parse(Console.ReadLine());
        int thinner = int.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());

        double nylonPrice = 1.50;
        double paintPrice = 14.50;
        double thinnerPrice = 5.00;
        


        double materialsPrice =(nylon+2)*nylonPrice+paint*1.1*paintPrice+thinnerPrice*thinner+0.40;
        double craftmenPrice=materialsPrice*hours*0.3;
        double totalAmount=materialsPrice+craftmenPrice;
        
        Console.WriteLine(totalAmount);
        
    }
}