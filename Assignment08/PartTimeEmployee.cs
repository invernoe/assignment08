class PartTimeEmployee : Employee
{
    public decimal HourRate { get; set; }

    public new void MyFunc01()
    {
        Console.WriteLine("I am PartTimeEmployee");
    }

    public override void MyFunc02()
    {
        Console.WriteLine($"ID = {ID}, Name = {Name}, Age = {Age}, HourRate = {HourRate}");
    }
}