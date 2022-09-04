using System;

class Program
{
    static void Main(string[] args)
    {
        AutoService BestService = new AutoService("BestService", 123456);
        BestService.Print();
        Vehicle Transp = new Vehicle("BestService", 123456, "light", 4444444);
        Transp.Print();
        Wheels Teach1 = new Wheels("BestService", 123456, "rubber", 5555555);
        Car Schedule1 = new Car("BestService", 123456, "light", 4444444, 00010001);
    }
}

class AutoService
{
    string Name { get; set; }// since the property used as private field - no need use is as property, you can just use private field
    int Id { get; set; }// you can just use private field
    public AutoService(string name, int id)
    {
        Name = name;
        Id = id;
    }
    public virtual void Print()
    {
        Console.WriteLine($"AutoService {Name}");
    }
}
class Vehicle : AutoService

{
    string Type { get; set; }// you can just use private field
    int Number { get; set; }// you can just use private field

    public Vehicle(string name, int id, string type, int number) : base(name, id)
    {
        Type = type;
        Number = number;
    }

    public void Print()
    {
        Console.WriteLine("Car " + Type + " number " + Number);
    }
}

    class Wheels : AutoService
{
    DateTime DataOfManufacture;
    string Matherial { get; set; }// you can just use private field
    int IdWheel { get; set; }// you can just use private field

    public Wheels(string name, int id, string matherial, int idWheel) : base(name, id)
    {
        Matherial = matherial;
        IdWheel = idWheel;
    }
}

class Car: Vehicle
{
    int Seria { get; set; }// you can just use private field

    public Car(string name, int id, string type, int number, int seria) : base(name, id, type, number)
    {
        Seria = seria;
    }
}
//checked
