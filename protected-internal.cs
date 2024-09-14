class Base
{
    protected internal int id = 123;
}
class Derived : Base
{
    public void DisplayId()
    {
        Console.WriteLine("ID: " + id);
    }
}
// public static void Main(string[] args)
// {
//     Derived example2 = new Derived();
//     example2.DisplayId();
// }