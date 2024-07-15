interface IMyType
{
    public int Age { get; set; } //signature for property

    public void MyFunc();

    public void Print()
    {
        System.Console.WriteLine("Default implemented method");
    }
}