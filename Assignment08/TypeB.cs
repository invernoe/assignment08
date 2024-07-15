class TypeB : TypeA
{
    public int B { get; set; }

    public TypeB(int _a, int _b) : base(_a)
    {
        B = _b;
    }

    public new void MyFunc01()
    {
        System.Console.WriteLine("I am child");
    }

    public override void MyFunc02()
    {
        System.Console.WriteLine($"B = {B}");
    }
}