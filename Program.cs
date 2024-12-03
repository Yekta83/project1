// See https://aka.ms/new-console-template for more information
//Circle myCircle = new Circle(5);
//double area = myCircle.CalculateArea();
//Console.WriteLine("area of circle: " + area);
class Program
{
    static void Main(string[] args)
    {
        ProductPriceChecker checker = new ProductPriceChecker();
        checker.CheckPrices();
    }
}