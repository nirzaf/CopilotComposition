
Vehicle v1 = new Vehicle();

v1.Drive();
v1.Brake();
v1.Park();

//Crate a new class for Vehicle with Interface implementation of Drive, Brake, and Park
public class Vehicle : IDrive, IBrake, IPark
{
    public void Drive()
    {
        Console.WriteLine("Vehicle is driving");
    }

    public void Brake()
    {
        Console.WriteLine("Vehicle is braking");
    }

    public void Park()
    {
        Console.WriteLine("Vehicle is parking");
    }
}

public interface IDrive
{
    void Drive();
}

public interface IBrake
{
    void Brake();
}

public interface IPark
{
    void Park();
}



