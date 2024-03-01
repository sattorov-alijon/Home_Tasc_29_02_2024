namespace Tasc1;

public class SmartPhone :Computer
{
    public int NumberOfSelfies { get; set; }
    public  SmartPhone(int ram,int storage,string keyboard,int numberOfSelfies):base(ram,storage,keyboard)
    {
        NumberOfSelfies=numberOfSelfies;
    }
    public void TakeSelfies(int numberOfSelfies)
    {
        System.Console.WriteLine($"Pamyati teefon- {numberOfSelfies} ");
    
        if (NumberOfSelfies>numberOfSelfies)
        {
            System.Console.WriteLine("Dar pamyat joy nest");
        }
    }


}
