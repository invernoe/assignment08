class TypeA
{
    public int A { get; set; }

    public TypeA(int _a)
    {
        A = _a;
    }

    public void MyFunc01()
    {
        System.Console.WriteLine("I am Base");
    }

    public virtual void MyFunc02()
    {
        System.Console.WriteLine($"A = {A}");
    }
}