namespace Tasc1;


public class Laptop:Computer
{
    public int Weight { get; set; }
    public void WeightCheck(int weight)
    {
       
       if (weight!=Weight)
       {
        System.Console.WriteLine("In Laptop nest chizi digar ast!");
       }
    }
     public  Laptop(int ram,int storage,string keyboard,int weight):base(ram,storage,keyboard)
    {
        Weight=weight;
    }
}
