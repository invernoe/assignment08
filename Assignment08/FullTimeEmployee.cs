class FullTimeEmployee : Employee
{
    public decimal Salary { get; set; }

    public new void MyFunc01()
    {
        Console.WriteLine("I am FullTimeEmployee");
    }
    public override void MyFunc02()
    {
        Console.WriteLine($"ID = {ID}, Name = {Name}, Age = {Age}, Salary = {Salary}");
    }
}