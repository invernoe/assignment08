internal class Employee
{
    public int ID { get; set; }

    public string? Name { get; set; }

    public int? Age { get; set; }

    public void MyFunc01()
    {
        Console.WriteLine("I am Employee");
    }

    public virtual void MyFunc02()
    {
        Console.WriteLine($"ID = {ID}, Name = {Name}, Age = {Age}");
    }
}