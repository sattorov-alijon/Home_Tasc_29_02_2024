namespace Tasc1;

public class Computer
{
    public int Ram { get; set; }
    public int Storage { get; set; }
    public string Keyboard { get; set; }
    
    public void AddRam(int ram)
    {
        Ram=ram;
    }
        public void AddStorage(int storage)
    {
        Storage=storage;
    }
    public  Computer(int ram,int storage,string keyboard)
    {
        Ram=ram;
        Storage=storage;
        Keyboard=keyboard;
    }


}
