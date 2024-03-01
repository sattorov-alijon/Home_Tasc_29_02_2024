using System.Runtime.InteropServices;
using Tasc1;

var computer=new Computer(8,500,"keyboard");

computer.AddRam(12);
computer.AddStorage(1000);

var smartphone=new SmartPhone(4,128,"obichniy",20000);
smartphone.TakeSelfies(2500);

var laptop=new Laptop(16,256,"Podsvetka",1800);
laptop.WeightCheck(2600);

